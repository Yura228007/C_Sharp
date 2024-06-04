using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Car_Toyota : Car
    {
        public Car_Toyota(string _name, int _y) : base(_name, _y) { }

        public Car_Toyota(string _name, int _life, int _speed, int _y) : base(_name, _life, _speed, _y)
        {

        }

        public bool hit_handler(int value)
        {
            Life -= value;
            return Life > 0 ? true : false;
        }
    }
}
