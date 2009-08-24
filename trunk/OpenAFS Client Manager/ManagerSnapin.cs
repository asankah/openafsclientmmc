using Microsoft.ManagementConsole;
using System.Security.Permissions;
using System.ComponentModel;

[assembly: PermissionSetAttribute(SecurityAction.RequestMinimum, Unrestricted=true)]
namespace OpenAFSClientManager
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Util"), RunInstaller(true)]
    public class InstallUtilSupport : SnapInInstaller
    {
    }

    [SnapInSettings("{95E6D88A-832B-49DF-A8E1-BF4DD77F2897}",
        DisplayName = "OpenAFS Client Manager",
        Description="Manages the OpenAFS Client",
        Vendor="OpenAFS")]
    public class ManagerSnapIn : SnapIn
    {
        public ManagerSnapIn()
        {
            this.RootNode = new ScopeNode();
            this.RootNode.DisplayName = "OpenAFS Client Manager";

            FormViewDescription fvd = new FormViewDescription();
            fvd.DisplayName = "OpenAFS Client Manager";
            fvd.ViewType = typeof(ManagerFormView);
            fvd.ControlType = typeof(ManagerControl);

            this.RootNode.ViewDescriptions.Add(fvd);
            this.RootNode.ViewDescriptions.DefaultIndex = 0;
        }
    }
}