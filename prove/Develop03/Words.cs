class Word
{
    private string text;
    private bool hidden;
     public Word(string text)
    {
        this.text = text;
        this.hidden = false;
    }
     public string GetDisplayText()
    {
        if (this.hidden)
        {
            return "______";
        }
        else
        {
            return this.text;
        }
    }
     public bool IsHidden()
    {
        return this.hidden;
    }
     public void Hide()
    {
        this.hidden = true;
    }
}
