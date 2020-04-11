namespace ClientMyPhotos
{
    partial class AddPropertyDialogForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveNewPropButton = new System.Windows.Forms.Button();
            this.CancelNewPropButton = new System.Windows.Forms.Button();
            this.PropNameLabel = new System.Windows.Forms.Label();
            this.PropTypeLabel = new System.Windows.Forms.Label();
            this.PropNameText = new System.Windows.Forms.TextBox();
            this.PropTypeCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SaveNewPropButton
            // 
            this.SaveNewPropButton.Location = new System.Drawing.Point(132, 120);
            this.SaveNewPropButton.Name = "SaveNewPropButton";
            this.SaveNewPropButton.Size = new System.Drawing.Size(75, 23);
            this.SaveNewPropButton.TabIndex = 0;
            this.SaveNewPropButton.Text = "Save";
            this.SaveNewPropButton.UseVisualStyleBackColor = true;
            this.SaveNewPropButton.Click += new System.EventHandler(this.SaveNewPropButton_Click);
            // 
            // CancelNewPropButton
            // 
            this.CancelNewPropButton.Location = new System.Drawing.Point(227, 120);
            this.CancelNewPropButton.Name = "CancelNewPropButton";
            this.CancelNewPropButton.Size = new System.Drawing.Size(75, 23);
            this.CancelNewPropButton.TabIndex = 1;
            this.CancelNewPropButton.Text = "Cancel";
            this.CancelNewPropButton.UseVisualStyleBackColor = true;
            this.CancelNewPropButton.Click += new System.EventHandler(this.CancelNewPropButton_Click);
            // 
            // PropNameLabel
            // 
            this.PropNameLabel.AutoSize = true;
            this.PropNameLabel.Location = new System.Drawing.Point(22, 36);
            this.PropNameLabel.Name = "PropNameLabel";
            this.PropNameLabel.Size = new System.Drawing.Size(35, 13);
            this.PropNameLabel.TabIndex = 2;
            this.PropNameLabel.Text = "Name";
            // 
            // PropTypeLabel
            // 
            this.PropTypeLabel.AutoSize = true;
            this.PropTypeLabel.Location = new System.Drawing.Point(22, 68);
            this.PropTypeLabel.Name = "PropTypeLabel";
            this.PropTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.PropTypeLabel.TabIndex = 3;
            this.PropTypeLabel.Text = "Type";
            // 
            // PropNameText
            // 
            this.PropNameText.Location = new System.Drawing.Point(87, 36);
            this.PropNameText.Name = "PropNameText";
            this.PropNameText.Size = new System.Drawing.Size(215, 20);
            this.PropNameText.TabIndex = 4;
            // 
            // PropTypeCombo
            // 
            this.PropTypeCombo.FormattingEnabled = true;
            this.PropTypeCombo.Items.AddRange(new object[] {
            "String",
            "Integer",
            "Float",
            "Double",
            "DateTime"});
            this.PropTypeCombo.Location = new System.Drawing.Point(87, 68);
            this.PropTypeCombo.Name = "PropTypeCombo";
            this.PropTypeCombo.Size = new System.Drawing.Size(215, 21);
            this.PropTypeCombo.TabIndex = 5;
            this.PropTypeCombo.Text = "String";
            // 
            // AddPropertyDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 155);
            this.Controls.Add(this.PropTypeCombo);
            this.Controls.Add(this.PropNameText);
            this.Controls.Add(this.PropTypeLabel);
            this.Controls.Add(this.PropNameLabel);
            this.Controls.Add(this.CancelNewPropButton);
            this.Controls.Add(this.SaveNewPropButton);
            this.Name = "AddPropertyDialogForm";
            this.Text = "Add Property";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveNewPropButton;
        private System.Windows.Forms.Button CancelNewPropButton;
        private System.Windows.Forms.Label PropNameLabel;
        private System.Windows.Forms.Label PropTypeLabel;
        private System.Windows.Forms.TextBox PropNameText;
        private System.Windows.Forms.ComboBox PropTypeCombo;
    }
}