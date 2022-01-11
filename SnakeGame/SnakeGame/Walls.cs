using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontallLine top = new HorizontallLine(0, 80, 0, '#');
            VerticalLine left = new VerticalLine(0, 25, 0, '#');
            HorizontallLine bottom = new HorizontallLine(0, 80, 25, '$');
            VerticalLine right = new VerticalLine(0, 25, 80, '$');


            VerticalLine obstacle = new VerticalLine(10, 13, 50, '%');
            VerticalLine obstacle2 = new VerticalLine(5, 5, 30, '%');
            VerticalLine obstacle3 = new VerticalLine(15, 25, 34, '%');
            VerticalLine obstacle4 = new VerticalLine(6, 16, 45, '%');
            VerticalLine obstacle5 = new VerticalLine(28, 3, 40, '%');
            VerticalLine obstacle6 = new VerticalLine(9, 1, 32, '%');

            wallList.Add(top);
            wallList.Add(left);
            wallList.Add(bottom);
            wallList.Add(right);
            wallList.Add(obstacle);
            wallList.Add(obstacle2);
            wallList.Add(obstacle3);
            wallList.Add(obstacle4);
            wallList.Add(obstacle5);
            wallList.Add(obstacle6);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;


        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();

            }
        }
        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}