class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;
    private string reference;

    public Reference(string reference)
    {
        this.reference = reference;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }
    
    public override string ToString()
    {
        if (this.startVerse == this.endVerse)
        {
            return $"{this.book} {this.chapter}:{this.startVerse}";
        }
        else
        {
            return $"{this.book} {this.chapter}:{this.startVerse}-{this.endVerse}";
        }
    }
}

        

    //  public Reference(string reference)
    // {
    //     string[] parts = reference.Split(':');
    //     this.book = parts[0];
    //     string[] chapterAndVerse = parts[1].Split(' ');
    //     this.chapter = int.Parse(chapterAndVerse[0]);
    //     if (chapterAndVerse.Length == 1)
    //     {
    //         this.startVerse = 1;
    //         this.endVerse = 1;
    //     }
    //     else
    //     {
    //         this.startVerse = int.Parse(chapterAndVerse[1]);
    //         this.endVerse = int.Parse(chapterAndVerse[2]);
    //     }
    // }
//      public override string ToString()
//     {
//         if (this.startVerse == this.endVerse)
//         {
//             return this.book + " " + this.chapter + ":" + this.startVerse;
//         }
//         else
//         {
//             return this.book + " " + this.chapter + ":" + this.startVerse + "-" + this.endVerse;
//         }
//     }
// }