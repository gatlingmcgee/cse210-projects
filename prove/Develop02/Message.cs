using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Console.WriteLine("What was the best part of your day?");
// Console.WriteLine("What was the worst part of your day?");
// Console.WriteLine("What can you do better tomorrow?");
// Console.WriteLine("What is something you would like to change?");

public class UpliftMessage
{
    public List<string> _message = new List<string>() {"My beloved brothers and sisters, fear not. Be of good cheer. The future is as bright as your faith.",
     "The purpose of the gospel is to make bad men good and good men better.", 
     "If you are lonely, please know you can find comfort. If you are discouraged, please know you can find hope. If you are poor in spirit, please know you can be strengthened. If you feel you are broken, please know you can be mended.", 
     "Continuous effort, not strength or intelligence, is the key to unlocking our potential", 
     "Our Heavenly Father is more liberal in His views, and boundless in His mercies and blessings, than we are ready to believe or receive."};
    
    Random mes2 = new Random();

    public string GetPrompt()
    {
        int index = mes2.Next(_message.Count());
        return _message[index];
    }
}