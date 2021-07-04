using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class HelpMoney: Entity
    {
        private DateTime Time;
        private string Available;
        private string frozen;
        private string Chage;
        private string Remarks;
        private int HelpMoneyNumber;
        public DateTime Time1 { get => Time; set => Time = value; }
        public string Available1 { get => Available; set => Available = value; }
        public string Frozen { get => frozen; set => frozen = value; }
        public string Chage1 { get => Chage; set => Chage = value; }
        public string Remarks1 { get => Remarks; set => Remarks = value; }
        public int HelpMoneyNumber1 { get => HelpMoneyNumber; set => HelpMoneyNumber = value; }

        public void Type()
        {
            Console.WriteLine("种类很多");
        }
    }
}
