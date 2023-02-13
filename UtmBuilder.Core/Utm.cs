using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core;

public class Utm
{
    public Utm(Url url, Campaing campaing)
    {
        Url = url;
        Campaing = campaing;
    }

    //null! ==> null not (não pode ser nulo, mas não tem um objeto ainda)
    /// <summary>
    /// URL (Website Link)
    /// </summary>
    public Url Url { get; }

    /// <summary>
    /// Campaign Details
    /// </summary>
    public Campaing Campaing { get; }

}
