using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace day2_3_
{


    class Monster
    {

        

    }
    class Boss:Monster
    {

        public void skill()
        {


            Console.WriteLine("释放技能");
        }


    }
    class Goblin:Monster
    {
        public void ack()
        {

            Console.WriteLine("攻击");


        }


    }
    
    class project 
   {
      static void Main(string[] args)
      {
        //里氏替换原则
        //用一个父类容器装子类对象
        //子类能够包含父类
        //is是用于判断该对象是否为指定类对象，是则返回true，不是则false
        //as是类型转换，把对象转换为指定类对象，转换成功则返回该对象，否则返回null
        Random rand = new Random();

        
        
        
            Monster[] mon = new Monster[10]; 
            for (int i = 0; i < mon.Length; i++)
            {
                int r;
                r = rand.Next(1, 101);
                if (r > 50)
                {

                    mon[i] = new Boss();

                }
                else
                {

                    mon[i] = new Goblin();
                }
            }
            for (int i = 0;i < mon.Length; i++)
            {

                if (mon[i] is Boss)
                {
                    
                     (mon[i] as Boss).skill();
                    
                }
                if (mon[i] is Goblin)
                {
                    
                    (mon[i] as Goblin).ack();
                    


                }


            }

           

      }




   }

}