
using System;

namespace MohawkGame2D
{
    public class Game
    {
        int keyboardS = 0;

        Color amethyst = new Color("#9966cc");
        Color pinkiePie = new Color("#ff55a3");
        Color joy = new Color("#ccff00");

        int count = 20000;
        float[] xCoordinates = new float[20000];
        float[] yCoordinates = new float[20000];

        public void Setup()
        {
            Window.SetTitle("Your Lovely little Boy");
            Window.SetSize(700, 600);
            Window.TargetFPS = 60;

            Console.WriteLine("the Boy does not -- Feel -- . Situation should become: feel.");

            for (int i = 0; i < count; i++)
            {
                xCoordinates[i] = Random.Float(0, 700);
                yCoordinates[i] = Random.Float(0, 600);
            }

        }

        public void Update()
        {
            Window.ClearBackground(Color.Black);

            //creates the boy's home, allowing for redecorating at the player's will
            void safeHome()
            {
                Color homeColor = Color.Clear;
                if (Input.IsKeyboardKeyDown(KeyboardInput.W))
                {
                    homeColor = amethyst;
                }
                else if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
                {
                    homeColor = pinkiePie;
                }
                else if (Input.IsKeyboardKeyDown(KeyboardInput.S))
                {
                    homeColor = Color.White;
                }
                Draw.FillColor = homeColor;
                Draw.LineColor = Color.Yellow;
                Draw.Rectangle(0.0f, 0.0f, 700.0f, 600.0f);

            }

            //creates the boy himself, and changes his mood based on the house's color
            void littleGuy()
            {
                Color boyColor = Color.Clear;
                if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
                {
                    boyColor = joy;
                }
                else if (Input.IsKeyboardKeyDown(KeyboardInput.W))
                {
                    boyColor = Color.Blue;
                }
                else if (Input.IsKeyboardKeyDown(KeyboardInput.S))
                {
                    boyColor = Color.Red;
                }
                else if (Input.IsKeyboardKeyDown(KeyboardInput.A))
                {
                    boyColor = Color.Green;
                }
                Draw.LineColor = Color.Yellow;
                Draw.LineSize = 5;
                Draw.FillColor = boyColor;
                Draw.Capsule(Input.GetMouseX() - 15.0f, Input.GetMouseY(), Input.GetMouseX() + 15.0f, Input.GetMouseY(), 11.0f);
                Draw.Square(Input.GetMouseX() - 17.5f, Input.GetMouseY() + 11.0f, 35.0f);
                Draw.Line(Input.GetMouseX() - 17.0f, Input.GetMouseY() + 20.0f, Input.GetMouseX() - 37.0f, Input.GetMouseY() + 27.0f);
                Draw.Line(Input.GetMouseX() + 17.0f, Input.GetMouseY() + 20.0f, Input.GetMouseX() + 37.0f, Input.GetMouseY() + 27.0f);
                Draw.Line(Input.GetMouseX() + 10.0f, Input.GetMouseY() + 45.0f, Input.GetMouseX() + 10.0f, Input.GetMouseY() + 70.0f);
                Draw.Line(Input.GetMouseX() - 10.0f, Input.GetMouseY() + 45.0f, Input.GetMouseX() - 10.0f, Input.GetMouseY() + 70.0f);

            }

            //prepares to freeze the boy

            void iceSheet()
            {

                for (int i = 0; i < count; i++)
                {

                    Draw.LineColor = Color.White;
                    Draw.FillColor = Color.Cyan;

                    float x = xCoordinates[i];
                    float y = yCoordinates[i];

                    Draw.Square(x, y, 7);

                }

            }

            //prepares the creation of the boy's circles

            void createTheCircles()
            {

                int count = 500;
                float[] xCoordinates = new float[count];
                float[] yCoordinates = new float[count];


                for (int i = 0; i < count; i++)
                {
                    xCoordinates[i] = Random.Float(0, 700);
                    yCoordinates[i] = Random.Float(0, 600);

                    float x = xCoordinates[i];
                    float y = yCoordinates[i];

                    Draw.FillColor = Color.Cyan;
                    Draw.Circle(x, y, 10);

                }

            }

            safeHome();

            littleGuy();

            // freezes the boy
            if (Input.IsKeyboardKeyDown(KeyboardInput.Q))
            {
                iceSheet();

            }

            if (Input.IsKeyboardKeyPressed(KeyboardInput.Q))
            {
                Console.WriteLine("S");
                Console.WriteLine("O");
                Console.WriteLine();
                Console.WriteLine("C");
                Console.WriteLine("O");
                Console.WriteLine("L");
                Console.WriteLine("D");
                Console.WriteLine();
            }

            //creates his circles
            if (Input.IsKeyboardKeyDown(KeyboardInput.A))
            {
                createTheCircles();
                Console.WriteLine("Y'O'U''R'E DOING IT. YOU ARE --MAKING THE CIRCLES--. THE BOY _loves_ THE CIRCLES.");

            }

            // alerting the player to the boy's feelings 
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                Console.WriteLine("You are making the Boy: Joy. Situation is content.");
            }
            else if (Input.IsKeyboardKeyPressed(KeyboardInput.W))
            {
                Console.WriteLine("Boy Sad now. Situation is: Badly.");
            }
            else if (Input.IsKeyboardKeyPressed(KeyboardInput.S))
            {
                Console.WriteLine("HATE. THE BOY FEELS: HATE. FALSE; FALSE; . BOY NOT MEANT TO: FEEL RED");
            }

            if (Input.IsKeyboardKeyPressed(KeyboardInput.S))
            {
                keyboardS++;
            }

            //display a haunting message repeating for eternity!!
            if (keyboardS > 3)
            {
                Window.ClearBackground(Color.Red);
                Console.WriteLine("--E R R O R-- --E R R O R-- --E R R O R--");
                Console.WriteLine("The_Rage. Running without : UserPermissions");
                Console.WriteLine();
                Console.WriteLine("system.Diagnosis:");
                Console.WriteLine("Boy has become blinded by: The_Rage. Recommended fix:");
                Console.WriteLine(".....");
                Console.WriteLine(".......");
                Console.WriteLine("...........");
                Console.WriteLine("Boy is Blind --Forever--");
                Console.WriteLine("......Processing......");
                Console.WriteLine();
                Console.WriteLine("Situation: Forever.                                 Fix: _No.");
                Console.WriteLine();
                Console.WriteLine();
            }

        }

    }

}
