using First.profile;

namespace First.factory;

public abstract class ProfileFactory
{
    
    private static readonly Dictionary<string, Profile> _profiles = new Dictionary<string, Profile>();

    public static void Register(Profile profile)
    {
        _profiles.Add(profile.GetName(), profile);
    }

    public static Profile? GetProfile(string name)
    {
        return !_profiles.ContainsKey(name) ? null : _profiles[name];
    }

    public static void Delete(string name)
    {
        _profiles.Remove(name);
    }
    
    public static Dictionary<string, Profile> Profiles => _profiles;

    public static string AppendProfiles(string separator)
    {
        return string.Join(separator, _profiles.Keys);
    }
}