using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal abstract class Car
    {
        public delegate bool Damaged(int value);
        public event Damaged? hit_from_pit;
        public int Life {  get; set; }
        public int Y {  get; set; }
        public int Speed { get; set; }
        public string Name { get; set; }

        public Car(string _name, int _y) :this(_name, 30, 1, _y) { }
        public Car(string _name, int _life, int _speed, int Y) 
        {
            Life = _life;
            Name = _name;
            Speed = _speed;
        }
    }
}
