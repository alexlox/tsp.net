namespace ClientMyPhotos
{
    partial class MyPhotosForm
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
            this.components = new System.ComponentModel.Container();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.AddMediaButton = new System.Windows.Forms.Button();
            this.FiltersList = new System.Windows.Forms.ListView();
            this.AddPropButton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.DisplayObjectsPanel = new System.Windows.Forms.Panel();
            this.SendEmailButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SelectedImageProps = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImagesListView = new System.Windows.Forms.ListView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.AddMediaPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DisplayObjectsBackButton = new System.Windows.Forms.Button();
            this.AddMediaBackButton = new System.Windows.Forms.Button();
            this.AddFolderButton = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FilterPanel.SuspendLayout();
            this.DisplayObjectsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AddMediaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterPanel
            // 
            this.FilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterPanel.AutoSize = true;
            this.FilterPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterPanel.Controls.Add(this.AddFolderButton);
            this.FilterPanel.Controls.Add(this.AddMediaButton);
            this.FilterPanel.Controls.Add(this.FiltersList);
            this.FilterPanel.Controls.Add(this.AddPropButton);
            this.FilterPanel.Controls.Add(this.GoButton);
            this.FilterPanel.Location = new System.Drawing.Point(12, 12);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(849, 497);
            this.FilterPanel.TabIndex = 0;
            // 
            // AddMediaButton
            // 
            this.AddMediaButton.Location = new System.Drawing.Point(232, 18);
            this.AddMediaButton.Name = "AddMediaButton";
            this.AddMediaButton.Size = new System.Drawing.Size(104, 23);
            this.AddMediaButton.TabIndex = 3;
            this.AddMediaButton.Text = "Add Image/Video";
            this.AddMediaButton.UseVisualStyleBackColor = true;
            this.AddMediaButton.Click += new System.EventHandler(this.AddMediaButton_Click);
            // 
            // FiltersList
            // 
            this.FiltersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltersList.HideSelection = false;
            this.FiltersList.Location = new System.Drawing.Point(21, 66);
            this.FiltersList.MultiSelect = false;
            this.FiltersList.Name = "FiltersList";
            this.FiltersList.Size = new System.Drawing.Size(814, 419);
            this.FiltersList.TabIndex = 2;
            this.FiltersList.UseCompatibleStateImageBehavior = false;
            // 
            // AddPropButton
            // 
            this.AddPropButton.Location = new System.Drawing.Point(119, 18);
            this.AddPropButton.Name = "AddPropButton";
            this.AddPropButton.Size = new System.Drawing.Size(89, 23);
            this.AddPropButton.TabIndex = 1;
            this.AddPropButton.Text = "Add Property";
            this.AddPropButton.UseVisualStyleBackColor = true;
            this.AddPropButton.Click += new System.EventHandler(this.AddPropButton_Click);
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(21, 18);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 0;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(0, 512);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(875, 22);
            this.Status.TabIndex = 1;
            // 
            // DisplayObjectsPanel
            // 
            this.DisplayObjectsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayObjectsPanel.AutoSize = true;
            this.DisplayObjectsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DisplayObjectsPanel.Controls.Add(this.DisplayObjectsBackButton);
            this.DisplayObjectsPanel.Controls.Add(this.SendEmailButton);
            this.DisplayObjectsPanel.Controls.Add(this.PrintButton);
            this.DisplayObjectsPanel.Controls.Add(this.ExportButton);
            this.DisplayObjectsPanel.Controls.Add(this.SelectedImageProps);
            this.DisplayObjectsPanel.Controls.Add(this.pictureBox1);
            this.DisplayObjectsPanel.Controls.Add(this.ImagesListView);
            this.DisplayObjectsPanel.Location = new System.Drawing.Point(12, 12);
            this.DisplayObjectsPanel.Name = "DisplayObjectsPanel";
            this.DisplayObjectsPanel.Size = new System.Drawing.Size(850, 497);
            this.DisplayObjectsPanel.TabIndex = 2;
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.Location = new System.Drawing.Point(690, 18);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(75, 23);
            this.SendEmailButton.TabIndex = 7;
            this.SendEmailButton.Text = "Send Email";
            this.SendEmailButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(609, 18);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 6;
            this.PrintButton.Text = "Print Image";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(509, 18);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(94, 23);
            this.ExportButton.TabIndex = 5;
            this.ExportButton.Text = "Export Results";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // SelectedImageProps
            // 
            this.SelectedImageProps.HideSelection = false;
            this.SelectedImageProps.Location = new System.Drawing.Point(427, 289);
            this.SelectedImageProps.Name = "SelectedImageProps";
            this.SelectedImageProps.Size = new System.Drawing.Size(408, 196);
            this.SelectedImageProps.TabIndex = 4;
            this.SelectedImageProps.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(428, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 230);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ImagesListView
            // 
            this.ImagesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagesListView.HideSelection = false;
            this.ImagesListView.Location = new System.Drawing.Point(21, 18);
            this.ImagesListView.MultiSelect = false;
            this.ImagesListView.Name = "ImagesListView";
            this.ImagesListView.Size = new System.Drawing.Size(401, 467);
            this.ImagesListView.StateImageList = this.ImageList;
            this.ImagesListView.TabIndex = 2;
            this.ImagesListView.UseCompatibleStateImageBehavior = false;
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AddMediaPanel
            // 
            this.AddMediaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMediaPanel.AutoSize = true;
            this.AddMediaPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddMediaPanel.Controls.Add(this.AddMediaBackButton);
            this.AddMediaPanel.Controls.Add(this.SaveButton);
            this.AddMediaPanel.Controls.Add(this.ChooseFileButton);
            this.AddMediaPanel.Controls.Add(this.listView1);
            this.AddMediaPanel.Location = new System.Drawing.Point(12, 12);
            this.AddMediaPanel.Name = "AddMediaPanel";
            this.AddMediaPanel.Size = new System.Drawing.Size(849, 497);
            this.AddMediaPanel.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(214, 18);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Location = new System.Drawing.Point(119, 18);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseFileButton.TabIndex = 3;
            this.ChooseFileButton.Text = "Choose File";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 66);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(814, 419);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // DisplayObjectsBackButton
            // 
            this.DisplayObjectsBackButton.Location = new System.Drawing.Point(428, 18);
            this.DisplayObjectsBackButton.Name = "DisplayObjectsBackButton";
            this.DisplayObjectsBackButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayObjectsBackButton.TabIndex = 8;
            this.DisplayObjectsBackButton.Text = "Back";
            this.DisplayObjectsBackButton.UseVisualStyleBackColor = true;
            this.DisplayObjectsBackButton.Click += new System.EventHandler(this.DisplayObjectsBackButton_Click);
            // 
            // AddMediaBackButton
            // 
            this.AddMediaBackButton.Location = new System.Drawing.Point(21, 18);
            this.AddMediaBackButton.Name = "AddMediaBackButton";
            this.AddMediaBackButton.Size = new System.Drawing.Size(75, 23);
            this.AddMediaBackButton.TabIndex = 9;
            this.AddMediaBackButton.Text = "Back";
            this.AddMediaBackButton.UseVisualStyleBackColor = true;
            this.AddMediaBackButton.Click += new System.EventHandler(this.AddMediaBackButton_Click);
            // 
            // AddFolderButton
            // 
            this.AddFolderButton.Location = new System.Drawing.Point(358, 18);
            this.AddFolderButton.Name = "AddFolderButton";
            this.AddFolderButton.Size = new System.Drawing.Size(75, 23);
            this.AddFolderButton.TabIndex = 4;
            this.AddFolderButton.Text = "Add Folder";
            this.AddFolderButton.UseVisualStyleBackColor = true;
            this.AddFolderButton.Click += new System.EventHandler(this.AddFolderButton_Click);
            // 
            // MyPhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 534);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.DisplayObjectsPanel);
            this.Controls.Add(this.AddMediaPanel);
            this.Name = "MyPhotosForm";
            this.Text = "My Photos";
            this.Load += new System.EventHandler(this.MyPhotosForm_Load);
            this.FilterPanel.ResumeLayout(false);
            this.DisplayObjectsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AddMediaPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.ListView FiltersList;
        private System.Windows.Forms.Button AddPropButton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.Panel DisplayObjectsPanel;
        private System.Windows.Forms.ListView ImagesListView;
        private System.Windows.Forms.ListView SelectedImageProps;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Button AddMediaButton;
        private System.Windows.Forms.Panel AddMediaPanel;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SendEmailButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button DisplayObjectsBackButton;
        private System.Windows.Forms.Button AddMediaBackButton;
        private System.Windows.Forms.Button AddFolderButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    }
}