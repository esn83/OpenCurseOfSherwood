using Raylib_cs;

namespace main {
    
    public class Game {

        public List<Object> choises;
        public float dt;
        public Camera camera;

        public Random rnd = new Random();
        public bool game_won = false;
        public List<Player> players = new List<Player>(){};
        public SceneManager scene_manager;
        public Texture2D topbar;
        public Audio general_item_sound;

        private Color txt_color;
        private Font font;

        private bool popup_1_is_showing = false;
        private Texture2D popup_1_texture;
        private string popup_1_text;
        
        // constructor
        public Game
        (
            List<Object> menuChoises_p
        )
        {
            choises = menuChoises_p;
            dt = 0;

            //txt_color = new Color(240,200,5,255); // yellow
            //txt_color = new Color(210,125,237,255); // purple
            txt_color = new Color(100,100,100,255); // gray

            camera = new Camera(Raylib.GetScreenWidth(),
                        Raylib.GetScreenHeight(),
                        0,//Raylib.GetScreenWidth()/2.0f,
                        0,//Raylib.GetScreenHeight()/2.0f,
                        0,//Raylib.GetScreenWidth()/2.0f,
                        0//Raylib.GetScreenHeight()/2.0f
                        );
        }

        void init() {
            // misc
            general_item_sound = new Audio(new List<string>(){Start.data.general_item_sound}, 0f);

            // players
            foreach (List<Object> p in (List<Object>) choises[0]) {
                Player new_player = new Player((string) p[0],
                                               (Color) p[1],
                                               (List<KeyboardKey>) p[2],
                                               (int) p[3]);
                players.Add(new_player);
            }
            
            // topbar
            Image topbar_img = Raylib.LoadImage(Start.data.topbar);
            Raylib.ImageColorReplace(ref topbar_img, Start.data.bg, new Color(0,0,0,0));
            topbar = Raylib.LoadTextureFromImage(topbar_img);

            // scene
            scene_manager = new SceneManager();
            
            // players character
            Sprite monk_sprite = new Sprite(Start.data.monk_images,
                                            0.08f,
                                            0,0);
            monk_sprite.change_color(new Color(252,249,252,255), players[0].color);

            Sprite monk_sprite_death = new Sprite(Start.data.monk_images_death,
                                                  0.2f,
                                                  0,0);
            monk_sprite_death.change_color(new Color(252,249,252,255), players[0].color);

            Sprite monk_sprite_sink = new Sprite(Start.data.monk_images_sink,
                                                 0.35f,
                                                 0,0);
            monk_sprite_sink.change_color(new Color(252,249,252,255), players[0].color);

            // List<string> monk_images_rise = Start.data.monk_images_sink;
            // monk_images_rise.Reverse();
            // Sprite monk_sprite_rise= new Sprite(monk_images_rise,
            //                                     0.35f,
            //                                     0,0,
            //                                     "L");
            // monk_sprite_rise.change_color(new Color(252,249,252,255), players[0].color);

            Unit monk = new Unit("Monk",
                                130,//scene_manager.active_scene.respawn_point_x,
                                130,//scene_manager.active_scene.respawn_point_y,
                                "L",
                                1,
                                1,
                                monk_sprite,
                                monk_sprite_death);
            monk.sprite_sink = monk_sprite_sink;
            // monk.sprite_rise = monk_sprite_rise;
            monk.walk_sounds = new Audio(Start.data.monk_walk_sounds, 0.35f);
            monk.death_sounds = new Audio(Start.data.monk_death_sounds, 0.5f);
            monk.sink_sounds = new Audio(Start.data.sink_sounds, 1.5f);
            // monk.rise_sounds = new Audio(Start.data.rise_sounds, 0.0f);
            
            // monk.weapons.Add(new Weapon("sword", Start.data.weapons_data_dict["sword"], 202, 67));
            // monk.weapons.Add(new Weapon("club", Start.data.weapons_data_dict["club"], 202, 67));
            // monk.weapons.Add(new Weapon("silver dagger", Start.data.weapons_data_dict["silver dagger"], 202, 67));
            // monk.weapons.Add(new Weapon("ice wand", Start.data.weapons_data_dict["ice wand"], 202, 67));
            // monk.weapons.Add(new Weapon("crossbow", Start.data.weapons_data_dict["crossbow"], 202, 67));
            // monk.active_weapon = monk.weapons[0];
            // monk.items.Add(new Item("shield",Start.data.items_data_dict["shield"],0,0));
            // monk.items.Add(new Item("scrying glass",Start.data.scrying_glass_data,0,0));
            // monk.items.Add(new Item("cross",Start.data.items_data_dict["cross"],0,0));
            // monk.items.Add(new Item("fangs",Start.data.fangs_data,0,0));
            // monk.items.Add(new Item("bag gold",Start.data.items_data_dict["bag gold"],0,0));
            // monk.items.Add(new Item("f-elixir",Start.data.items_data_dict["f-elixir"],0,0));
            // monk.items.Add(new Item("map",Start.data.items_data_dict["map"],0,0));
            
            players[0].unit = monk;
        }

        public void run() {
            Raylib.SetWindowTitle("Open Curse of Sherwood : Game");
            if ((bool) choises[1] == false) {
                Raylib.SetWindowPosition(500,200); // window position
            }
            else {
                Raylib.SetWindowSize(Raylib.GetMonitorWidth(Raylib.GetCurrentMonitor()),
                                     Raylib.GetMonitorHeight(Raylib.GetCurrentMonitor()));
                Raylib.SetWindowPosition(0,0);
            }
            font = Raylib.LoadFont("assets/fonts/alagard.ttf");
            init();
            while (!Raylib.WindowShouldClose() && Start.playing)
            {
                time();
                events();
                update();
                draw();
            }
            Raylib.UnloadFont(font);
        }

        void time() {
            dt = Raylib.GetFrameTime(); // Raylib.GetFrameTime() : Get time in seconds for last frame drawn (delta time) ~0.01667s @ 60FPS
        }

        void events() {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)) {Start.playing = false;}

            if (!game_won) {
                foreach (Player p in players) {
                    p.events(scene_manager.active_scene);
                }
            }
            else {
                foreach (Player p in players) {
                    p.unit.stop();
                }
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_X)) {
                System.Console.WriteLine("the X key!");
                players[0].lives += 1;
            }
        }

        void update() {
            
            camera.update();

            // update scene
                // scene edges
            if (!scene_manager.active_scene.disable_right &&
                players[0].unit.terrain_hitbox.x + players[0].unit.terrain_hitbox.width +1 >= scene_manager.active_scene.scene_limit_x_right) { // +1 to bypass scene edge colission
                scene_manager.next_scene_right();
                players[0].unit.pos_x = scene_manager.active_scene.scene_limit_x_left;
            }
            else if (!scene_manager.active_scene.disable_left &&
                players[0].unit.terrain_hitbox.x -1 <= scene_manager.active_scene.scene_limit_x_left) { // -1 to bypass scene edge colission
                scene_manager.next_scene_left();
                players[0].unit.pos_x = scene_manager.active_scene.scene_limit_x_right - players[0].unit.terrain_hitbox.width -5;
            }
            else if (!scene_manager.active_scene.disable_down &&
                players[0].unit.terrain_hitbox.y + players[0].unit.terrain_hitbox.height +1 >= scene_manager.active_scene.scene_limit_y_down) { // +1 to bypass scene edge colission
                scene_manager.next_scene_down();
                players[0].unit.pos_y = scene_manager.active_scene.scene_limit_y_up - players[0].unit.terrain_hitbox.height + players[0].unit.terrain_hitbox_offset_y;
            }
            else if (!scene_manager.active_scene.disable_up &&
                players[0].unit.terrain_hitbox.y -1 <= scene_manager.active_scene.scene_limit_y_up) { // -1 to bypass scene edge colission
                scene_manager.next_scene_up();
                players[0].unit.pos_y = scene_manager.active_scene.scene_limit_y_down - players[0].unit.terrain_hitbox.height - 2*players[0].unit.terrain_hitbox_offset_y;
            }
                // / scene edges

                // doors
            if (Raylib.CheckCollisionRecs(players[0].unit.terrain_hitbox, scene_manager.active_scene.door_left)) {
                scene_manager.next_scene_left();
                players[0].unit.pos_x = scene_manager.active_scene.door_right.x - scene_manager.active_scene.door_right.width - players[0].unit.terrain_hitbox.width -5;
                players[0].unit.pos_y = scene_manager.active_scene.door_right.y - players[0].unit.terrain_hitbox.height;
            }
            else if (Raylib.CheckCollisionRecs(players[0].unit.terrain_hitbox, scene_manager.active_scene.door_right)) {
                scene_manager.next_scene_right();
                players[0].unit.pos_x = scene_manager.active_scene.door_left.x + scene_manager.active_scene.door_right.width +1;
                players[0].unit.pos_y = scene_manager.active_scene.door_left.y - players[0].unit.terrain_hitbox.height;
            }
            else if (Raylib.CheckCollisionRecs(players[0].unit.terrain_hitbox, scene_manager.active_scene.door_up)) {
                scene_manager.next_scene_up();
                players[0].unit.pos_x = scene_manager.active_scene.door_down.x;
                players[0].unit.pos_y = scene_manager.active_scene.door_down.y - players[0].unit.terrain_hitbox.height - players[0].unit.terrain_hitbox_offset_y;
            }
            else if (Raylib.CheckCollisionRecs(players[0].unit.terrain_hitbox, scene_manager.active_scene.door_down)) {
                scene_manager.next_scene_down();
                players[0].unit.pos_x = scene_manager.active_scene.door_up.x;
                players[0].unit.pos_y = scene_manager.active_scene.door_up.y - players[0].unit.terrain_hitbox.height +8;
            }

                // / doors

            scene_manager.update(dt, players);
            // / update scene

            foreach (Player p in players) {
                p.update(dt, scene_manager.active_scene);

                // check if player collides with a weapon on the ground
                List<Weapon> remove_ground = new List<Weapon>(){};
                foreach(Weapon w in scene_manager.active_scene.weapons) {
                    bool col = Raylib.CheckCollisionRecs(p.unit.terrain_hitbox, w.icon_hitbox);
                    if (col) {
                        w.pos_x = 202;
                        w.pos_y = 67;
                        p.unit.weapons.Add(w);
                        p.unit.active_weapon = p.unit.weapons.LastOrDefault();
                        general_item_sound.play_sound();
                        remove_ground.Add(w);
                    }
                }
                foreach (Weapon w in remove_ground) {
                    scene_manager.active_scene.weapons.Remove(w);
                }
                // / check if player collides with a weapon on the ground

                // check if player collides with an item on the ground
                List<Item> remove_ground_2 = new List<Item>(){};
                foreach(Item i in scene_manager.active_scene.items) {
                    bool col = Raylib.CheckCollisionRecs(p.unit.terrain_hitbox, i.icon_hitbox);
                    if (col) {
                        i.pos_x = 0;
                        i.pos_y = 0;
                        p.unit.items.Add(i);
                        general_item_sound.play_sound();
                        remove_ground_2.Add(i);
                    }
                }
                foreach (Item i in remove_ground_2) {
                    scene_manager.active_scene.items.Remove(i);
                }
                while (p.unit.items.Count > 3) { // drop item [0] if inventory has more than 3 items
                    Item i = p.unit.items[0];
                    if (p.unit.direction_l_or_r.Equals("L")) {
                        scene_manager.active_scene.items.Add(new Item(i.name,Start.data.items_data_dict[i.name],p.unit.pos_x-12, p.unit.pos_y+20));
                    }
                    else {
                        scene_manager.active_scene.items.Add(new Item(i.name,Start.data.items_data_dict[i.name],p.unit.pos_x+22, p.unit.pos_y+20));
                    }
                    p.unit.items.Remove(i);
                }
                // / check if player collides with an item on the ground

                // check for player bullet colission with monster
                List<Bullet> remove_p_bullets = new List<Bullet>(){};
                foreach (Bullet b in scene_manager.active_scene.player_bullets) {
                    foreach (Unit u in scene_manager.active_scene.units) {
                        if (!u.is_dead) {
                            bool col = Raylib.CheckCollisionRecs(b.hitbox, u.hitbox);
                            if (col) {
                                bool deflect = false;
                                foreach (Item item in u.items) {
                                    if (item.name.Equals("shield")) { // deflect bullet
                                        int chance = rnd.Next(3); // 1/3 chance of deflect
                                        if (chance == 0) {
                                            deflect = true;
                                            u.bullets.Add(b);
                                            scene_manager.active_scene.monster_bullets.Add(b);
                                            b.speed += 1;
                                            if (b.direction.Equals("L")) {
                                                b.direction = "R";
                                            }
                                            else {
                                                b.direction = "L";
                                            }
                                            break;
                                        }
                                    }
                                }
                                if (!deflect && !u.is_immortal) {
                                    if (u.weapon_weakness != null && u.weapon_weakness.Equals(b.name)) {u.hitpoints -= (int) Math.Ceiling((float)u.hitpoints_max/2);} // take ½ unit hitpoints rounded up for weapon weakness
                                    else {u.hitpoints -= b.damage;}
                                }
                                if (!u.is_immortal) {
                                    remove_p_bullets.Add(b);
                                }
                            }
                        }
                    }
                }
                foreach (Bullet rb in remove_p_bullets) {
                    scene_manager.active_scene.player_bullets.Remove(rb);
                }
                // / check for player bullet colission with monster

                // check for monster body colission with player
                foreach (Unit u in scene_manager.active_scene.units) {
                    if (!u.is_dead && !u.is_npc) {
                        bool col = Raylib.CheckCollisionRecs(p.unit.hitbox, u.hitbox);
                        if (u.name.Equals("Fire Spirit")) { // f-elixir protects against Fire Spirits
                            foreach (Item i in p.unit.items) {
                                if (i.name.Equals("f-elixir")) {
                                    col = false;
                                }
                            }
                        }
                        if (col && !p.unit.is_sinking) {p.unit.hitpoints = 0;}
                    }

                    else if (!u.is_dead && u.is_npc) { // npc trade items
                        bool col = Raylib.CheckCollisionRecs(p.unit.hitbox, u.hitbox);
                        if (col) {
                            List<Item> player_to_npc_items = new List<Item>(){};
                            foreach (Item i in p.unit.items) {
                                if (u.trade_takes.Contains(i.name)) {
                                    player_to_npc_items.Add(i);
                                    u.trade_takes.Remove(i.name);
                                }
                            }
                            if (player_to_npc_items.Count > 0) {
                                foreach (Item i in player_to_npc_items) {
                                    p.unit.items.Remove(i);
                                    u.items.Add(i);
                                }
                            }
                            if (u.trade_takes.Count == 0) {
                                List<Item> npc_to_player_items = new List<Item>(){};
                                foreach (Item i in u.items) {
                                    if (u.trade_gives.Contains(i.name)) {
                                        npc_to_player_items.Add(i);
                                        u.trade_gives.Remove(i.name);
                                    }
                                }
                                if (npc_to_player_items.Count > 0) {
                                    foreach (Item i in npc_to_player_items) {
                                        p.unit.items.Add(i);
                                        general_item_sound.play_sound();
                                        u.items.Remove(i);
                                        if (i.name.Equals("map")) {
                                            p.popup_1 = true;
                                        }
                                    }
                                }
                            }

                        }
                    }
                }

                // / check for monster body colission with player

                // check for monster bullet collision with player
                List<Bullet> remove_m_bullets = new List<Bullet>(){};
                foreach(Bullet b in scene_manager.active_scene.monster_bullets) {
                    bool col = Raylib.CheckCollisionRecs(p.unit.hitbox, b.hitbox);
                    if (col && !p.unit.is_dead) {
                        bool deflect = false;
                        foreach (Item item in p.unit.items) {
                            if (item.name.Equals("shield")) { // deflect bullet
                                int chance = rnd.Next(3); // 1/3 chance of deflect
                                if (chance == 0) {
                                    deflect = true;
                                    p.unit.bullets.Add(b);
                                    scene_manager.active_scene.player_bullets.Add(b);
                                    b.speed += 1;
                                    if (b.direction.Equals("L")) {
                                        b.direction = "R";
                                    }
                                    else {
                                        b.direction = "L";
                                    }
                                    break;
                                }
                            }
                        }
                        if (!deflect) {
                            p.unit.hitpoints -= b.damage;
                        }
                        remove_m_bullets.Add(b);
                    }
                }
                foreach (Bullet rb in remove_m_bullets) {
                    scene_manager.active_scene.monster_bullets.Remove(rb);
                }
                // / check for monster bullet collision with player

                // check for player collision with swamp
                foreach (Rectangle swamp in scene_manager.active_scene.swamp_areas) {
                    bool col = Raylib.CheckCollisionRecs(p.unit.terrain_hitbox, swamp);
                    if (col) {
                        p.unit.is_sinking = true;
                        break;
                    }
                }
                // / check for player collision with swamp

                // check if player has won the game
                if (scene_manager.active_scene == scene_manager.s43) { // last scene
                    if (scene_manager.active_scene.scene_monsters_done) {
                        bool col = Raylib.CheckCollisionRecs(p.unit.hitbox, new Rectangle(190,175,2,2)); // centre of star
                        if(col) {
                            foreach (Item item in p.unit.items) {
                                if (item.name.Equals("cross")) {
                                    game_won = true;
                                    Scene end = new Scene(new List<string>(){Start.data.end_screen});
                                    scene_manager.active_scene = end;
                                    break;
                                }
                            }
                        }
                    }
                }
                // / check if player has won the game

            }
        }

        void draw() {

            Raylib.BeginDrawing();
            Raylib.ClearBackground(new Color(25,29,25,255));
            Raylib.BeginMode2D(camera.camera);

            if (!game_won) {
                // draw topbar
                Raylib.DrawTexture(topbar,65,42,Color.WHITE);

                // draw scene
                Raylib.DrawTexture(scene_manager.active_scene.scene,0,0,Color.WHITE);

                foreach (Texture2D extra in scene_manager.active_scene.scene_extras) {
                    Raylib.DrawTexture(extra,0,0,Color.WHITE);
                }

                foreach (Unit u in scene_manager.active_scene.units) {
                    u.sprite_active.draw();
                    //Raylib.DrawRectangleRec(u.hitbox, Color.BLUE);
                }
                foreach(Bullet b in scene_manager.active_scene.player_bullets) {
                    b.sprite.draw();
                }
                foreach(Bullet b in scene_manager.active_scene.monster_bullets) {
                    b.sprite.draw();
                }
                foreach (Weapon w in scene_manager.active_scene.weapons) {
                    Raylib.DrawTexture(w.icon, (int) w.pos_x, (int) w.pos_y, Color.WHITE);
                }
                foreach (Item i in scene_manager.active_scene.items) {
                    Raylib.DrawTexture(i.icon, (int) i.pos_x, (int) i.pos_y, Color.WHITE);
                }

                // Raylib.DrawRectangleRec(scene_manager.active_scene.door_down, Color.WHITE);
                // Raylib.DrawRectangleRec(scene_manager.active_scene.door_up, Color.WHITE);
                // Raylib.DrawRectangleRec(scene_manager.active_scene.door_left, Color.WHITE);
                // Raylib.DrawRectangleRec(scene_manager.active_scene.door_right, Color.WHITE);
                // foreach (Rectangle r in scene_manager.active_scene.swamp_areas) {Raylib.DrawRectangleRec(r, new Color(0,0,100,100));}

                // / draw scene

                foreach (Player p in players) {
                    
                    // Raylib.DrawRectangleRec(p.unit.hitbox, new Color(0,0,200,150));
                    // Raylib.DrawRectangleRec(p.unit.terrain_hitbox, new Color(200,0,0,150));
                    // Raylib.DrawText("unit dir           " + p.unit.direction,5,110,10,Color.GOLD);
                    // Raylib.DrawText("unit dir lr        " + p.unit.direction_l_or_r,5,120,10,Color.GOLD);
                    // Raylib.DrawText("active sprite dir " + p.unit.sprite_active.direction,5,130,10,Color.GOLD);
                    // Raylib.DrawText("death sprite dir  " + p.unit.sprite_death.direction,5,140,10,Color.GOLD);
                    
                    p.unit.sprite_active.draw();

                    Raylib.DrawText(p.lives.ToString(), // draw lives
                                    289,
                                    62,
                                    18,
                                    new Color(251,251,139,255));
                    
                    if (p.unit.items.Count > 0) { // draw items
                        int x = 121;
                        int y = 66;
                        int count = 0;
                        foreach (Item i in p.unit.items) {
                            Raylib.DrawTexture(i.icon,
                                            x + count * 25,
                                            y,
                                            Color.WHITE);
                            count += 1;
                        }
                    }
                    
                    if (p.unit.active_weapon != null) { // draw active weapon
                        Weapon w = p.unit.active_weapon;
                        Raylib.DrawTexture(w.icon,
                                        (int) w.pos_x,
                                        (int) w.pos_y,
                                        Color.WHITE);
                                        
                        if (w.name.Split(" ").Count() > 1) { // draw weapon name, split weapon name in two of there is a space in its name
                            Raylib.DrawText(w.name.Split(" ")[0], // draw weapon name part1
                                            (int) w.pos_x + 20,
                                            (int) w.pos_y - 6,
                                            10,
                                            new Color(106,207,111,255));
                            Raylib.DrawText(w.name.Split(" ")[1], // draw weapon name part2
                                            (int) w.pos_x + 20,
                                            (int) w.pos_y + 3,
                                            10,
                                            new Color(106,207,111,255));
                        }
                        else {
                            Raylib.DrawText(w.name, // draw weapon name
                                            (int) w.pos_x + 20,
                                            (int) w.pos_y - 2,
                                            10,
                                            new Color(106,207,111,255));
                        }
                    }

                    if (p.popup_1) {show_popup_1();}
                    else if (popup_1_is_showing) {popup_1_is_showing = false;}
                }

            }
            else { // show end screen
                Raylib.DrawTexture(scene_manager.active_scene.scene,0,0,Color.WHITE);
                string score = players[0].score.ToString();
                Raylib.DrawText(score,200,160,10,new Color(106,207,111,255));
            }

            Raylib.EndMode2D();
            
            Raylib.DrawTextEx(font,"FPS : "+Raylib.GetFPS().ToString(),new System.Numerics.Vector2(10,10),font.baseSize*0.4f,0,txt_color);
            //Raylib.DrawFPS(10, 10);
            Raylib.DrawTextEx(font,"move : arrow keys",new System.Numerics.Vector2(10,25),font.baseSize*0.4f,0,txt_color);
            Raylib.DrawTextEx(font,"shoot : LCTRL",new System.Numerics.Vector2(10,40),font.baseSize*0.4f,0,txt_color);
            Raylib.DrawTextEx(font,"next weapon : RSHIFT",new System.Numerics.Vector2(10,55),font.baseSize*0.4f,0,txt_color);
            Raylib.DrawTextEx(font,"map : F1",new System.Numerics.Vector2(10,70),font.baseSize*0.4f,0,txt_color);
            Raylib.DrawTextEx(font,"menu : SPACE",new System.Numerics.Vector2(10,85),font.baseSize*0.4f,0,txt_color);

            Raylib.EndDrawing();

        }

        public void show_popup_1() { // swamp map
            if (popup_1_is_showing == false) {
                Image img = Raylib.LoadImage(Start.data.swamp_map);
                popup_1_texture = Raylib.LoadTextureFromImage(img);
                popup_1_text = "Press " + players[0].controls[6].ToString() + " to close map";
                popup_1_is_showing = true;
            }
            else {
                Raylib.DrawTexture(popup_1_texture, 100, 30, Color.WHITE);
                Raylib.DrawTextEx(font,popup_1_text,new System.Numerics.Vector2(100,20),font.baseSize*0.3f,0,txt_color);
            }
        }

    }
}