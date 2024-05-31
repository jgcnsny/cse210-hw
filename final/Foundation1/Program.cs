using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();


        Video video1 = new Video("Cheers to Youth MV","Vocal Unit(Seventeen)",240);
        video1.StoreComment(new Comment("@saynotshh","cheers to youth feels like the quote 'you can't change the people around you, but you can change the people around you' I'M BAWLING MY EYES OUT"));
        video1.StoreComment(new Comment("@SittiehanyaAbdulhalem-gd4po","one of the main reason why we become carat is because they have this kind of  friendship /family relation  that we didnt have ourselves, but seeing them cherish one another is one way to comfort ourself"));
        video1.StoreComment(new Comment("@zahschive","where could my happiness possibly be? no one can answer that for me” really hits hard.."));

        Video video2 = new Video("Spell MV","Performance Unit(Seventeen)",225);
        video2.StoreComment(new Comment("@HoranghaeBee","Not gonna stop playing. This really a masterpiece. A work of art made by works of art themselves."));
        video2.StoreComment(new Comment("@main135k","Everything about this is amazing, but a real shout out to the makeup artists on set."));
        video2.StoreComment(new Comment("@yumelynes","This is genuinely the best song ever created i'm so speechless i love everything about it"));


        Video video3 = new Video("LaLaLi MV","Hip Hop Unit(Seventeen)",199);
        video3.StoreComment(new Comment("@YUNA..267","Why so beautiful???? The music video???? The atmosphere??? The concept??? The choreography??? The members voices??? "));
        video3.StoreComment(new Comment("@katghenciu8753","The best unit ever !!!!!"));
        video3.StoreComment(new Comment("@imros3","Hands down one of the best MVs out there! So much fun to watch!"));
        

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach(Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}