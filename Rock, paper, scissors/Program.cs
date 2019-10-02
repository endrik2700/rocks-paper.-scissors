namespace Rock__paper__scissors
{
    class Program
    {

        public static int computerChoice;
        public static int userPick;
        public static int userPoints =0;
        public static int computerPoints=0;
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello! Pick your nr from 1-3");
             userPick = int.Parse(Console.ReadLine());
            Random newRand = new Random();
            computerChoice = newRand.Next(1, 4);
            while (userPoints <=3 || computerPoints <=3) 
            {
                Console.WriteLine(Comparer(userPick, computerChoice));
                if (computerPoints ==3 || userPoints ==3)
                {
                    break;
                }
            }
            
            Console.ReadLine();
            }
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
             
            if (userPick ==1 & computerChoice ==2 || userPick ==2 && computerChoice==3 || userPick ==3 && computerChoice ==1)
            {
         result =(" You picked " + pickedByUser + " and won! Congrats! Computer picked " + pickedByComp);
         userPoints +=1;
         Console.WriteLine("Computer has " + computerPoints + " points and user has " + userPoints + " points");
        // Console.ReadLine();

            }
            
            else if (userPick == 1 &&computerChoice== 3 || userPick ==3 &&computerChoice ==2 || userPick ==2 &&computerChoice 1)
                {
                result = (" You picked " + pickedByUser + " and lost" + " Computer picked " + pickedByComp);
                computerPoints +=1;
                Console.WriteLine("Computer has " + computerPoints + " points and user has " + userPoints + " points");
                //Console.ReadLine();
            }
             else
            {
                result = " You picked "  + pickedByUser + " and  Computer picked " + pickedByComp + " and it's a die ";
          Console.WriteLine("Computer has " + computerPoints + " points and user has " + userPoints + " points");
        // Console.ReadLine();
            }
            return result;
        }
            
        }
    }       
