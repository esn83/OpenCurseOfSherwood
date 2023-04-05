using Raylib_cs;

namespace main {

    public class Unit {
        public string name;
        public int pos_x;
        public int pos_y;
        public int speed;
        public int hitpoints;
        public int hitpoints_max;
        public bool is_dead = false;
        public string? weapon_weakness;
        public Rectangle hitbox;
        public int hitbox_offset_x;
        public int hitbox_offset_y;        
        public Sprite sprite_active;
        public Sprite sprite_walk;
        public Sprite sprite_death;
        public Audio? walk_sounds;
        public Audio? death_sounds;
        public bool is_walking = false;
        public List<Weapon> weapons = new List<Weapon>(){};
        public Weapon? active_weapon;
        public int max_bullets = 3;
        public List<Bullet> my_bullets = new List<Bullet>(){};
        public List<Item> items = new List<Item>(){};
        public bool is_npc = false;
        public List<string> trade_takes = new List<string>(){};
        public List<string> trade_gives = new List<string>(){};
        public List<string> terrain_collision_colors = new List<string>(){"{R:0 G:0 B:0 A:0}"};
        
        // constructor
        public Unit(string name_p,
                    int pos_x_p,
                    int pos_y_p,
                    int speed_p,
                    int hitpoints_p,
                    List<int> hitbox_stats_p,
                    Sprite sprite_p,
                    Sprite sprite_death_p)
        {
            name = name_p;
            pos_x = pos_x_p;
            pos_y = pos_y_p;
            speed = speed_p;
            hitpoints = hitpoints_p;
            hitpoints_max = hitpoints_p;
            hitbox = new Rectangle(hitbox_stats_p[0],hitbox_stats_p[1],hitbox_stats_p[2],hitbox_stats_p[3]);
            hitbox_offset_x = pos_x-hitbox_stats_p[0];
            hitbox_offset_y = pos_y-hitbox_stats_p[1];
            sprite_walk = sprite_p;
            sprite_active = sprite_p;
            sprite_death = sprite_death_p;
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

        public void move_left(float dt_factor, Scene active_scene) {
            if (!is_dead) {
                sprite_active.direction = "W";
                if (!check_collision(dt_factor, active_scene)) {
                    is_walking = true;
                    pos_x -= (int) ((float) speed * dt_factor);
                }
            }
        }
        public void move_up(float dt_factor, Scene active_scene) {
            if (!is_dead) {
                sprite_active.direction = "N";
                if (!check_collision(dt_factor, active_scene)) {
                    is_walking = true;
                    pos_y -= (int) ((float) speed * dt_factor);
                }
            }
        }
        public void move_right(float dt_factor, Scene active_scene) {
            if (!is_dead) {
                sprite_active.direction = "E";
                if (!check_collision(dt_factor, active_scene)) {
                    is_walking = true;
                    pos_x += (int) ((float) speed * dt_factor);
                }
            }
        }
        public void move_down(float dt_factor, Scene active_scene) {
            if (!is_dead) {
                sprite_active.direction = "S";
                if (!check_collision(dt_factor, active_scene)) {
                    is_walking = true;
                    pos_y += (int) ((float) speed * dt_factor);
                }
            }
        }

        public void stop() {is_walking=false;}

        public bool check_collision(float dt_factor, Scene active_scene) {
            bool terrain_collision = false;
            // check if hitbox would have other colors in it than black which means that it is colliding with terrain (or items)
            Rectangle r1 = new Rectangle(hitbox.x, hitbox.y, hitbox.width, hitbox.height);
            if (sprite_active.direction.Equals("W")) {r1.x -= (int) ((float) speed * dt_factor);}
            if (sprite_active.direction.Equals("N")) {r1.y -= (int) ((float) speed * dt_factor);}
            if (sprite_active.direction.Equals("E")) {r1.x += (int) ((float) speed * dt_factor);}
            if (sprite_active.direction.Equals("S")) {r1.y += (int) ((float) speed * dt_factor);}
            Image ix = Raylib.ImageFromImage(Raylib.LoadImageFromTexture(active_scene.scene), r1);
            for (int i=0 ; i<ix.height ; i++) {
                for (int j=0 ; j<ix.width ; j++) {
                    Color cx = Raylib.GetImageColor(ix,j,i);
                    string cx_str = cx.ToString();
                    if (terrain_collision_colors.Contains(cx_str)) {continue;}
                    //if (cx_str.Equals("{R:0 G:0 B:0 A:0}")) {continue;}
                    else {terrain_collision = true; break;}
                }
                if (terrain_collision) {break;}
            }
            // / check if hitbox would have other colors in it than black which means that it is colliding with terrain (or items)
            
            // check if hitbox would exceed scene limits
            if (sprite_active.direction.Equals("W") && sprite_active.pos_x - (float) speed * dt_factor <= active_scene.scene_limit_x_left) {terrain_collision = true;}
            if (sprite_active.direction.Equals("E") && sprite_active.pos_x + (float) speed * dt_factor + sprite_active.textures_active[0].width > active_scene.scene_limit_x_right) {terrain_collision = true;}
            if (sprite_active.direction.Equals("N") && sprite_active.pos_y - (float) speed * dt_factor < active_scene.scene_limit_y_up) {terrain_collision = true;}
            if (sprite_active.direction.Equals("S") && sprite_active.pos_y + (float) speed * dt_factor + sprite_active.textures_active[0].height > active_scene.scene_limit_y_down) {terrain_collision = true;}
            // /check if hitbox would exceed scene limits

            return terrain_collision;
        }

        public void shoot(List<Bullet> bullets) {
            if (active_weapon != null && !is_dead) {

                bool max_bullets_reached = false;
                int active_bullet_count = 0;
                foreach (Bullet my_b in my_bullets) {
                    if (bullets.Contains(my_b)) {
                        active_bullet_count += 1;
                        if (active_bullet_count >= max_bullets) {
                            max_bullets_reached = true;
                            break;
                        }
                    }
                }

                if (!max_bullets_reached) {
                    active_weapon.bullet_sound.play_sound();
                    List<string> bullet_img_list = new List<string>(){active_weapon.data_paths[1]};
                    
                    string bullet_direction = "W";
                    if (sprite_active.textures_active == sprite_active.textures_e) {bullet_direction = "E";}
                    
                    Sprite bullet_sprite = new Sprite(
                    bullet_img_list,
                    0.08f,
                    pos_x,
                    pos_y+10,
                    bullet_direction);

                    Bullet bullet = new Bullet (
                        active_weapon.name,
                        bullet_direction,
                        pos_x,
                        pos_y+10,
                        active_weapon.bullet_speed,
                        active_weapon.damage,
                        new List<int>(){pos_x,pos_y+10,active_weapon.bullet.width,active_weapon.bullet.height},
                        bullet_sprite
                    );
                    bullets.Add(bullet);
                    my_bullets.Add(bullet);
                }

            }
        }

        public bool respawn_at(int x, int y) {
            if (sprite_active.current_frame >= sprite_active.textures_active.Count-1) { // wait for death animation to be done
                pos_x = x;
                pos_y = y;
                hitpoints = hitpoints_max;
                is_dead = false;
                sprite_active = sprite_walk;
                sprite_death.current_frame = 0; // reset death animaition
                return true;
            }
            else {return false;}
        }

        public void update(float dt, float dt_factor, List<Bullet> bullets) {
            // death
            if (hitpoints <= 0) {
                stop();
                is_dead = true;
                sprite_death.pos_x = sprite_active.pos_x;
                sprite_death.pos_y = sprite_active.pos_y;
                sprite_death.direction = sprite_active.direction_w_or_e;
                sprite_active = sprite_death;
                if (death_sounds != null && sprite_active.current_frame == 0) {death_sounds.play_sound();} // play the death sound once
                if (sprite_active.current_frame < sprite_active.textures_active.Count-1) { // play death anim once
                    sprite_active.next_frame();
                }
            }
            // / death

            sprite_active.pos_x = pos_x;
            sprite_active.pos_y = pos_y;
            sprite_active.update(dt);

            hitbox.x = pos_x + hitbox_offset_x;
            hitbox.y = pos_y + hitbox_offset_y;

            if (walk_sounds != null) {walk_sounds.update(dt);}
            if (death_sounds != null) {death_sounds.update(dt);}

            foreach (Weapon w in weapons) {
                w.update(dt);
            }
            
            if (is_walking && !is_dead) {
                if (walk_sounds != null) {walk_sounds.play_sound();}
                sprite_active.next_frame();
            }

            // remove old bullets
            List<Bullet> remove_bullets = new List<Bullet>(){};
            foreach (Bullet my_b in my_bullets) {
                if (!bullets.Contains(my_b)) {
                    remove_bullets.Add(my_b);
                }
            }
            foreach (Bullet rb in remove_bullets) {
                my_bullets.Remove(rb);
            }
            // / remove old bullets
        }

    }
}