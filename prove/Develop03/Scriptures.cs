class Scripture
{
    private Reference reference;
    private List<Word> words;
     public Scripture(string reference, string text)
    {
        this.reference = new Reference(reference);
        this.words = new List<Word>();
        string[] wordStrings = text.Split(' ');
        foreach (string wordString in wordStrings)
        {
            this.words.Add(new Word(wordString));
        }
    }
     public string GetFullText()
    {
        string fullText = this.reference.ToString() + " ";
        foreach (Word word in this.words)
        {
            fullText += word.GetDisplayText() + " ";
        }
        return fullText.Trim();
    }
     public void HideRandomWords()
    {
        Random random = new Random();
        foreach (Word word in this.words)
        {
            if (!word.IsHidden() && random.Next(2) == 0)
            {
                word.Hide();
            }
        }
    }
     public bool AllWordsHidden()
    {
        foreach (Word word in this.words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}