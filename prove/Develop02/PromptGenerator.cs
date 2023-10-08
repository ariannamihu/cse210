public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "What made you happy today?",
        "What made you sad today?",
        "What was the most interesting thing you saw or heard today?",
        "What are you grateful for today?",
        "What did you learn today?",
        "What was the most fun thing you did today?"
    };

    public string GenerateRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        Console.WriteLine(prompt);
        return prompt;
    }
}


