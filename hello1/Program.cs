using System;


namespace hello1
{
    [DeBugInfo(45, "Zara Ali", "12/8/2012",
      Message = "Return type mismatch")]
    [DeBugInfo(49, "Nuha Ali", "10/10/2012",
      Message = "Unused variable")]
    class Program
    {
        static void Main(string[] args)
        {



            // var str = "hello";

            // Console.WriteLine(str);



            People p = new People(1, "小明");


            People p2 = new People();


            System.Reflection.MemberInfo info = typeof(Program);


            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
                DeBugInfo dbi = (DeBugInfo)attributes[i];

                Console.WriteLine("Bug no: {0}", dbi.BugNo);
                Console.WriteLine("Developer: {0}", dbi.Developer);
                Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                Console.WriteLine("Remarks: {0}", dbi.Message);


            }



            // Console.WriteLine(p.hello());



            int[] intArr = { 1, 3, 4 };


            Array.Sort(intArr);



            // Console.WriteLine(intArr[0]);
            // Console.WriteLine(intArr[1]);
            // Console.WriteLine(intArr[2]);




            // Console.WriteLine("Hello World!");
            /*
            是针对 VS.NET 用户的。这使得程序会等待一个按键的动作，防止程序从 Visual Studio .NET 启动时屏幕会快速运行并关闭。
            */
            // Console.ReadKey();
        }
    }

    // 一个自定义特性 BugFix 被赋给类及其成员
    [AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true)]

    public class DeBugInfo : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        public DeBugInfo(int bg, string dev, string d)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = d;
        }

        public int BugNo
        {
            get
            {
                return bugNo;
            }
        }
        public string Developer
        {
            get
            {
                return developer;
            }
        }
        public string LastReview
        {
            get
            {
                return lastReview;
            }
        }
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }
}
