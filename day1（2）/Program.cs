using System;
namespace Project
{


    //扩展方法
    //在静态类中，给一个非静态变量类型扩展一个方法

    class Player
    {

        public string name;
        public int hp;
        public int atk;
        public int def;
        


    }
    static class Playerd
    {


        public static void Playerdead(this Player value,int hp)
        {

            hp = 0;
         


        }


    }

static class Int
    {

       public static int IntL(this int value)
        {

            return value * value;


        }




    }
    class Project
    {

        static void Main(string[] args)
        {
            int t = 10;
            int Q = t.IntL();
            Console.WriteLine(Q);


        }
    
    }





}



