class ScriptureLibrary
{
    private List<Scripture> scriptures;
     public ScriptureLibrary()
    {
        this.scriptures = new List<Scripture>();
    }
     public void LoadFromFile(string filename)
    {
        StreamReader reader = new StreamReader(filename);
        while (!reader.EndOfStream)
        {
            string reference = reader.ReadLine();
            string text = reader.ReadLine();
            this.scriptures.Add(new Scripture(reference, text));
        }
        reader.Close();
    }
     public Scripture GetRandomScripture()
    {
        Random random = new Random();
        return this.scriptures[random.Next(this.scriptures.Count)];
    }
}