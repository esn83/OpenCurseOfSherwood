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
        public Item (
            string name_p,
            List<string> data_paths_p,
            float pos_x_p,
            float pos_y_p)
        {
            name = name_p;
            data_paths = data_paths_p;
            pos_x = pos_x_p;
            pos_y = pos_y_p;

            icon = Game.img_path_to_texture_scaled(data_paths[0], Game.window_scale, false, Start.data.transparent);
            icon_hitbox = new Rectangle(pos_x, pos_y, icon.Width, icon.Height);
        }

    }
}