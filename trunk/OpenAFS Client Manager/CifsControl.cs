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
    public partial class CifsControl : UserControl
    {
        private RegistryKey serviceParameters = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TransarcAFSDaemon\\Parameters");

        public CifsControl()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
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
        }

        private void CifsControl_Load(object sender, EventArgs e)
        {
            netbiosNameTextBox.Text = serviceParameters.GetValue("NetbiosName", "AFS") as string;
            multiplexedRequestsTextBox.Text = ((int)serviceParameters.GetValue("MaxMpxRequests", 50)).ToString();
            maximumVirtualCircuitsTextBox.Text = ((int)serviceParameters.GetValue("MaxVCPerServer", 100)).ToString();
        }
    }
}
