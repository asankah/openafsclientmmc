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
    [SnapInHelpTopic("OpenAFS Client Manager.chm")]
    [SnapInLinkedHelpTopic("OpenAFS Client Manager.chm")]
    public class ManagerSnapIn : SnapIn
    {
        public ManagerSnapIn()
        {
            this.RootNode = new ScopeNode();
            this.RootNode.DisplayName = "OpenAFS Client Manager";
            this.RootNode.HelpTopic = "OpenAFS%20Client%20Manager.chm::/OpenAFS%20Client%20Manager.htm";

            ScopeNode cifsNode = new ScopeNode(true);
            ScopeNode perfNode = new ScopeNode(true);
            ScopeNode cacheManNode = new ScopeNode(true);
            ScopeNode freelanceNode = new ScopeNode(true);
            ScopeNode serversNode = new ScopeNode(true);
            ScopeNode logonNode = new ScopeNode(true);
            ScopeNode diagnosticsNode = new ScopeNode(true);
            cifsNode.DisplayName = "CIFS";
            cifsNode.HelpTopic = "OpenAFS%20Client%20Manager.chm::/CIFS.htm";
            perfNode.DisplayName = "Performance";
            perfNode.HelpTopic = "OpenAFS%20Client%20Manager.chm::/Performance.htm";
            cacheManNode.DisplayName = "Cache Manager";
            cacheManNode.HelpTopic = "OpenAFS%20Client%20Manager.chm::/Cache%20Manager.htm";
            freelanceNode.DisplayName = "Freelance Client";
            freelanceNode.HelpTopic = "OpenAFS%20Client%20Manager.chm::/Freelance%20Client.htm";
            serversNode.DisplayName = "Servers";
            serversNode.HelpTopic = "OpenAFS%20Client%20Manager.chm::/Servers.htm";
            logonNode.DisplayName = "Log on options";
            logonNode.HelpTopic = "OpenAFS%20Client%20Manager.chm::/Log on options.htm";
            diagnosticsNode.DisplayName = "Diagnostics";
            diagnosticsNode.HelpTopic = "OpenAFS%20Client%20Manager.chm::/Diagnostics.htm";
            this.RootNode.Children.Add(cifsNode);
            this.RootNode.Children.Add(perfNode);
            this.RootNode.Children.Add(cacheManNode);
            this.RootNode.Children.Add(freelanceNode);
            this.RootNode.Children.Add(serversNode);
            this.RootNode.Children.Add(logonNode);
            this.RootNode.Children.Add(diagnosticsNode);

            FormViewDescription fvd = new FormViewDescription(typeof(ManagerControl));
            fvd.DisplayName = "OpenAFS Client Manager";
            fvd.ViewType = typeof(ManagerFormView);

            FormViewDescription cifsFvd = new FormViewDescription(typeof(CifsControl));
            cifsFvd.DisplayName = "CIFS";

            FormViewDescription perfFvd = new FormViewDescription(typeof(PerformanceControl));
            perfFvd.DisplayName = "Performance";

            FormViewDescription cacheManFvd = new FormViewDescription(typeof(CacheManagerControl));
            cacheManFvd.DisplayName = "Cache Manager";

            FormViewDescription freelanceFvd = new FormViewDescription(typeof(FreelanceClientControl));
            freelanceFvd.DisplayName = "Freelance Client";

            FormViewDescription serversFvd = new FormViewDescription(typeof(ServersControl));
            serversFvd.DisplayName = "Servers";

            FormViewDescription logonFvd = new FormViewDescription(typeof(LogOnControl));
            logonFvd.DisplayName = "Log on options";
            
            FormViewDescription diagnosticsFvd = new FormViewDescription(typeof(DiagnosticsControl));
            diagnosticsFvd.DisplayName = "Diagnostics";

            cifsNode.ViewDescriptions.Add(cifsFvd);
            perfNode.ViewDescriptions.Add(perfFvd);
            cacheManNode.ViewDescriptions.Add(cacheManFvd);
            freelanceNode.ViewDescriptions.Add(freelanceFvd);
            serversNode.ViewDescriptions.Add(serversFvd);
            logonNode.ViewDescriptions.Add(logonFvd);
            diagnosticsNode.ViewDescriptions.Add(diagnosticsFvd);
            this.RootNode.ViewDescriptions.Add(fvd);
        }
    }
}