using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
     
        // Create videos
        Video video1 = new Video();
        video1._title = "How to make Italian pasta";
        video1._author = "Del Piero";
        video1._length = 610; // 10 minutes and 10 seconds

        Video video2 = new Video();
        video2._title = "Easy ways to make a delicious burger";
        video2._author = "Emah Cooks";
        video2._length = 800; // 13 minutes and 20 seconds

        Video video3 = new Video();
        video3._title = "How to make Instant noodles taste better";
        video3._author = "Gloria Smith";
        video3._length = 750; // 12.5 minutes

        // Create comments for video1
        Comment comment1 = new Comment();
        comment1._name = "Grace";
        comment1._text = "Great video! I can't wait to try this recipe.";
        
        Comment comment2 = new Comment();
        comment2._name = "Daniel";
        comment2._text = "I loved this content, keep it up!";
        
        Comment comment3 = new Comment();
        comment3._name = "Charles";
        comment3._text = "This was so helpful, thank you!";

        // Add comments to video1
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        // Create comments for video2
        Comment comment4 = new Comment();
        comment4._name = "Emily";
        comment4._text = "Wow! I finally understand this.";

        Comment comment5 = new Comment();
        comment5._name = "Michael";
        comment5._text = "This is exactly what I was looking for, thanks!";

        // Add comments to video2
        video2.AddComment(comment4);
        video2.AddComment(comment5);

        // Create comments for video3
        Comment comment6 = new Comment();
        comment6._name = "Sophia";
        comment6._text = "Makes so much sense now!";

        Comment comment7 = new Comment();
        comment7._name = "Liam";
        comment7._text = "Great teaching style!";

        // Add comments to video3
        video3.AddComment(comment6);
        video3.AddComment(comment7);

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}

    