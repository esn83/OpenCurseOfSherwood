using Raylib_cs;

namespace main {

    public class Start {

        public bool running;
        public static bool playing;
        public static Data data;
        public Menu menu;
        public Game game;

        // constructor
        public Start()
        {
            running = true;
            playing = false;
            data = new Data();
            menu = new Menu(data.cover_image); // window size changes in menu and game
            game = new Game(menu.choises);
        }

        public void run() {
            
            Raylib.SetTraceLogLevel(TraceLogLevel.Warning);
            Raylib.InitWindow((int) menu.choises[2]+(int)(5*Game.window_scale),(int) menu.choises[3]+(int)(5*Game.window_scale),""); // +5x/+5y for a small black edge around the window
            Raylib.SetTargetFPS(60); // set 60FPS
            Raylib.InitAudioDevice(); // sound, must be called before loading sounds
            
            while (running) {
                
                if (Raylib.IsKeyPressed(KeyboardKey.Escape)) {
                playing = false;
                running = false;
                }

                if (running && !playing) {
                    menu.run();
                }

                else if (running && playing) {
                    game = new Game(menu.choises);
                    game.run();
                }
            }
            
            Raylib.CloseAudioDevice();
            Raylib.CloseWindow();
        }

    }
}
