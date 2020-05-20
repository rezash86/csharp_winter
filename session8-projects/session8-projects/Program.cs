using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session8_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IfNumberContains3(7201432));
            //Console.WriteLine(IfNumberContains3(87501));

            //Console.WriteLine(TheBiggestNumber(new int[] { 190, 291, 145, 209, 280, 300 }));
            //Console.WriteLine(TheBiggestNumber(new int[] { -9, -2, -7, -8, -4 }));

            //Console.WriteLine(ExtractString("KfC##jGTO##pLTTT##pass##pL")); //=> jGTO
            //Console.WriteLine(ExtractString("abc##def")); // emptySting
            //Console.WriteLine(ExtractString("gar##d#en")); // emptySting

            //Console.WriteLine(SumAndAverage(20, 22));
            //Console.WriteLine(SumAndAverage(0, 100));

            //Console.WriteLine(LettersBalance("fgvbgvfa"));
            //Console.WriteLine(IsMirrored("abcdeedcba"));
            //Console.WriteLine(IsPalindrome("madam"));

            Console.WriteLine(MakeUppercase("modem"));
            Console.WriteLine(MakeUppercase("Aliquam dolor nisl"));
        }

        //Task 1
        private static bool IfNumberContains3(int number)
        {
            // MOD % => 25 % 2 = 1
            //23231 => while using mod to take each digit
            //extraction needs / divide by 10 2323 => 232 => 23 => 2 => 0
            while(number > 0)
            {
                if( number % 10 == 3)
                {
                    return true;
                }
                number = number / 10;
                //number /= 10;
            }
            return false;           
        }


        //Task2
        private static int TheBiggestNumber(int[] NumberArr)
        {
            int thebiggest = NumberArr[0];
            for(int i=1; i< NumberArr.Length; i++)
            {
                if(NumberArr[i] > thebiggest)
                {
                    thebiggest = NumberArr[i];
                }
            }
            return thebiggest;
        }

        //Task3
        private static string ExtractString(string word)
        {
            string extractedWord = string.Empty;
            string result = string.Empty;

            //"##abc##def##"
            for (int i=0; i<=word.Length -1; i++)
            {
                if(word[i] == '#' && word[i + 1] == '#')
                {
                    //first occurance happened
                    for(int j= i+2; j<= word.Length - 1; j++)
                    {
                        if(word[j] == '#' && word[j+1] == '#')
                        {
                            //second occurance happened
                            //first correct result
                            //return extractedWord;
                            
                            //for accepting the all occurances
                            result +=  " " + extractedWord;
                            extractedWord = string.Empty;
                            break;
                        }
                        extractedWord += word[j];
                    }
                
                }
            }
            if (result != string.Empty)
            {
                return result;
            }
            return string.Empty;
        }

        //Task4
        private static string SumAndAverage(int lowerBound, int highBound)
        {
            int sum = 0;
            double average = 0.0;
            int counter = 0;
            
            for(int i=lowerBound; i< highBound; i++)
            {
                sum += i;
                counter++;
            }

            average = sum /(double) counter;

            return $" Sum = {sum} and average= {average}";

        }

        //Task5
        private static bool LettersBalance(string word)
        {
            // Loop!
            // complexity => 2 nested loop O(n^2)
            //It is not mirror
            //abcddcab => true
            for(int i=0; i< word.Length/2;i++)
            {
                bool isBalanced = false;
                for (int j = word.Length - 1; j >= word.Length / 2; j--)
                {
                    if(word[i] == word[j])
                    {
                        isBalanced = true;
                    }
                }
                if (!isBalanced)
                {
                    return false;
                }

            }

            return true;
        }

        private static bool IsMirrored(string word)
        {
            //abcddcba
            bool isMirrored = false;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if(word[i] == word[word.Length - 1 - i])
                {
                    isMirrored = true;
                }
                else
                {
                    return false;
                }
            }

            return isMirrored;
        }

        //Task6
        private static bool IsPalindrome(string str)
        {
            for (int i=0; i< str.Length/2; i++)
            {
                if(str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        //Task7
        private static string MakeUppercase(string str)
        {
            string upperLetterCase = string.Empty;
            int wordIndex = 0;

            for (int i =0; i<str.Length; i++)
            {
                //we need to check if char is small
                //also we need to check if the position is odd
                //make it uppercase
                if(str[i] >= 'a' && str[i] <= 'z' && wordIndex % 2 == 0)
                {
                    //I need to create the output with upper letter case
                    wordIndex++;
                    upperLetterCase += (char)(str[i] - 32);
                   
                }

                //and not space
                else if (str[i] != ' ')
                {
                    wordIndex++;
                    upperLetterCase += str[i];
                }
                //space
                else
                {
                    wordIndex = 0;
                    upperLetterCase += str[i];
                }
            }

            return upperLetterCase;
        }
    }
}
