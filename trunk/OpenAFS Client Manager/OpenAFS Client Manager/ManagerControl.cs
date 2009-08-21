using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using Microsoft.Win32;
using System.Resources;
using OpenAFSClientManager.Properties;

namespace OpenAFSClientManager
{
    public partial class ManagerControl : UserControl
    {
        public ManagerControl()
        {
            InitializeComponent();
        }

        private void ManagerControl_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public override void Refresh()
        {
            RegistryKey clientKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\OpenAFS\\Client");
            RegistryKey daemonKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TransarcAFSDaemon\\Parameters");
            cellServDBTextBox.Text = clientKey.GetValue("CellServDBDir", "") as string;
            defaultCellTextBox.Text = clientKey.GetValue("Cell", "") as string;
            rootVolumeTextBox.Text = daemonKey.GetValue("RootVolume", "root.afs") as string;
            rootMountPointTextBox.Text = daemonKey.GetValue("MountRoot", "/afs") as string;
            sysnamesTextbox.Text = daemonKey.GetValue("SysName", "x86_win32 i386_w2k i386_nt40") as string;
            int securityValue = (int) daemonKey.GetValue("SecurityLevel", 0);
            encryptCheckBox.Checked = securityValue == 1;
            int ansiValue = (int) clientKey.GetValue("StoreAnsiFilenames", 0);
            ansiFilenamesCheckBox.Checked = ansiValue == 1;
            int hideDotValue = (int) daemonKey.GetValue("HideDotFiles", 1);
            hiddenDotFilesCheckBox.Checked = hideDotValue == 1;
            int callbackValue = (int) daemonKey.GetValue("CallBackPort", 7001);
            callbackPortTextBox.Text = callbackValue.ToString();

            clientServiceController.Refresh();
            switch (clientServiceController.Status)
            {
                case ServiceControllerStatus.Stopped:
                    startButton.Enabled = true;
                    stopButton.Enabled = false;
                    runningTextBox.Text = Resources.Stopped;
                    serviceTimer.Enabled = false;
                    break;
                case ServiceControllerStatus.Running:
                    startButton.Enabled = false;
                    stopButton.Enabled = true;
                    runningTextBox.Text = Resources.Running;
                    serviceTimer.Enabled = false;
                    break;
                case ServiceControllerStatus.StopPending:
                    startButton.Enabled = false;
                    stopButton.Enabled = false;
                    runningTextBox.Text = Resources.Stopping;
                    serviceTimer.Enabled = true;
                    break;
                case ServiceControllerStatus.StartPending:
                    startButton.Enabled = false;
                    stopButton.Enabled = false;
                    runningTextBox.Text = Resources.Starting;
                    serviceTimer.Enabled = true;
                    break;
                default:
                    throw new UnhandledStateException(clientServiceController.Status);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            clientServiceController.Start();
            Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            clientServiceController.Stop();
            Refresh();
        }

        private void serviceTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            browseFileDialog.ShowDialog();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey clientKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\OpenAFS\\Client", true);
                RegistryKey daemonKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TransarcAFSDaemon\\Parameters", true);
                clientKey.SetValue("CellServDBDir", cellServDBTextBox.Text, RegistryValueKind.String);
                clientKey.SetValue("Cell", defaultCellTextBox.Text, RegistryValueKind.String);
                daemonKey.SetValue("RootVolume", rootVolumeTextBox.Text, RegistryValueKind.String);
                daemonKey.SetValue("MountRoot", rootMountPointTextBox.Text, RegistryValueKind.String);
                daemonKey.SetValue("SysName", sysnamesTextbox.Text, RegistryValueKind.String);
                daemonKey.SetValue("SecurityLevel", Convert.ToInt32(encryptCheckBox.Checked), RegistryValueKind.DWord);
                clientKey.SetValue("StoreAnsiFilenames", Convert.ToInt32(ansiFilenamesCheckBox.Checked), RegistryValueKind.DWord);
                daemonKey.SetValue("HideDotFiles", Convert.ToInt32(hiddenDotFilesCheckBox.Checked), RegistryValueKind.DWord);
                daemonKey.SetValue("CallBackPort", Int32.Parse(callbackPortTextBox.Text), RegistryValueKind.DWord);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have the necessary access to apply these settings. Please ensure you are an AFS administrator.", "Insufficient permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cellServDBBrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = browseFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                cellServDBTextBox.Text = browseFileDialog.FileName;
            }
        }
    }
}
