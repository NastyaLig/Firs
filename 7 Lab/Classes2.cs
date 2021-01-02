using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab_6
{

    struct FL
    {
        public string color;

        public FL(string Color)
        {
            color = Color;
        }
    }

    partial class Flower
    {
        private FL objFl;
        private FL xFl = new FL("Red");
        private FL xLFl = new FL("Green");
        private FL xLLFl = new FL("Blue");

        public enum enumFL
        {
            x = 1, xL, xLL
        }

        public void ChooseFL(enumFL num)
        {
            switch (num)
            {
                case enumFL.x:                  ///1
                    objFl = xFl;
                    Console.WriteLine("Вы выбрали Красный цветок");
                    break;
                case enumFL.xL:                 ///2
                    objFl = xLFl;
                    Console.WriteLine("Вы выбрали Зеленый");
                    break;
                case enumFL.xLL:                ///3
                    objFl = xLLFl;
                    Console.WriteLine("Вы выбрали Синий");
                    break;
                default:
                    Console.WriteLine("Такого цветка нет, пусть будет xFl");
                    objFl = xFl;
                    break;
            }
        }
    }
}