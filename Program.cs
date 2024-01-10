namespace C_studying
{


    //继承中的构造函数
    //要特别注意父类中的无参构造函数
    //使用base进行指定父类中的有参构造函数
    //实例化子类对象会自动调用父类的无参构造函数

    class Work
    {

        public string part;


        public Work(string part)
        {
            if (part == "美术")
            {
                Console.WriteLine("1");


            }
            else if(part == "程序")
            {


                Console.WriteLine("2"); 

            }
            else if(part == "策划")
            {



                Console.WriteLine("3");
            }

        }



    }
    class Projecter : Work
    {

        public Projecter():base("程序")
        {



        }



    }
    class Arter : Work
    {
        public Arter() : base("美术")
        {



        }



    }
    class planer : Work
    {

        public planer() : base("策划")
        {



        }



    }
    class Program
    {

        static void Main(string[] args)
        {
            Projecter p1 = new Projecter();
        }
    }
}