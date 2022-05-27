using System;
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

      Challenge bestDrummer = new Challenge(
          @"Who's the best drummer?
                1) John Bonham
                2) Benny Greb
                3) Jojo Mayer
                4) Mark Guiliana
                ",
          1, 25
      );

      Challenge bestDrink = new Challenge(
          @"What's a superior drink?
                1) Coffee
                2) Tea
                ",
          1, 15
      );

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

      Adventurer theAdventurer = new Adventurer(adventurerName, rando, hatObj, 0);

      Console.WriteLine(theAdventurer.GetDescription());

      List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle,
                bestDrummer,
                bestDrink
            };

      // Loop through all the challenges and subject the Adventurer to them
      int index = 5;

      foreach (Challenge challenge in challenges)
      {
        while (index != 0)
        {
          int randomIndex = new Random().Next(challenges.Count);
          challenges[randomIndex].RunChallenge(theAdventurer);
          index--;
        }
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
      
      index = 5;
      Console.Write("Would you like to play again? yes/no: ");
      string answer = Console.ReadLine();

      while (answer.ToUpper() != "NO" && index != 0)
      {
        theAdventurer.Awesomeness += (theAdventurer.CorrectCount * 10);
        {
          foreach (Challenge challenge in challenges)
          {

            while (index != 0)
            {
              int randomIndex = new Random().Next(challenges.Count);
              challenges[randomIndex].RunChallenge(theAdventurer);
              index--;
            }
          }

          if (theAdventurer.Awesomeness >= maxAwesomeness)
          {
            Console.WriteLine("YOU DID IT! You are truly awesome!");
            turtlesComic.ShowPrize(theAdventurer);
            Console.Write("Would you like to play again? yes/no: ");
            answer = Console.ReadLine();
          }
          else if (theAdventurer.Awesomeness <= minAwesomeness)
          {
            Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
            turtlesComic.ShowPrize(theAdventurer);
            Console.Write("Would you like to play again? yes/no: ");
            answer = Console.ReadLine();
          }
          else
          {
            Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
            turtlesComic.ShowPrize(theAdventurer);
            Console.Write("Would you like to play again? yes/no: ");
            answer = Console.ReadLine();
          }
        }
        Console.WriteLine($"Job well done?????? {theAdventurer.Name}, your awesomeness was {theAdventurer.Awesomeness}");
      }
    }
  }
}
