using System;

namespace Rock__paper__scissors
{
    class Program
    {

        public static int computerChoice;
        public static int userPick;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! Pick your nr from 1-3");
             userPick = int.Parse(Console.ReadLine());
            Random newRand = new Random();
            computerChoice = newRand.Next(1, 4);
            Console.WriteLine(Comparer(userPick, computerChoice));
            Console.ReadLine();


        }
        public static String Comparer(int nr1, int nr2 )
        {
            string result = "text";
            string pickedByComp;
            string pickedByUser;
            if (computerChoice == 1)
            {
                pickedByComp = "rocks";

            }
            else if (computerChoice ==2)
            {
                pickedByComp = "paper";
            }
            else
            {
                pickedByComp = "scissors";
            }


            if (userPick == 1)
            {
                pickedByUser = "rocks";
            } 
            else if (userPick == 2 )
            {
                pickedByUser = "paper";
            }
            else
            {
                pickedByUser = "scissors";
            }
             
            if (userPick> computerChoice)
            {
         result =(" You picked " + pickedByUser + " and won! Congrats! Computer picked " + pickedByComp);
            }
            
            else if (userPick <computerChoice)
                {
                result = (" You picked " + pickedByUser + " and lost" + " Computer picked " + pickedByComp);
            }
             else
            {
                result = " You picked "  + pickedByUser + " and  Computer picked " + pickedByComp + "and it's a die ";
          
            }
            return result;
        }
            
        }
    }       

