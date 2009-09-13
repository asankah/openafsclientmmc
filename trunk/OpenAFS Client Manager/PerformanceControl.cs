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
    public partial class PerformanceControl : UserControl
    {
        public PerformanceControl()
        {
            InitializeComponent();
        }

        private void PerformanceControl_Load(object sender, EventArgs e)
        {
            RegistryKey serviceParameters = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TransarcAFSDaemon\\Parameters");
            cacheSizeTextBox.Text = ((int)serviceParameters.GetValue("CacheSize", 98304)).ToString();
            chunkSizeTextBox.Text = ((int)serviceParameters.GetValue("ChunkSize", 20)).ToString();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey serviceParameters = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TransarcAFSDaemon\\Parameters", true);
                if ("20".Equals(chunkSizeTextBox.Text))
                {
                    serviceParameters.DeleteValue("CacheSize", false);
                }
                else
                {
                    serviceParameters.SetValue("CacheSize", Int32.Parse(chunkSizeTextBox.Text));
                }

                if ("98304".Equals(cacheSizeTextBox.Text))
                {
                    serviceParameters.DeleteValue("CacheSize", false);
                }
                else
                {
                    serviceParameters.SetValue("CacheSize", Int32.Parse(cacheSizeTextBox.Text));
                }
            }
            catch (SecurityException)
            {
                MessageBox.Show("You do not have access to apply these settings.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
