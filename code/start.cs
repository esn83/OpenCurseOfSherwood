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
            menu = new Menu(800,600,data.cover_image);
            game = new Game(menu.choises);
        }

        public void run() {
            
            Raylib.SetTraceLogLevel(TraceLogLevel.LOG_WARNING);
            Raylib.InitWindow((int) menu.choises[2],(int) menu.choises[3],"");
            Raylib.SetTargetFPS(60); // set 60FPS
            Raylib.InitAudioDevice(); // sound, must be called before loading sounds
            
            while (running) {
                
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_ESCAPE)) {
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
