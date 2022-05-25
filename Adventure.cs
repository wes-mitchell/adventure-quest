using System;

namespace Quest
{
    // An instance of the Adventurer class is an object that will undergo some challenges
    public class Adventurer
    {
        // This is an "immutable" property. It only has a "get".
        // The only place the Name can be set is in the Adventurer constructor
        // Note: the constructor is defined below.
        public string Name { get; }

        public Robe ColorFulRobe { get; }

        // This is a mutable property it has a "get" and a "set"
        //  So it can be read and changed by any code in the application
        public int Awesomeness { get; set; }

        public Hat Hat { get; set; }

        // A constructor to make a new Adventurer object with a given name
        public Adventurer(string name, Robe robe, Hat hat)
        {
            Name = name;
            Awesomeness = 50;
            ColorFulRobe = robe;
            Hat = hat;
        }

       public string GetDescription()
        {
            string colors = "";
            for(int i = 0; i < ColorFulRobe.Colors.Count; i++)
            {
                if(i == 0)
                {
                    colors += $"{ColorFulRobe.Colors[i]}";
                }
                else if(i == ColorFulRobe.Colors.Count - 1)
                {
                    colors += $" and {ColorFulRobe.Colors[i]}";
                    // colors += $"{ColorFulRobe.Colors[i]} and";
                }
                else
                {
                    colors += $", {ColorFulRobe.Colors[i]}";
                }
            }

            return $"{Name} is wearing a {Hat.ShininessDescription()} hat and robe of colors {colors}."; 
        }


        // This method returns a string that describes the Adventurer's status
        // Note one way to describe what this method does is:
        //   it transforms the Awesomeness integer into a status string
        public string GetAdventurerStatus()
        {
            string status = "okay";
            if (Awesomeness >= 75)
            {
                status = "great";
            }
            else if (Awesomeness < 25 && Awesomeness >= 10)
            {
                status = "not so good";
            }
            else if (Awesomeness < 10 && Awesomeness > 0)
            {
                status = "barely hanging on";
            }
            else if (Awesomeness <= 0)
            {
                status = "not gonna make it";
            }

            return $"Adventurer, {Name}, is {status}";
        }
    }
}