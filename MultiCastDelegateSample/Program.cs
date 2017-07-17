using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegateSample
{

    internal class TestDeleGate
    {
        public delegate void ShowMessage(string s);
        public static void message1(string msg)
        {
            Console.WriteLine("1st Message is : {0}", msg);
        }
        public static void message2(string msg)
        {
            Console.WriteLine("2nd Message is : {0}", msg);
        }
        public static void message3(string msg)
        {
            Console.WriteLine("3rd Message is : {0}", msg);
        }
    }

    class Program
    {
        static void Main()
        {
            var td = new TestDeleGate();
            TestDeleGate.ShowMessage message = null;
            message += new TestDeleGate.ShowMessage(TestDeleGate.message1);
            message += new TestDeleGate.ShowMessage(TestDeleGate.message2);
            message += new TestDeleGate.ShowMessage(TestDeleGate.message3);
            message("Hello Multicast Delegates");
            message -= new TestDeleGate.ShowMessage(TestDeleGate.message2);
            Console.WriteLine("----------------------");
            message("Message 2 Removed");
            Console.ReadKey();

        }
    }
}
