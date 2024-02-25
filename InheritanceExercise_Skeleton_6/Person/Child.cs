using System;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {//agr!=>15


        }
        public override int Age { get => base.Age;
            set
            {
                if (value>15)
                {
                    throw new Exception();
                }
                base.Age = value;
            } }

    }
}