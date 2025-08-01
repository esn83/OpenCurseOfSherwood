using Raylib_cs;

namespace main {

    public class Unit {
        public string name;
        public float pos_x;
        public float pos_y;
        public string direction;
        public string direction_l_or_r = "L";
        public float speed;
        public int points = 100;
        public int hitpoints;
        public int hitpoints_max;
        public bool is_immortal = false;
        public bool is_dead = false;
        public string? weapon_weakness;
        public Rectangle hitbox;
        public float hitbox_offset_x;
        public float hitbox_offset_y;
        public Rectangle terrain_hitbox;
        public float terrain_hitbox_offset_x;
        public float terrain_hitbox_offset_y;
        public bool can_pass_through_obstacles = false;
        public Sprite sprite_active;
        public Sprite sprite_walk;
        public Sprite? sprite_death;
        public Sprite? sprite_sink;
        public Audio? walk_sounds;
        public Audio? death_sounds;
        public Audio? sink_sounds;
        public bool is_sinking = false;
        public bool is_walking = false;
        public List<Weapon> weapons = new List<Weapon>(){};
        public Weapon? active_weapon;
        public int max_bullets = 3;
        public List<Bullet> bullets = new List<Bullet>(){};
        public List<Item> items = new List<Item>(){};
        public bool is_npc = false;
        public List<string> trade_takes = new List<string>(){};
        public List<string> trade_gives = new List<string>(){};
        public List<string> terrain_collision_colors = new List<string>(){"{R:0 G:0 B:0 A:0}"};
        
        // constructor
        public Unit (
            string name_p,
            float pos_x_p,
            float pos_y_p,
            string direction_p,
            float speed_p,
            int hitpoints_p,
            Sprite sprite_p,
            Sprite sprite_death_p
        )
        {
            name = name_p;
            pos_x = pos_x_p;
            pos_y = pos_y_p;
            direction = direction_p;
            speed = speed_p;
            hitpoints = hitpoints_p;
            hitpoints_max = hitpoints_p;
            sprite_walk = sprite_p;
            sprite_active = sprite_p;
            sprite_death = sprite_death_p;

            hitbox_offset_x = ((sprite_active.textures_active[0].Width - sprite_active.textures_active[0].Width * 0.4f) / 2);
            hitbox_offset_y = ((sprite_active.textures_active[0].Height - sprite_active.textures_active[0].Height * 0.8f) / 2f);
            float hb_x = pos_x + hitbox_offset_x;
            float hb_y = pos_y + hitbox_offset_y;
            float hb_w = sprite_active.textures_active[0].Width * 0.4f;
            float hb_h = sprite_active.textures_active[0].Height * 0.8f;
            hitbox = new Rectangle(hb_x, hb_y, hb_w, hb_h);

            terrain_hitbox_offset_x = ((sprite_active.textures_active[0].Width - sprite_active.textures_active[0].Width * 0.6f) / 2);
            terrain_hitbox_offset_y = ((sprite_active.textures_active[0].Height - sprite_active.textures_active[0].Height * 0.4f) / 1.4f);
            float thb_x = pos_x + hitbox_offset_x;
            float thb_y = pos_y + hitbox_offset_y;
            float thb_w = sprite_active.textures_active[0].Width * 0.6f;
            float thb_h = sprite_active.textures_active[0].Height * 0.5f;
            terrain_hitbox = new Rectangle(thb_x, thb_y, thb_w, thb_h);

            if (weapons.Count > 0) {
                active_weapon = weapons[0];
            }
        }

        public void next_weapon() {
            if (weapons.Count > 1) {
                int index = weapons.IndexOf(active_weapon);
                if (index < weapons.Count-1) {
                    active_weapon = weapons[index+1];
                }
                else {
                    active_weapon = weapons[0];
                }
            }
        }

        public void move_up(Scene active_scene) {
            if (!is_dead) {
                direction = "U";
                if (!check_collision(active_scene)) {
                    is_walking = true;
                    pos_y -= speed;
                }
            }
        }
        public void move_down(Scene active_scene) {
            if (!is_dead) {
                direction = "D";
                if (!check_collision(active_scene)) {
                    is_walking = true;
                    pos_y += speed;
                }
            }
        }
        public void move_left(Scene active_scene) {
            if (!is_dead) {
                direction = "L";
                if (!check_collision(active_scene)) {
                    is_walking = true;
                    pos_x -= speed;
                }
            }
        }
        public void move_right(Scene active_scene) {
            if (!is_dead) {
                direction = "R";
                if (!check_collision(active_scene)) {
                    is_walking = true;
                    pos_x += speed;
                }
            }
        }

        public void stop() {is_walking=false;}

        public bool check_collision(Scene active_scene) {
            bool terrain_collision = false;
            // if (!can_pass_through_obstacles) {
            //     // check if hitbox would have other colors in it than black which means that it is colliding with terrain (or items)
            //     Rectangle r1 = new Rectangle(terrain_hitbox.X+65f*Game.window_scale,
            //                                  terrain_hitbox.Y+43f*Game.window_scale,
            //                                  terrain_hitbox.Width,
            //                                  terrain_hitbox.Height);
            //     if (direction.Equals("L")) {r1.X -= speed;}
            //     if (direction.Equals("R")) {r1.X += speed;}
            //     if (direction.Equals("U")) {r1.Y -= speed;}
            //     if (direction.Equals("D")) {r1.Y += speed;}
            //     Image ix = Raylib.ImageFromImage(Raylib.LoadImageFromTexture(active_scene.scene), r1);

            //     // draw the cut out image for debugging
            //     //Texture2D tx = Raylib.LoadTextureFromImage(ix);
            //     //Raylib.DrawTexture(tx, 100, 200 , Color.WHITE);

            //     for (int j=0 ; j<ix.Width ; j++) {
            //         Color cx_top = Raylib.GetImageColor(ix, j, 0);
            //         Color cx_down = Raylib.GetImageColor(ix, j, ix.Height-1);
            //         string cx_str_t = cx_top.ToString();
            //         string cx_str_d = cx_down.ToString();
            //         if (!terrain_collision_colors.Contains(cx_str_t) || !terrain_collision_colors.Contains(cx_str_d)) {
            //             terrain_collision = true;
            //             break;
            //         }
            //     }
            //     if (!terrain_collision) {
            //         for (int i=0 ; i<ix.Height ; i++) {
            //             Color cx_left = Raylib.GetImageColor(ix, 0, i);
            //             Color cx_right = Raylib.GetImageColor(ix, ix.Width-1, i);
            //             string cx_str_l = cx_left.ToString();
            //             string cx_str_r = cx_right.ToString();
            //             if (!terrain_collision_colors.Contains(cx_str_l) || !terrain_collision_colors.Contains(cx_str_r)) {
            //                 terrain_collision = true;
            //                 break;
            //             }
            //         }
            //     }
            // }
            //terrain_collision = false; // bypass terrain colission check
            // / check if hitbox would have other colors in it than black which means that it is colliding with terrain (or items)

            // check if hitbox would exceed scene limits to prevent monsters from leaving play area
            if (direction.Equals("L") && terrain_hitbox.X - speed <= active_scene.scene_limit_x_left) {terrain_collision = true;}
            if (direction.Equals("R") && terrain_hitbox.X + terrain_hitbox.Width + speed >= active_scene.scene_limit_x_right) {terrain_collision = true;}
            if (direction.Equals("U") && terrain_hitbox.Y - speed <= active_scene.scene_limit_y_up) {terrain_collision = true;}
            if (direction.Equals("D") && terrain_hitbox.Y + terrain_hitbox.Height + speed >= active_scene.scene_limit_y_down) {terrain_collision = true;}
            // /check if hitbox would exceed scene limits to prevent monsters from leaving play area

            return terrain_collision;
        }

        public void shoot(List<Bullet> scene_bullets) {
            if (active_weapon != null && !is_dead) {

                bool max_bullets_reached = false;
                int active_bullet_count = 0;
                foreach (Bullet b in bullets) {
                    if (scene_bullets.Contains(b)) {
                        active_bullet_count += 1;
                        if (active_bullet_count >= max_bullets) {
                            max_bullets_reached = true;
                            break;
                        }
                    }
                }

                if (!max_bullets_reached) {
                    Bullet b = active_weapon.shoot(pos_x,pos_y,direction_l_or_r);
                    scene_bullets.Add(b);
                    bullets.Add(b);
                }
            }
        }

        public bool respawn_at(float x, float y) {
            if (sprite_active.current_frame >= sprite_active.textures_active.Count-1) { // wait for death animation to be done
                pos_x = x;
                pos_y = y;
                hitpoints = hitpoints_max;
                is_dead = false;
                is_sinking = false;
                sprite_active = sprite_walk;
                sprite_death.current_frame = 0; // reset death animaition
                sprite_sink.current_frame = 0; // reset sink animaition
                return true;
            }
            else {return false;}
        }

        public void update(float dt, List<Bullet> scene_bullets) {

            // death
            if (hitpoints <= 0) {
                stop();
                is_dead = true;
                sprite_death.pos_x = sprite_active.pos_x;
                sprite_death.pos_y = sprite_active.pos_y;
                sprite_active = sprite_death;
                if (death_sounds != null && sprite_active.current_frame == 0) {death_sounds.play_sound();} // play the death sound once
                if (sprite_active.current_frame < sprite_active.textures_active.Count-1) { // play death anim once
                    sprite_active.next_frame();
                }
            }
            // / death

            // sinking
            if (is_sinking) {
                stop();
                is_dead = true;
                sprite_sink.pos_x = sprite_active.pos_x;
                sprite_sink.pos_y = sprite_active.pos_y;
                sprite_active = sprite_sink;
                if (sink_sounds != null && sprite_active.current_frame == 0) {sink_sounds.play_sound();} // play the sink sound once
                if (sprite_active.current_frame < sprite_active.textures_active.Count-1) { // play sink anim once
                    sprite_active.next_frame();
                }
            }
            // / sinking
            
            if (direction.Equals("L")) {direction_l_or_r = "L";}
            if (direction.Equals("R")) {direction_l_or_r = "R";}
            
            sprite_active.update(dt, direction_l_or_r); // change direction_l_or_r to direction if the sprite has up and down images
            sprite_active.pos_x = pos_x;
            sprite_active.pos_y = pos_y;

            hitbox.X = pos_x + hitbox_offset_x;
            hitbox.Y = pos_y + hitbox_offset_y;

            terrain_hitbox.X = pos_x + terrain_hitbox_offset_x;
            terrain_hitbox.Y = pos_y + terrain_hitbox_offset_y;

            if (walk_sounds != null) {walk_sounds.update(dt);}
            if (death_sounds != null) {death_sounds.update(dt);}
            if (sink_sounds != null) {sink_sounds.update(dt);}

            foreach (Weapon w in weapons) {
                w.update(dt);
            }
            
            if (is_walking && !is_dead) {
                if (walk_sounds != null) {walk_sounds.play_sound();}
                sprite_active.next_frame();
            }

            // remove old scene_bullets
            List<Bullet> remove_bullets = new List<Bullet>(){};
            foreach (Bullet b in bullets) {
                if (!scene_bullets.Contains(b)) {remove_bullets.Add(b);}
            }
            foreach (Bullet rb in remove_bullets) {bullets.Remove(rb);}
            // / remove old scene_bullets
        }

    }
}