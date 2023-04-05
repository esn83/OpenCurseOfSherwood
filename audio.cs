using Raylib_cs;

namespace main {

    public class Audio {

        public List<string> sound_paths; // list of paths to sounds
        public float sound_length;
        public List<Sound> sound_list = new List<Sound>{};
        public Random rnd = new Random();
        public float sound_delay_count = 0;

        // constructor
        public Audio(List<string>sound_list_str_p,
                     float sound_length_p)
        {
            sound_paths = sound_list_str_p;
            sound_length = sound_length_p;

            init();
        }

        public void init() {
            foreach (string s in sound_paths) {
                Sound sx = Raylib.LoadSound(s);
                sound_list.Add(sx);
                }
        }

        public void update(float dt) {
            sound_delay_count += dt;
        }

        // functions

        public void play_sound() {
            if (sound_delay_count >= sound_length) {
                int rndint = rnd.Next(0, sound_list.Count);
                Raylib.PlaySound(sound_list[rndint]);
                sound_delay_count = 0;
            }
        }

    }
}
