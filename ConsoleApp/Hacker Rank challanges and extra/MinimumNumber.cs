using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    class MinimumNumber
    {
        /// <summary>
        /// Strong Password
        /// https://www.hackerrank.com/challenges/strong-password/problem
        /// following code for Program.cs to call this program to run...
        ///  MinimumNumber objM = new MinimumNumber();
        ///  objM.minimumNumber();
        /// </summary>
        public void minimumNumber()
        {
            int n;
            string password = "Ab1";
            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";

            int countPassword =0;
            int countNumber=0;
            int countLowerCase = 0;
            int countUpperCase = 0;
            int countSpecialChar = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i].ToString());
            //}
            for (int i = 0; i < password.Length; i++)
            {
                for (int j = 0; j < lower_case.Length; j++)
                {
                    if (password[i] == lower_case[j])
                    {
                        countLowerCase++;
                    }
                }
                for (int k = 0; k < numbers.Length; k++)
                { 
                    if (password[i] == numbers[k])
                    {
                        countNumber++;
                    }
                
                }
                for (int l = 0; l < upper_case.Length; l++)
                {
                    if (password[i] == upper_case[l])
                    {
                        countUpperCase++;
                    }
                }
                for (int m = 0; m < special_characters.Length; m++)
                {
                    if (password[i] == special_characters[m])
                    {
                        countSpecialChar++;
                    }
                }
            }

            if (password.Length < 6)
            {
                countPassword = 6 - password.Length;
            }

            int minimumNumber = 0;

            if (countLowerCase == 0)
                minimumNumber++;
            if (countNumber == 0)
                minimumNumber++;
            if (countSpecialChar == 0)
                minimumNumber++;
            if (countUpperCase == 0)
                minimumNumber++;

            if (countPassword < 6)
            {
                if (countPassword > minimumNumber)
                {
                    int number = countPassword - minimumNumber;
                    minimumNumber = minimumNumber + number;
                }
                
            }      

            Console.WriteLine("Minimum Number: " + minimumNumber);
          
            if (countLowerCase > 1)
                Console.WriteLine("Password has lower case");
            else
                Console.Write("There is no Lower case in the password");

            Console.ReadLine();
        }
    }
}
