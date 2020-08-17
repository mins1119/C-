using System;
using System.Linq;

namespace GroupBy
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

            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 160 into g
                              select new { GroupKey = g.Key, Profiles = g };
            foreach( var Group in listProfile)
            {
                Console.WriteLine($"- 160cm 미만? : {Group.GroupKey}");
                foreach(var profile in Group.Profiles)
                {
                    Console.WriteLine($"   {profile.Name}, {profile.Height}");
                }
            }
        }
    }
}
