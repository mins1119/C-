using System;
using System.Globalization;
using System.Linq;

namespace LINQ2
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
                new Profile(){Name="Alice", Height = 150},
                new Profile(){Name="Belle", Height = 160},
                new Profile(){Name="Caroline", Height = 155},
                new Profile(){Name="Daisy", Height = 166},
                new Profile(){Name="Eve", Height = 148}
            };
            var profiles = arrProfile.
                Where(profile => profile.Height < 160).
                OrderBy(profile => profile.Height).
                Select(profile => new
                {
                    Name = profile.Name,
                    InchHeight = profile.Height * 0.393
                });
            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name},{profile.InchHeight}");
        }
    }
}
