using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal class ContentService:Entity
    {

        public void Release()
        {
            
        }
        public void Publish(Content content ,HelpMoney helpMoney)
        {
            if(content is Article)
            {
                Console.WriteLine("消耗一个帮帮币");
                helpMoney.HelpMoneyNumber1--; 
            }
            else
            {

            }
            if(content is Problem)
            {
                Console.WriteLine("需要消耗其设置悬赏数量的帮帮币");
            }
            else
            {

            }
            if (content is Suggest)
            {
                Console.WriteLine("不需要消耗帮帮币");
            }
            else
            {

            }
        }
    }
}
