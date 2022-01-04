using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class FoodGenerator
    {
        int mapWidth;
        int mapHeight;
        char symb;
        Random rnd = new Random();
        public FoodGenerator(int _mapWidth, int _mapHeight, char _symb)
        {
            mapWidth = _mapWidth;
            mapHeight = _mapHeight;
            symb = _symb;
        }
    }
}
