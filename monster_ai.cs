namespace main {
    
    public class Monster_AI {
        public Random rnd = new Random();

        public int move_pattern; // 0 = move up/down | 1 = move diagonally | 2 = move up/down then forward | 4 = player homing
        public bool allow_move_back;
        public string move_direction_e_w;
        public string  move_direction_n_s;
        public List<string> move_direction_e_w_list = new List<string>(){"E","W"};
        public List<string> move_direction_n_s_list = new List<string>(){"N","S"};
        public float move_delay;
        public float move_delay_count = 0;

        public float min_shoot_delay;
        public float shoot_delay;
        public float shoot_delay_count = 0;
        public bool do_shoot = false;

        // Constructor
        public Monster_AI (int move_pattern_p,
                           bool allow_move_back_p,
                           string move_direction_e_w_p,
                           float min_shoot_delay_p
                           )
        {
            move_pattern = move_pattern_p;
            allow_move_back = allow_move_back_p;
            move_direction_e_w = move_direction_e_w_p;
            min_shoot_delay = min_shoot_delay_p;
            move_direction_n_s = move_direction_n_s_list[rnd.Next(2)];
            move_delay = 0.1f + (float) (rnd.NextDouble() * 0.4f);
            shoot_delay = 0.2f + (float) (rnd.NextDouble() * 1f);            
        }

        public void update(float dt, Scene active_scene, Unit u, Player p) {
            // move
            move_delay_count += dt;
            if (move_delay_count >= move_delay) {
                if (move_pattern == 0) { // move up/down
                    move_direction_n_s = move_direction_n_s_list[rnd.Next(2)];
                    move_delay_count = 0;
                    move_delay = 0.1f + (float) (rnd.NextDouble() * 0.4f);
                }

                else if (move_pattern == 1) { // move diagonally
                    if (allow_move_back) {
                        move_direction_e_w = move_direction_e_w_list[rnd.Next(2)];
                    }
                    move_direction_n_s = move_direction_n_s_list[rnd.Next(2)];
                    move_delay_count = 0;
                    move_delay = 0.1f + (float) (rnd.NextDouble() * 0.4f);
                }

                else if (move_pattern == 2) { // move up/down then forward
                    move_direction_n_s = move_direction_n_s_list[rnd.Next(2)];
                    move_delay_count = 0;
                    move_delay = 0.1f + (float) (rnd.NextDouble() * 0.4f);
                    
                    if (move_direction_e_w.Equals("")) { // random chance to start moving forward
                        float chance = (float) rnd.NextDouble() * 20;
                        if (chance < 1) {
                            move_direction_e_w = u.sprite_active.direction_w_or_e;
                        }
                    }
                    if (move_direction_e_w.Equals("E") && u.pos_x + u.sprite_active.textures_active[0].width >= active_scene.scene_limit_x_right - 5) {
                        u.pos_x = active_scene.scene_limit_x_left;
                        u.pos_y = 160;
                    }
                    if (move_direction_e_w.Equals("W") && u.pos_x <= active_scene.scene_limit_x_left + 5) {
                        u.pos_x = active_scene.scene_limit_x_right + u.sprite_active.textures_active[0].width;
                        u.pos_y = 160;
                    }
                }

                else if (move_pattern == 4) { // player homing
                    move_delay_count = 0;
                    move_delay = 0.2f ;
                    if (u.pos_x < p.unit.pos_x) {move_direction_e_w = "E";}
                    else {move_direction_e_w = "W";}
                    if (u.pos_y < p.unit.pos_y) {move_direction_n_s = "S";}
                    else {move_direction_n_s = "N";}
                }
            }
            // / move

            // shoot
            shoot_delay_count += dt;
            if (shoot_delay_count >= shoot_delay) {
                do_shoot = true;
                shoot_delay_count = 0;
                shoot_delay = min_shoot_delay + 0.2f + (float) (rnd.NextDouble() * 1f);
            }
            else {
                do_shoot = false;
            }
            // / shoot
        }


    }
}