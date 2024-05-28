using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    internal class Car
    {
        public delegate bool Damaged(int value);
        public event Damaged? hit_from_pit;
        public int Life {  get; set; }
        public int Speed { get; set; }
        public string Name { get; set; }
        public Car(string _name) : this(_name, 30, 10) { }
        public Car(string _name, int _life, int _speed)
        {
            Name = _name;
            Life = _life;
            Speed = _speed;
        }
    }

}
