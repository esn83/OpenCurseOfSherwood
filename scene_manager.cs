using Raylib_cs;

namespace main {

    public class SceneManager {

        public Scene active_scene;

        public Scene s1;public Scene s2;public Scene s3;public Scene s4;public Scene s5;public Scene s6;public Scene s7;public Scene s8;public Scene s9;
        public Scene s10;public Scene s11;public Scene s12;public Scene s13;public Scene s14;public Scene s15;public Scene s16;public Scene s17;
        public Scene s18;public Scene s19;public Scene s20;public Scene s21;public Scene s22;public Scene s23;public Scene s24;public Scene s25;
        public Scene s26;public Scene s27;public Scene s28;public Scene s29;public Scene s30;public Scene s31;

        // constructor
        public SceneManager()
        {
            active_scene = init_scene_1();
        }

        public void next_scene_right() {
            // bottom right side map
            if      (active_scene == s1) {active_scene = init_scene_2();}
            else if (active_scene == s2) {active_scene = init_scene_3();}
            else if (active_scene == s3) {active_scene = init_scene_4();}
            else if (active_scene == s4) {active_scene = init_scene_5();}
            else if (active_scene == s5) {active_scene = init_scene_6();}
            else if (active_scene == s6) {active_scene = init_scene_7();}
            else if (active_scene == s9) {active_scene = init_scene_10();}
            else if (active_scene == s10) {active_scene = init_scene_11();}
            else if (active_scene == s11) {active_scene = init_scene_12();}
            // bottom left side map
            else if (active_scene == s14) {active_scene = init_scene_1();}
            else if (active_scene == s15) {active_scene = init_scene_14();}
            else if (active_scene == s16) {active_scene = init_scene_15();}
            else if (active_scene == s18) {active_scene = init_scene_16();}
            // bottom +1up
            else if (active_scene == s20) {active_scene = init_scene_21();}
            else if (active_scene == s21) {active_scene = init_scene_22();}
            else if (active_scene == s22) {active_scene = init_scene_23();}
            else if (active_scene == s23) {active_scene = init_scene_24();}
            else if (active_scene == s24) {active_scene = init_scene_25();}
            else if (active_scene == s25) {active_scene = init_scene_26();}
            // bottom +3up
            else if (active_scene == s29) {active_scene = init_scene_28();}
            else if (active_scene == s31) {active_scene = init_scene_29();}
            active_scene.player_bullets = new List<Bullet>(){};
            active_scene.monster_bullets = new List<Bullet>(){};
        }
        public void next_scene_left() {
            // bottom right side map
            if      (active_scene == s2) {active_scene = init_scene_1();}
            else if (active_scene == s3) {active_scene = init_scene_2();}
            else if (active_scene == s4) {active_scene = init_scene_3();}
            else if (active_scene == s5) {active_scene = init_scene_4();}
            else if (active_scene == s6) {active_scene = init_scene_5();}
            else if (active_scene == s7) {active_scene = init_scene_6();}
            else if (active_scene == s10) {active_scene = init_scene_9();}
            else if (active_scene == s11) {active_scene = init_scene_10();}
            else if (active_scene == s12) {active_scene = init_scene_11();}
            // bottom left side map
            else if (active_scene == s1) {active_scene = init_scene_14();}
            else if (active_scene == s14) {active_scene = init_scene_15();}
            else if (active_scene == s15) {active_scene = init_scene_16();}
            else if (active_scene == s16) {active_scene = init_scene_18();}
            // bottom +1up
            else if (active_scene == s21) {active_scene = init_scene_20();}
            else if (active_scene == s22) {active_scene = init_scene_21();}
            else if (active_scene == s23) {active_scene = init_scene_22();}
            else if (active_scene == s24) {active_scene = init_scene_23();}
            else if (active_scene == s25) {active_scene = init_scene_24();}
            else if (active_scene == s26) {active_scene = init_scene_25();}
            // bottom +3up
            else if (active_scene == s28) {active_scene = init_scene_29();}
            else if (active_scene == s29) {active_scene = init_scene_31();}
            active_scene.player_bullets = new List<Bullet>(){};
            active_scene.monster_bullets = new List<Bullet>(){};
        }

        public void next_scene_down() {
            // bottom right side map
            if      (active_scene == s8) {active_scene = init_scene_7();}
            else if (active_scene == s6) {active_scene = init_scene_9();}
            else if (active_scene == s12) {active_scene = init_scene_13();}
            // bottom left side map
            else if (active_scene == s17) {active_scene = init_scene_16();}
            else if (active_scene == s16) {active_scene = init_scene_19();}
            // bottom +1up
            else if (active_scene == s20) {active_scene = init_scene_14();}
            // bottom +2up
            else if (active_scene == s27) {active_scene = init_scene_22();}
            // bottom +3up
            else if (active_scene == s28) {active_scene = init_scene_27();}
            else if (active_scene == s30) {active_scene = init_scene_29();}
            active_scene.player_bullets = new List<Bullet>(){};
            active_scene.monster_bullets = new List<Bullet>(){};
        }

        public void next_scene_up() {
            // bottom right side map
            if      (active_scene == s7) {active_scene = init_scene_8();}
            else if (active_scene == s9) {active_scene = init_scene_6();}
            else if (active_scene == s13) {active_scene = init_scene_12();}
            // bottom left side map
            else if (active_scene == s16) {active_scene = init_scene_17();}
            else if (active_scene == s19) {active_scene = init_scene_16();}
            // bottom +1up
            else if (active_scene == s14) {active_scene = init_scene_20();}
            // bottom +2up
            else if (active_scene == s22) {active_scene = init_scene_27();}
            // bottom +3up
            else if (active_scene == s27) {active_scene = init_scene_28();}
            else if (active_scene == s29) {active_scene = init_scene_30();}
            active_scene.player_bullets = new List<Bullet>(){};
            active_scene.monster_bullets = new List<Bullet>(){};
        }

        public void update(float dt, float dt_factor, List<Player> players) {
            active_scene.update_1(dt, dt_factor, players);
            if (active_scene.units.Count > 0 && active_scene.dead_units_index.Count >= active_scene.units.Count && !active_scene.scene_monsters_done)
                specialSceneEventsItems(active_scene.units[0]);
            if (active_scene == s11 || active_scene == s24 || active_scene == s27) {
                specialSceneEventMap(players);
            }
            active_scene.update_2(dt, dt_factor);

            if (active_scene.units.Count == 0) {
                active_scene.scene_monsters_done = true;
            }
        }
        
        public void specialSceneEventsItems(Unit u) {
            if (active_scene == s4) { // scene 4 3right, drop shield
                active_scene.items.Add(new Item("shield",Start.data.items_data_dict["shield"], u.pos_x+5, u.pos_y+15));
            }
            if (active_scene == s5) { // scene 5 4right, drop club
                active_scene.weapons.Add(new Weapon("club",Start.data.weapons_data_dict["club"],u.pos_x+5,u.pos_y+15));
            }
            if (active_scene == s8) { // scene 8 7up, drop crystal ball
                active_scene.items.Add(new Item("crystal ball",Start.data.items_data_dict["crystal ball"], u.pos_x+5, u.pos_y+15));
            }
            if (active_scene == s13) { // scene 13 12down, drop silver dagger
                active_scene.weapons.Add(new Weapon("silver dagger",Start.data.weapons_data_dict["silver dagger"],u.pos_x+5,u.pos_y+15));
            }
            if (active_scene == s18) { // scene 18 16left, drop fangs
                active_scene.items.Add(new Item("fangs",Start.data.items_data_dict["fangs"], u.pos_x+5, u.pos_y+15));
            }
            if (active_scene == s21) { // scene 21 20right, drop ice wand
                active_scene.weapons.Add(new Weapon("ice wand",Start.data.weapons_data_dict["ice wand"],u.pos_x+5,u.pos_y+15));
            }
            if (active_scene == s23) { // scene 23 22right, drop crossbow
                active_scene.weapons.Add(new Weapon("crossbow",Start.data.weapons_data_dict["crossbow"],u.pos_x+5,u.pos_y+15));
            }
            if (active_scene == s26) { // scene 26 25right, drop bag of gold
                active_scene.items.Add(new Item("bag gold",Start.data.items_data_dict["bag gold"],u.pos_x+5,u.pos_y+15));
            }
            if (active_scene == s27) { // scene 27 22yp, drop key
                active_scene.items.Add(new Item("key",Start.data.items_data_dict["key"],u.pos_x+5,u.pos_y+15));
            }
        }

        public void specialSceneEventMap(List<Player> players) {
            if (active_scene == s11) { // break door
                if (!active_scene.scene_objectives_done) {
                    foreach (Bullet b in active_scene.player_bullets) {
                        if (b.name.Equals("club")) {
                            Rectangle rect = new Rectangle(293,135,1,30);
                            bool col = Raylib.CheckCollisionRecs(b.hitbox, rect);
                            if(col) {
                                new Audio(Start.data.monster_bullet_sounds, 0.0f).play_sound();
                                active_scene.scene_img_paths = Start.data.scene_11_2;
                                active_scene.load_scene_images();
                                s11.door_right = new Rectangle(280,160,1,5); // broken door
                                active_scene.scene_objectives_done = true;
                            }
                        }
                    }
                }
            }
            if (active_scene == s24) { // freeze river
                List<Bullet> remove_bullets = new List<Bullet>(){};
                foreach (Bullet b in active_scene.player_bullets) {
                    if (b.name.Equals("ice wand")) {
                        Rectangle rect = new Rectangle(195,130,5,50);
                        bool col = Raylib.CheckCollisionRecs(b.hitbox, rect);
                            if(col) {
                                remove_bullets.Add(b);
                                if (!active_scene.scene_objectives_done) {
                                    new Audio(Start.data.monster_bullet_sounds, 0.0f).play_sound();
                                    active_scene.scene_img_paths = Start.data.scene_24_2;
                                    active_scene.load_scene_images();
                                    active_scene.scene_objectives_done = true;
                            }
                        }
                    }
                }
                foreach (Bullet b in remove_bullets) {
                    active_scene.player_bullets.Remove(b);
                }
            }
            if (active_scene == s27) { // open gate with key
                if (!active_scene.scene_objectives_done) {
                    Rectangle rect = new Rectangle(177,129,30,10); // locked gate
                    foreach (Player p in players){
                        bool col = Raylib.CheckCollisionRecs(p.unit.hitbox, rect);
                        if(col) {
                            foreach (Item i in p.unit.items) {
                                if (i.name.Equals("key")) {
                                    new Audio(Start.data.monster_bullet_sounds, 0.0f).play_sound();
                                    active_scene.scene_img_paths = Start.data.scene_27_2;
                                    active_scene.load_scene_images();
                                    s27.door_up = new Rectangle(177,90,30,5); // opened gate
                                    active_scene.scene_objectives_done = true;
                                }
                            }
                        }
                    }
                }
            }

        }

        public Scene init_scene_1() { // scene 1 start
            if (s1 == null) {
                s1 = new Scene(Start.data.scene_1);
                s1.weapons.Add(new Weapon("sword",Start.data.weapons_data_dict["sword"],140,175));
            }
            // s1.items.Add(new Item("key",Start.data.items_data_dict["key"],80,150));
            // s1.items.Add(new Item("map",Start.data.items_data_dict["map"],80,170));
            // s1.items.Add(new Item("fangs",Start.data.items_data_dict["fangs"],80,130));
            // s1.items.Add(new Item("shield",Start.data.items_data_dict["shield"],100,150));
            return s1;
        }

        public Scene init_scene_2() { // scene 2 1right
            if (s2 == null) {
                s2 = new Scene(Start.data.scene_2);
                spawn_units();}
            else if (!s2.scene_monsters_done) {
                spawn_units();}
            return s2;

            void spawn_units() {
                s2.units = new List<Unit>(){};
                s2.ais = new List<Monster_AI>(){};

                Sprite bat_1_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"W");
                Sprite bat_2_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"E");
                Sprite bat_3_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"W");
                Sprite bat_4_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"E");

                Sprite bat_1_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bat_2_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");
                Sprite bat_3_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bat_4_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");

                bat_1_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_2_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_3_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_4_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);

                Audio bat_death_sound = new Audio(Start.data.monster_death_sounds, 0.0f); 

                Unit u1 = new Unit("Bat",
                                230,
                                170,
                                2,
                                2,
                                new List<int>(){230,170,15,10},
                                bat_1_sprite,
                                bat_1_sprite_death);
                                            
                Unit u2 = new Unit("Bat",
                                210,
                                170,
                                2,
                                2,
                                new List<int>(){210,170,15,10},
                                bat_2_sprite,
                                bat_2_sprite_death);

                Unit u3 = new Unit("Bat",
                                230,
                                150,
                                2,
                                2,
                                new List<int>(){230,150,15,10},
                                bat_3_sprite,
                                bat_3_sprite_death);

                Unit u4 = new Unit("Bat",
                                210,
                                150,
                                2,
                                2,
                                new List<int>(){210,150,15,10},
                                bat_4_sprite,
                                bat_4_sprite_death);
                
                u1.death_sounds = bat_death_sound;
                u2.death_sounds = bat_death_sound;
                u3.death_sounds = bat_death_sound;
                u4.death_sounds = bat_death_sound;

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0);
                Monster_AI u2_ai = new Monster_AI(1,true,"E",0);
                Monster_AI u3_ai = new Monster_AI(1,true,"W",0);
                Monster_AI u4_ai = new Monster_AI(1,true,"E",0);

                s2.units.Add(u1);
                s2.units.Add(u2);
                s2.units.Add(u3);
                s2.units.Add(u4);
                s2.ais.Add(u1_ai);
                s2.ais.Add(u2_ai);
                s2.ais.Add(u3_ai);
                s2.ais.Add(u4_ai);
            }
        }

        public Scene init_scene_3() { // scene 3 2right
            if (s3 == null) {
                s3 = new Scene(Start.data.scene_3);
                spawn_units();}
            else if (!s3.scene_monsters_done) {
                spawn_units();}
            return s3;

            void spawn_units() {
                s3.units = new List<Unit>(){};
                s3.ais = new List<Monster_AI>(){};

                Sprite troll_sprite = new Sprite(Start.data.troll_images,
                                                0.1f,
                                                0,
                                                0,
                                                "W");
                Sprite troll_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                troll_sprite_death.change_color(Start.data.death_images_large_color, Start.data.troll_color);
                
                Unit u1 = new Unit("Troll",
                                    260,
                                    170,
                                    2,
                                    6,
                                    new List<int>(){256,160,14,15},
                                    troll_sprite,
                                    troll_sprite_death);
                u1.active_weapon = new Weapon("rock",Start.data.weapons_data_dict["rock"],0,0);
                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0);

                s3.units.Add(u1);
                s3.ais.Add(u1_ai);
            }
        }

        public Scene init_scene_4() { // scene 4 3right
            if (s4 == null) {s4 = new Scene(
                Start.data.scene_4);
                spawn_units();}
            else if (!s4.scene_monsters_done) {
                spawn_units();}
            return s4;

            void spawn_units() {
                s4.units = new List<Unit>(){};
                s4.ais = new List<Monster_AI>(){};
                
                Sprite archer_1_sprite = new Sprite(Start.data.archer_images,0.2f,0,0,"W");
                Sprite archer_2_sprite = new Sprite(Start.data.archer_images,0.2f,0,0,"W");
                Sprite archer_3_sprite = new Sprite(Start.data.archer_images,0.2f,0,0,"W");

                Sprite archer_1_sprite_death = new Sprite(Start.data.death_images_large,0.2f,0,0,"W");
                Sprite archer_2_sprite_death = new Sprite(Start.data.death_images_large,0.2f,0,0,"W");
                Sprite archer_3_sprite_death = new Sprite(Start.data.death_images_large,0.2f,0,0,"W");

                archer_1_sprite_death.change_color(Start.data.death_images_large_color, Start.data.archer_color);
                archer_2_sprite_death.change_color(Start.data.death_images_large_color, Start.data.archer_color);
                archer_3_sprite_death.change_color(Start.data.death_images_large_color, Start.data.archer_color);

                Audio archer_death_sound = new Audio(Start.data.monster_death_sounds, 0.0f); 

                Unit u1 = new Unit("Archer",
                                300,
                                170,
                                2,
                                2,
                                new List<int>(){296,160,15,10},
                                archer_1_sprite,
                                archer_1_sprite_death);
                                            
                Unit u2 = new Unit("Archer",
                                290,
                                150,
                                2,
                                2,
                                new List<int>(){286,140,15,10},
                                archer_2_sprite,
                                archer_2_sprite_death);

                Unit u3 = new Unit("Archer",
                                280,
                                120,
                                2,
                                2,
                                new List<int>(){276,110,15,10},
                                archer_3_sprite,
                                archer_3_sprite_death);
                
                u1.death_sounds = archer_death_sound;
                u2.death_sounds = archer_death_sound;
                u3.death_sounds = archer_death_sound;

                u1.active_weapon = new Weapon("crossbow",Start.data.weapons_data_dict["crossbow"],0,0);
                u2.active_weapon = new Weapon("crossbow",Start.data.weapons_data_dict["crossbow"],0,0);
                u3.active_weapon = new Weapon("crossbow",Start.data.weapons_data_dict["crossbow"],0,0);

                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u2.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u2.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);

                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u2.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u2.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);

                u1.items.Add(new Item("shield", Start.data.items_data_dict["shield"]));
                u2.items.Add(new Item("shield", Start.data.items_data_dict["shield"]));
                u3.items.Add(new Item("shield", Start.data.items_data_dict["shield"]));

                Monster_AI u1_ai = new Monster_AI(0,false,"",1.5f);
                Monster_AI u2_ai = new Monster_AI(0,false,"",1.5f);
                Monster_AI u3_ai = new Monster_AI(0,false,"",1.5f);

                s4.units.Add(u1);
                s4.units.Add(u2);
                s4.units.Add(u3);
                s4.ais.Add(u1_ai);
                s4.ais.Add(u2_ai);
                s4.ais.Add(u3_ai);
            }
        }

        public Scene init_scene_5() { // scene 5 4right
            if (s5 == null) {
                s5 = new Scene(Start.data.scene_5);
                spawn_units();}
            else if (!s5.scene_monsters_done) {
                spawn_units();}
            return s5;

            void spawn_units() {
                s5.units = new List<Unit>(){};
                s5.ais = new List<Monster_AI>(){};

                Sprite brigand_sprite = new Sprite(Start.data.brigand_images,
                                                0.1f,
                                                0,
                                                0,
                                                "W");
                Sprite brigand_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                brigand_sprite_death.change_color(Start.data.death_images_large_color, Start.data.brigand_color);
                
                Unit u1 = new Unit("Brigand",
                                    250,
                                    150,
                                    2,
                                    4,
                                    new List<int>(){246,140,14,15},
                                    brigand_sprite,
                                    brigand_sprite_death);
                u1.active_weapon = new Weapon("club",Start.data.weapons_data_dict["club"],0,0);
                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0);

                s5.units.Add(u1);
                s5.ais.Add(u1_ai);
            }
        }

        public Scene init_scene_6() { // scene 6 5right
            if (s6 == null) {
                s6 = new Scene(Start.data.scene_6);
                spawn_units();}
            else if (!s6.scene_monsters_done) {
                spawn_units();}
            return s6;

            void spawn_units() {
                s6.units = new List<Unit>(){};
                s6.ais = new List<Monster_AI>(){};

                Sprite skeleton_1_sprite = new Sprite(Start.data.skeleton_images,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                Sprite skeleton_2_sprite = new Sprite(Start.data.skeleton_images,
                                                0.2f,
                                                0,
                                                0,
                                                "E");
                Sprite skeleton_1_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                Sprite skeleton_2_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "E");

                skeleton_1_sprite_death.change_color(Start.data.death_images_large_color, Start.data.skeleton_color);
                skeleton_2_sprite_death.change_color(Start.data.death_images_large_color, Start.data.skeleton_color);
                
                Unit u1 = new Unit("Skeleton",
                                    250,
                                    150,
                                    2,
                                    4,
                                    new List<int>(){246,140,14,15},
                                    skeleton_1_sprite,
                                    skeleton_1_sprite_death);
                u1.active_weapon = new Weapon("sword",Start.data.weapons_data_dict["sword"],0,0);
                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u1.weapon_weakness = "club";

                Unit u2 = new Unit("Skeleton",
                                    220,
                                    170,
                                    2,
                                    4,
                                    new List<int>(){216,160,14,15},
                                    skeleton_2_sprite,
                                    skeleton_2_sprite_death);
                u2.active_weapon = new Weapon("sword",Start.data.weapons_data_dict["sword"],0,0);
                u2.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u2.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u2.weapon_weakness = "club";

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0.2f);
                Monster_AI u2_ai = new Monster_AI(1,true,"E",0.2f);

                s6.units.Add(u1);
                s6.units.Add(u2);
                s6.ais.Add(u1_ai);
                s6.ais.Add(u2_ai);
            }
        }

        public Scene init_scene_7() { // scene 7 6right
            if (s7 == null) {
                s7 = new Scene(Start.data.scene_7);
                spawn_units();}
            else if (!s7.scene_monsters_done) {
                spawn_units();}
            s7.door_up = new Rectangle(258,150,20,1); // evil witch hut door outside
            return s7;            

            void spawn_units() {
                s7.units = new List<Unit>(){};
                s7.ais = new List<Monster_AI>(){};

                Sprite skeleton_1_sprite = new Sprite(Start.data.skeleton_images,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                Sprite skeleton_2_sprite = new Sprite(Start.data.skeleton_images,
                                                0.2f,
                                                0,
                                                0,
                                                "E");
                Sprite skeleton_1_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                Sprite skeleton_2_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "E");
                skeleton_1_sprite_death.change_color(Start.data.death_images_large_color, Start.data.skeleton_color);
                skeleton_2_sprite_death.change_color(Start.data.death_images_large_color, Start.data.skeleton_color);
                
                Unit u1 = new Unit("Skeleton",
                                    200,
                                    150,
                                    2,
                                    4,
                                    new List<int>(){196,140,14,15},
                                    skeleton_1_sprite,
                                    skeleton_1_sprite_death);
                u1.active_weapon = new Weapon("sword",Start.data.weapons_data_dict["sword"],0,0);
                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u1.weapon_weakness = "club";

                Unit u2 = new Unit("Skeleton",
                                    220,
                                    170,
                                    2,
                                    4,
                                    new List<int>(){216,160,14,15},
                                    skeleton_2_sprite,
                                    skeleton_2_sprite_death);
                u2.active_weapon = new Weapon("sword",Start.data.weapons_data_dict["sword"],0,0);
                u2.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u2.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u2.weapon_weakness = "club";

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0.2f);
                Monster_AI u2_ai = new Monster_AI(1,true,"E",0.2f);

                s7.units.Add(u1);
                s7.units.Add(u2);
                s7.ais.Add(u1_ai);
                s7.ais.Add(u2_ai);
            }
        }

        public Scene init_scene_8() { // scene 8 7up
            if (s8 == null) {
                s8 = new Scene(Start.data.scene_8);
                spawn_units();}
            else if (!s8.scene_monsters_done) {
                spawn_units();}
            s8.disable_left = true;
            s8.disable_right = true;
            s8.disable_down = true;
            s8.door_down = new Rectangle(187,220,20,1); // evil witch hut door inside
            return s8;

            void spawn_units() {
                s8.units = new List<Unit>(){};
                s8.ais = new List<Monster_AI>(){};

                Sprite witch_sprite = new Sprite(Start.data.evil_witch_images,
                                                0.1f,
                                                0,
                                                0,
                                                "E");
                Sprite witch_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "E");
                witch_sprite_death.change_color(Start.data.death_images_large_color, Start.data.evil_witch_color);

                Unit u1 = new Unit("Evil Witch",
                                    100,
                                    120,
                                    2,
                                    20,
                                    new List<int>(){96,110,14,15},
                                    witch_sprite,
                                    witch_sprite_death);
                u1.active_weapon = new Weapon("sword",Start.data.weapons_data_dict["sword"],0,0);
                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u1.weapon_weakness = "club";

                Monster_AI u1_ai = new Monster_AI(1,true,"E",0);

                s8.units.Add(u1);
                s8.ais.Add(u1_ai);
            }
        }

        public Scene init_scene_9() { // scene 9 6down
            if (s9 == null) {
                s9 = new Scene(Start.data.scene_9);
                spawn_units();}
            else if (!s9.scene_monsters_done) {
                spawn_units();}
            return s9;

            void spawn_units() {
                s9.units = new List<Unit>(){};
                s9.ais = new List<Monster_AI>(){};

                Sprite bat_1_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"W");
                Sprite bat_2_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"E");
                Sprite bat_3_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"W");
                Sprite bat_4_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"E");

                Sprite bat_1_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bat_2_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");
                Sprite bat_3_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bat_4_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");

                bat_1_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_2_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_3_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_4_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);

                Audio bat_death_sound = new Audio(Start.data.monster_death_sounds, 0.0f); 

                Unit u1 = new Unit("Bat",
                                230,
                                170,
                                2,
                                1,
                                new List<int>(){230,170,15,10},
                                bat_1_sprite,
                                bat_1_sprite_death);
                                            
                Unit u2 = new Unit("Bat",
                                210,
                                170,
                                2,
                                1,
                                new List<int>(){210,170,15,10},
                                bat_2_sprite,
                                bat_2_sprite_death);

                Unit u3 = new Unit("Bat",
                                230,
                                150,
                                2,
                                1,
                                new List<int>(){230,150,15,10},
                                bat_3_sprite,
                                bat_3_sprite_death);

                Unit u4 = new Unit("Bat",
                                210,
                                150,
                                2,
                                1,
                                new List<int>(){210,150,15,10},
                                bat_4_sprite,
                                bat_4_sprite_death);
                
                u1.death_sounds = bat_death_sound;
                u2.death_sounds = bat_death_sound;
                u3.death_sounds = bat_death_sound;
                u4.death_sounds = bat_death_sound;

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0);
                Monster_AI u2_ai = new Monster_AI(1,true,"E",0);
                Monster_AI u3_ai = new Monster_AI(1,true,"W",0);
                Monster_AI u4_ai = new Monster_AI(1,true,"E",0);

                s9.units.Add(u1);
                s9.units.Add(u2);
                s9.units.Add(u3);
                s9.units.Add(u4);
                s9.ais.Add(u1_ai);
                s9.ais.Add(u2_ai);
                s9.ais.Add(u3_ai);
                s9.ais.Add(u4_ai);
            }
        }

        public Scene init_scene_10() { // scene 10 9right
            if (s10 == null) {s10 = new Scene(Start.data.scene_10);}
            s10.door_right = new Rectangle(185,165,1,10); // mushrooms
            return s10;
        }

        public Scene init_scene_11() { // scene 11 10mushrooms
            if (s11 == null) {s11 = new Scene(Start.data.scene_11);}
            s11.door_left = new Rectangle(185,165,1,10); // mushrooms
            return s11;
        }

        public Scene init_scene_12() { // scene 12 11right
            if (s12 == null) {
                s12 = new Scene(Start.data.scene_12);
                spawn_units();}
            else if (!s12.scene_monsters_done) {
                spawn_units();}
            s12.door_left = new Rectangle(105,160,5,10); // broken door
            return s12;
            
            void spawn_units() {
                s12.units = new List<Unit>(){};
                s12.ais = new List<Monster_AI>(){};

                Sprite bat_1_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"W");
                Sprite bat_2_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"E");
                Sprite bat_3_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"W");
                Sprite bat_4_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"E");

                Sprite bat_1_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bat_2_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");
                Sprite bat_3_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bat_4_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");

                bat_1_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_2_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_3_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_4_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);

                Audio bat_death_sound = new Audio(Start.data.monster_death_sounds, 0.0f); 

                Unit u1 = new Unit("Bat",
                                230,
                                170,
                                2,
                                2,
                                new List<int>(){230,170,15,10},
                                bat_1_sprite,
                                bat_1_sprite_death);
                                            
                Unit u2 = new Unit("Bat",
                                210,
                                170,
                                2,
                                2,
                                new List<int>(){210,170,15,10},
                                bat_2_sprite,
                                bat_2_sprite_death);

                Unit u3 = new Unit("Bat",
                                230,
                                150,
                                2,
                                2,
                                new List<int>(){230,150,15,10},
                                bat_3_sprite,
                                bat_3_sprite_death);

                Unit u4 = new Unit("Bat",
                                210,
                                150,
                                2,
                                2,
                                new List<int>(){210,150,15,10},
                                bat_4_sprite,
                                bat_4_sprite_death);
                
                u1.death_sounds = bat_death_sound;
                u2.death_sounds = bat_death_sound;
                u3.death_sounds = bat_death_sound;
                u4.death_sounds = bat_death_sound;

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0);
                Monster_AI u2_ai = new Monster_AI(1,true,"E",0);
                Monster_AI u3_ai = new Monster_AI(1,true,"W",0);
                Monster_AI u4_ai = new Monster_AI(1,true,"E",0);

                s12.units.Add(u1);
                s12.units.Add(u2);
                s12.units.Add(u3);
                s12.units.Add(u4);
                s12.ais.Add(u1_ai);
                s12.ais.Add(u2_ai);
                s12.ais.Add(u3_ai);
                s12.ais.Add(u4_ai);
            }
        }

        public Scene init_scene_13() { // scene 13 12down
            if (s13 == null) {
                s13 = new Scene(Start.data.scene_13);
                spawn_units();}
            else if (!s13.scene_monsters_done) {
                spawn_units();}
            s13.items.Add(new Item("cross",Start.data.items_data_dict["cross"],236,155));

            void spawn_units() {
                s13.units = new List<Unit>(){};
                s13.ais = new List<Monster_AI>(){};

                Sprite brigand_sprite = new Sprite(Start.data.brigand_images,
                                                0.1f,
                                                0,
                                                0,
                                                "W");
                Sprite brigand_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                brigand_sprite_death.change_color(Start.data.death_images_large_color, Start.data.brigand_color);
                
                Unit u1 = new Unit("Brigand",
                                    250,
                                    150,
                                    2,
                                    4,
                                    new List<int>(){246,150,14,15},
                                    brigand_sprite,
                                    brigand_sprite_death);
                u1.active_weapon = new Weapon("silver dagger",Start.data.weapons_data_dict["silver dagger"],0,0);
                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0);

                s13.units.Add(u1);
                s13.ais.Add(u1_ai);
            }
            return s13;
        }

        public Scene init_scene_14() { // scene 14 1left
            if (s14 == null) {
                s14 = new Scene(Start.data.scene_14);
                spawn_units();}
            else if (!s14.scene_monsters_done) {
                spawn_units();}
            return s14;

            void spawn_units() {
                s14.units = new List<Unit>(){};
                s14.ais = new List<Monster_AI>(){};

                Sprite troll_sprite = new Sprite(Start.data.troll_images,
                                                0.1f,
                                                0,
                                                0,
                                                "E");
                Sprite troll_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "E");
                troll_sprite_death.change_color(Start.data.death_images_small_color, Start.data.troll_color);

                Unit u1 = new Unit("Troll",
                                    120,
                                    170,
                                    2,
                                    6,
                                    new List<int>(){116,160,14,15},
                                    troll_sprite,
                                    troll_sprite_death);
                u1.active_weapon = new Weapon("rock",Start.data.weapons_data_dict["rock"],0,0);
                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);

                Monster_AI u1_ai = new Monster_AI(1,true,"E",0);

                s14.units.Add(u1);
                s14.ais.Add(u1_ai);
            }
        }

        public Scene init_scene_15() { // scene 15 14left
            if (s15 == null) {
                s15 = new Scene(Start.data.scene_15);
                spawn_units();}
            else if (!s15.scene_monsters_done) {
                spawn_units();}
            return s15;

            void spawn_units() {
                s15.units = new List<Unit>(){};
                s15.ais = new List<Monster_AI>(){};

                Sprite bee_1_sprite = new Sprite(Start.data.bee_images,0.2f,0,0,"E");
                Sprite bee_2_sprite = new Sprite(Start.data.bee_images,0.2f,0,0,"E");
                Sprite bee_3_sprite = new Sprite(Start.data.bee_images,0.2f,0,0,"E");
                Sprite bee_4_sprite = new Sprite(Start.data.bee_images,0.2f,0,0,"E");

                Sprite bee_1_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");
                Sprite bee_2_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");
                Sprite bee_3_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");
                Sprite bee_4_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");

                bee_1_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bee_color);
                bee_2_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bee_color);
                bee_3_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bee_color);
                bee_4_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bee_color);

                Audio bee_death_sound = new Audio(Start.data.monster_death_sounds, 0.0f); 

                Unit u1 = new Unit("Bee",
                                70,
                                150,
                                2,
                                1,
                                new List<int>(){70,150,14,13},
                                bee_1_sprite,
                                bee_1_sprite_death);
                                            
                Unit u2 = new Unit("Bee",
                                70,
                                160,
                                2,
                                1,
                                new List<int>(){70,160,14,13},
                                bee_2_sprite,
                                bee_2_sprite_death);

                Unit u3 = new Unit("Bee",
                                70,
                                155,
                                2,
                                1,
                                new List<int>(){70,155,14,13},
                                bee_3_sprite,
                                bee_3_sprite_death);

                Unit u4 = new Unit("Bee",
                                70,
                                165,
                                2,
                                1,
                                new List<int>(){70,165,14,13},
                                bee_4_sprite,
                                bee_4_sprite_death);
                
                u1.death_sounds = bee_death_sound;
                u2.death_sounds = bee_death_sound;
                u3.death_sounds = bee_death_sound;
                u4.death_sounds = bee_death_sound;

                u1.active_weapon = new Weapon("pollen",Start.data.weapons_data_dict["pollen"],0,0);
                u2.active_weapon = new Weapon("pollen",Start.data.weapons_data_dict["pollen"],0,0);
                u3.active_weapon = new Weapon("pollen",Start.data.weapons_data_dict["pollen"],0,0);
                u4.active_weapon = new Weapon("pollen",Start.data.weapons_data_dict["pollen"],0,0);

                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u2.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u3.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u4.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);

                Monster_AI u1_ai = new Monster_AI(2,false,"",1f);
                Monster_AI u2_ai = new Monster_AI(2,false,"",1f);
                Monster_AI u3_ai = new Monster_AI(2,false,"",1f);
                Monster_AI u4_ai = new Monster_AI(2,false,"",1f);

                s15.units.Add(u1);
                s15.units.Add(u2);
                s15.units.Add(u3);
                s15.units.Add(u4);
                s15.ais.Add(u1_ai);
                s15.ais.Add(u2_ai);
                s15.ais.Add(u3_ai);
                s15.ais.Add(u4_ai);
            }
        }

        public Scene init_scene_16() { // scene 16 15left
            if (s16 == null) {
                s16 = new Scene(Start.data.scene_16);
                spawn_units();}
            else if (!s16.scene_monsters_done) {
                spawn_units();}
            s16.door_up = new Rectangle(140,150,20,1); // good witch hut door outside
            return s16;

            void spawn_units() {
                s16.units = new List<Unit>(){};
                s16.ais = new List<Monster_AI>(){};

                Sprite skeleton_1_sprite = new Sprite(Start.data.skeleton_images,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                Sprite skeleton_2_sprite = new Sprite(Start.data.skeleton_images,
                                                0.2f,
                                                0,
                                                0,
                                                "E");
                Sprite skeleton_1_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                Sprite skeleton_2_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "E");
                skeleton_1_sprite_death.change_color(Start.data.death_images_large_color, Start.data.skeleton_color);
                skeleton_2_sprite_death.change_color(Start.data.death_images_large_color, Start.data.skeleton_color);
                
                Unit u1 = new Unit("Skeleton",
                                    150,
                                    160,
                                    2,
                                    4,
                                    new List<int>(){146,150,14,15},
                                    skeleton_1_sprite,
                                    skeleton_1_sprite_death);
                u1.active_weapon = new Weapon("sword",Start.data.weapons_data_dict["sword"],0,0);
                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u1.weapon_weakness = "club";

                Unit u2 = new Unit("Skeleton",
                                    120,
                                    170,
                                    2,
                                    4,
                                    new List<int>(){116,160,14,15},
                                    skeleton_2_sprite,
                                    skeleton_2_sprite_death);
                u2.active_weapon = new Weapon("sword",Start.data.weapons_data_dict["sword"],0,0);
                u2.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u2.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u2.weapon_weakness = "club";

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0.2f);
                Monster_AI u2_ai = new Monster_AI(1,true,"E",0.2f);

                s16.units.Add(u1);
                s16.units.Add(u2);
                s16.ais.Add(u1_ai);
                s16.ais.Add(u2_ai);
            }
        }

        public Scene init_scene_17() { // scene 17 16up
            if (s17 == null) {
                s17 = new Scene(Start.data.scene_17);
                spawn_units();}
            s17.disable_down = true;
            s17.door_down = new Rectangle(187,220,20,1); // good witch hut door inside
            return s17;

            void spawn_units() {
                s17.units = new List<Unit>(){};
                s17.ais = new List<Monster_AI>(){};

                Sprite witch_sprite = new Sprite(Start.data.good_witch_images,
                                                0.1f,
                                                0,
                                                0,
                                                "E");
                Sprite witch_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "E");
                witch_sprite_death.change_color(Start.data.death_images_large_color, Start.data.good_witch_color);

                Unit u1 = new Unit("Good Witch",
                                    100,
                                    120,
                                    2,
                                    3,
                                    new List<int>(){96,110,14,15},
                                    witch_sprite,
                                    witch_sprite_death);
                
                u1.is_npc = true;
                u1.trade_takes.Add("fangs");
                u1.trade_takes.Add("crystal ball");
                u1.trade_gives.Add("f-elixir");
                u1.items.Add(new Item("f-elixir",Start.data.items_data_dict["f-elixir"],0,0));
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);

                Monster_AI u1_ai = new Monster_AI(1,true,"E",0);

                s17.units.Add(u1);
                s17.ais.Add(u1_ai);
            }
        }

        public Scene init_scene_18() { // scene 18 16left
            if (s18 == null) {
                s18 = new Scene(Start.data.scene_18);
                spawn_units();}
            else if (!s18.scene_monsters_done) {
                spawn_units();}
            return s18;

            void spawn_units() {
                s18.units = new List<Unit>(){};
                s18.ais = new List<Monster_AI>(){};

                Sprite wolf_1_sprite = new Sprite(Start.data.wolf_images,
                                                0.2f,
                                                0,
                                                0,
                                                "E");

                Sprite wolf_1_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "E");
                wolf_1_sprite_death.change_color(Start.data.death_images_large_color, Start.data.wolf_color);
                
                Unit u1 = new Unit("Wolf",
                                    150,
                                    160,
                                    2,
                                    50,
                                    new List<int>(){146,150,14,15},
                                    wolf_1_sprite,
                                    wolf_1_sprite_death);
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u1.weapon_weakness = "silver dagger";

                Monster_AI u1_ai = new Monster_AI(4,true,"E",0);

                s18.units.Add(u1);
                s18.ais.Add(u1_ai);
            }
        }

        public Scene init_scene_19() { // scene 19 16down
            if (s19 == null) {
                s19 = new Scene(Start.data.scene_19);
                spawn_units();}
            else if (!s19.scene_monsters_done) {
                spawn_units();}
            return s19;
            
            void spawn_units() {
                s19.units = new List<Unit>(){};
                s19.ais = new List<Monster_AI>(){};

                Sprite bat_1_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"W");
                Sprite bat_2_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"E");
                Sprite bat_3_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"W");
                Sprite bat_4_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"E");

                Sprite bat_1_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bat_2_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");
                Sprite bat_3_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bat_4_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");

                bat_1_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_2_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_3_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_4_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);

                Audio bat_death_sound = new Audio(Start.data.monster_death_sounds, 0.0f); 

                Unit u1 = new Unit("Bat",
                                230,
                                170,
                                2,
                                2,
                                new List<int>(){230,170,15,10},
                                bat_1_sprite,
                                bat_1_sprite_death);
                                            
                Unit u2 = new Unit("Bat",
                                210,
                                170,
                                2,
                                2,
                                new List<int>(){210,170,15,10},
                                bat_2_sprite,
                                bat_2_sprite_death);

                Unit u3 = new Unit("Bat",
                                230,
                                150,
                                2,
                                2,
                                new List<int>(){230,150,15,10},
                                bat_3_sprite,
                                bat_3_sprite_death);

                Unit u4 = new Unit("Bat",
                                210,
                                150,
                                2,
                                2,
                                new List<int>(){210,150,15,10},
                                bat_4_sprite,
                                bat_4_sprite_death);
                
                u1.death_sounds = bat_death_sound;
                u2.death_sounds = bat_death_sound;
                u3.death_sounds = bat_death_sound;
                u4.death_sounds = bat_death_sound;

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0);
                Monster_AI u2_ai = new Monster_AI(1,true,"E",0);
                Monster_AI u3_ai = new Monster_AI(1,true,"W",0);
                Monster_AI u4_ai = new Monster_AI(1,true,"E",0);

                s19.units.Add(u1);
                s19.units.Add(u2);
                s19.units.Add(u3);
                s19.units.Add(u4);
                s19.ais.Add(u1_ai);
                s19.ais.Add(u2_ai);
                s19.ais.Add(u3_ai);
                s19.ais.Add(u4_ai);
            }
        }

        public Scene init_scene_20() { // scene 20 14up
            if (s20 == null) {
                s20 = new Scene(Start.data.scene_20);
            }
            return s20;
        }

        public Scene init_scene_21() { // scene 21 20right
            if (s21 == null) {
                s21 = new Scene(Start.data.scene_21);
                spawn_units();}
            else if (!s21.scene_monsters_done) {
                spawn_units();}
            return s21;

            void spawn_units() {
                s21.units = new List<Unit>(){};
                s21.ais = new List<Monster_AI>(){};

                Sprite ice_wizard_sprite = new Sprite(Start.data.ice_wizard_images,
                                                      0.1f,
                                                      0,
                                                      0,
                                                      "W");
                Sprite ice_wizard_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                ice_wizard_sprite_death.change_color(Start.data.death_images_large_color, Start.data.ice_wizard_color);
                
                Unit u1 = new Unit("Ice Wizard",
                                    260,
                                    150,
                                    2,
                                    4,
                                    new List<int>(){256,140,14,15},
                                    ice_wizard_sprite,
                                    ice_wizard_sprite_death);
                u1.active_weapon = new Weapon("ice wand",Start.data.weapons_data_dict["ice wand"],0,0);
                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0);

                s21.units.Add(u1);
                s21.ais.Add(u1_ai);
            }
        }

        public Scene init_scene_22() { // scene 22 21right
            if (s22 == null) {
                s22 = new Scene(Start.data.scene_22);
                spawn_units();}
            else if (!s22.scene_monsters_done) {
                spawn_units();}
            return s22;

            void spawn_units() {
                s22.units = new List<Unit>(){};
                s22.ais = new List<Monster_AI>(){};

                Sprite bat_1_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"W");
                Sprite bat_2_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"E");
                Sprite bat_3_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"W");
                Sprite bat_4_sprite = new Sprite(Start.data.bat_images,0.2f,0,0,"E");

                Sprite bat_1_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bat_2_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");
                Sprite bat_3_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bat_4_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"E");

                bat_1_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_2_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_3_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);
                bat_4_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bat_color);

                Audio bat_death_sound = new Audio(Start.data.monster_death_sounds, 0.0f); 

                Unit u1 = new Unit("Bat",
                                230,
                                170,
                                2,
                                2,
                                new List<int>(){230,170,15,10},
                                bat_1_sprite,
                                bat_1_sprite_death);
                                            
                Unit u2 = new Unit("Bat",
                                210,
                                170,
                                2,
                                2,
                                new List<int>(){210,170,15,10},
                                bat_2_sprite,
                                bat_2_sprite_death);

                Unit u3 = new Unit("Bat",
                                230,
                                150,
                                2,
                                2,
                                new List<int>(){230,150,15,10},
                                bat_3_sprite,
                                bat_3_sprite_death);

                Unit u4 = new Unit("Bat",
                                210,
                                150,
                                2,
                                2,
                                new List<int>(){210,150,15,10},
                                bat_4_sprite,
                                bat_4_sprite_death);
                
                u1.death_sounds = bat_death_sound;
                u2.death_sounds = bat_death_sound;
                u3.death_sounds = bat_death_sound;
                u4.death_sounds = bat_death_sound;

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0);
                Monster_AI u2_ai = new Monster_AI(1,true,"E",0);
                Monster_AI u3_ai = new Monster_AI(1,true,"W",0);
                Monster_AI u4_ai = new Monster_AI(1,true,"E",0);

                s22.units.Add(u1);
                s22.units.Add(u2);
                s22.units.Add(u3);
                s22.units.Add(u4);
                s22.ais.Add(u1_ai);
                s22.ais.Add(u2_ai);
                s22.ais.Add(u3_ai);
                s22.ais.Add(u4_ai);
            }
        }

        public Scene init_scene_23() { // scene 23 22right
            if (s23 == null) {s23 = new Scene(
                Start.data.scene_23);
                spawn_units();}
            else if (!s23.scene_monsters_done) {
                spawn_units();}
            return s23;

            void spawn_units() {
                s23.units = new List<Unit>(){};
                s23.ais = new List<Monster_AI>(){};
                
                Sprite archer_1_sprite = new Sprite(Start.data.archer_images,0.2f,0,0,"W");
                Sprite archer_2_sprite = new Sprite(Start.data.archer_images,0.2f,0,0,"W");
                Sprite archer_3_sprite = new Sprite(Start.data.archer_images,0.2f,0,0,"W");

                Sprite archer_1_sprite_death = new Sprite(Start.data.death_images_large,0.2f,0,0,"W");
                Sprite archer_2_sprite_death = new Sprite(Start.data.death_images_large,0.2f,0,0,"W");
                Sprite archer_3_sprite_death = new Sprite(Start.data.death_images_large,0.2f,0,0,"W");

                archer_1_sprite_death.change_color(Start.data.death_images_large_color, Start.data.archer_color);
                archer_2_sprite_death.change_color(Start.data.death_images_large_color, Start.data.archer_color);
                archer_3_sprite_death.change_color(Start.data.death_images_large_color, Start.data.archer_color);

                Audio archer_death_sound = new Audio(Start.data.monster_death_sounds, 0.0f); 

                Unit u1 = new Unit("Archer",
                                300,
                                170,
                                2,
                                2,
                                new List<int>(){296,160,15,10},
                                archer_1_sprite,
                                archer_1_sprite_death);
                                            
                Unit u2 = new Unit("Archer",
                                290,
                                150,
                                2,
                                2,
                                new List<int>(){286,140,15,10},
                                archer_2_sprite,
                                archer_2_sprite_death);

                Unit u3 = new Unit("Archer",
                                280,
                                120,
                                2,
                                2,
                                new List<int>(){276,110,15,10},
                                archer_3_sprite,
                                archer_3_sprite_death);
                
                u1.death_sounds = archer_death_sound;
                u2.death_sounds = archer_death_sound;
                u3.death_sounds = archer_death_sound;

                u1.active_weapon = new Weapon("crossbow",Start.data.weapons_data_dict["crossbow"],0,0);
                u2.active_weapon = new Weapon("crossbow",Start.data.weapons_data_dict["crossbow"],0,0);
                u3.active_weapon = new Weapon("crossbow",Start.data.weapons_data_dict["crossbow"],0,0);

                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u2.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u2.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);

                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u2.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u2.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);

                u1.items.Add(new Item("shield", Start.data.items_data_dict["shield"]));
                u2.items.Add(new Item("shield", Start.data.items_data_dict["shield"]));
                u3.items.Add(new Item("shield", Start.data.items_data_dict["shield"]));

                Monster_AI u1_ai = new Monster_AI(0,false,"",1.5f);
                Monster_AI u2_ai = new Monster_AI(0,false,"",1.5f);
                Monster_AI u3_ai = new Monster_AI(0,false,"",1.5f);

                s23.units.Add(u1);
                s23.units.Add(u2);
                s23.units.Add(u3);
                s23.ais.Add(u1_ai);
                s23.ais.Add(u2_ai);
                s23.ais.Add(u3_ai);
            }
        }

        public Scene init_scene_24() { // scene 24 23right river not frozen
            if (s24 == null) {
                s24 = new Scene(Start.data.scene_24);
                spawn_units();}
            else if (!s24.scene_monsters_done) {
                spawn_units();}
            return s24;

            void spawn_units() {
                s24.units = new List<Unit>(){};
                s24.ais = new List<Monster_AI>(){};

                Sprite bee_1_sprite = new Sprite(Start.data.bee_images,0.2f,0,0,"W");
                Sprite bee_2_sprite = new Sprite(Start.data.bee_images,0.2f,0,0,"W");
                Sprite bee_3_sprite = new Sprite(Start.data.bee_images,0.2f,0,0,"W");
                Sprite bee_4_sprite = new Sprite(Start.data.bee_images,0.2f,0,0,"W");

                Sprite bee_1_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bee_2_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bee_3_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bee_4_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");

                bee_1_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bee_color);
                bee_2_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bee_color);
                bee_3_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bee_color);
                bee_4_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bee_color);

                Audio bee_death_sound = new Audio(Start.data.monster_death_sounds, 0.0f); 

                Unit u1 = new Unit("Bee",
                                290,
                                150,
                                2,
                                1,
                                new List<int>(){290,150,14,13},
                                bee_1_sprite,
                                bee_1_sprite_death);
                                            
                Unit u2 = new Unit("Bee",
                                290,
                                160,
                                2,
                                1,
                                new List<int>(){290,160,14,13},
                                bee_2_sprite,
                                bee_2_sprite_death);

                Unit u3 = new Unit("Bee",
                                290,
                                155,
                                2,
                                1,
                                new List<int>(){290,155,14,13},
                                bee_3_sprite,
                                bee_3_sprite_death);

                Unit u4 = new Unit("Bee",
                                290,
                                165,
                                2,
                                1,
                                new List<int>(){290,165,14,13},
                                bee_4_sprite,
                                bee_4_sprite_death);

                u1.terrain_collision_colors.Add("{R:182 G:250 B:250 A:255}"); // let the bees fly over the blue + frozen river
                u1.terrain_collision_colors.Add("{R:252 G:249 B:252 A:255}");
                u2.terrain_collision_colors.Add("{R:182 G:250 B:250 A:255}");
                u2.terrain_collision_colors.Add("{R:252 G:249 B:252 A:255}");
                u3.terrain_collision_colors.Add("{R:182 G:250 B:250 A:255}");
                u3.terrain_collision_colors.Add("{R:252 G:249 B:252 A:255}");
                u4.terrain_collision_colors.Add("{R:182 G:250 B:250 A:255}");
                u4.terrain_collision_colors.Add("{R:252 G:249 B:252 A:255}");

                u1.death_sounds = bee_death_sound;
                u2.death_sounds = bee_death_sound;
                u3.death_sounds = bee_death_sound;
                u4.death_sounds = bee_death_sound;

                u1.active_weapon = new Weapon("pollen",Start.data.weapons_data_dict["pollen"],0,0);
                u2.active_weapon = new Weapon("pollen",Start.data.weapons_data_dict["pollen"],0,0);
                u3.active_weapon = new Weapon("pollen",Start.data.weapons_data_dict["pollen"],0,0);
                u4.active_weapon = new Weapon("pollen",Start.data.weapons_data_dict["pollen"],0,0);

                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u2.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u3.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u4.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);

                Monster_AI u1_ai = new Monster_AI(2,false,"",1f);
                Monster_AI u2_ai = new Monster_AI(2,false,"",1f);
                Monster_AI u3_ai = new Monster_AI(2,false,"",1f);
                Monster_AI u4_ai = new Monster_AI(2,false,"",1f);

                s24.units.Add(u1);
                s24.units.Add(u2);
                s24.units.Add(u3);
                s24.units.Add(u4);
                s24.ais.Add(u1_ai);
                s24.ais.Add(u2_ai);
                s24.ais.Add(u3_ai);
                s24.ais.Add(u4_ai);
            }
        }

        public Scene init_scene_25() { // scene 25 24right
            if (s25 == null) {
                s25 = new Scene(Start.data.scene_25);
                spawn_units();}
            else if (!s25.scene_monsters_done) {
                spawn_units();}
            return s25;

            void spawn_units() {
                s25.units = new List<Unit>(){};
                s25.ais = new List<Monster_AI>(){};

                Sprite bee_1_sprite = new Sprite(Start.data.bee_images,0.2f,0,0,"W");
                Sprite bee_2_sprite = new Sprite(Start.data.bee_images,0.2f,0,0,"W");
                Sprite bee_3_sprite = new Sprite(Start.data.bee_images,0.2f,0,0,"W");
                Sprite bee_4_sprite = new Sprite(Start.data.bee_images,0.2f,0,0,"W");

                Sprite bee_1_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bee_2_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bee_3_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");
                Sprite bee_4_sprite_death = new Sprite(Start.data.death_images_small,0.2f,0,0,"W");

                bee_1_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bee_color);
                bee_2_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bee_color);
                bee_3_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bee_color);
                bee_4_sprite_death.change_color(Start.data.death_images_small_color, Start.data.bee_color);

                Audio bee_death_sound = new Audio(Start.data.monster_death_sounds, 0.0f); 

                Unit u1 = new Unit("Bee",
                                290,
                                150,
                                2,
                                1,
                                new List<int>(){290,150,14,13},
                                bee_1_sprite,
                                bee_1_sprite_death);
                                            
                Unit u2 = new Unit("Bee",
                                290,
                                160,
                                2,
                                1,
                                new List<int>(){290,160,14,13},
                                bee_2_sprite,
                                bee_2_sprite_death);

                Unit u3 = new Unit("Bee",
                                290,
                                155,
                                2,
                                1,
                                new List<int>(){290,155,14,13},
                                bee_3_sprite,
                                bee_3_sprite_death);

                Unit u4 = new Unit("Bee",
                                290,
                                165,
                                2,
                                1,
                                new List<int>(){290,165,14,13},
                                bee_4_sprite,
                                bee_4_sprite_death);
                
                u1.death_sounds = bee_death_sound;
                u2.death_sounds = bee_death_sound;
                u3.death_sounds = bee_death_sound;
                u4.death_sounds = bee_death_sound;

                u1.active_weapon = new Weapon("pollen",Start.data.weapons_data_dict["pollen"],0,0);
                u2.active_weapon = new Weapon("pollen",Start.data.weapons_data_dict["pollen"],0,0);
                u3.active_weapon = new Weapon("pollen",Start.data.weapons_data_dict["pollen"],0,0);
                u4.active_weapon = new Weapon("pollen",Start.data.weapons_data_dict["pollen"],0,0);

                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u2.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u3.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u4.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);

                Monster_AI u1_ai = new Monster_AI(2,false,"",1f);
                Monster_AI u2_ai = new Monster_AI(2,false,"",1f);
                Monster_AI u3_ai = new Monster_AI(2,false,"",1f);
                Monster_AI u4_ai = new Monster_AI(2,false,"",1f);

                s25.units.Add(u1);
                s25.units.Add(u2);
                s25.units.Add(u3);
                s25.units.Add(u4);
                s25.ais.Add(u1_ai);
                s25.ais.Add(u2_ai);
                s25.ais.Add(u3_ai);
                s25.ais.Add(u4_ai);
            }
        }

        public Scene init_scene_26() { // scene 26 25right dragon and gold
            if (s26 == null) {
                s26 = new Scene(Start.data.scene_26);
                spawn_units();}
            else if (!s26.scene_monsters_done) {
                spawn_units();}
            return s26;

            void spawn_units() {
                s26.units = new List<Unit>(){};
                s26.ais = new List<Monster_AI>(){};

                Sprite dragon_sprite = new Sprite(Start.data.dragon_images,
                                                0.1f,
                                                0,
                                                0,
                                                "W");
                Sprite dragon_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                dragon_sprite_death.change_color(Start.data.death_images_large_color, Start.data.dragon_color);
                
                Unit u1 = new Unit("Dragon",
                                    260,
                                    170,
                                    2,
                                    50,
                                    new List<int>(){256,160,14,15},
                                    dragon_sprite,
                                    dragon_sprite_death);
                u1.active_weapon = new Weapon("fire breath",Start.data.weapons_data_dict["fire breath"],0,0);
                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u1.weapon_weakness = "ice wand";

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0);

                s26.units.Add(u1);
                s26.ais.Add(u1_ai);
            }
        }


        public Scene init_scene_27() { // scene 27 22up
            if (s27 == null) {
                s27 = new Scene(Start.data.scene_27);
                spawn_units();}
            else if (!s27.scene_monsters_done) {
                spawn_units();}
            return s27;

            void spawn_units() {
                s27.units = new List<Unit>(){};
                s27.ais = new List<Monster_AI>(){};

                Sprite troll_sprite = new Sprite(Start.data.troll_images,
                                                0.1f,
                                                0,
                                                0,
                                                "W");
                Sprite troll_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                troll_sprite_death.change_color(Start.data.death_images_large_color, Start.data.troll_color);
                
                Unit u1 = new Unit("Troll",
                                    160,
                                    140,
                                    2,
                                    6,
                                    new List<int>(){156,130,14,15},
                                    troll_sprite,
                                    troll_sprite_death);
                u1.active_weapon = new Weapon("rock",Start.data.weapons_data_dict["rock"],0,0);
                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0);

                s27.units.Add(u1);
                s27.ais.Add(u1_ai);
            }
        }

        public Scene init_scene_28() { // scene 28 27up
            if (s28 == null) {
                s28 = new Scene(Start.data.scene_28);
            }
            s28.door_down = new Rectangle(177,232,30,5);
            return s28;
        }

        public Scene init_scene_29() { // scene 29 28left
            if (s29 == null) {
                s29 = new Scene(Start.data.scene_29);}
            s29.door_up = new Rectangle(205,145,20,1); // hermit hut door outside
            return s29;
        }

        public Scene init_scene_30() { // scene 30 29up
            if (s30 == null) {
                s30 = new Scene(Start.data.scene_30);
                spawn_units();}
            s30.disable_down = true;
            s30.door_down = new Rectangle(187,220,20,1); // hermit hut door inside
            return s30;

            void spawn_units() {
                s30.units = new List<Unit>(){};
                s30.ais = new List<Monster_AI>(){};

                Sprite hermit_sprite = new Sprite(Start.data.hermit_images,
                                                0.1f,
                                                0,
                                                0,
                                                "E");
                Sprite hermit_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "E");
                hermit_sprite_death.change_color(Start.data.death_images_large_color, Start.data.hermit_color);

                Unit u1 = new Unit("Good Hermit",
                                    130,
                                    140,
                                    2,
                                    3,
                                    new List<int>(){126,130,14,15},
                                    hermit_sprite,
                                    hermit_sprite_death);
                
                u1.is_npc = true;
                u1.trade_takes.Add("bag gold");
                u1.trade_gives.Add("map");
                u1.items.Add(new Item("map",Start.data.items_data_dict["map"],0,0));
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);

                Monster_AI u1_ai = new Monster_AI(1,true,"E",0);

                s30.units.Add(u1);
                s30.ais.Add(u1_ai);
            }
        }

        public Scene init_scene_31() { // scene 31 29left
            if (s31 == null) {
                s31 = new Scene(Start.data.scene_31);
                spawn_units();}
            else if (!s31.scene_monsters_done) {
                spawn_units();}
            s31.disable_up = true;
            return s31;

            void spawn_units() {
                s31.units = new List<Unit>(){};
                s31.ais = new List<Monster_AI>(){};

                Sprite skeleton_1_sprite = new Sprite(Start.data.skeleton_images,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                Sprite skeleton_2_sprite = new Sprite(Start.data.skeleton_images,
                                                0.2f,
                                                0,
                                                0,
                                                "E");
                Sprite skeleton_1_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "W");
                Sprite skeleton_2_sprite_death = new Sprite(Start.data.death_images_large,
                                                0.2f,
                                                0,
                                                0,
                                                "E");
                skeleton_1_sprite_death.change_color(Start.data.death_images_large_color, Start.data.skeleton_color);
                skeleton_2_sprite_death.change_color(Start.data.death_images_large_color, Start.data.skeleton_color);
                
                Unit u1 = new Unit("Skeleton",
                                    130,
                                    150,
                                    2,
                                    4,
                                    new List<int>(){126,140,14,15},
                                    skeleton_1_sprite,
                                    skeleton_1_sprite_death);
                u1.active_weapon = new Weapon("sword",Start.data.weapons_data_dict["sword"],0,0);
                u1.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u1.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u1.weapon_weakness = "club";

                Unit u2 = new Unit("Skeleton",
                                    120,
                                    170,
                                    2,
                                    4,
                                    new List<int>(){116,160,14,15},
                                    skeleton_2_sprite,
                                    skeleton_2_sprite_death);
                u2.active_weapon = new Weapon("sword",Start.data.weapons_data_dict["sword"],0,0);
                u2.active_weapon.bullet_sound = new Audio(Start.data.monster_bullet_sounds, 0.0f);
                u2.death_sounds = new Audio(Start.data.monster_death_sounds, 0.0f);
                u2.weapon_weakness = "club";

                Monster_AI u1_ai = new Monster_AI(1,true,"W",0.2f);
                Monster_AI u2_ai = new Monster_AI(1,true,"E",0.2f);

                s31.units.Add(u1);
                s31.units.Add(u2);
                s31.ais.Add(u1_ai);
                s31.ais.Add(u2_ai);
            }
        }

    }
}