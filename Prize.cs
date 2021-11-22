using System;

namespace Quest
{
    public class Prize
    {
        private string _text {get; set;}

        public Prize(string text)
        {
            _text = text;
        }

        public void ShowPrize(Adventurer adventurer)
        {
            if (adventurer.Awesomeness > 0)
            {
                for (int i = 0; i < adventurer.Awesomeness; i++)
                {
                    Console.WriteLine($"Congrats, your prize is: {_text}!");
                }
            }
            else
            {
                Console.WriteLine("You lack Awesomeness, no prize for you");
            }
        }
    }
}