using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Repoistory:Entity
    {
        private int version;
        static readonly string connection;
        public int Info;
        public  int Version { get => version; set => version = value; }
       
        public void Save(User user)
        {
            Console.WriteLine("存入数据库");
        }
        public Entity Get(int id)
        {
            if(id == Info)
            {
                Console.WriteLine("从数据库取出数据");
            }
            return new Entity();
        }
    }
}
