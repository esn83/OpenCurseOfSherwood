using Raylib_cs;

namespace main {
    
    public class Menu {

        private int menu_screen_w;
        private int menu_screen_h;
        string cover_img_path;
        
        private List<Object> players;
        private bool fullscreen;
        private int game_screen_w;
        private int game_screen_h;
        private int fps;

        private Texture2D cover;
        private Color txt_color;
        Font font;

        public List<Object> choises;

        // constructor
        public Menu(
            int menu_screen_w_p,
            int menu_screen_h_p,
            string cover_img_path_p
        )
        {
            players = new List<Object>(){};
            fullscreen = false;
            menu_screen_w = menu_screen_w_p;
            menu_screen_h = menu_screen_h_p;
            game_screen_w = 0;
            game_screen_h = 0;
            fps = 0;
            cover_img_path = cover_img_path_p;
            txt_color = new Color(240,200,5,255);

            choises = new List<Object>(){};

            temp_menu();
        }

        public void run() {
            Raylib.InitWindow(menu_screen_w, menu_screen_h, "Open Curse of Sherwood : Menu");
            Raylib.SetTargetFPS( (int) choises[4] ); // set target FPS
            Raylib.SetWindowPosition(500,200); // window position
            resize_cover();
            font = Raylib.LoadFont("assets/fonts/alagard.ttf");
            while (!Raylib.WindowShouldClose())
            {
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)) {Start.playing = true;}
                if (Start.playing) {break;}
                events();
                update();
                draw();
            }
            Raylib.UnloadFont(font);
            Raylib.CloseWindow();
        }

        void events() {
        }

        void update() {
        }

        void draw() {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(new Color(50,50,50,255));
            Raylib.DrawTexture(cover,menu_screen_w-cover.width-5,5,Color.WHITE);
            Raylib.DrawText("MENU!", 12, 12, 20, txt_color);
            Raylib.DrawText("Press SPACE to play!", 12, 40, 20, txt_color);

            int guide_y = 110;
            foreach (string s in Start.data.guide) {
                Raylib.DrawTextEx(font,s,new System.Numerics.Vector2(12,guide_y),font.baseSize*0.6f,0,txt_color);
                guide_y += 22;
            }

            Raylib.EndDrawing();
        }

        public void resize_cover() {
            Image cover_img = Raylib.LoadImage(cover_img_path);
            float cover_size_factor = ((float) menu_screen_h-10) / (float) cover_img.height;
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
                                                                               KeyboardKey.KEY_UP, // up
                                                                               KeyboardKey.KEY_RIGHT, // right
                                                                               KeyboardKey.KEY_DOWN, // down
                                                                               KeyboardKey.KEY_RIGHT_CONTROL, // fire
                                                                               KeyboardKey.KEY_RIGHT_SHIFT, // next weapon
                                                        },
                                                        3 // lives
                                        }
            };

            fullscreen = false;
            //fullscreen = true;
            game_screen_w = 800;
            game_screen_h = 600;
            fps = 60;

            choises = new List<Object> {players,fullscreen,game_screen_w,game_screen_h,fps};
        }
        // / temp menu items until menu screen with choises is implemented

    }
}