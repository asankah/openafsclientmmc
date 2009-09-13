using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security;

namespace OpenAFSClientManager
{
    public partial class CifsControl : UserControl
    {
        public CifsControl()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            RegistryKey serviceParameters = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TransarcAFSDaemon\\Parameters", true);
            if ("AFS".Equals(netbiosNameTextBox.Text))
            {
                serviceParameters.DeleteValue("NetbiosName", false);
            }
            else
            {
                serviceParameters.SetValue("NetbiosName", netbiosNameTextBox.Text, RegistryValueKind.ExpandString);
            }

            if ("50".Equals(multiplexedRequestsTextBox.Text))
            {
                serviceParameters.DeleteValue("MaxMpxRequests", false);
            }
            else
            {
                serviceParameters.SetValue("MaxMpxRequests", Int32.Parse(multiplexedRequestsTextBox.Text), RegistryValueKind.DWord);
            }

            if ("100".Equals(maximumVirtualCircuitsTextBox.Text))
            {
                serviceParameters.DeleteValue("MaxVCPerServer", false);
            }
            else
            {
                serviceParameters.SetValue("MaxVCPerServer", Int32.Parse(maximumVirtualCircuitsTextBox.Text), RegistryValueKind.DWord);
            }

            if (2 == authenticationLevelComboBox.SelectedIndex)
            {
                serviceParameters.DeleteValue("smbAuthType");
            }
            else
            {
                serviceParameters.SetValue("smbAuthType", authenticationLevelComboBox.SelectedIndex, RegistryValueKind.DWord);
            }

            if (locateAdapterCheckBox.Checked)
            {
                serviceParameters.SetValue("NoFindLanaByName", 1, RegistryValueKind.DWord);
            }
            else
            {
                serviceParameters.DeleteValue("NoFindLanaByName", false);
            }
        }

        private void CifsControl_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey serviceParameters = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TransarcAFSDaemon\\Parameters");
                netbiosNameTextBox.Text = serviceParameters.GetValue("NetbiosName", "AFS") as string;
                multiplexedRequestsTextBox.Text = ((int)serviceParameters.GetValue("MaxMpxRequests", 50)).ToString();
                maximumVirtualCircuitsTextBox.Text = ((int)serviceParameters.GetValue("MaxVCPerServer", 100)).ToString();
                authenticationLevelComboBox.SelectedIndex = (int)serviceParameters.GetValue("smbAuthType", 2);
                locateAdapterCheckBox.Checked = Convert.ToBoolean((int)serviceParameters.GetValue("NoFindLanaByName", 0));
            }
            catch (SecurityException)
            {
                MessageBox.Show("You do not have access to apply these settings.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
