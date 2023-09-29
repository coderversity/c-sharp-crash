using System;
using System.Xml.Linq;

namespace c_sharp_crash
{
	public class Person
	{
		public string? Name { get; set; }
		public int? Age { get; set;  }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }

        private void SayAge()
        {
            Console.WriteLine($"I am {Age} years old.");
        }
    }
}

