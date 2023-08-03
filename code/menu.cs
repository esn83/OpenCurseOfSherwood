using Raylib_cs;

namespace main {
    
    public class Menu {

        private int menu_screen_w;
        private int menu_screen_h;
        public static float window_scale;
        string cover_img_path;
        private List<Object> players;
        private bool fullscreen;
        private int game_screen_w;
        private int game_screen_h;
        private int state = 0; // 0=poem guide, 1=controls
        private Texture2D cover;
        private Color txt_color;
        private Font font;
        public List<Object> choises;

        // constructor
        public Menu (
            string cover_img_path_p
        )
        {
            players = new List<Object>(){};
            fullscreen = false;
            game_screen_w = 0;
            game_screen_h = 0;
            cover_img_path = cover_img_path_p;
            txt_color = new Color(240,200,5,255);
            choises = new List<Object>(){};
            temp_menu();
            menu_screen_w = (int) choises[2];
            menu_screen_h = (int) choises[3];
            window_scale = menu_screen_w / (float)Start.data.native_screen_width;
        }

        public void run() {
            Raylib.SetWindowTitle("Open Curse of Sherwood : Menu");
            Raylib.SetWindowPosition(500,100); // window position
            resize_cover();
            font = Raylib.LoadFont("assets/fonts/alagard.ttf");
            while (!Raylib.WindowShouldClose() && !Start.playing)
            {
                events();
                update();
                draw();
            }
            Raylib.UnloadFont(font);
        }

        void events() {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)) {Start.playing = true;}
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_F1)) {
                if      (state==0) {state=1;}
                else if (state==1) {state=0;}
            }

        }

        void update() {
        }

        void draw() {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Start.data.bg);
            Raylib.DrawTexture(cover,menu_screen_w-cover.width-5,5,Color.WHITE);
            Raylib.DrawText("Press SPACE to play!", (int)(6*window_scale), (int)(10*window_scale), (int)(10*window_scale), txt_color);
            Raylib.DrawText("Controls : F1", (int)(6*window_scale), (int)(25*window_scale), (int)(6*window_scale), txt_color);

            if (state == 0) { // draw poem guide
                int y_pos = (int)(40*window_scale);
                foreach (string s in Start.data.guide) {
                    Raylib.DrawTextEx(font,
                                    s,
                                    new System.Numerics.Vector2((int)(6*window_scale),y_pos),
                                    font.baseSize*0.17f*window_scale,
                                    0,
                                    txt_color);
                    y_pos += (int)(7*window_scale);
                }
            }
            else if (state == 1) { // draw controls
                int y_pos = (int)(40*window_scale);
                List<string> control_names = new List<string>() {"Move Left      :  ",
                                                                 "Move Right    :  ",
                                                                 "Move Up        :  ",
                                                                 "Move Down    :  ",
                                                                 "Shoot             :  ",
                                                                 "Next Weapon :  ",
                                                                 "Swamp Map   :  ",
                                                                };
                int count = 0;
                foreach (List<Object> player in (List<Object>) choises[0]) {
                    foreach (KeyboardKey key in (List<KeyboardKey>) player[2]) {
                        Raylib.DrawTextEx(font,
                                            control_names[count] + key.ToString().Replace("KEY_",""),
                                            new System.Numerics.Vector2((int)(6*window_scale),y_pos),
                                            font.baseSize*0.17f*window_scale,
                                            0,
                                            txt_color);
                        y_pos += (int)(7*window_scale);
                        count += 1;
                    }
                }
            }

            Raylib.EndDrawing();
        }

        public void resize_cover() {
            Image cover_img = Raylib.LoadImage(cover_img_path);
            float cover_size_factor = ((float) (menu_screen_w*0.75f)-10) / (float) cover_img.height;
            int cover_width = (int)((float)cover_img.width * cover_size_factor);
            int cover_height = (int)((float)cover_img.height * cover_size_factor);
            Raylib.ImageResize(ref cover_img,cover_width,cover_height);
            cover = Raylib.LoadTextureFromImage(cover_img);
        }
        
        // temp menu items until menu screen with choises is implemented
        public void temp_menu() {
            players = new List<Object> {new List<Object> {
                                                        "Player 1",
                                                        new Color(255,255,255,255),
                                                        new List<KeyboardKey> {KeyboardKey.KEY_LEFT, // left
                                                                               KeyboardKey.KEY_RIGHT, // right
                                                                               KeyboardKey.KEY_UP, // up
                                                                               KeyboardKey.KEY_DOWN, // down
                                                                               KeyboardKey.KEY_LEFT_CONTROL, // fire
                                                                               KeyboardKey.KEY_RIGHT_SHIFT, // next weapon
                                                                               KeyboardKey.KEY_F1, // map
                                                        },
                                                        3 // lives
                                        }
            };
            fullscreen = false;
            //fullscreen = true;
            // game_screen_w = 640;
            // game_screen_h = 480;
            game_screen_w = 800;
            game_screen_h = 600;
            // game_screen_w = 1024;
            // game_screen_h = 768;

            choises = new List<Object> {players,fullscreen,game_screen_w,game_screen_h};
        }
        // / temp menu items until menu screen with choises is implemented

    }
}