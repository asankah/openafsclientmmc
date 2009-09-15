namespace OpenAFSClientManager
{
    partial class CacheManagerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CacheManagerControl));
            this.callbackPortTextBox = new System.Windows.Forms.TextBox();
            this.callbackPortLabel = new System.Windows.Forms.Label();
            this.rootVolumeTextBox = new System.Windows.Forms.TextBox();
            this.rootVolumeLabel = new System.Windows.Forms.Label();
            this.defaultCellTextBox = new System.Windows.Forms.TextBox();
            this.defaultCellLabel = new System.Windows.Forms.Label();
            this.cellServDBBrowseButton = new System.Windows.Forms.Button();
            this.cellServDBTextBox = new System.Windows.Forms.TextBox();
            this.cellServDBLabel = new System.Windows.Forms.Label();
            this.encryptCheckBox = new System.Windows.Forms.CheckBox();
            this.sysnamesTextbox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.hiddenDotFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.sysnamesLabel = new System.Windows.Forms.Label();
            this.rootMountPointTextBox = new System.Windows.Forms.TextBox();
            this.rootMountPointLabel = new System.Windows.Forms.Label();
            this.directoryBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // callbackPortTextBox
            // 
            resources.ApplyResources(this.callbackPortTextBox, "callbackPortTextBox");
            this.callbackPortTextBox.Name = "callbackPortTextBox";
            // 
            // callbackPortLabel
            // 
            resources.ApplyResources(this.callbackPortLabel, "callbackPortLabel");
            this.callbackPortLabel.Name = "callbackPortLabel";
            // 
            // rootVolumeTextBox
            // 
            resources.ApplyResources(this.rootVolumeTextBox, "rootVolumeTextBox");
            this.rootVolumeTextBox.Name = "rootVolumeTextBox";
            // 
            // rootVolumeLabel
            // 
            resources.ApplyResources(this.rootVolumeLabel, "rootVolumeLabel");
            this.rootVolumeLabel.Name = "rootVolumeLabel";
            // 
            // defaultCellTextBox
            // 
            resources.ApplyResources(this.defaultCellTextBox, "defaultCellTextBox");
            this.defaultCellTextBox.Name = "defaultCellTextBox";
            // 
            // defaultCellLabel
            // 
            resources.ApplyResources(this.defaultCellLabel, "defaultCellLabel");
            this.defaultCellLabel.Name = "defaultCellLabel";
            // 
            // cellServDBBrowseButton
            // 
            resources.ApplyResources(this.cellServDBBrowseButton, "cellServDBBrowseButton");
            this.cellServDBBrowseButton.Name = "cellServDBBrowseButton";
            this.cellServDBBrowseButton.UseVisualStyleBackColor = true;
            this.cellServDBBrowseButton.Click += new System.EventHandler(this.cellServDBBrowseButton_Click);
            // 
            // cellServDBTextBox
            // 
            resources.ApplyResources(this.cellServDBTextBox, "cellServDBTextBox");
            this.cellServDBTextBox.Name = "cellServDBTextBox";
            // 
            // cellServDBLabel
            // 
            resources.ApplyResources(this.cellServDBLabel, "cellServDBLabel");
            this.cellServDBLabel.Name = "cellServDBLabel";
            // 
            // encryptCheckBox
            // 
            resources.ApplyResources(this.encryptCheckBox, "encryptCheckBox");
            this.encryptCheckBox.Name = "encryptCheckBox";
            this.encryptCheckBox.UseVisualStyleBackColor = true;
            // 
            // sysnamesTextbox
            // 
            resources.ApplyResources(this.sysnamesTextbox, "sysnamesTextbox");
            this.sysnamesTextbox.Name = "sysnamesTextbox";
            // 
            // applyButton
            // 
            resources.ApplyResources(this.applyButton, "applyButton");
            this.applyButton.Name = "applyButton";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // hiddenDotFilesCheckBox
            // 
            resources.ApplyResources(this.hiddenDotFilesCheckBox, "hiddenDotFilesCheckBox");
            this.hiddenDotFilesCheckBox.Name = "hiddenDotFilesCheckBox";
            this.hiddenDotFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // sysnamesLabel
            // 
            resources.ApplyResources(this.sysnamesLabel, "sysnamesLabel");
            this.sysnamesLabel.Name = "sysnamesLabel";
            // 
            // rootMountPointTextBox
            // 
            resources.ApplyResources(this.rootMountPointTextBox, "rootMountPointTextBox");
            this.rootMountPointTextBox.Name = "rootMountPointTextBox";
            // 
            // rootMountPointLabel
            // 
            resources.ApplyResources(this.rootMountPointLabel, "rootMountPointLabel");
            this.rootMountPointLabel.Name = "rootMountPointLabel";
            // 
            // CacheManagerControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.callbackPortTextBox);
            this.Controls.Add(this.callbackPortLabel);
            this.Controls.Add(this.rootVolumeTextBox);
            this.Controls.Add(this.rootVolumeLabel);
            this.Controls.Add(this.defaultCellTextBox);
            this.Controls.Add(this.defaultCellLabel);
            this.Controls.Add(this.cellServDBBrowseButton);
            this.Controls.Add(this.cellServDBTextBox);
            this.Controls.Add(this.cellServDBLabel);
            this.Controls.Add(this.encryptCheckBox);
            this.Controls.Add(this.sysnamesTextbox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.hiddenDotFilesCheckBox);
            this.Controls.Add(this.sysnamesLabel);
            this.Controls.Add(this.rootMountPointTextBox);
            this.Controls.Add(this.rootMountPointLabel);
            this.Name = "CacheManagerControl";
            this.Load += new System.EventHandler(this.CacheManagerControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox callbackPortTextBox;
        private System.Windows.Forms.Label callbackPortLabel;
        private System.Windows.Forms.TextBox rootVolumeTextBox;
        private System.Windows.Forms.Label rootVolumeLabel;
        private System.Windows.Forms.TextBox defaultCellTextBox;
        private System.Windows.Forms.Label defaultCellLabel;
        private System.Windows.Forms.Button cellServDBBrowseButton;
        private System.Windows.Forms.TextBox cellServDBTextBox;
        private System.Windows.Forms.Label cellServDBLabel;
        private System.Windows.Forms.CheckBox encryptCheckBox;
        private System.Windows.Forms.TextBox sysnamesTextbox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox hiddenDotFilesCheckBox;
        private System.Windows.Forms.Label sysnamesLabel;
        private System.Windows.Forms.TextBox rootMountPointTextBox;
        private System.Windows.Forms.Label rootMountPointLabel;
        private System.Windows.Forms.FolderBrowserDialog directoryBrowserDialog;
    }
}
