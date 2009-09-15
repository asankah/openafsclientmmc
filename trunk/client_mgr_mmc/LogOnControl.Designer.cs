namespace OpenAFSClientManager
{
    partial class LogOnControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogOnControl));
            this.newDomainButton = new System.Windows.Forms.Button();
            this.preserveTokensCheckBox = new System.Windows.Forms.CheckBox();
            this.cellsTreeView = new System.Windows.Forms.TreeView();
            this.cellOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.cellsUpdateButton = new System.Windows.Forms.Button();
            this.cellsRemoveButton = new System.Windows.Forms.Button();
            this.cellsTextBox = new System.Windows.Forms.TextBox();
            this.cellsLabel = new System.Windows.Forms.Label();
            this.loginFailGroupBox = new System.Windows.Forms.GroupBox();
            this.quitTextBox = new System.Windows.Forms.TextBox();
            this.quitLabel = new System.Windows.Forms.Label();
            this.retryTextBox = new System.Windows.Forms.TextBox();
            this.retryLabel = new System.Windows.Forms.Label();
            this.silenceErrorsCheckBox = new System.Windows.Forms.CheckBox();
            this.automaticLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.cellOptionsGroupBox.SuspendLayout();
            this.loginFailGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newDomainButton
            // 
            resources.ApplyResources(this.newDomainButton, "newDomainButton");
            this.newDomainButton.Name = "newDomainButton";
            this.newDomainButton.UseVisualStyleBackColor = true;
            // 
            // preserveTokensCheckBox
            // 
            resources.ApplyResources(this.preserveTokensCheckBox, "preserveTokensCheckBox");
            this.preserveTokensCheckBox.Name = "preserveTokensCheckBox";
            this.preserveTokensCheckBox.UseVisualStyleBackColor = true;
            // 
            // cellsTreeView
            // 
            resources.ApplyResources(this.cellsTreeView, "cellsTreeView");
            this.cellsTreeView.Name = "cellsTreeView";
            // 
            // cellOptionsGroupBox
            // 
            this.cellOptionsGroupBox.Controls.Add(this.cellsUpdateButton);
            this.cellOptionsGroupBox.Controls.Add(this.cellsRemoveButton);
            this.cellOptionsGroupBox.Controls.Add(this.cellsTextBox);
            this.cellOptionsGroupBox.Controls.Add(this.cellsLabel);
            this.cellOptionsGroupBox.Controls.Add(this.loginFailGroupBox);
            this.cellOptionsGroupBox.Controls.Add(this.automaticLoginCheckBox);
            resources.ApplyResources(this.cellOptionsGroupBox, "cellOptionsGroupBox");
            this.cellOptionsGroupBox.Name = "cellOptionsGroupBox";
            this.cellOptionsGroupBox.TabStop = false;
            // 
            // cellsUpdateButton
            // 
            resources.ApplyResources(this.cellsUpdateButton, "cellsUpdateButton");
            this.cellsUpdateButton.Name = "cellsUpdateButton";
            this.cellsUpdateButton.UseVisualStyleBackColor = true;
            // 
            // cellsRemoveButton
            // 
            resources.ApplyResources(this.cellsRemoveButton, "cellsRemoveButton");
            this.cellsRemoveButton.Name = "cellsRemoveButton";
            this.cellsRemoveButton.UseVisualStyleBackColor = true;
            // 
            // cellsTextBox
            // 
            resources.ApplyResources(this.cellsTextBox, "cellsTextBox");
            this.cellsTextBox.Name = "cellsTextBox";
            // 
            // cellsLabel
            // 
            resources.ApplyResources(this.cellsLabel, "cellsLabel");
            this.cellsLabel.Name = "cellsLabel";
            // 
            // loginFailGroupBox
            // 
            resources.ApplyResources(this.loginFailGroupBox, "loginFailGroupBox");
            this.loginFailGroupBox.Controls.Add(this.quitTextBox);
            this.loginFailGroupBox.Controls.Add(this.quitLabel);
            this.loginFailGroupBox.Controls.Add(this.retryTextBox);
            this.loginFailGroupBox.Controls.Add(this.retryLabel);
            this.loginFailGroupBox.Controls.Add(this.silenceErrorsCheckBox);
            this.loginFailGroupBox.Name = "loginFailGroupBox";
            this.loginFailGroupBox.TabStop = false;
            // 
            // quitTextBox
            // 
            resources.ApplyResources(this.quitTextBox, "quitTextBox");
            this.quitTextBox.Name = "quitTextBox";
            // 
            // quitLabel
            // 
            resources.ApplyResources(this.quitLabel, "quitLabel");
            this.quitLabel.Name = "quitLabel";
            // 
            // retryTextBox
            // 
            resources.ApplyResources(this.retryTextBox, "retryTextBox");
            this.retryTextBox.Name = "retryTextBox";
            // 
            // retryLabel
            // 
            resources.ApplyResources(this.retryLabel, "retryLabel");
            this.retryLabel.Name = "retryLabel";
            // 
            // silenceErrorsCheckBox
            // 
            resources.ApplyResources(this.silenceErrorsCheckBox, "silenceErrorsCheckBox");
            this.silenceErrorsCheckBox.Name = "silenceErrorsCheckBox";
            this.silenceErrorsCheckBox.UseVisualStyleBackColor = true;
            // 
            // automaticLoginCheckBox
            // 
            resources.ApplyResources(this.automaticLoginCheckBox, "automaticLoginCheckBox");
            this.automaticLoginCheckBox.Name = "automaticLoginCheckBox";
            this.automaticLoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            resources.ApplyResources(this.applyButton, "applyButton");
            this.applyButton.Name = "applyButton";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // LogOnControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newDomainButton);
            this.Controls.Add(this.preserveTokensCheckBox);
            this.Controls.Add(this.cellsTreeView);
            this.Controls.Add(this.cellOptionsGroupBox);
            this.Controls.Add(this.applyButton);
            this.Name = "LogOnControl";
            this.cellOptionsGroupBox.ResumeLayout(false);
            this.cellOptionsGroupBox.PerformLayout();
            this.loginFailGroupBox.ResumeLayout(false);
            this.loginFailGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newDomainButton;
        private System.Windows.Forms.CheckBox preserveTokensCheckBox;
        private System.Windows.Forms.TreeView cellsTreeView;
        private System.Windows.Forms.GroupBox cellOptionsGroupBox;
        private System.Windows.Forms.Button cellsUpdateButton;
        private System.Windows.Forms.Button cellsRemoveButton;
        private System.Windows.Forms.TextBox cellsTextBox;
        private System.Windows.Forms.Label cellsLabel;
        private System.Windows.Forms.GroupBox loginFailGroupBox;
        private System.Windows.Forms.TextBox quitTextBox;
        private System.Windows.Forms.Label quitLabel;
        private System.Windows.Forms.TextBox retryTextBox;
        private System.Windows.Forms.Label retryLabel;
        private System.Windows.Forms.CheckBox silenceErrorsCheckBox;
        private System.Windows.Forms.CheckBox automaticLoginCheckBox;
        private System.Windows.Forms.Button applyButton;
    }
}
