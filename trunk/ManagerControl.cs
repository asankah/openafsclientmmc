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
    }
}
