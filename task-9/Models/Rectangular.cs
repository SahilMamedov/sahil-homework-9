using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9.Models
{
    class Rectangular:Figure
    {
        private int _width;
        private int _length;

        public int Width 
        {
            get
            {
                return _width;
            }
            set
            {
                if(value > 0)
                {
                    _width = value;
                }
                else
                {
                    Console.WriteLine("the Width cannot be negative");
                }
            }
        
        }
        public int Length 
        {
            get
            {
                return _length;
            }
                set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    Console.WriteLine("the Length cannot be negative");
                }
            }
        }
        public Rectangular(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public override int CalcArea()
        {
           
           return  Width * Length;
           
        }
    }
}
