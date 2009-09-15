namespace OpenAFSClientManager
{
    partial class FreelanceClientControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreelanceClientControl));
            this.freelanceRemoveButton = new System.Windows.Forms.Button();
            this.freelanceAddModifyButton = new System.Windows.Forms.Button();
            this.rwMountPointRadioButton = new System.Windows.Forms.RadioButton();
            this.roMountPointRadioButton = new System.Windows.Forms.RadioButton();
            this.symbolicLinkRadioButton = new System.Windows.Forms.RadioButton();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mountpointDataGridView = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enableFreelanceCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mountpointDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // freelanceRemoveButton
            // 
            resources.ApplyResources(this.freelanceRemoveButton, "freelanceRemoveButton");
            this.freelanceRemoveButton.Name = "freelanceRemoveButton";
            this.freelanceRemoveButton.UseVisualStyleBackColor = true;
            // 
            // freelanceAddModifyButton
            // 
            resources.ApplyResources(this.freelanceAddModifyButton, "freelanceAddModifyButton");
            this.freelanceAddModifyButton.Name = "freelanceAddModifyButton";
            this.freelanceAddModifyButton.UseVisualStyleBackColor = true;
            // 
            // rwMountPointRadioButton
            // 
            resources.ApplyResources(this.rwMountPointRadioButton, "rwMountPointRadioButton");
            this.rwMountPointRadioButton.Name = "rwMountPointRadioButton";
            this.rwMountPointRadioButton.TabStop = true;
            this.rwMountPointRadioButton.UseVisualStyleBackColor = true;
            // 
            // roMountPointRadioButton
            // 
            resources.ApplyResources(this.roMountPointRadioButton, "roMountPointRadioButton");
            this.roMountPointRadioButton.Name = "roMountPointRadioButton";
            this.roMountPointRadioButton.TabStop = true;
            this.roMountPointRadioButton.UseVisualStyleBackColor = true;
            // 
            // symbolicLinkRadioButton
            // 
            resources.ApplyResources(this.symbolicLinkRadioButton, "symbolicLinkRadioButton");
            this.symbolicLinkRadioButton.Name = "symbolicLinkRadioButton";
            this.symbolicLinkRadioButton.TabStop = true;
            this.symbolicLinkRadioButton.UseVisualStyleBackColor = true;
            // 
            // targetTextBox
            // 
            resources.ApplyResources(this.targetTextBox, "targetTextBox");
            this.targetTextBox.Name = "targetTextBox";
            // 
            // targetLabel
            // 
            resources.ApplyResources(this.targetLabel, "targetLabel");
            this.targetLabel.Name = "targetLabel";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            // 
            // applyButton
            // 
            resources.ApplyResources(this.applyButton, "applyButton");
            this.applyButton.Name = "applyButton";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // mountpointDataGridView
            // 
            resources.ApplyResources(this.mountpointDataGridView, "mountpointDataGridView");
            this.mountpointDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mountpointDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.typeColumn,
            this.targetColumn});
            this.mountpointDataGridView.Name = "mountpointDataGridView";
            this.mountpointDataGridView.RowHeadersVisible = false;
            // 
            // nameColumn
            // 
            resources.ApplyResources(this.nameColumn, "nameColumn");
            this.nameColumn.Name = "nameColumn";
            // 
            // typeColumn
            // 
            resources.ApplyResources(this.typeColumn, "typeColumn");
            this.typeColumn.Name = "typeColumn";
            // 
            // targetColumn
            // 
            resources.ApplyResources(this.targetColumn, "targetColumn");
            this.targetColumn.Name = "targetColumn";
            // 
            // enableFreelanceCheckBox
            // 
            resources.ApplyResources(this.enableFreelanceCheckBox, "enableFreelanceCheckBox");
            this.enableFreelanceCheckBox.Name = "enableFreelanceCheckBox";
            this.enableFreelanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // FreelanceClientControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.freelanceRemoveButton);
            this.Controls.Add(this.freelanceAddModifyButton);
            this.Controls.Add(this.rwMountPointRadioButton);
            this.Controls.Add(this.roMountPointRadioButton);
            this.Controls.Add(this.symbolicLinkRadioButton);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.mountpointDataGridView);
            this.Controls.Add(this.enableFreelanceCheckBox);
            this.Name = "FreelanceClientControl";
            this.Load += new System.EventHandler(this.FreelanceClientControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mountpointDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button freelanceRemoveButton;
        private System.Windows.Forms.Button freelanceAddModifyButton;
        private System.Windows.Forms.RadioButton rwMountPointRadioButton;
        private System.Windows.Forms.RadioButton roMountPointRadioButton;
        private System.Windows.Forms.RadioButton symbolicLinkRadioButton;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView mountpointDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetColumn;
        private System.Windows.Forms.CheckBox enableFreelanceCheckBox;
    }
}
