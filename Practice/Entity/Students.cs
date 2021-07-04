using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class OneAttribute : Attribute
    {
        public int version { get; set; }
    }
    [OneAttribute(version = 3)]
    class Students:Entity
    {
        private double[] scores;
        private int age =10;
    
        public User user;
        public Students()
        {

        }
        public Students(int length)
        {
            scores = new double[length];
        }
        public double this[int index]
        {
            get { return scores[index - 1]; }
            set { scores[index - 1] = value; }

        }

        public int Age { get => age; set => age = value; }

        public void Geet(string name)
        {
            Console.WriteLine($"hello{name}");
        }
    }
}
