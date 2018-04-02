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
