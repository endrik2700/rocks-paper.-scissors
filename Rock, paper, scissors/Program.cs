using System;

namespace Rock__paper__scissors
{
    class Program
    {   public static string userPick;
        public static string computerpick;

        public static void Main () {
            Random  rand = new Random();   
            int userChoice;
            int computerChoice;
            
            int userPoints =0;
            int computerPoints =0;
            Console.WriteLine("Hello!");
            Console.ReadLine();
            while (userPoints <=3 || computerPoints <=3) 
        {
            Console.WriteLine ( "Pick your number from 1-3, 1=paper, 2=rock, 3=scissors"); 
             userChoice = int.Parse(Console.ReadLine());
             computerChoice = rand.Next(1,4);
            switch (userChoice =1 )
            {
                case 1:
                    userPick ="paper";
                    break;
                case 2:
                   userPick ="rock";
                   break;
                case 3:
                userPick = "scissors";
                break;
            }
         switch (computerChoice) {
               case 1:
               computerpick = "paper";
               break;
               case  2:
              
               computerpick = "rock";
               break;
               case  3:
               computerpick = "scissors";
               break;
               default :
               Console.WriteLine("something is not right");
               break;
         }
            if ( userChoice ==1 && computerChoice == 2 || userChoice == 2 && computerChoice ==3 || userChoice ==3 && computerChoice ==1  ) {
                  Console.WriteLine ("You picked " + userPick + "and computer picked " + computerpick + " you won!");
                  userPoints ++;
                  Console.WriteLine ("User has " + userPoints + "  points and the computer has " + computerPoints + "points");
            }
            else if ( userChoice ==3 && computerChoice == 2 || userChoice == 2 && computerChoice ==1 || userChoice ==1 && computerChoice ==3 ) {
                    Console.WriteLine ("You picked " + userPick + "and computer picked " + computerpick + " you lost!");
                    computerPoints ++;
                    Console.WriteLine ("User has " + userPoints + "  points and the computer has " + computerPoints + " points");
            } else {
                 Console.WriteLine ("You picked " + userPick + " and the computer picked " + computerpick + " there is a tie");
                 Console.WriteLine ("User has " + userPoints + "  points and the computer has " + computerPoints + " points");
            }
            if ( userPoints ==3) {
                Console.WriteLine("User won");
                break;
            } 
            else if (computerPoints ==3){
                Console.WriteLine("Computer won");
                break;
            }
         }
        }
        
    }       
}
