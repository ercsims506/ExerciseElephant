using System;

namespace ExerciseElephant
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant[] elephants = new Elephant[7];
            elephants[0] = new Elephant() { Name = "Lloyd", EarSize = 40 };
            elephants[1] = new Elephant() { Name = "Lucinda", EarSize = 33 };
            elephants[2] = new Elephant() { Name = "Larry", EarSize = 42 };
            elephants[3] = new Elephant() { Name = "Lucille", EarSize = 32 };
            elephants[4] = new Elephant() { Name = "Lars", EarSize = 44 };
            elephants[5] = new Elephant() { Name = "Linda", EarSize = 37 };
            elephants[6] = new Elephant() { Name = "Humphrey", EarSize = 45 };

            Elephant biggestEars = elephants[0]; //Iteration #1 biggestEars.EarSize = 
            for (int i = 1; 1 < elephants.Length; i++)
            {
                Console.WriteLine("Iteration #" + i); //Iteration #2 biggestEars.EarSize = 

                if (elephants[i].EarSize > biggestEars.EarSize)
                {                                   //Iteration #3 biggestEars.EarSize =
                    biggestEars = elephants[i];     //This sets the biggestEars reference to the object that elephants[i] points to.
                }
                                                    //Iteration #4 biggestEars.EarSize =
                Console.WriteLine(biggestEars.EarSize.ToString());
            }
                                                    //Iteration #5 biggestEars.EarSize = 
                                                    
                                                    //Iteration #6 biggestEars.EarSize = 



            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 33 };
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed " + input);
                if (input == '1')
                {
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                }
                else if (input == '2')
                {
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                }
                else if (input == '3')
                {
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;
                    Console.WriteLine("References have been swapped");
                }
                //else if (input == '4')
                //{
                //    lloyd = lucinda;
                //    lloyd.EarSize = 4321;
                //    lloyd.WhoAmI();
                //}
                else if (input == '5')
                {
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
                }
                else return;
                Console.WriteLine();
            }
        }
    }
}
