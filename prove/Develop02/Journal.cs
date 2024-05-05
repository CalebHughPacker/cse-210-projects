using System.Data;

public class Journal 
{

    public List<Entry> _entries= new List<Entry>(); 
        
    
    public Journal ()
    {
  
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} – Prompt: {entry._promptText}\n{entry._entryText}\n");
        }
    }

    public void SaveToFile(string file)
    {

        file = @"C:\Users\packe\Desktop\CSE210\cse-210-projects\prove\Develop02\" + file;
        
        if (!Path.IsPathRooted(file))
        {
            Console.WriteLine("Invalid file path. Please provide an absolute file path.");
            return;
        }

        string directory = Path.GetDirectoryName(file);
        
        if (!Directory.Exists(directory))
        {
            Console.WriteLine("Directory does not exist. Please provide a valid directory.");
            return;
        }

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
            }
        }
        Console.WriteLine("Entry saved successfully.");
    }

    public void LoadFromFile(string file)
    {
        file = @"C:\Users\packe\Desktop\CSE210\cse-210-projects\prove\Develop02\" + file;
        if (!Path.IsPathRooted(file))
        {
            Console.WriteLine("Invalid file path. Please provide an absolute file path.");
            return;
        }

        string directory = Path.GetDirectoryName(file);
        
        if (!Directory.Exists(directory))
        {
            Console.WriteLine("Directory does not exist. Please provide a valid directory.");
            return;
        }
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string date = parts[0];
            string prompt = parts[1];
            string userEntry = parts[2];
            Entry entry = new Entry(); 
            entry._date = date;
            entry._promptText = prompt;
            entry._entryText = userEntry;
            AddEntry(entry);
        }
        Console.WriteLine("Loaded Successfully");
    }
}