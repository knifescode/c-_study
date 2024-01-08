using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //单例化
    //外部无法实例化，a静态实例化一个空间存储了QW类，属性A返回对象a，因此可以通过QW.A.t访问变量；
    public class QW
    {


        static private QW a = new QW();
        public int t = 10;
        
        static public QW A
        {
            get
            {

                return a; 
            }

        }
        private QW() 
        {
        
        }

    }


    public class Lesson2
    {
        //const和static的区别
        //不同处
        //1.const只能用于变量，而static可以用于变量，方法，属性。
        //2.const不能改变该值，而static可以改变该值
        //3.const必须初始化，而static可以不初始化
        //4.const要写在访问修饰符前边，而static随意
        //相同处
        //1,const和static都可以直接使用类名点出来
        static void Main(string[] args)
        {
            
            
            Console.WriteLine(QW.A.t);


        }




    }
}
