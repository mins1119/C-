using System;
using System.Collections.Generic;

namespace SimpleLinq
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
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
                new Profile() { Name = "Danny", Height = 145 },
                new Profile() { Name = "Eric", Height = 160 }
            };

            List<Profile> profiles = new List<Profile>();
            foreach(Profile profile in arrProfile)
            {
                if (profile.Height < 160)
                    profiles.Add(profile);
            }
            profiles.Sort(
                (profile1, profile2) =>
                {
                    return profile1.Height - profile2.Height;
                });
            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name},{profile.Height}");
        }
    }
}