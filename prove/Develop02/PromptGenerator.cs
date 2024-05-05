using System.IO;

class PromptGenerator{
    public List<string> _prompts= new List<string>(); 
    public PromptGenerator() 
    {
        _prompts.Add("What is the best memory I made today?");
        _prompts.Add("What is an opportunity I had today to build my testimony?");
        _prompts.Add("What is something I could have done better today?");
        _prompts.Add("Who did I help today?");
        _prompts.Add("How well was I able to accomplish my daily tasks?");
    }
 

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int _index = random.Next(1,_prompts.Count());
        return _prompts[_index];
        
    }


    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }


}