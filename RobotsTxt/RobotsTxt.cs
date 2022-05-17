namespace RobotsTxt;

/// <summary>
/// Represents the result of parsing the content of a robots.txt file.
/// </summary>
public class RobotsTxt
{
    /// <inheritdoc />
    public RobotsTxt(Group[] groups)
    {
        Groups = groups;
    }
    
    /// <summary>
    /// The rules grouped by one or more user-agents.
    /// </summary>
    public Group[] Groups { get; init; }
}
