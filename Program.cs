﻿using System;
using System.Collections.Generic;

// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome, please provide your name: ");
            string adventurerName = Console.ReadLine();
            // Create a few challenges for our Adventurer's quest
            // The "Challenge" Constructor takes three arguments
            //   the text of the challenge
            //   a correct answer
            //   a number of awesome points to gain or lose depending on the success of the challenge
            Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
            Challenge theAnswer = new Challenge(
                "What's the answer to life, the universe and everything?", 42, 25);
            Challenge whatSecond = new Challenge(
                "What is the current second?", DateTime.Now.Second, 50);

            int randomNumber = new Random().Next() % 10;
            Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
                1) John
                2) Paul
                3) George
                4) Ringo
                ",
                4, 20
            );

            // "Awesomeness" is like our Adventurer's current "score"
            // A higher Awesomeness is better

            // Here we set some reasonable min and max values.
            //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
            //  If an Adventurer has an Awesomeness less than the min, they are terrible
            int minAwesomeness = 0;
            int maxAwesomeness = 100;
            List<string> colors = new List<string>
            {
                "red",
                "posh purple",
                "green",
                "blue",
                "purple",
                "cucumber green"
            };
            Robe rando = new Robe
            {
                Colors = colors, 
                Length = 45
            };
            Hat hatObj = new Hat
            {
                ShininessLevel = 9
            };
            Prize turtlesComic = new Prize("Ninja Turtles Comic book issue one, 1st edition mate!");
            // Make a new "Adventurer" object using the "Adventurer" class

            Adventurer theAdventurer = new Adventurer(adventurerName, rando, hatObj);
            Console.WriteLine(theAdventurer.GetDescription());
            

            // A list of challenges for the Adventurer to complete
            // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
            List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle
            };

            // Loop through all the challenges and subject the Adventurer to them
            foreach (Challenge challenge in challenges)
            {
                challenge.RunChallenge(theAdventurer);
            }

            // This code examines how Awesome the Adventurer is after completing the challenges
            // And praises or humiliates them accordingly
            if (theAdventurer.Awesomeness >= maxAwesomeness)
            {
                Console.WriteLine("YOU DID IT! You are truly awesome!");
                turtlesComic.ShowPrize(theAdventurer);
            }
            else if (theAdventurer.Awesomeness <= minAwesomeness)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
                turtlesComic.ShowPrize(theAdventurer);
            }
            else
            {
                Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
                turtlesComic.ShowPrize(theAdventurer);
            }

                Console.Write("Would you like to play again? yes/no: ");
                string answer = Console.ReadLine();

            while(answer.ToUpper() != "NO")
            {
                foreach (Challenge challenge in challenges)
            {
                challenge.RunChallenge(theAdventurer);
            }

            if (theAdventurer.Awesomeness >= maxAwesomeness)
            {
                Console.WriteLine("YOU DID IT! You are truly awesome!");
                turtlesComic.ShowPrize(theAdventurer);
            }
            else if (theAdventurer.Awesomeness <= minAwesomeness)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
                turtlesComic.ShowPrize(theAdventurer);
            }
            else
            {
                Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
                turtlesComic.ShowPrize(theAdventurer);
            }
                Console.Write("Would you like to play again? yes/no: ");
                answer = Console.ReadLine();
            }
            }
        }
    }
    