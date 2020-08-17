using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;

namespace Join
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Story
    {
        public string Character { get; set; }
        public string Title { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile() { Name = "Alice", Height = 150 },
                new Profile() { Name = "Belle", Height = 163 },
                new Profile() { Name = "Caroline", Height = 178 },
                new Profile() { Name = "Dorothy", Height = 145 },
                new Profile() { Name = "Eve", Height = 160 }
            };
            Story[] arrStory =
            {
                new Story(){Character="Alice",Title="Wonderland"},
                new Story(){Character="Belle",Title="Beauty"},
                new Story(){Character="Belle",Title="Beast"},
                new Story(){Character="Caroline",Title="Caroline"},
                new Story(){Character="Dorothy",Title="Oz"},
            };

            var listProfile =
                from profile in arrProfile
                join story in arrStory on profile.Name equals story.Character
                select new
                {
                    Name = profile.Name,
                    Title = story.Title,
                    Height = profile.Height
                };

            Console.WriteLine("---내부 조인 결과---");

            foreach ( var profile in listProfile)
            {
                Console.WriteLine($"이름 : {profile.Name,-10}, 작품 : {profile.Title,-10}, 키 : {profile.Height}");
            }

            listProfile =
                from profile in arrProfile
                join story in arrStory on profile.Name equals story.Character into sc
                from story in sc.DefaultIfEmpty(new Story() { Title = "Nothing" })
                select new
                {
                    Name = profile.Name,
                    Title = story.Title,
                    Height = profile.Height
                };
            Console.WriteLine();
            Console.WriteLine("---외부 조인 결과---");
            foreach(var profile in listProfile)
            {
                Console.WriteLine($"이름 : {profile.Name,-10}, 작품 : {profile.Title,-10}, 키 : {profile.Height}");
            }
        }
    }
}
