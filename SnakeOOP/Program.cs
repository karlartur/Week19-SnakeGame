﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Point p1 = new Point(10, 10, '*');           
            Point p2 = new Point(11, 10, '*');

            HorizontallLine hLine = new HorizontallLine(10, 14, 5, '*');
            hLine.Draw();
            VerticalLine vLine = new VerticalLine(6, 16, 10, '@');
            vLine.Draw();
            HorizontallLine top = new HorizontallLine(0, 80, 0, '#');
            top.Draw();
            VerticalLine left = new VerticalLine(0, 25, 0, '#');
            left.Draw();
            HorizontallLine bottom = new HorizontallLine(0, 80, 25, '$');
            bottom.Draw();
            VerticalLine right = new VerticalLine(0, 25, 80, '$');
            right.Draw();

            Point snakeTail = new Point(15, 15, 's');
            Snake snake = new Snake(snakeTail,5, Direction.UP);
            snake.Draw();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKeys(key.Key);
                }
                Thread.Sleep(300);
                snake.Move();
            }
            Console.ReadLine();
        }
        
    }
}