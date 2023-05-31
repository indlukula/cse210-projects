using System;

// A code template for the category of things known as 
public class JsonFile
{
    // The C# convention is to start member variables with an underscore _
    public string ID{ get; set;}
    public string Date { get; set;}
    public string Prompt { get; set; }
    public string Capture {get; set;}


    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public JsonFile()
    {
    }

}