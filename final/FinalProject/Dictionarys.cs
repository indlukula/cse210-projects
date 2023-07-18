using System;

public class Dictionary
{
    private List<string> _dictionary = new List<string> ();
    public List<string> GetList (string fileName)
    {
        LoadWords(fileName);
        return _dictionary;
    }
    public void AddWord(string word)
    {
        _dictionary.Add(word);
    }

    public void LoadWords(string fileName)
    {
        string[] readText = File.ReadAllLines(fileName);
        
    }
}