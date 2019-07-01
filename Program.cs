using System;

namespace Deliverable_two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! please select which type of activity you're looking for.");
            Console.WriteLine("Here are your choices, please use the number associated with the activity to make your selection.");
            Console.WriteLine("1. Action" + "\n" + "2. Chilling" + "\n" + "3. Danger" + "\n" + "4. Good Food");
            Double activitySelection = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many people besides you are going to be participating?");
            Double numParticipants = Convert.ToDouble(Console.ReadLine());

            decisionmaking(activitySelection, numParticipants);
            Console.WriteLine("Okay, if you're in the mood for {0}, then you should go to {1}, and travel in a {2}.", selection, travel);
            Console.WriteLine("Have a good time, goodbye");
        }
        public static void decisionmaking(Double activitySelection, Double numParticipants)
        {
            Double activity = Convert.ToDouble(activitySelection);
            Double num = Convert.ToDouble(numParticipants);
            string selection;
            string travel;

            if (activity == 1)
            {
                selection = "Stock car racing";
            }
            else if (activity == 2)
            {
                selection = "Hiking";
            }
            else if (activity == 3)
            {
                selection = "Skydiving";
            }
            else
            {
                selection = "To taco bell";
            }

            if (numParticipants == 0)
            {
                travel = "sneakers";
            }
            else if (numParticipants <= 1 | numParticipants >= 4)
            {
                travel = "a sedan";
            }
            else if (numParticipants <= 5 | numParticipants >= 10)
            {

            }
            else if (numParticipants < 10)
            {
                travel = "an airplane";
            }
            return;



        }
    }
}
