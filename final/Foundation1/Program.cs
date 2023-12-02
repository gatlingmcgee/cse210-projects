using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video's
        Video video1 = new Video
        {
            Title = "Programming with JavaScript",
            Author = "Brother Gibson",
            LengthInSeconds = 350
        };

        Video video2 = new Video
        {
            Title = "Debugging Concepts",
            Author = "Brother Geroge",
            LengthInSeconds = 1000
        };

        Video video3 = new Video
        {
            Title = "Programming with C#",
            Author = "Brother Tripp",
            LengthInSeconds = 820
        };

        Video video4 = new Video
        {
            Title = "Big brain concepts",
            Author = "Brother Bright",
            LengthInSeconds = 1440
        };       

        // Comments
        video1.AddComment("James", "Great CSS!");
        video1.AddComment("John", "Very informative.");
        video1.AddComment("Sally", "Very orderly.");

        video2.AddComment("Jermey", "Great lesson!");
        video2.AddComment("Luke", "Wonderful concept.");

        video3.AddComment("Jane", "Great tutorial!");
        video3.AddComment("Noah", "Well constructed.");
        video3.AddComment("Addy", "Thanks for sharing.");
        video3.AddComment("Noah", "Very informative.");

        video4.AddComment("Jane", "Great lesson!");
        video4.AddComment("Noah", "Well constructed.");
        video4.AddComment("Addy", "Wonderful concept.");
        video4.AddComment("Johnny", "Very informative.");
        video4.AddComment("Yulisa", "Will use this!");
        video4.AddComment("Lisa", "Never seen better example!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (var video in videos)
        {
            DisplayInformation(video);
        }
    }

    static void DisplayInformation(Video video)
    {
        Console.WriteLine();
        Console.WriteLine(video);
    }

}
