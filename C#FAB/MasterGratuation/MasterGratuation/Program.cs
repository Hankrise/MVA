using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace MasterGratuationNamespace
{
    class Phone
    {
        public string Region;
        public long Number;
    }

    partial class MasterGraduation
    {
        public static void PhoneChange()
        {
            Phone Nokia6 = new Phone()
            {
                Region = "杭州",
                Number = 15558191023
            };
            Console.WriteLine("即将前往{0},新号码为{1},望惠存", 
                Nokia6.Region, 
                Nokia6.Number);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MasterGraduation.PhoneChange();
            Console.ReadLine();
        }
    }
}


//不能在静态类中声明实例成员                         Line16 去掉 static
//不可访问 因为它具有一定的保护级别                  Line12 13 加 public
//对象引用对于非静态的字段 方法或属性是必需的        Line18 加 static