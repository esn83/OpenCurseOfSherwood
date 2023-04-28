using Raylib_cs;

namespace main {

    public class Sprite {
        public List<string> image_paths; // list of paths to images the sprite uses in the order of the animation
        public int current_frame = 0;
        public List<Texture2D> textures_w = new List<Texture2D>{};
        public List<Texture2D> textures_e = new List<Texture2D>{};
        public List<Texture2D> textures_active = new List<Texture2D>{};
        public string direction; // west, north, east, south
        public float frame_delay;
        public float frame_delay_count = 0;
        public float pos_x;
        public float pos_y;
        public string direction_w_or_e = "W";

        // constructor
        public Sprite
        (
            List<string> image_paths_p,
            float frame_dealy_p,
            float pos_x_p,
            float pos_y_p,
            string direction_p
        )
        {
            image_paths = image_paths_p;
            frame_delay = frame_dealy_p;
            pos_x = pos_x_p;
            pos_y = pos_y_p;
            direction = direction_p;
            init(); 
        }

        public void init() {
            load_textures();
            if (direction.Equals("W")) {textures_active = textures_w; direction_w_or_e = direction;}
            else if (direction.Equals("E")) {textures_active = textures_e; direction_w_or_e = direction;}
        }

        public void update(float dt) {
            frame_delay_count += dt;

            if (direction.Equals("W")) {
                direction_w_or_e = direction;
                textures_active = textures_w;
                }
            if (direction.Equals("E")) {
                direction_w_or_e = direction;
                textures_active = textures_e;
                }
        }

        public void draw() {
            Raylib.DrawTexture(textures_active[current_frame], (int) pos_x, (int) pos_y, Color.WHITE);
        }

        public void next_frame() {
            if (frame_delay_count > frame_delay) {
                if (current_frame + 1 >= textures_active.Count) {
                    current_frame = 0;
                }
                else {
                    current_frame += 1;
                }
            frame_delay_count = 0;
            }
        }

        public void load_textures() {
            textures_w = new List<Texture2D>{};
            textures_e = new List<Texture2D>{};
            
            foreach (string i in image_paths) {
                Image ix = Raylib.LoadImage(i);
                Raylib.ImageColorReplace(ref ix, Start.data.bg, new Color(0,0,0,0));

                Texture2D tx_w = Raylib.LoadTextureFromImage(ix);
                textures_w.Add(tx_w);

                Raylib.ImageFlipHorizontal(ref ix);
                Texture2D tx_e = Raylib.LoadTextureFromImage(ix);
                textures_e.Add(tx_e);
            }
        }

        public void change_color(Color old_col, Color new_col) {
            List<Texture2D> textures_w_temp = new List<Texture2D>{};
            List<Texture2D> textures_e_temp = new List<Texture2D>{};

            foreach (string i in image_paths) {
                Image ix = Raylib.LoadImage(i);
                Raylib.ImageColorReplace(ref ix, Start.data.bg, new Color(0,0,0,0));

                Raylib.ImageColorReplace(ref ix, old_col, new_col);
                Texture2D tx_w = Raylib.LoadTextureFromImage(ix);
                textures_w_temp.Add(tx_w);

                Raylib.ImageFlipHorizontal(ref ix);
                Texture2D tx_e = Raylib.LoadTextureFromImage(ix);
                textures_e_temp.Add(tx_e);
            }
            textures_w = textures_w_temp;
            textures_e = textures_e_temp;
        }

        public void print_image_colors() {
            System.Console.WriteLine("image colors");
            foreach (string sx in image_paths) {
                Image ix = Raylib.LoadImage(sx);
                List<string> colors = new List<string>(){};
                for (int i=0 ; i<ix.height ; i++) {
                    for (int j=0 ; j<ix.width ; j++) {
                        Color cx = Raylib.GetImageColor(ix,j,i);
                        string cx_str = cx.ToString();
                        if (colors.Contains(cx_str)) {continue;}
                        else {colors.Add(cx_str);}
                    }
                }
                foreach (string color in colors) {
                    System.Console.WriteLine(color);
                }
            }
        }

        public void print_texture_colors() {
            System.Console.WriteLine("texture colors");
            foreach (Texture2D tw in textures_w) {
                Image ix = Raylib.LoadImageFromTexture(tw);
                List<string> colors = new List<string>(){};
                for (int i=0 ; i<ix.height ; i++) {
                    for (int j=0 ; j<ix.width ; j++) {
                        Color cx = Raylib.GetImageColor(ix,j,i);
                        string cx_str = cx.ToString();
                        if (colors.Contains(cx_str)) {continue;}
                        else {colors.Add(cx_str);}
                    }
                }
                foreach (string color in colors) {
                    System.Console.WriteLine(color);
                }
            }

            foreach (Texture2D te in textures_e) {
                Image ix = Raylib.LoadImageFromTexture(te);
                List<string> colors = new List<string>(){};
                for (int i=0 ; i<ix.height ; i++) {
                    for (int j=0 ; j<ix.width ; j++) {
                        Color cx = Raylib.GetImageColor(ix,j,i);
                        string cx_str = cx.ToString();
                        if (colors.Contains(cx_str)) {continue;}
                        else {colors.Add(cx_str);}
                    }
                }
                foreach (string color in colors) {
                    System.Console.WriteLine(color);
                }
            }
        }

    }   
}