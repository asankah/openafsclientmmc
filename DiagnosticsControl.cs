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
    public partial class DiagnosticsControl : UserControl
    {

        public DiagnosticsControl()
        {
            InitializeComponent();
        }

        private void DiagnosticsControl_Load(object sender, EventArgs e)
        {
            RegistryKey serviceParameters = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TransarcAFSDaemon\\Parameters");
            RegistryKey clientParameters = Registry.LocalMachine.OpenSubKey("SOFTWARE\\OpenAFS\\Client");
            reportStartupCheckBox.Checked = Convert.ToBoolean((int)serviceParameters.GetValue("ReportSessionStartups", 0));
            signatureVerificationCheckBox.Checked = Convert.ToBoolean((int)clientParameters.GetValue("VerifyServiceSignature", 1));
            debugCallsCheckBox.Checked = Convert.ToBoolean((int)clientParameters.GetValue("IoctlDebug", 0));
            breakpointOnPanicCheckBox.Checked = Convert.ToBoolean((int)serviceParameters.GetValue("TrapOnPanic", 0));
            logEntriesTextBox.Text = ((int)serviceParameters.GetValue("TraceBufferSize", 10000)).ToString();
            logSizeTextBox.Text = ((int)serviceParameters.GetValue("MaxLogSize", 102400)).ToString();
            traceAsDebugOutputCheckBox.Checked = Convert.ToBoolean(((int)serviceParameters.GetValue("TraceOption", 0) & 4) >> 2);
            enableTracingCheckBox.Checked = Convert.ToBoolean(((int)serviceParameters.GetValue("TraceOption", 0) & 8) >> 3);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey serviceParameters = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TransarcAFSDaemon\\Parameters", true);
                RegistryKey clientParameters = Registry.LocalMachine.OpenSubKey("SOFTWARE\\OpenAFS\\Client", true);

                if (enableTracingCheckBox.Checked)
                {
                    serviceParameters.SetValue("TraceOption", (int)serviceParameters.GetValue("TraceOption", 0) | 8, RegistryValueKind.DWord);
                }
                else
                {
                    serviceParameters.SetValue("TraceOption", (int)serviceParameters.GetValue("TraceOption", 0) & 7, RegistryValueKind.DWord);
                }

                if (traceAsDebugOutputCheckBox.Checked)
                {
                    serviceParameters.SetValue("TraceOption", (int)serviceParameters.GetValue("TraceOption", 0) | 4, RegistryValueKind.DWord);
                }
                else
                {
                    serviceParameters.SetValue("TraceOption", (int)serviceParameters.GetValue("TraceOption", 0) & 11, RegistryValueKind.DWord);
                }

                if ("102400".Equals(logSizeTextBox.Text))
                {
                    serviceParameters.DeleteValue("MaxLogSize", false);
                }
                else
                {
                    serviceParameters.SetValue("MaxLogSize", Int32.Parse(logSizeTextBox.Text));
                }

                if ("10000".Equals(logEntriesTextBox.Text))
                {
                    serviceParameters.DeleteValue("TraceBufferSize", false);
                }
                else
                {
                    serviceParameters.SetValue("TraceBufferSize", Int32.Parse(logEntriesTextBox.Text), RegistryValueKind.DWord);
                }

                if (breakpointOnPanicCheckBox.Checked)
                {
                    serviceParameters.SetValue("TrapOnPanic", 1, RegistryValueKind.DWord);
                }
                else
                {
                    serviceParameters.DeleteValue("TrapOnPanic", false);
                }

                if (reportStartupCheckBox.Checked)
                {
                    serviceParameters.SetValue("ReportSessionStartups", 1, RegistryValueKind.DWord);
                }
                else
                {
                    serviceParameters.DeleteValue("ReportSessionStartups", false);
                }

                if (signatureVerificationCheckBox.Checked)
                {
                    clientParameters.DeleteValue("VerifyServiceSignature", false);
                }
                else
                {
                    clientParameters.SetValue("VerifyServiceSignature", 0, RegistryValueKind.DWord);
                }

                if (debugCallsCheckBox.Checked)
                {
                    clientParameters.SetValue("IoctlDebug", 1, RegistryValueKind.DWord);
                }
                else
                {
                    clientParameters.DeleteValue("IoctlDebug", false);
                }
            }
            catch (SecurityException)
            {
                MessageBox.Show("You do not have access to apply these settings.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
