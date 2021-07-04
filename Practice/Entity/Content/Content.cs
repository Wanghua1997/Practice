using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Content:Entity
    {
        protected string king;
        public DateTime CreateTime { get; private set; }
        public DateTime PublishTime { get; }
        public Content()
        {

        }
        public Content(string king)
        {
            this.king = king;     
        }
        public Content(string king,DateTime CreateTime,DateTime PublishTime)
        {
            this.king = king;
            this.CreateTime = CreateTime;
            this.PublishTime = PublishTime;
        }

       
    }
}
