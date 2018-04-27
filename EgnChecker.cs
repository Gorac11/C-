using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGNchecker1b21
{
    class Program
    {
        public enum Gender{ Male, Female };
        public static Boolean Validate( out string date,out Gender gender)
        {
            Console.WriteLine("Enter EGN to validate: ");
            string egn = "";
            egn = Console.ReadLine();
            string year = "";
            string month = "";
            string day = "";
            gender=0;
            date = "";
            Boolean lengthDet = true;      
            Boolean monthDet = true;
            Boolean dayDet = true;
            Boolean FinalDigitDet = true;

            if (egn.Length < 10 || egn.Length > 10)
            {
                lengthDet = false;      //Checks if EGN is exactly 10 in length!
                Console.WriteLine("The validator returns false.");
                return false;
            }
            
            bool digit = egn.All(char.IsDigit);  //Checks if all characters are digits!                   

            char y1 = egn[0];
            char y2 = egn[1];
            String YearString = y1.ToString() + y2.ToString();  //Final 2 year digits!           
            int yearN = 0;
            Int32.TryParse(YearString, out yearN);

            char m1 = egn[2];       //Month char 1     
            char m2 = egn[3];       //Month char 2
            string MonthString = m1.ToString() +m2.ToString();  //The Month as string!
            int monthN = 0;         //Initialize 
            Int32.TryParse(MonthString, out monthN);    //Converts the string to integer

            if (monthN > 00 && monthN < 13)
            {
                year = "19" + YearString;       //YEAR!
            }
            else if (monthN > 20 && monthN < 33)
            {
                year = "18" + YearString;
            }
            else if (monthN > 40 && monthN < 53)
            {
                year = "20" + YearString;
            }
            else
            {
                monthDet = false;       //Checks if month is valid!
            }

            char d1 = egn[4];
            char d2 = egn[5];
            Boolean leapDay = false;
            int maxD = 0;
            string dayString = d1.ToString() + d2.ToString();   // Days!
            day = dayString;    //Final day count

            int dayN = 0;
            Int32.TryParse(dayString, out dayN);    //Days as an integer
            int leapY = 0;
            Int32.TryParse(year, out leapY);    //The year as an integer
            if ((leapY % 100 != 0 && leapY % 4 == 0) 
                || leapY % 400 == 0)
            {
                leapDay = true;
            }
            
            switch (monthN)
            {
                case int n when (monthN ==01||monthN== 21||monthN==41):
                    month = "January";
                    maxD = 31;
                    break;
                case int n when (monthN == 02 || monthN == 22 || monthN == 42):
                    month = "February";
                    maxD = 29;
                    break;
                case int n when (monthN == 03 || monthN == 23 || monthN == 43):
                    month = "March";
                    maxD = 31;
                    break;
                case int n when (monthN == 04 || monthN == 24 || monthN == 44):
                    month = "April";
                    maxD = 30;
                    break;
                case int n when (monthN == 05 || monthN == 25 || monthN == 45):
                    month = "May";
                    maxD = 31;
                    break;
                case int n when (monthN == 06 || monthN == 26 || monthN == 46):
                    month = "June";
                    maxD = 30;
                    break;
                case int n when (monthN == 07 || monthN == 27 || monthN == 47):
                    month = "July";
                    maxD = 31;
                    break;
                case int n when (monthN == 08 || monthN == 28 || monthN == 48):
                    month = "August";
                    maxD = 31;
                    break;
                case int n when (monthN == 09 || monthN == 29 || monthN == 49):
                    month = "September";
                    maxD = 30;
                    break;
                case int n when (monthN == 10 || monthN == 30 || monthN == 50):
                    month = "October";
                    maxD = 31;
                    break;
                case int n when (monthN == 11 || monthN == 31 || monthN == 51):
                    month = "November";
                    maxD = 30;
                    break;
                case int n when (monthN == 12 || monthN == 32 || monthN == 52):
                    month = "December";
                    maxD = 31;
                    break;
                    
            }
            if (dayN < 1 || dayN > maxD || (month == "February" && dayN == 29 && leapDay == false))
            {
                dayDet = false;         //Checks if day is valid!
            }

            //Final Digit calculations:  
            string s1 = egn[0].ToString();
            string s2 = egn[1].ToString();
            string s3 = egn[2].ToString();
            string s4 = egn[3].ToString();
            string s5 = egn[4].ToString();
            string s6 = egn[5].ToString();
            string s7 = egn[6].ToString();
            string s8 = egn[7].ToString();
            string s9 = egn[8].ToString();
            string s10 = egn[9].ToString();
            
            int digit1 = 0; int digit2 = 0; int digit3 = 0; int digit4 = 0;
            int digit5 = 0; int digit6 = 0; int digit7 = 0; int digit8 = 0;
            int digit9 = 0; int digit10 = 0;
            Int32.TryParse(s1, out digit1);Int32.TryParse(s2, out digit2);Int32.TryParse(s3, out digit3);
            Int32.TryParse(s4, out digit4);Int32.TryParse(s5, out digit5);Int32.TryParse(s6, out digit6);
            Int32.TryParse(s7, out digit7);Int32.TryParse(s8, out digit8);Int32.TryParse(s9, out digit9);
            Int32.TryParse(s10, out digit10);

            int sum=
                  digit1 * 2 + digit2 * 4 + digit3 * 8
                + digit4 * 5 + digit5 * 10 + digit6 * 9
                + digit7 * 7 + digit8 * 3 + digit9 * 6;
            int final = sum % 11;
            if (final !=digit10)
            {
                FinalDigitDet = false;          //Checks if the final digit is valid!
            }

            switch (10)     //ENUM DETERMINATOR
            {
                case int n when (digit9 == 0 || digit9 == 2 || digit9 == 4 || digit9 == 6 || digit9 == 8):
                    gender =Gender.Male ;
                    break;
                case int n when (digit9 == 1 || digit9 == 3 || digit9 == 5 || digit9 == 7 || digit9 == 9):
                    gender = Gender.Female;
                    break;
            }

            if (lengthDet==false||digit==false||monthDet==false||dayDet==false||FinalDigitDet==false) //THE DETERMINATORS!
            {
                Console.WriteLine("The validator returns false.");
                return false;                               
            }
            else
            {
                date = year+" "+month+" "+day;
                Console.WriteLine(date + " " + gender);
                return true;
            }                     
        }

        static void Main(string[] args)
        {                                          
            string date = "";            
            Gender gender = new Gender();
            Validate(out date, out gender);
            Console.ReadKey();
        }
    }
}
