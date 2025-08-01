using Raylib_cs;

namespace main {

    public class Bullet {
        public string name;
        public string direction;
        public float pos_x;
        public float pos_y;
        public float speed;
        public int damage;
        public Rectangle hitbox;
        public int width;
        public Sprite sprite;

        // constructor
        public Bullet (
            string name_p,
            string direction_p,
            float pos_x_p,
            float pos_y_p,
            float speed_p,
            int damage_p,
            Sprite sprite_p
        )
        {
            name = name_p;
            direction = direction_p;
            pos_x = pos_x_p;
            pos_y = pos_y_p + 10*Game.window_scale;
            speed = speed_p;
            damage = damage_p;
            sprite = sprite_p;
            hitbox = new Rectangle(pos_x, pos_y, sprite.textures_active[0].Width, sprite.textures_active[0].Height);
        }

        public void update(float dt) {
            if (direction.Equals("L")) {pos_x -= speed;}
            if (direction.Equals("R")) {pos_x += speed;}
            sprite.pos_x = pos_x;
            sprite.pos_y = pos_y;
            sprite.update(dt, direction);
            hitbox.X = pos_x;
            hitbox.Y = pos_y;
        }

    }
}