using First.factory;
using First.profile;

namespace First;

internal abstract class Program
{
    private static void Main(string[] args)
    {
        ProfileFactory.Register(new Profile("Xoapp", 18, 1.82));

        // CREATE AUTOMATIC PROFILES
        for (int i = 0; i <= 11; i++)
        {
            ProfileFactory.Register(new Profile($"User-{i}", 12 + i, 1.82));
        }
        
        // GET PROFILE
        Profile? xoappProfile = ProfileFactory.GetProfile("Xoapp");

        // PROFILE NULL CONDITIONAL
        if (xoappProfile == null) 
        {
            Console.WriteLine("No Xoapp profile found");
        }
        else
        {
            Console.WriteLine(" ");
            Console.WriteLine("Xoapp profile found");
            Console.WriteLine(" ");

            var properties = xoappProfile.GetProperties();

            // SEND PROFILE INFORMATION
            foreach (var (key, value) in properties)
            {
                Console.WriteLine($"{char.ToUpper(key[0]) + key.Substring(1)}: {value}");
            }
        }
        
        Console.WriteLine(" ");
        
        // APPEND ALL PROFILES IN LIST
        Console.WriteLine(ProfileFactory.AppendProfiles(", "));
    }
}