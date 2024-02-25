using System;
using System.Text;

namespace Person
{
	public class Person
	{
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        private string name;
        private int age;

        public string Name { get; set; }
		public virtual int  Age
        {
            get { return age; }
            set
            {
                if (value<0)
                {
                    throw new Exception();
                }
                age = value;
            }
        }


        public override string ToString()
        {

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(String.Format($"Name: {this.Name}, Age: {this.Age}"));

            return stringBuilder.ToString();

        }
    }
}

