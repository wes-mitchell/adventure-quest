using System;

namespace Quest
{
  public class Prize
  {
    private string _text { get; }
    public Prize(string text)
    {
      _text = text;
    }

    public void ShowPrize(Adventurer adventurer)
    {
      if (adventurer.Awesomeness > 0)
      {
        int index = adventurer.Awesomeness;
        while(index != 0)
        {
          Console.WriteLine(_text);
          index--;
        }
      }
      else 
      {
        Console.WriteLine("Whoof, that's a bummer. No prize for you");
      }
    }
  }
}