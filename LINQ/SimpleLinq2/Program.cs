using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinq2
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

            var profiles = from profile in arrProfile
                           where profile.Height < 160
                           orderby profile.Height
                           select profile;
            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name},{profile.Height}");
        }
    }
}