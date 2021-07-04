using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    sealed class User :Entity
    {
        private string Name;       //用户名字
        private string PassWord;    //用户密码
        private string InvitedBy;   //邀请人
        private string Invited_Code;//邀请码
        private string Verify_password; //验证密码
        private string Verify;//验证码
        private int helpmoneynum; //帮帮币个数
        public TokenManager Tokens { get; set; }
        public string Name1
        {
            get => Name;
            set
            {
                if (Name =="admin")
                {
                    Name = "系统管理员";
                }
                else
                {
                    Name = value;
                }
                   
            }
        }
        public string PassWord1 { set => PassWord = value; }
        public string InvitedBy1 { get => InvitedBy; set => InvitedBy = value; }
        public string Invited_Code1 { get => Invited_Code; set => Invited_Code = value; }
        public string Verify_password1 { get => Verify_password; set => Verify_password = value; }
        public string Verify1 { get => Verify; set => Verify = value; }
        public int Helpmoneynum { get => helpmoneynum; set => helpmoneynum = value; }

        public User(string name ,string password)
        {
            this.Name = name;
            this.PassWord = password;           
        }
        public void PrintfName()
        {
            Console.WriteLine("用户名字：" + Name);
            Console.WriteLine("用户密码：" + PassWord);
        }
        public void Register() //注册方法
        {
            Console.WriteLine("注册成功");
        }
        public void Login() //登录方法
        {
            Console.WriteLine("登录成功");
        }

    }
}
