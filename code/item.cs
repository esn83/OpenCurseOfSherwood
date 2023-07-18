using Raylib_cs;

namespace main {

    public class Item {

        public string name;
        public List<string> data_paths;
        public Texture2D icon;
        public float pos_x;
        public float pos_y;
        public Rectangle icon_hitbox;

        // constructor
        public Item
        (
            string name_p,
            List<string> data_paths_p,
            float pos_x_p,
            float pos_y_p)
        {
            name = name_p;
            data_paths = data_paths_p;
            pos_x = pos_x_p;
            pos_y = pos_y_p;

            Image icon_img = Raylib.LoadImage(data_paths[0]);
            Raylib.ImageColorReplace(ref icon_img, Start.data.bg, new Color(0,0,0,0)); // transparent background
            icon = Raylib.LoadTextureFromImage(icon_img);
            icon_hitbox = new Rectangle(pos_x, pos_y, icon.width, icon.height);
        }

    }
}