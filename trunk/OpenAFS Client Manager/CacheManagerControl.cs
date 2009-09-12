using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace OpenAFSClientManager
{
    public partial class CacheManagerControl : UserControl
    {
        private RegistryKey clientKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\OpenAFS\\Client");
        private RegistryKey serviceParameters = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TransarcAFSDaemon\\Parameters");

        public CacheManagerControl()
        {
            InitializeComponent();
        }

        private void CacheManagerControl_Load(object sender, EventArgs e)
        {
            cellServDBTextBox.Text = clientKey.GetValue("CellServDBDir", "(undefined)") as string;
            defaultCellTextBox.Text = serviceParameters.GetValue("Cell", "(none)") as string;
            rootVolumeTextBox.Text = serviceParameters.GetValue("RootVolume", "root.afs") as string;
            rootMountPointTextBox.Text = serviceParameters.GetValue("MountRoot", "/afs") as string;
#if x86
            sysnamesTextbox.Text = serviceParameters.GetValue("SysName", "x86_win32 i386_w2k i386_nt40") as string;
#elif x64
            sysnamesTextbox.Text = serviceParameters.GetValue("SysName", "amd64_win64 x86_win32 i386_w2k") as string;
#else
#error Neither x86 nor x64 are defined.
#endif
            encryptCheckBox.Checked = Convert.ToBoolean((int)serviceParameters.GetValue("SecurityLevel", 0));
            hiddenDotFilesCheckBox.Checked = Convert.ToBoolean((int)serviceParameters.GetValue("HideDotFiles", 1));
            callbackPortTextBox.Text = ((int)serviceParameters.GetValue("CallBackPort", 7001)).ToString();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if ("(undefined)".Equals(cellServDBTextBox.Text))
            {
                clientKey.DeleteValue("CellServDBDir", false);
            }
            else
            {
                clientKey.SetValue("CellServDBDir", cellServDBTextBox.Text, RegistryValueKind.String);
            }

            if ("(none)".Equals(defaultCellTextBox.Text))
            {
                serviceParameters.DeleteValue("Cell", false);
            }
            else
            {
                serviceParameters.SetValue("Cell", defaultCellTextBox.Text, RegistryValueKind.String);
            }

            if ("root.afs".Equals(rootVolumeTextBox.Text))
            {
                serviceParameters.DeleteValue("RootVolume", false);
            }
            else
            {
                serviceParameters.SetValue("RootVolume", rootVolumeTextBox.Text, RegistryValueKind.String);
            }

            if ("/afs".Equals(rootMountPointTextBox.Text))
            {
                serviceParameters.DeleteValue("MountRoot", false);
            }
            else
            {
                serviceParameters.SetValue("MountRoot", rootMountPointTextBox.Text, RegistryValueKind.String);
            }

#if x86
            if ("x86_win32 i386_w2k i386_nt40".Equals(sysnamesTextbox.Text))
#elif x64
            if ("amd64_win64 x86_win32 i386_w2k".Equals(sysnamesTextbox.Text))
#else
#error Neither x86 nor x64 are defined.
#endif
            {
                serviceParameters.DeleteValue("SysName", false);
            }
            else
            {
                serviceParameters.SetValue("SysName", sysnamesTextbox.Text, RegistryValueKind.String);
            }

            if (encryptCheckBox.Checked)
            {
                serviceParameters.SetValue("SecurityLevel", Convert.ToInt32(encryptCheckBox.Checked), RegistryValueKind.DWord);
            }
            else
            {
                serviceParameters.DeleteValue("SecurityLevel", false);
            }

            if (hiddenDotFilesCheckBox.Checked)
            {
                serviceParameters.DeleteValue("HideDotFiles", false);
            }
            else
            {
                serviceParameters.SetValue("HideDotFiles", Convert.ToInt32(hiddenDotFilesCheckBox.Checked), RegistryValueKind.DWord);
            }

            if ("7001".Equals(callbackPortTextBox.Text))
            {
                serviceParameters.DeleteValue("CallBackPort", false);
            }
            else
            {
                serviceParameters.SetValue("CallBackPort", Int32.Parse(callbackPortTextBox.Text), RegistryValueKind.DWord);
            }
        }

        private void cellServDBBrowseButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == directoryBrowserDialog.ShowDialog())
            {
                cellServDBTextBox.Text = directoryBrowserDialog.SelectedPath;
            }
        }
    }
}
