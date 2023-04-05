using Raylib_cs;

namespace main {

    public class Bullet {
        public string name;
        public string direction;
        public int pos_x;
        public int pos_y;
        public int speed;
        public int damage;
        public Rectangle hitbox;
        public int hitbox_offset_x;
        public int hitbox_offset_y;
        public int width;
        public Sprite sprite;

        // constructor
        public Bullet(string name_p,
                      string direction_p,
                      int pos_x_p,
                      int pos_y_p,
                      int speed_p,
                      int damage_p,
                      List<int> hitbox_stats_p,
                      Sprite sprite_p)
        {
            name = name_p;
            direction = direction_p;
            pos_x = pos_x_p;
            pos_y = pos_y_p;
            speed = speed_p;
            damage = damage_p;
            hitbox = new Rectangle(hitbox_stats_p[0],hitbox_stats_p[1],hitbox_stats_p[2],hitbox_stats_p[3]);
            hitbox_offset_x = pos_x-hitbox_stats_p[0];
            hitbox_offset_y = pos_y-hitbox_stats_p[1];
            width = hitbox_stats_p[2];
            sprite = sprite_p;
        }

        public void update(float dt, float dt_factor) {
            if (direction.Equals("W")) {pos_x -= (int) ((float) speed * dt_factor);}
            if (direction.Equals("E")) {pos_x += (int) ((float) speed * dt_factor);}
            sprite.pos_x = pos_x;
            sprite.pos_y = pos_y;
            sprite.update(dt);
            hitbox.x = pos_x + hitbox_offset_x;
            hitbox.y = pos_y + hitbox_offset_y;
        }

    }
}