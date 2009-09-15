namespace OpenAFSClientManager
{
    partial class DiagnosticsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosticsControl));
            this.debugCallsCheckBox = new System.Windows.Forms.CheckBox();
            this.signatureVerificationCheckBox = new System.Windows.Forms.CheckBox();
            this.tracingGroupBox = new System.Windows.Forms.GroupBox();
            this.reportStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.logSizeTextBox = new System.Windows.Forms.TextBox();
            this.logSizeLabel = new System.Windows.Forms.Label();
            this.logEntriesTextBox = new System.Windows.Forms.TextBox();
            this.logEntriesLabel = new System.Windows.Forms.Label();
            this.traceAsDebugOutputCheckBox = new System.Windows.Forms.CheckBox();
            this.enableTracingCheckBox = new System.Windows.Forms.CheckBox();
            this.breakpointOnPanicCheckBox = new System.Windows.Forms.CheckBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.tracingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // debugCallsCheckBox
            // 
            resources.ApplyResources(this.debugCallsCheckBox, "debugCallsCheckBox");
            this.debugCallsCheckBox.Name = "debugCallsCheckBox";
            this.debugCallsCheckBox.UseVisualStyleBackColor = true;
            // 
            // signatureVerificationCheckBox
            // 
            resources.ApplyResources(this.signatureVerificationCheckBox, "signatureVerificationCheckBox");
            this.signatureVerificationCheckBox.Name = "signatureVerificationCheckBox";
            this.signatureVerificationCheckBox.UseVisualStyleBackColor = true;
            // 
            // tracingGroupBox
            // 
            resources.ApplyResources(this.tracingGroupBox, "tracingGroupBox");
            this.tracingGroupBox.Controls.Add(this.reportStartupCheckBox);
            this.tracingGroupBox.Controls.Add(this.logSizeTextBox);
            this.tracingGroupBox.Controls.Add(this.logSizeLabel);
            this.tracingGroupBox.Controls.Add(this.logEntriesTextBox);
            this.tracingGroupBox.Controls.Add(this.logEntriesLabel);
            this.tracingGroupBox.Controls.Add(this.traceAsDebugOutputCheckBox);
            this.tracingGroupBox.Controls.Add(this.enableTracingCheckBox);
            this.tracingGroupBox.Name = "tracingGroupBox";
            this.tracingGroupBox.TabStop = false;
            // 
            // reportStartupCheckBox
            // 
            resources.ApplyResources(this.reportStartupCheckBox, "reportStartupCheckBox");
            this.reportStartupCheckBox.Name = "reportStartupCheckBox";
            this.reportStartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // logSizeTextBox
            // 
            resources.ApplyResources(this.logSizeTextBox, "logSizeTextBox");
            this.logSizeTextBox.Name = "logSizeTextBox";
            // 
            // logSizeLabel
            // 
            resources.ApplyResources(this.logSizeLabel, "logSizeLabel");
            this.logSizeLabel.Name = "logSizeLabel";
            // 
            // logEntriesTextBox
            // 
            resources.ApplyResources(this.logEntriesTextBox, "logEntriesTextBox");
            this.logEntriesTextBox.Name = "logEntriesTextBox";
            // 
            // logEntriesLabel
            // 
            resources.ApplyResources(this.logEntriesLabel, "logEntriesLabel");
            this.logEntriesLabel.Name = "logEntriesLabel";
            // 
            // traceAsDebugOutputCheckBox
            // 
            resources.ApplyResources(this.traceAsDebugOutputCheckBox, "traceAsDebugOutputCheckBox");
            this.traceAsDebugOutputCheckBox.Name = "traceAsDebugOutputCheckBox";
            this.traceAsDebugOutputCheckBox.UseVisualStyleBackColor = true;
            // 
            // enableTracingCheckBox
            // 
            resources.ApplyResources(this.enableTracingCheckBox, "enableTracingCheckBox");
            this.enableTracingCheckBox.Name = "enableTracingCheckBox";
            this.enableTracingCheckBox.UseVisualStyleBackColor = true;
            // 
            // breakpointOnPanicCheckBox
            // 
            resources.ApplyResources(this.breakpointOnPanicCheckBox, "breakpointOnPanicCheckBox");
            this.breakpointOnPanicCheckBox.Name = "breakpointOnPanicCheckBox";
            this.breakpointOnPanicCheckBox.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            resources.ApplyResources(this.applyButton, "applyButton");
            this.applyButton.Name = "applyButton";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // DiagnosticsControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.debugCallsCheckBox);
            this.Controls.Add(this.signatureVerificationCheckBox);
            this.Controls.Add(this.tracingGroupBox);
            this.Controls.Add(this.breakpointOnPanicCheckBox);
            this.Controls.Add(this.applyButton);
            this.Name = "DiagnosticsControl";
            this.Load += new System.EventHandler(this.DiagnosticsControl_Load);
            this.tracingGroupBox.ResumeLayout(false);
            this.tracingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox debugCallsCheckBox;
        private System.Windows.Forms.CheckBox signatureVerificationCheckBox;
        private System.Windows.Forms.GroupBox tracingGroupBox;
        private System.Windows.Forms.CheckBox reportStartupCheckBox;
        private System.Windows.Forms.TextBox logSizeTextBox;
        private System.Windows.Forms.Label logSizeLabel;
        private System.Windows.Forms.TextBox logEntriesTextBox;
        private System.Windows.Forms.Label logEntriesLabel;
        private System.Windows.Forms.CheckBox traceAsDebugOutputCheckBox;
        private System.Windows.Forms.CheckBox enableTracingCheckBox;
        private System.Windows.Forms.CheckBox breakpointOnPanicCheckBox;
        private System.Windows.Forms.Button applyButton;
    }
}
