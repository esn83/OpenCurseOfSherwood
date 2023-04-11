using Raylib_cs;

namespace main {

    public class Scene {
        public List<string> scene_img_paths;
        public List<Unit> units = new List<Unit>(){};
        public List<int> dead_units_index = new List<int>(){};
        public List<Weapon> weapons = new List<Weapon>(){};
        public List<Item> items = new List<Item>(){};
        public List<Bullet> player_bullets = new List<Bullet>(){};
        public List<Bullet> monster_bullets = new List<Bullet>(){};
        public Texture2D scene;
        public List<Texture2D> scene_extras = new List<Texture2D>(){};
        public List<Monster_AI>  ais = new List<Monster_AI>(){};
        public int respawn_point_x = 0;
        public int respawn_point_y = 0;
        public Rectangle door_up = new Rectangle(0,0,0,0);
        public Rectangle door_down = new Rectangle(0,0,0,0);
        public Rectangle door_left = new Rectangle(0,0,0,0);
        public Rectangle door_right = new Rectangle(0,0,0,0);
        public bool disable_left = false;
        public bool disable_right = false;
        public bool disable_up = false;
        public bool disable_down = false;
        public bool scene_objectives_done = false;
        public bool scene_monsters_done = false;
        public List<Rectangle> swamp_areas = new List<Rectangle>(){};
        
        public int scene_limit_x_left = 63;
        public int scene_limit_x_right = 321;
        public int scene_limit_y_up = 88;
        public int scene_limit_y_down = 236;

        // constructor
        public Scene(List<string> scene_img_paths_p
                    )
        {
        scene_img_paths = scene_img_paths_p;
        init();
        }

        public void init() {
            load_scene_images();
        }

        public void load_scene_images() {
            for (int i=0 ; i<scene_img_paths.Count ; i++) {
                if (i==0) { // main scene
                    Image scene_img = Raylib.LoadImage(scene_img_paths[i]);
                    Raylib.ImageColorReplace(ref scene_img, Start.data.bg, new Color(0,0,0,0)); // transparent background
                    scene = Raylib.LoadTextureFromImage(scene_img);
                    }
                else { // extra graphics that doesn't cause colission
                    Image scene_img = Raylib.LoadImage(scene_img_paths[i]);
                    Raylib.ImageColorReplace(ref scene_img, Start.data.bg, new Color(0,0,0,0)); // transparent background
                    scene_extras.Add(Raylib.LoadTextureFromImage(scene_img));
                }
            }
        }

        public void update_1(float dt, float dt_factor, List<Player> players) {

            foreach( Player p in players) {
                for (int i=0 ; i < units.Count ; i++) {
                    ais[i].update(dt, this, units[i], p);
                }
            }
            if (units.Count > 0) {
                for (int i=0 ; i<units.Count ; i++) {
                    units[i].update(dt, dt_factor, player_bullets);
                    units[i].update(dt, dt_factor, monster_bullets);
                    if (units[i].is_dead) {
                        if (units[i].sprite_active.current_frame >= units[i].sprite_active.textures_active.Count-1) {
                            dead_units_index.Add(i);
                        }
                    }
                }
            }

            for (int i=0 ; i<units.Count ; i++) {
                if (ais[i].do_shoot) {units[i].shoot(monster_bullets);}
                if (ais[i].move_direction_n_s.Equals("N")) {units[i].move_up(dt_factor, this);}
                if (ais[i].move_direction_n_s.Equals("S")) {units[i].move_down(dt_factor, this);}
                if (ais[i].move_direction_e_w.Equals("W")) {units[i].move_left(dt_factor, this);}
                if (ais[i].move_direction_e_w.Equals("E")) {units[i].move_right(dt_factor, this);}
            }

            foreach (Weapon w in weapons) {
                w.update(dt);
            }
        }

        public void update_2(float dt, float dt_factor) {
            // remove dead units
            if (dead_units_index.Count > 0) {
                dead_units_index.Sort();
                dead_units_index.Reverse(); // sort and reverse the index list before removing units from unit list to prevent random index errors and crash
                foreach (int index in dead_units_index) {
                    units.RemoveAt(index);
                    ais.RemoveAt(index);
                }
                dead_units_index = new List<int>(){};
            }
            // / remove dead units

            // remove old monster bullets
            List<Bullet> remove_bullets_m = new List<Bullet>(){};
            foreach (Bullet b in monster_bullets) {
                b.update(dt, dt_factor);
                if (b.pos_x + b.width > scene_limit_x_right || b.pos_x < scene_limit_x_left) {
                    remove_bullets_m.Add(b);
                }
            }
            foreach (Bullet rb in remove_bullets_m) {
                monster_bullets.Remove(rb);
            }
            // / remove old monster bullets

            // remove old player bullets
            List<Bullet> remove_bullets_p = new List<Bullet>(){};
            foreach (Bullet b in player_bullets) {
                b.update(dt, dt_factor);
                if (b.pos_x + b.width > scene_limit_x_right || b.pos_x < scene_limit_x_left) {
                    remove_bullets_p.Add(b);
                }
            }
            foreach (Bullet rb in remove_bullets_p) {
                player_bullets.Remove(rb);
            }
            // / remove old player bullets
        }

    }
}