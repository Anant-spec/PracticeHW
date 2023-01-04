using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




// WAP to find maximum between three numbers
namespace DemoProject { 
    class MyApplications
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            num1 = 5;
            num2 = 17;
            num3 = 12;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is largest!");
                }
                else
                {
                    Console.Write("Number three is largest!");

                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!");
            else
                Console.Write("Number three is the largest!");
            






            // Check whether the no. is divisible by 5 and 11 or not

            int num;
            num = 115;
            Console.WriteLine("Number:" + num);
            if (num % 5 ==0 && num % 11 == 0)
            {
                Console.WriteLine("Divisible by 5 & 11");

            } else
            {
                Console.WriteLine("Not divisible by 5 and 11");
            }
            Console.ReadLine();





            // To check whether an alphabet is a vowel or consonant

            char ch;
            Console.Write("\n\n");
            Console.Write("check whether the input alphabet is a vowel or not:\n");
            Console.Write("-----------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input an Alphabet (A-Z or a-z):") ;
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if(i>=48 && i<=57)
            {
                Console.Write("You entered a number, Please enter an alphabet.");
            }
            else { switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The alphaber is vowel");
                        break;
                        case 'u':
                        Console.WriteLine("The alphaber is vowel");
                        break;
                    default:
                        Console.WriteLine("The alphabet is not a vowel");
                        break;
                } 
            }
            Console.ReadKey();
              
                                   
            
        }
    }
}




