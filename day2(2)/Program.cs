using System;
using System.Security.Cryptography.X509Certificates;

namespace Project
{

    //继承
    //1.子类可以使用父类的成员，方法,属性等
    //2.传递性：子类也可以聚成父类的父类的。。。但只能有一个父亲
    //3.可以通过访问修饰符规定子类能否访问继承父类的成员，方法属性等。
    //4.private只是使得子类不能直接使用，但仍然可以间接使用，如通过调用public的方法使用private的成员变量。
    class Person
    {

        public string name;
        public int age;
        public void Speak()
        {

            Console.WriteLine("我是{0}", name);



        } 


    }

    class Atkperson : Person
    {


        public void Atk()
        {


            Console.WriteLine("攻击你");

        }


    }

    class Project
    {




        static void Main(string[] args)
        {


            Atkperson p = new Atkperson();
            p.name = "Bob";
            p.age = 100;
            p.Speak();
            p.Atk();

        }
    }



}
