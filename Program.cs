using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;
using static Raylib_cs.Color;

namespace Pong
{
    public class PongClone
    {
        public static int Main()
        {
            // Initialization
            //--------------------------------------------------------------------------------------
            const int screenWidth = 1200;
            const int screenHeight = 900;

            InitWindow(screenWidth, screenHeight, "pong");

             Vector2 playerOnePosition = new Vector2(150 - 120, 300);
             Vector2 playerTwoPosition = new Vector2(1100, (float)screenHeight / 2);


            SetTargetFPS(240);
            //--------------------------------------------------------------------------------------

            // Main game loop
            while (!WindowShouldClose())    // Detect window close button or ESC key
            {
                // Player Two - arrow key controls 
                //----------------------------------------------------------------------------------
                // if (IsKeyDown(KEY_D))
                //     playerOnePosition.X += 2.0f;
                // if (IsKeyDown(KEY_A))
                //     playerOnePosition.X -= 2.0f;
                if (IsKeyDown(KEY_W))
                    playerOnePosition.Y -= 2.0f;
                if (IsKeyDown(KEY_S))
                    playerOnePosition.Y += 2.0f;
                //----------------------------------------------------------------------------------

                // Player Two - arrow key controls 
                //----------------------------------------------------------------------------------
                // if (IsKeyDown(KEY_RIGHT))
                //     playerTwoPosition.X += 2.0f;
                // if (IsKeyDown(KEY_LEFT))
                //     playerTwoPosition.X -= 2.0f;
                if (IsKeyDown(KEY_UP))
                    playerTwoPosition.Y -= 2.0f;
                if (IsKeyDown(KEY_DOWN))
                    playerTwoPosition.Y += 2.0f;
                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                BeginDrawing();
                ClearBackground(RAYWHITE);

                DrawText("Pong", 20, 20, 20, DARKGRAY);

                DrawLine(18, 42, screenWidth - 18, 42, BLACK);

                // Player One -- left 
                DrawRectangle((int)playerOnePosition.X, (int)playerOnePosition.Y, 50, 150,  BLUE);

                // Player Two -- right
                DrawRectangle((int)playerTwoPosition.X, (int)playerTwoPosition.Y, 50, 150,  RED);

                EndDrawing();
                //----------------------------------------------------------------------------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------

            return 0;
        }
    }
}
