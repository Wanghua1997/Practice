using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Problem : Content
    {
        private string Title;
        private string Body;
        private int Reward;
        private DateTime PublishDate_Time;
        private User Author;

        public string Title1 { get => Title; set => Title = value; }
        public string Body1 { get => Body; set => Body = value; }
        public int Reward1
        {
            get => Reward;
            set
            {
                if (value > 0)
                    Reward = value;
            }
        }
        public DateTime PublishDate_Time1 { get => PublishDate_Time; set => PublishDate_Time = value; }
        public User Author1 { get => Author; set => Author = value; }

        public Problem(string boby):base("king")
        {
            Body = boby;
        }
        public void PrintfBoby()
        {
            Console.WriteLine(Body);
        }
        public void Publish()
        {
            Console.WriteLine("发布成功");
        }
        //public Problem Load(int id)
        //{
        //    Repoistory repoistory = new Repoistory();
           
        //}
    
        public void Delete(int id)
        {

        }

    }
}
