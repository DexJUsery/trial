using System;

public class Entry 
{
    public string _date = DateTime.Now.ToString("dd-MM-yyyy");
    public string _prompt;
    public string _response;
    public List<Entry> _entry = new List<Entry>();
    public void Display()
    {
        Console.WriteLine($"Date:{_date} Prompt:{_prompt}");
        Console.WriteLine($"{_response}");
        foreach (Entry elementEntry in _entry)
        {
            elementEntry.Display();
        }
    }
}