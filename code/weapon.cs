using System.Globalization;
using Raylib_cs;

namespace main {

    public class Weapon {

        public string name;
        public List<string> data_paths;
        public Texture2D icon;
        public Texture2D bullet;
        public Audio shoot_sound;
        public int damage;
        public int bullet_speed;
        public float pos_x;
        public float pos_y;
        public Rectangle icon_hitbox;

        // constructor
        public Weapon
        (
            string name_p,
            List<string> data_paths_p,
            float pos_x_p,
            float pos_y_p
        )
        {
            name = name_p;
            data_paths = data_paths_p;
            pos_x = pos_x_p;
            pos_y = pos_y_p;

            Image icon_img = Raylib.LoadImage(data_paths[0]);
            Raylib.ImageColorReplace(ref icon_img, Start.data.bg, new Color(0,0,0,0));
            icon = Raylib.LoadTextureFromImage(icon_img);

            Image bullet_img = Raylib.LoadImage(data_paths[1]);
            Raylib.ImageColorReplace(ref bullet_img, Start.data.bg, new Color(0,0,0,0));
            bullet = Raylib.LoadTextureFromImage(bullet_img);

            shoot_sound = new Audio(new List<string>(){data_paths[2]},
                                     float.Parse(data_paths[3],
                                     CultureInfo.InvariantCulture.NumberFormat));
            damage = Convert.ToInt16(data_paths[4]);
            bullet_speed = int.Parse(data_paths[5]);
            icon_hitbox = new Rectangle(pos_x, pos_y, icon.width, icon.height);
        }

        public Bullet shoot(float bpos_x, float bpos_y, string direction) {
            shoot_sound.play_sound();
            List<string> bullet_img_list = new List<string>(){data_paths[1]};
            
            Sprite bullet_sprite = new Sprite(
            bullet_img_list,
            0.08f,
            bpos_x,
            bpos_y);

            Bullet bullet = new Bullet (
                name,
                direction,
                bpos_x,
                bpos_y,
                bullet_speed,
                damage,
                bullet_sprite);
            
            return bullet;
        }

        public void update(float dt) {
            shoot_sound.update(dt);
        }

    }
}