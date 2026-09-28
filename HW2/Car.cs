using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        private int _year;

        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    _year = value;
                }
            }


        }
    
     private int _speed;

        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    _speed = value;
                }
            }


        }
    
    public string color { get; set; }
        public void getCarInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Speed: {Speed}, Color: {color}");
        }
    }
}
