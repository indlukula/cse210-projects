public class Dictionary
{
     private Dictionary<int, string> _words;
     private void LoadWordsFromFile()
    {
        try
        {
            using (StreamReader sr = new StreamReader("words.txt"))
            {
                string line;
                int index = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    _words.Add(index, line);
                    index++;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Failed to load words from file: " + e.Message);
        }
    
    }
}