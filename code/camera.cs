using Raylib_cs;
using System.Numerics;

namespace main {
    
    public class Camera {

        public Camera2D camera;
        public int screenHeight;
        public int screenWidth;
        public int scrollSpeed;
        public float offset_x;
        public float offset_y;
        public float target_x;
        public float target_y;

        // constructor
        public Camera (
            int screenWidth_p,
            int screenHeight_p,
            float offset_x_p,
            float offset_y_p,
            float target_x_p,
            float target_y_p
        )
        {
            screenWidth = screenWidth_p;
            screenHeight = screenHeight_p;
            offset_x = offset_x_p;
            offset_y = offset_y_p;
            target_x = target_x_p;
            target_y = target_y_p;

            camera = new Camera2D();
            camera.target = new Vector2( target_x , target_y );
            camera.offset = new Vector2( offset_x , offset_y );
            camera.rotation = 0.0f;
            camera.zoom = 2.0f;

            scrollSpeed = 30;
        }

        public void update() {
            //scroll();
            //zoom();
        }

        public void scroll() {
            Vector2 mousePos = Raylib.GetMousePosition();
            //System.Console.WriteLine(mousePos);
            if (mousePos.X >= screenWidth * 0.95f) {camera.target.X += scrollSpeed;}
            if (mousePos.X <= screenWidth * 0.05f) {camera.target.X -= scrollSpeed;}
            if (mousePos.Y >= screenHeight * 0.95f) {camera.target.Y += scrollSpeed;}
            if (mousePos.Y <= screenHeight * 0.05f) {camera.target.Y -= scrollSpeed;}
        }

        public void zoom() {
            float mouseWheel = Raylib.GetMouseWheelMove();
            if (mouseWheel ==  1) {camera.zoom += camera.zoom*0.05f;}
            if (mouseWheel == -1 & (camera.zoom - camera.zoom*0.05f > 0)) {camera.zoom -= camera.zoom*0.05f;}
        }

        public void resetCamera() {
            camera.target = new Vector2( target_x , target_y );
            camera.offset = new Vector2( offset_x, offset_y );
            camera.rotation = 0.0f;
            camera.zoom = 1.0f;
        }
    }
}