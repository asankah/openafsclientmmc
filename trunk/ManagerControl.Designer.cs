namespace OpenAFSClientManager
{
    partial class ManagerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerControl));
            this.serviceTimer = new System.Windows.Forms.Timer(this.components);
            this.clientServiceController = new System.ServiceProcess.ServiceController();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clientServiceGroupBox = new System.Windows.Forms.GroupBox();
            this.manageGroupButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.runningTextBox = new System.Windows.Forms.TextBox();
            this.runningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.clientServiceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceTimer
            // 
            this.serviceTimer.Interval = 2000;
            this.serviceTimer.Tick += new System.EventHandler(this.serviceTimer_Tick);
            // 
            // clientServiceController
            // 
            this.clientServiceController.ServiceName = "TransarcAFSDaemon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OpenAFSClientManager.Properties.Resources.bannrbmp;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // clientServiceGroupBox
            // 
            resources.ApplyResources(this.clientServiceGroupBox, "clientServiceGroupBox");
            this.clientServiceGroupBox.Controls.Add(this.manageGroupButton);
            this.clientServiceGroupBox.Controls.Add(this.stopButton);
            this.clientServiceGroupBox.Controls.Add(this.startButton);
            this.clientServiceGroupBox.Controls.Add(this.runningTextBox);
            this.clientServiceGroupBox.Controls.Add(this.runningLabel);
            this.clientServiceGroupBox.Name = "clientServiceGroupBox";
            this.clientServiceGroupBox.TabStop = false;
            // 
            // manageGroupButton
            // 
            resources.ApplyResources(this.manageGroupButton, "manageGroupButton");
            this.manageGroupButton.Name = "manageGroupButton";
            this.manageGroupButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // runningTextBox
            // 
            resources.ApplyResources(this.runningTextBox, "runningTextBox");
            this.runningTextBox.Name = "runningTextBox";
            // 
            // runningLabel
            // 
            resources.ApplyResources(this.runningLabel, "runningLabel");
            this.runningLabel.Name = "runningLabel";
            // 
            // ManagerControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientServiceGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManagerControl";
            this.Load += new System.EventHandler(this.ManagerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.clientServiceGroupBox.ResumeLayout(false);
            this.clientServiceGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer serviceTimer;
        private System.ServiceProcess.ServiceController clientServiceController;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox clientServiceGroupBox;
        private System.Windows.Forms.Button manageGroupButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox runningTextBox;
        private System.Windows.Forms.Label runningLabel;
    }
}
