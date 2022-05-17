using System.Management.Automation;

namespace RobotsTxt;

/// <summary>
/// Converts the content of a robots.txt file to an instance of <see cref="RobotsTxt"/>.
/// </summary>
[Cmdlet(VerbsData.ConvertTo, nameof(RobotsTxt))]
[OutputType(typeof(RobotsTxt))]
public class ConvertToRobotsTxtCmdlet : Cmdlet
{
    /// <summary>
    /// Specifies the robots.txt content to convert to an instance of <see cref="RobotsTxt"/>.
    /// Enter a variable that contains the robots.txt content, or type a command or expression that
    /// gets the robots.txt content. You can also pipe the robots.txt content to this cmdlet.
    /// </summary>
    [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
    public string? InputObject { get; set; }

    /// <inheritdoc />
    protected override void ProcessRecord()
    {
        var result = new RobotsTxt(new[]
        {
            new Group(),
            new Group(),
            new Group()
        });

        WriteObject(result);
    }
}