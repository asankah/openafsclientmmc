namespace OpenAFSClientManager
{
    partial class ServersControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServersControl));
            this.serverRemoveButton = new System.Windows.Forms.Button();
            this.serverAddButton = new System.Windows.Forms.Button();
            this.volumeServerRadioButton = new System.Windows.Forms.RadioButton();
            this.fileServerRadioButton = new System.Windows.Forms.RadioButton();
            this.rankTextBox = new System.Windows.Forms.TextBox();
            this.rankLabel = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.serverLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.volumeServersCheckBox = new System.Windows.Forms.CheckBox();
            this.fileServersCheckBox = new System.Windows.Forms.CheckBox();
            this.serversDataGridView = new System.Windows.Forms.DataGridView();
            this.serverColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // serverRemoveButton
            // 
            resources.ApplyResources(this.serverRemoveButton, "serverRemoveButton");
            this.serverRemoveButton.Name = "serverRemoveButton";
            this.serverRemoveButton.UseVisualStyleBackColor = true;
            // 
            // serverAddButton
            // 
            resources.ApplyResources(this.serverAddButton, "serverAddButton");
            this.serverAddButton.Name = "serverAddButton";
            this.serverAddButton.UseVisualStyleBackColor = true;
            // 
            // volumeServerRadioButton
            // 
            resources.ApplyResources(this.volumeServerRadioButton, "volumeServerRadioButton");
            this.volumeServerRadioButton.Name = "volumeServerRadioButton";
            this.volumeServerRadioButton.TabStop = true;
            this.volumeServerRadioButton.UseVisualStyleBackColor = true;
            // 
            // fileServerRadioButton
            // 
            resources.ApplyResources(this.fileServerRadioButton, "fileServerRadioButton");
            this.fileServerRadioButton.Name = "fileServerRadioButton";
            this.fileServerRadioButton.TabStop = true;
            this.fileServerRadioButton.UseVisualStyleBackColor = true;
            // 
            // rankTextBox
            // 
            resources.ApplyResources(this.rankTextBox, "rankTextBox");
            this.rankTextBox.Name = "rankTextBox";
            // 
            // rankLabel
            // 
            resources.ApplyResources(this.rankLabel, "rankLabel");
            this.rankLabel.Name = "rankLabel";
            // 
            // serverTextBox
            // 
            resources.ApplyResources(this.serverTextBox, "serverTextBox");
            this.serverTextBox.Name = "serverTextBox";
            // 
            // serverLabel
            // 
            resources.ApplyResources(this.serverLabel, "serverLabel");
            this.serverLabel.Name = "serverLabel";
            // 
            // applyButton
            // 
            resources.ApplyResources(this.applyButton, "applyButton");
            this.applyButton.Name = "applyButton";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // volumeServersCheckBox
            // 
            resources.ApplyResources(this.volumeServersCheckBox, "volumeServersCheckBox");
            this.volumeServersCheckBox.Name = "volumeServersCheckBox";
            this.volumeServersCheckBox.UseVisualStyleBackColor = true;
            // 
            // fileServersCheckBox
            // 
            resources.ApplyResources(this.fileServersCheckBox, "fileServersCheckBox");
            this.fileServersCheckBox.Name = "fileServersCheckBox";
            this.fileServersCheckBox.UseVisualStyleBackColor = true;
            // 
            // serversDataGridView
            // 
            resources.ApplyResources(this.serversDataGridView, "serversDataGridView");
            this.serversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serverColumn,
            this.serverTypeColumn,
            this.rankColumn});
            this.serversDataGridView.Name = "serversDataGridView";
            this.serversDataGridView.RowHeadersVisible = false;
            // 
            // serverColumn
            // 
            resources.ApplyResources(this.serverColumn, "serverColumn");
            this.serverColumn.Name = "serverColumn";
            // 
            // serverTypeColumn
            // 
            resources.ApplyResources(this.serverTypeColumn, "serverTypeColumn");
            this.serverTypeColumn.Name = "serverTypeColumn";
            // 
            // rankColumn
            // 
            resources.ApplyResources(this.rankColumn, "rankColumn");
            this.rankColumn.Name = "rankColumn";
            // 
            // ServersControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.serverRemoveButton);
            this.Controls.Add(this.serverAddButton);
            this.Controls.Add(this.volumeServerRadioButton);
            this.Controls.Add(this.fileServerRadioButton);
            this.Controls.Add(this.rankTextBox);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.volumeServersCheckBox);
            this.Controls.Add(this.fileServersCheckBox);
            this.Controls.Add(this.serversDataGridView);
            this.Name = "ServersControl";
            ((System.ComponentModel.ISupportInitialize)(this.serversDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button serverRemoveButton;
        private System.Windows.Forms.Button serverAddButton;
        private System.Windows.Forms.RadioButton volumeServerRadioButton;
        private System.Windows.Forms.RadioButton fileServerRadioButton;
        private System.Windows.Forms.TextBox rankTextBox;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox volumeServersCheckBox;
        private System.Windows.Forms.CheckBox fileServersCheckBox;
        private System.Windows.Forms.DataGridView serversDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankColumn;
    }
}
