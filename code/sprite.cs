using Raylib_cs;

namespace main {

    public class Sprite {
        public List<string> image_paths_left; // list of paths to images the sprite uses in the order of the animation facing left. right is made by flipping these vertically.
        public List<string> image_paths_up;
        public List<string> image_paths_down;
        public int current_frame = 0;
        public List<Texture2D> textures_l;
        public List<Texture2D> textures_r;
        public List<Texture2D> textures_u;
        public List<Texture2D> textures_d;
        public List<Texture2D> textures_active;
        public string direction = "L"; // left, right, up, down
        public float frame_delay;
        public float frame_delay_count = 0;
        public float pos_x;
        public float pos_y;

        // constructor
        public Sprite
        (
            List<string> image_paths_left_p,
            float frame_dealy_p,
            float pos_x_p,
            float pos_y_p,
            List<string> image_paths_up_p = null,
            List<string> image_paths_down_p = null
        )
        {
            image_paths_left = image_paths_left_p;
            frame_delay = frame_dealy_p;
            pos_x = pos_x_p;
            pos_y = pos_y_p;
            if (image_paths_up_p != null) {image_paths_up = image_paths_up_p;}
            if (image_paths_down_p != null) {image_paths_down = image_paths_down_p;}
            init(); 
        }

        public void init() {
            load_textures();
            set_active_textures_direction();
        }

        public void update(float dt, string direction_p) {
            frame_delay_count += dt;
            direction = direction_p;
            set_active_textures_direction();
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

        public void set_active_textures_direction() {
            if (direction.Equals("L")) {
                if (textures_l != null && textures_l.Count > 0) {
                    textures_active = textures_l;
                }
            }
            if (direction.Equals("R")) {
                if (textures_r != null && textures_r.Count > 0) {
                    textures_active = textures_r;
                }
            }
            if (direction.Equals("U")) {
                if (textures_u != null && textures_u.Count > 0) {
                    textures_active = textures_u;
                }
            }
            if (direction.Equals("D")) {
                if (textures_d != null && textures_d.Count > 0) {
                    textures_active = textures_d;
                }
            }
        }

        public void load_textures() {
            List<Texture2D> textures_l_temp = new List<Texture2D>{};
            List<Texture2D> textures_r_temp = new List<Texture2D>{};
            List<Texture2D> textures_u_temp = new List<Texture2D>{};
            List<Texture2D> textures_d_temp = new List<Texture2D>{};
            
            foreach (string i in image_paths_left) {
                Image ix = Raylib.LoadImage(i);
                Raylib.ImageColorReplace(ref ix, Start.data.bg, new Color(0,0,0,0));
                Texture2D tx_l = Raylib.LoadTextureFromImage(ix);
                textures_l_temp.Add(tx_l);
                Raylib.ImageFlipHorizontal(ref ix);
                Texture2D tx_r = Raylib.LoadTextureFromImage(ix);
                textures_r_temp.Add(tx_r);
            }
            textures_l = textures_l_temp;
            textures_r = textures_r_temp;
            if (image_paths_up != null) {
                foreach (string i in image_paths_up) {
                    Image ix = Raylib.LoadImage(i);
                    Raylib.ImageColorReplace(ref ix, Start.data.bg, new Color(0,0,0,0));
                    Texture2D tx_u = Raylib.LoadTextureFromImage(ix);
                    textures_u_temp.Add(tx_u);
                }
            }
            textures_u = textures_u_temp;
            if (image_paths_down != null) {
                foreach (string i in image_paths_down) {
                    Image ix = Raylib.LoadImage(i);
                    Raylib.ImageColorReplace(ref ix, Start.data.bg, new Color(0,0,0,0));
                    Texture2D tx_d = Raylib.LoadTextureFromImage(ix);
                    textures_d_temp.Add(tx_d);
                }
            }
            textures_d = textures_d_temp;
        }

        public void change_color(Color old_col, Color new_col) {
            List<Texture2D> textures_l_temp = new List<Texture2D>{};
            List<Texture2D> textures_r_temp = new List<Texture2D>{};
            List<Texture2D> textures_u_temp = new List<Texture2D>{};
            List<Texture2D> textures_d_temp = new List<Texture2D>{};

            foreach (string i in image_paths_left) {
                Image ix = Raylib.LoadImage(i);
                Raylib.ImageColorReplace(ref ix, Start.data.bg, new Color(0,0,0,0));
                Raylib.ImageColorReplace(ref ix, old_col, new_col);
                Texture2D tx_l = Raylib.LoadTextureFromImage(ix);
                textures_l_temp.Add(tx_l);
                Raylib.ImageFlipHorizontal(ref ix);
                Texture2D tx_r = Raylib.LoadTextureFromImage(ix);
                textures_r_temp.Add(tx_r);
            }
            textures_l = textures_l_temp;
            textures_r = textures_r_temp;

            if (image_paths_up != null) {
                foreach (string i in image_paths_up) {
                    Image ix = Raylib.LoadImage(i);
                    Raylib.ImageColorReplace(ref ix, Start.data.bg, new Color(0,0,0,0));
                    Raylib.ImageColorReplace(ref ix, old_col, new_col);
                    Texture2D tx_u = Raylib.LoadTextureFromImage(ix);
                    textures_u_temp.Add(tx_u);
                }
                textures_u = textures_u_temp;
            }
            if (image_paths_down != null) {
                foreach (string i in image_paths_down) {
                    Image ix = Raylib.LoadImage(i);
                    Raylib.ImageColorReplace(ref ix, Start.data.bg, new Color(0,0,0,0));
                    Raylib.ImageColorReplace(ref ix, old_col, new_col);
                    Texture2D tx_d = Raylib.LoadTextureFromImage(ix);
                    textures_d_temp.Add(tx_d);
                }
                textures_d = textures_d_temp;
            }
        }

        // extra

        public void print_image_colors() {
            System.Console.WriteLine("image colors");
            foreach (string sx in image_paths_left) {
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
            foreach (Texture2D tw in textures_l) {
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

            foreach (Texture2D te in textures_r) {
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