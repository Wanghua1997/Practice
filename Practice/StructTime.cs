using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
 
    public struct StructTime
    {
        public string GetDate(int Year, int month, int day)
        {
            //获取当前时间
            DateTime now = DateTime.Now;
            now = now.AddYears(Year);
            now = now.AddMonths(month);
            now = now.AddDays(day);

            return now.ToString();
           
        }

        //输入一个年份得到每一周
        public static void GetWeek(int year)
        {
            int i =1;//表示第几周
            DateTime NowDataTime = new DateTime(year, 1, 1);
            while(NowDataTime.DayOfWeek != DayOfWeek.Monday)
            {
                NowDataTime = NowDataTime.AddDays(1);
            }
            int NextYear = NowDataTime.Year + 1; //得到下一年
            while(NowDataTime.Year < NextYear)
            {
               
                if(NowDataTime.AddDays(6).Year< NextYear)
                {
                    Console.WriteLine($"第{i}周：{NowDataTime.ToLongDateString()}-{NowDataTime.AddDays(6).ToLongDateString()}");
                }
                else
                {
                    Console.WriteLine($"第{i}周：{NowDataTime.ToLongDateString()}-{year}年12月31日");
                }
                NowDataTime = NowDataTime.AddDays(7);
                i++;
            }

        }
    }
}
