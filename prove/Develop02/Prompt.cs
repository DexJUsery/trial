using System;

public class Prompt
{
    public static List<string> randomList = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
         "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is the most difficult thing i am trying to accomplish today?",
        "What is one small example of how i have “personalized” your life for the better?"
    };
    public static List<string> GetList()
    {
        return randomList;
    }
}