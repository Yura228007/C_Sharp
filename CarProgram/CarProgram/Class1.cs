using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog
{
    internal class Car
    {
        public delegate void aHandler(Car c);
        public event aHandler? collision;

        string Name { set; get; }

        int Life { set; get; }
        public Car(int life, string n)
        {
            Life = life;
            Name = n;
        }

        public void update(int a)
        {
            if (a == 3) collision(this);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}