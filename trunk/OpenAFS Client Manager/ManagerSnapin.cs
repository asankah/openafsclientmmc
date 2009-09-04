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

            ScopeNode cifsNode = new ScopeNode(true);
            ScopeNode perfNode = new ScopeNode(true);
            ScopeNode cacheManNode = new ScopeNode(true);
            ScopeNode freelanceNode = new ScopeNode(true);
            ScopeNode serversNode = new ScopeNode(true);
            ScopeNode logonNode = new ScopeNode(true);
            ScopeNode diagnosticsNode = new ScopeNode(true);
            cifsNode.DisplayName = "CIFS";
            perfNode.DisplayName = "Performance";
            cacheManNode.DisplayName = "Cache Manager";
            freelanceNode.DisplayName = "Freelance Client";
            serversNode.DisplayName = "Servers";
            logonNode.DisplayName = "Log on options";
            diagnosticsNode.DisplayName = "Diagnostics";
            this.RootNode.Children.Add(cifsNode);
            this.RootNode.Children.Add(perfNode);
            this.RootNode.Children.Add(cacheManNode);
            this.RootNode.Children.Add(freelanceNode);
            this.RootNode.Children.Add(serversNode);
            this.RootNode.Children.Add(logonNode);
            this.RootNode.Children.Add(diagnosticsNode);

            FormViewDescription fvd = new FormViewDescription();
            fvd.DisplayName = "OpenAFS Client Manager";
            fvd.ViewType = typeof(ManagerFormView);
            fvd.ControlType = typeof(ManagerControl);

            cifsNode.ViewDescriptions.Add(fvd);
            perfNode.ViewDescriptions.Add(fvd);
            cacheManNode.ViewDescriptions.Add(fvd);
            freelanceNode.ViewDescriptions.Add(fvd);
            serversNode.ViewDescriptions.Add(fvd);
            logonNode.ViewDescriptions.Add(fvd);
            diagnosticsNode.ViewDescriptions.Add(fvd);
            this.RootNode.ViewDescriptions.Add(fvd);
        }
    }
}