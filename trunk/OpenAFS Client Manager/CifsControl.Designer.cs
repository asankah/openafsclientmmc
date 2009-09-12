namespace OpenAFSClientManager
{
    partial class CifsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CifsControl));
            this.authenticationLevelComboBox = new System.Windows.Forms.ComboBox();
            this.authenticationLevelLabel = new System.Windows.Forms.Label();
            this.maximumVirtualCircuitsTextBox = new System.Windows.Forms.TextBox();
            this.maximumVirtualCircuitsLabel = new System.Windows.Forms.Label();
            this.multiplexedRequestsTextBox = new System.Windows.Forms.TextBox();
            this.multiplexedRequestsLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.locateAdapterCheckBox = new System.Windows.Forms.CheckBox();
            this.lanAdapterLabel = new System.Windows.Forms.Label();
            this.adapterNumberComboBox = new System.Windows.Forms.ComboBox();
            this.netbiosNameTextBox = new System.Windows.Forms.TextBox();
            this.netbiosNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authenticationLevelComboBox
            // 
            this.authenticationLevelComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.authenticationLevelComboBox, "authenticationLevelComboBox");
            this.authenticationLevelComboBox.Name = "authenticationLevelComboBox";
            // 
            // authenticationLevelLabel
            // 
            resources.ApplyResources(this.authenticationLevelLabel, "authenticationLevelLabel");
            this.authenticationLevelLabel.Name = "authenticationLevelLabel";
            // 
            // maximumVirtualCircuitsTextBox
            // 
            resources.ApplyResources(this.maximumVirtualCircuitsTextBox, "maximumVirtualCircuitsTextBox");
            this.maximumVirtualCircuitsTextBox.Name = "maximumVirtualCircuitsTextBox";
            // 
            // maximumVirtualCircuitsLabel
            // 
            resources.ApplyResources(this.maximumVirtualCircuitsLabel, "maximumVirtualCircuitsLabel");
            this.maximumVirtualCircuitsLabel.Name = "maximumVirtualCircuitsLabel";
            // 
            // multiplexedRequestsTextBox
            // 
            resources.ApplyResources(this.multiplexedRequestsTextBox, "multiplexedRequestsTextBox");
            this.multiplexedRequestsTextBox.Name = "multiplexedRequestsTextBox";
            // 
            // multiplexedRequestsLabel
            // 
            resources.ApplyResources(this.multiplexedRequestsLabel, "multiplexedRequestsLabel");
            this.multiplexedRequestsLabel.Name = "multiplexedRequestsLabel";
            // 
            // applyButton
            // 
            resources.ApplyResources(this.applyButton, "applyButton");
            this.applyButton.Name = "applyButton";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // locateAdapterCheckBox
            // 
            resources.ApplyResources(this.locateAdapterCheckBox, "locateAdapterCheckBox");
            this.locateAdapterCheckBox.Name = "locateAdapterCheckBox";
            this.locateAdapterCheckBox.UseVisualStyleBackColor = true;
            // 
            // lanAdapterLabel
            // 
            resources.ApplyResources(this.lanAdapterLabel, "lanAdapterLabel");
            this.lanAdapterLabel.Name = "lanAdapterLabel";
            // 
            // adapterNumberComboBox
            // 
            this.adapterNumberComboBox.FormattingEnabled = true;
            this.adapterNumberComboBox.Items.AddRange(new object[] {
            resources.GetString("adapterNumberComboBox.Items")});
            resources.ApplyResources(this.adapterNumberComboBox, "adapterNumberComboBox");
            this.adapterNumberComboBox.Name = "adapterNumberComboBox";
            // 
            // netbiosNameTextBox
            // 
            resources.ApplyResources(this.netbiosNameTextBox, "netbiosNameTextBox");
            this.netbiosNameTextBox.Name = "netbiosNameTextBox";
            // 
            // netbiosNameLabel
            // 
            resources.ApplyResources(this.netbiosNameLabel, "netbiosNameLabel");
            this.netbiosNameLabel.Name = "netbiosNameLabel";
            // 
            // CifsControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.authenticationLevelComboBox);
            this.Controls.Add(this.authenticationLevelLabel);
            this.Controls.Add(this.maximumVirtualCircuitsTextBox);
            this.Controls.Add(this.maximumVirtualCircuitsLabel);
            this.Controls.Add(this.multiplexedRequestsTextBox);
            this.Controls.Add(this.multiplexedRequestsLabel);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.locateAdapterCheckBox);
            this.Controls.Add(this.lanAdapterLabel);
            this.Controls.Add(this.adapterNumberComboBox);
            this.Controls.Add(this.netbiosNameTextBox);
            this.Controls.Add(this.netbiosNameLabel);
            this.Name = "CifsControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox authenticationLevelComboBox;
        private System.Windows.Forms.Label authenticationLevelLabel;
        private System.Windows.Forms.TextBox maximumVirtualCircuitsTextBox;
        private System.Windows.Forms.Label maximumVirtualCircuitsLabel;
        private System.Windows.Forms.TextBox multiplexedRequestsTextBox;
        private System.Windows.Forms.Label multiplexedRequestsLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox locateAdapterCheckBox;
        private System.Windows.Forms.Label lanAdapterLabel;
        private System.Windows.Forms.ComboBox adapterNumberComboBox;
        private System.Windows.Forms.TextBox netbiosNameTextBox;
        private System.Windows.Forms.Label netbiosNameLabel;

    }
}
