using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Seek_Help:Entity
    {
        //索引器
        private string[] _courses;
        public Seek_Help(int length)
        {
            _courses = new string[length];
        }
        public string this[int index]
        {
            get { return _courses[index - 1]; }
            set { _courses[index - 1] = value; }
        }

    }
}
