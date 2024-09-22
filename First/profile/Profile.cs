using System.Globalization;

namespace First.profile;

public class Profile(string name, int age, double height)
{
    public string GetName()
    {
        return name;
    }

    public Dictionary<string, string> GetProperties()
    {
        var properties = new Dictionary<string, string>
        {
            { "name", name },
            { "age", age.ToString() },
            { "height", height.ToString(CultureInfo.InvariantCulture) }
        };

        return properties;
    }
}