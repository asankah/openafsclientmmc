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
    public partial class FreelanceClientControl : UserControl
    {
        public FreelanceClientControl()
        {
            InitializeComponent();
        }

        private void FreelanceClientControl_Load(object sender, EventArgs e)
        {
            RegistryKey serviceParameters = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TransarcAFSDaemon\\Parameters");
            enableFreelanceCheckBox.Checked = Convert.ToBoolean((int)serviceParameters.GetValue("FreelanceClient", 0));
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey serviceParameters = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TransarcAFSDaemon\\Parameters", true);
                if (enableFreelanceCheckBox.Checked)
                {
                    serviceParameters.SetValue("FreelanceClient", 1, RegistryValueKind.DWord);
                }
                else
                {
                    serviceParameters.DeleteValue("FreelanceClient", false);
                }
            }
            catch (SecurityException)
            {
                MessageBox.Show("You do not have access to apply these settings.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
