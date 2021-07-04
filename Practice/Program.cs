using System;
using System.Collections.Generic;
using System.Reflection;

namespace Practice
{
    class Program
    {
        //C#作业
        static void Main(string[] args)
        {

            //ContentService j = new ContentService();
            //二维数组存储数据并输出出来
            //void Two_dimensional_array()
            //{
            //    string[,] arr = new string[4, 3] { { "小周", "5月12日", "座位1" }, { "小张", "5月13日", "座位2" }, { "小平", "5月14日", "座位3" }, { "小韩", "5月15日", "座位4" } }; //定义一个二维数组
            //    Console.WriteLine(arr.GetLongLength(0));
            //    for (int i = 0; i < arr.GetLongLength(0); i++) //arr.GetLongLength(0)返回数组中一维数组的个数
            //    {
            //        Console.WriteLine("姓名:{0},入栈时间:{1},座位：{2}", arr[i, 0], arr[i, 1], arr[i, 2]);
            //    }
            //    Console.ReadLine();
            //}
            //Two_dimensional_array();

            // 计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
            //float[] score = new float[6] { 99.5f, 98, 98.6f, 88, 97, 95 };
            //void GetAverage(float[] Score)
            //{
            //    float sum = 0;
            //    float average = 0;
            //    for (int i = 0; i < Score.Length; i++)
            //    {
            //        sum += Score[i];
            //    }
            //    average = sum / Score.Length;
            //    Console.WriteLine("总分为：{0},平均值为：{1}", sum, average);
            //    Console.ReadLine();
            //}
            //GetAverage(score);


            //找到数组中的最大值和最小值
            //double[] score = new double[6] {99.5,98,98.6,88,97,95};
            //double max = score[0];
            //double min = score[0];
            //int Index0 = 0;
            //int Index1 = 0;
            //for (int i=0;i<score.Length;i++)
            //{
            //    if(score[i] > max)
            //    {
            //        max = score[i];
            //        Index0 = i;
            //    }
            //    if(score[i] < min)
            //    {
            //        min = score[i];
            //        Index1 = i;
            //    }
            //}
            //Console.WriteLine("第{0}个元素是最大值：{1}，第{2}个元素是最小值：{3}", Index0,max,Index1,min);
            //Console.ReadLine();


            //随机生成一个数组并按从小到大排序
            //void Romarray()
            //{
            //int temp;
            //int[] a = new int[5];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = new Random().Next(1, 100);
            //    Console.WriteLine(a[i]);
            //}
            //for (int i = 0; i < a.Length - 1; i++)
            //{
            //    for (int j = 0; j < a.Length - 1 - i; j++)
            //    {
            //        if (a[j] > a[j + 1])
            //        {
            //            temp = a[j];
            //            a[j] = a[j + 1];
            //            a[j + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            //}
            // Romarray();


            //完成“猜数字”游戏，方法名GuessMe()：
            //void GuessME()
            //{
            //    var size = new Random().Next(0, 100);
            //    int num = 0;
            //    Console.WriteLine("请输入一个0到100的数字");
            //    for (int i = 0; i < 10; i++)
            //    {

            //        int size_num = Convert.ToInt16(Console.ReadLine());
            //        num++;
            //        if (size_num != size && size_num < size)
            //        {
            //            Console.WriteLine("对不起，你猜的有点小了，再试一次吧！");
            //        }

            //        else if (size_num != size && size_num > size)
            //        {
            //            Console.WriteLine("对不起，你猜的有大了，再试一次吧！");
            //        }
            //        else if (size_num == size && num < 5)
            //        {
            //            Console.WriteLine("恭喜你猜对了，真是天才！");
            //        }
            //        else if (size_num == size && num > 5 && num < 10)
            //        {
            //            Console.WriteLine("恭喜你猜对了，真聪明！");
            //        }

            //    }
            //    Console.WriteLine("对不起，十次机会已用完！");

            //}
            //GuessME();


            //利用ref调用Swap()方法交换两个同学的床位号
            //void Swap(ref int BedNum1,ref int BedNum2)
            //{
            //    int temp = 0;
            //    temp = BedNum1;
            //    BedNum1 = BedNum2;
            //    BedNum2 = temp;
            //    Console.WriteLine("床位{0}，床位{1}",BedNum1, BedNum2);
            //}
            //int a = 5;
            //int b = 9;
            //Swap(ref a,ref b);
            //Console.WriteLine("床位{0}，床位{1}", a, b);
            //Console.ReadLine();


            //值类型的参数的值传递
            //void swap( int bednum1,  int bednum2)
            //{
            //    int temp = 0;
            //    temp = bednum1;
            //    bednum1 = bednum2;
            //    bednum2 = temp;
            //    Console.WriteLine("床位{0}，床位{1}", bednum1, bednum2);
            //}
            //int a = 5;
            //int b = 9;
            //swap(a,  b);
            //Console.WriteLine("床位{0}，床位{1}", a, b);
            //Console.ReadLine();


            //引用类型参数的值传递
            //string[] arr = new string[2] {"6月","7月"};
            //void swap(string[] Array)
            //{
            //    string temp;
            //    temp = Array[0];
            //    Array[0] = Array[1];
            //    Array[1] = temp;

            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("调用前：{0}",arr[i]);
            //}
            //swap(arr);
            //for(int i =0;i<arr.Length;i++)
            //{
            //    Console.WriteLine("调用后：{0}", arr[i]);
            //}
            //Console.ReadLine();


            //值类型的引用传递
            //void swap(ref int bednum1, ref int bednum2)
            //{
            //    int temp = 0;
            //    temp = bednum1;
            //    bednum1 = bednum2;
            //    bednum2 = temp;
            //    Console.WriteLine("床位{0}，床位{1}", bednum1, bednum2);
            //}
            //int a = 5;
            //int b = 9;
            //swap(ref a, ref b);
            //Console.WriteLine("床位{0}，床位{1}", a, b);
            //Console.ReadLine();


            //调用User类
            //User user = new User("Jack","123454");
            //user.Login();
            //user.Register();
            //user.PrintfName();
            //Proplem proplem = new Proplem("Hello world");
            //proplem.PrintfBoby();
            //proplem.Title1 = "文章";
            //Console.WriteLine(proplem.Title1);
            //Console.ReadLine();

            //调用 索引器
            Seek_Help Key = new Seek_Help(10);
            Key[1] = "JACK";
            Key[2] = "ROSE";
            Console.WriteLine(Key[1]);
            //string now = "2010/2/12";
            //if(DateTime.TryParse(now ,out DateTime result))
            //{
            //    result = result.AddYears(10);
            //    Console.WriteLine(result.Year);
            //}

            //stduents a = new stduents();

            //if(a is System.ValueType)
            //{
            //    Console.WriteLine("结构体是值类型");
            //}
            //else
            //{
            //    Console.WriteLine("结构体是引用类型");
            //}

            //DateTime now = new DateTime();
            //now = DateTime.Now;
            //Console.WriteLine(new DateTime().Hour);

            //StructTime Time = new StructTime();
            //Console.WriteLine(Time.GetDate(1,2,3));
            //StructTime.GetWeek(2021);
            //Token gread = Token.Admin;

            //switch(gread)
            //{
            //    default:
            //}

            //Object[] Arr= {134} ;

            Students Jack = new Students();
            int a = (int)Jack.GetType()
                .GetField("age", BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(Jack);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Attribute attribute = Attribute.GetCustomAttribute(
            //       typeof(Students),
            //       typeof(OneAttribute)
            //       );
            //Console.WriteLine(((OneAttribute)attribute).version);


            //获取特性值
            Attribute attribute1 = Attribute.GetCustomAttribute(
                typeof(Students),
                typeof(OneAttribute)
                );
            Console.WriteLine(((OneAttribute)attribute1).version);

            //int a = (int)Jack.GetType()
            //    .GetField("age", BindingFlags.NonPublic | BindingFlags.Instance)
            //    .GetValue(Jack);


            DateTime now = new DateTime();
            now = DateTime.Now;
            Content content = new Content();
            Type type = content.GetType(); //获取类型
            PropertyInfo propertyInfo = type.GetProperty("CreateTime"); //获取指定名称的属性
            propertyInfo.SetValue(content, now); //给对应属性赋值
            DateTime value_New = (DateTime)propertyInfo.GetValue(content);
            Console.WriteLine(value_New);
        }






    }
    
}
