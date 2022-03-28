using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9.Models
{
    class Square:Figure
    {
        private int _side;

        public Square(int side)
        {
            Side = side;
        }

        public int Side
        {
            get
            {
                return _side;
            }
                set
            {
                if(value > 0 )
                {
                    
                    _side = value;
                }
                else
                {
                    Console.WriteLine("the side cannot be negative");
                }
            }
        }
      

        public override int CalcArea()
        {

           
            return Side * Side;
           

        }
    }
}
