using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    [AttributeUsage(AttributeTargets.Enum, Inherited = false)]
    public class MyAttribute : Attribute
    {

    }
    [My]
    enum Token
    {
        SuperAdmin=2,
        Admin = 4,
        Blogger = 8,
        Newbie = 16,
        Registered =32
    }
}
