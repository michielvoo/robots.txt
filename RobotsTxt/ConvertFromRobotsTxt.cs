using System.Management.Automation;

namespace RobotsTxt;

/// <summary>
/// Converts string input to an instance of <see cref="RobotsTxt"/>.
/// </summary>
[Cmdlet(VerbsData.ConvertTo, nameof(RobotsTxt))]
public class ConvertToRobotsTxt : PSCmdlet
{
    protected override void ProcessRecord()
    {
        WriteObject("Hello, World!");
    }
}