using System;
using System.Collections.Generic;

namespace Brigade
{
    class Brigade
    {
        string name;
        int number;
        string bossname;
        public Brigade(String name, int number, String bossname)
        {
            this.bossname = bossname;
            this.name = name;
            this.number = number;
        }
        
            void setinfo()
        {
            Console.WriteLine("Name: ");
            name=Console.ReadLine();

            Console.WriteLine("workers: ");
            string strnum = Console.ReadLine();
            Int32.TryParse(strnum,out number);

            Console.WriteLine("Boss: ");
            bossname = Console.ReadLine();
        }
        
        void Printinfo()
        {
            Console.WriteLine("Name: "+name + ", workers: " + number + ", boss: " + bossname);
        }


        static void Main(string[] args)
        {
            int number=0;
            Console.WriteLine("How many brigades: ");
            string input = Console.ReadLine();            
            Int32.TryParse(input, out number);

            List<Brigade> arr = new List<Brigade>();
            for(int i = 0; i < number; i++)
            {
                arr.Add(new Brigade("",0,""));
                arr[i].setinfo();
            }
            for(int i = 0; i < number; i++)
            {
                arr[i].Printinfo();
            }
            Console.ReadLine();
        }
    }
}




//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectingTriangles
{
    class Program
    {
        public bool LineIntersect(double x1,double x2,double y1,double y2,double x3,double x4, double y3,double y4,double a, double b)
        {
            if (x1 == x2&&x3==x4)   //If both are vertical
            {
                if (x1 != x3)   //And if they aren't on the same line
                {
                    return false;
                }
                else    //if they are on the same line
                {
                    if (y3 < y4)    
                    {
                         if(( y1 >= y3 && y1 <= y4) || (y2 >= y3 && y2 <= y4))
                        {
                            return true;
                        }
                    }
                    else if (y3>y4)     //now backwards
                    {
                        if((y1 >= y4 && y1 <= y3) ||(y2 >= y4 && y2 <= y3))
                        {
                            return true;
                        }
                    }                
                }
            }
           
            else if(x1 == x2)   //If the first is vertical only
            {

            }
            else if(x3 == x4)   //If the second is vertical only
            {

            }

            else    //If none are vertical!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            {

            }
            

        }
        public bool TriangleIntersect ( Triangle t1, Triangle t2)
        {
            
            LineIntersect(t1.x1,t1.x2,t1.y1,t1.y2, t2.x1,t2.x2,t2.y1,t2.y2, t1.Line1a1(), t1.Line1b1());
        }
            
        static void Main(string[] args)
        {
            int numberOfTriangles;
            Console.WriteLine("How many triangles?");
            try     //Try catch in case user types a non-integer.
            {
                numberOfTriangles = int.Parse(Console.ReadLine());
                if (numberOfTriangles == 0)     //In case user types in 0
                {
                    Console.WriteLine("A valid integer must be set. \nExiting...");
                    Console.ReadKey();
                    return;
                }
            }catch
            {
                Console.WriteLine("A valid integer must be set. \nExiting...");
                Console.ReadKey();
                return;
            }
            
            List<string> triangleData = new List<string>();

            for (int i = 0; i < numberOfTriangles; i++)     //Explaining how to insert coordinates
            {
                Console.WriteLine("Type in integer coordinates for x1,y1,x2,y2,x3,y3,x4,y4 with a space separating each coordinate, all in one line:");
                Console.WriteLine("Alternatively you can input a Double with a comma separator instead of an integer.");
                triangleData.Add(Console.ReadLine());
                Console.WriteLine("\nAdded.\n");
            }
            List<int> pointData = new List<int>();
            List<Triangle> triangles = new List<Triangle>();        //List to store the triangles
            List<string[]> coordinateList = new List<string[]>();
            List<string> xCoordinates = new List<string>();
            List<string> yCoordinates = new List<string>();
            string[] coordinates = new string[5];       //array to store coordinates
            int counter = 1;        //for triangle naming purposes

            foreach (var triangle in triangleData)
            {               
                coordinates = triangle.Split(' ');      //Split coordinates to be used separately

                Triangle t = new Triangle();
                t.name = "t" + (counter);    //name triangle
                try         //In case user does't type 6 coordinates or doesn't put all integers/doubles
                {
                    t.x1 = Double.Parse(coordinates[0]);
                    t.x2 = Double.Parse(coordinates[2]);
                    t.x3 = Double.Parse(coordinates[4]);
                    t.y1 = Double.Parse(coordinates[1]);
                    t.y2 = Double.Parse(coordinates[3]);
                    t.y3 = Double.Parse(coordinates[5]);
                    triangles.Add(t);       //add triangle to list
                }
                catch
                {
                    Console.WriteLine("You goofed somewhere! \nExiting...");
                    Console.ReadKey();
                    return;
                }
                counter++;      //Increasing the counter for naming
            }
        
            //Console.WriteLine(triangle);


            foreach (var t in triangles)
            {
                Console.WriteLine(t.name+": x1: "+ t.x1 + ", x2: " + t.x2 + ", x3:" + t.x3 + ", y1: " + t.y1 + ", y2: " + t.y2 + ", y3: " + t.y3);
                t.Line1a1();
                Console.WriteLine("a1: "+t.a1);
                t.Line2a1();               
                Console.WriteLine("a1 in line 2:  " + t.a1);
            }
            Console.WriteLine("how many: " + triangles.Count());

            for (int i = 0; i < triangles.Count - 1; i++)
                {
                    for (int j = i + 1; j < triangles.Count; j++)
                    {
                        triangles[i].
                    }

                }

            // coordinateList.Add(coordinates);

            /*  foreach(var triangle in triangles)
              {
                  triangle.x1=
              }*/
            /*  foreach(var c in coordinates)
              {for(int i=0;i<6;i++)
                  {

                  }
                  Console.WriteLine(c);
              }
              */


            // Your output goes here.






            Console.ReadKey();
            }
        }
    }


