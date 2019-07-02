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
            Double numParticipants = Convert.ToChar(Console.ReadLine());

            string selection;
            string travel;
            string name;

            actType(activitySelection);
            string activity1 = actType(selection);
            travelOpts(numParticipants);
            string travel1 = travelOpts(travel);
            nameOpts(activitySelection);
            string name1 = nameOpts(name);

            Console.WriteLine("Okay, if you're in the mood for {0}, then you should go to {1}, and travel in a {2}.", name1, activity1, travel1);
            Console.WriteLine("Have a good time, goodbye");
        }
        public static string actType(Double activitySelection)
        {
            Double activity = Convert.ToDouble(activitySelection);

            string selection;

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
            return selection;
        }
        public static string travelOpts(Double numParticipants)
        {

            string travel;

            if (numParticipants == 0)
            {
                travel = "sneakers";
            }
            else if (numParticipants >= 1 | numParticipants <= 4)
            {
                travel = "a sedan";
            }
            else if (numParticipants >= 5 | numParticipants <= 10)
            {
                travel = "a van";
            }
            else if (numParticipants < 10)
            {
                travel = "an airplane";
            }
            return travel;
        }
        public static string nameOpts(Double activitySelection)
        {
            Double opts = Convert.ToDouble(activitySelection);
            string name;

            if (opts == 1)
            {
                name = "action";
            }
            else if (opts == 2)
            {
                name = "chilling";
            }
            else if (opts == 3)
            {
                name = "danger";
            }
            else if(opts == 4)
            {
                name = "good food";
            }
            return name;
        }
    }
}
