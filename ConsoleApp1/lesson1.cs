using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{




    public class Student
    {

        public string name;
        public string sex;
        public int age;
        public Student[] friends;
        public Student[] newfriends;
        public Student[] deletefriends = new Student[10] ;
        //赋值
        public Student(string name)
        {

            this.name = name;

        }
        public Student(string name, string sex, int age) : this(name)
        {
            
            this.sex = sex; 
            this.age = age;

        }
        //属性
        public string Sex
        {

            set 
            {
                if (value == "男" || value == "女")
                {
                    this.sex = value;
                }
                else
                {
                    this.sex = "不男不女";
                }
            
            
            
            
            }



        }

        public int Age
        {

            set
            {

                if (value < 0)
                {
                    this.age = 0;
                }
                else if (value > 100)
                {
                    this.age = 100;
                }
                else
                {
                    this.age = value;


                }
            }



        }


        //增加朋友的索引器
        public void Friend()
        {

            for (int i = 0; i < friends.Length; i++)
            {
                
                
                Console.WriteLine("我有{0}个朋友，我的第{1}个朋友名字是{2}", friends.Length,i+1, friends[i].name);
            }
        }
        
        public Student this[int index]
        {
            
            set
            {
                if (friends == null)
                {
                    friends = new Student[] { value };

                }
                else
                {
                    newfriends = new Student[friends.Length + 1];
                    for (int i = 0; i < friends.Length ; i++)
                    {

                        newfriends[i] = friends[i];
                        newfriends[index] = value;
                        friends = newfriends;


                    }



                }



            }


        }
        public void Deletefriends(int dex)
        {

            deletefriends[dex]=friends[dex];
            for(;dex < friends.Length;dex++) 
            {

                friends[dex] = friends[dex+1];



            }
            for(int i = 0; i < friends.Length; i++)
            {

                newfriends[i] = friends[i];

            }
            friends = newfriends;


        }

    }

    

   class Program
    {
        
        static void Main(string[] args)
        {
            Student p1 = new Student("Bob","男",17);
            Student p2 = new Student("Ari", "女", 18);
            Student p3 = new Student("jane", "男", 19);
            
            p1[0] = p2;
            
            p1[1] = p3;
            
            p1.Deletefriends(1);
            p1.Friend();
        }



    }
}
