using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame

{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            

            Walls walls = new Walls(80, 25);
            walls.Draw();


            Point snakeTail = new Point(15, 15, 's');
            Snake snake = new Snake(snakeTail, 5, Direction.RIGHT);
            snake.Draw();

            FoodGenerator foodGenerator = new FoodGenerator(80, 25, '$');
            Point food = foodGenerator.GenerateFood();
            food.Draw();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            FoodGenerator foodGenerator2 = new FoodGenerator(80, 25, '/');
            Point food2 = foodGenerator2.GenerateFood();
            food2.Draw();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            FoodGenerator foodGenerator3 = new FoodGenerator(80, 25, '*');
            Point food3 = foodGenerator3.GenerateFood();
            food3.Draw();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodGenerator.GenerateFood();
                    food.Draw();
                    score--;
                    Console.Beep();
                }
                if (snake.Eat(food2))
                {
                    food2 = foodGenerator2.GenerateFood();
                    food2.Draw();
                    score++;
                    Console.Beep();
                }
                if (snake.Eat(food3))
                {
                    food3 = foodGenerator3.GenerateFood();
                    food3.Draw();
                    
                    Console.Beep();
                    int xOffset = 25;
                    int yOffset = 8;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xOffset, yOffset++);
                    WriteText("========================", xOffset, yOffset++);
                    WriteText("        GAME OVER       ", xOffset + 1, yOffset++);
                    yOffset++;
                    WriteText($" You Scored {score} points", xOffset + 2, yOffset++);
                    WriteText("", xOffset + 1, yOffset++);
                    WriteText("=========================", xOffset, yOffset++);
                    string Str_score = Convert.ToString(score);
                    WriteGameOver(Str_score);
                    Console.ReadLine();
                }

                else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKeys(key.Key);
                }
                Thread.Sleep(300);

            }
            string str_score = Convert.ToString(score);
            WriteGameOver(str_score);
            Console.ReadLine();
        }


        public static void WriteGameOver(string score)
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("========================", xOffset, yOffset++);
            WriteText("        GAME OVER       ", xOffset + 1, yOffset++);
            yOffset++;
            WriteText($" You Scored {score} points", xOffset + 2, yOffset++);
            WriteText("", xOffset + 1, yOffset++);
            WriteText("=========================", xOffset, yOffset++);
            Console.Beep();
        }


        public static void WriteText(string text, int xOffset, int YOffset)
        {
            Console.SetCursorPosition(xOffset, YOffset);
            Console.WriteLine(text);
        }




    }
}