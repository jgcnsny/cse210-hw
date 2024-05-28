using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Cheers to Youth MV";
        video1._author = "Vocal Unit(Seventeen)";
        video1._length = 240;

        Comment video1Comment1 = new Comment();
        video1Comment1._authorName = "@saynotshh";
        video1Comment1._comment = "cheers to youth feels like the quote 'you can't change the people around you, but you can change the people around you' I'M BAWLING MY EYES OUT";
        video1.StoreComment(video1Comment1);

        Comment video1Comment2 = new Comment();
        video1Comment2._authorName = "@SittiehanyaAbdulhalem-gd4po";
        video1Comment2._comment = "one of the main reason why we become carat is because they have this kind of  friendship /family relation  that we didnt have ourselves, but seeing them cherish one another is one way to comfort ourself";
        video1.StoreComment(video1Comment2);

        Comment video1Comment3 = new Comment();
        video1Comment3._authorName = "@zahschive";
        video1Comment3._comment = "“where could my happiness possibly be? no one can answer that for me” really hits hard..";
        video1.StoreComment(video1Comment3);


        Video video2 = new Video();
        video2._title = "Spell MV";
        video2._author = "Performance Unit(Seventeen)";
        video2._length = 225;

        Comment video2Comment1 = new Comment();
        video2Comment1._authorName = "@HoranghaeBee";
        video2Comment1._comment = "Not gonna stop playing. This really a masterpiece. A work of art made by works of art themselves.";
        video2.StoreComment(video2Comment1);

        Comment video2Comment2 = new Comment();
        video2Comment2._authorName = "@main135k";
        video2Comment2._comment = "Everything about this is amazing, but a real shout out to the makeup artists on set.";
        video2.StoreComment(video2Comment2);

        Comment video2Comment3 = new Comment();
        video2Comment3._authorName = "@yumelynes";
        video2Comment3._comment = "This is genuinely the best song ever created i'm so speechless i love everything about it";
        video2.StoreComment(video2Comment3);

        Video video3 = new Video();
        video3._title = "LaLaLi MV";
        video3._author = "Hip Hop Unit(Seventeen)";
        video3._length = 199;

        Comment video3Comment1 = new Comment();
        video3Comment1._authorName = "@YUNA..267";
        video3Comment1._comment = "Why so beautiful???? The music video???? The atmosphere??? The concept??? The choreography??? The members voices??? ";
        video3.StoreComment(video2Comment1);

        Comment video3Comment2 = new Comment();
        video3Comment2._authorName = "@katghenciu8753";
        video3Comment2._comment = "The best unit ever !!!!!";
        video3.StoreComment(video2Comment2);

        Comment video3Comment3 = new Comment();
        video3Comment3._authorName = "@imros3";
        video3Comment3._comment = "Hands down one of the best MVs out there! So much fun to watch!";
        video3.StoreComment(video2Comment3);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach(Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine($"Number of comments: {video.CommentCount()}");
            video.DisplayAllComments();
            Console.WriteLine();
        }
    }
}