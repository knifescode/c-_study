using System;
namespace Project
{
    class Point
    {


        public int x;
        public int y;
        public int z;
        public static bool operator ==(Point p1, Point p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
            {
                return true;
            }
            return false;

        }
        public static bool operator !=(Point p1, Point p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
            {
                return false;
            }


            return true;

        }
        public static Point operator +(Point p1, Point p2)
        {
            Point p = new Point();
            p.x=p1.x += p2.x;
            p.y=p1.y += p2.y;
            p.z=p1.z += p2.z;
            return p;

        }
        public static Point operator -(Point p1, Point p2)
        {
            Point p = new Point();
            p.x=p1.x - p2.x;
            p.y=p1.y - p2.y;
            p.z=p1.z - p2.z;

            return p;

        }
        public static Point operator *(Point p1, int num)
        {
            Point p = new Point();
            p.x = p1.x * num;
            p.y = p1.y * num;
            p.z = p1.z * num;
            return p;

        }
    }
        class project
        {

            static void Main(string[] args)
            {

                Point P1 = new Point();
                P1.x = 1;
                P1.y = 2;

                Point P2 = new Point();
                P2.x = 1;
                P2.y = 2;
                if (P1 == P2)
                {
                    Console.WriteLine("相等");

                }
                else
                {

                    Console.WriteLine("不等");

                }
            Point P3 = new Point();
            Point P4 = new Point();
            P3.x = 1;
            P3.y = 2;
            P3.z = 3;
            P4.x = 1;
            P4.y = 2;
            P4.z = 3;
            Point P5 = new Point();
            P5 = P3 + P4 * 2;

            Console.WriteLine("{0} {1} {2}",P5.x,P5.y,P5.z);
            
            }





        }




    
}