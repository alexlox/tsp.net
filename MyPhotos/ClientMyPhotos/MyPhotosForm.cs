using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotos;

namespace ClientMyPhotos
{
    public partial class MyPhotosForm : Form
    {
        MyPhotosClient myPhotos;
        public MyPhotosForm()
        {
            InitializeComponent();
        }

        private void MyPhotosForm_Load(object sender, EventArgs e)
        {
            myPhotos = new MyPhotosClient();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            DisplayObjectsPanel.BringToFront();
        }

        private void AddMediaButton_Click(object sender, EventArgs e)
        {
            AddMediaPanel.BringToFront();
        }

        private void AddPropButton_Click(object sender, EventArgs e)
        {
            AddPropertyDialogForm addPropertyDialog = new AddPropertyDialogForm();
            addPropertyDialog.ShowDialog();
        }

        private void DisplayObjectsBackButton_Click(object sender, EventArgs e)
        {
            FilterPanel.BringToFront();
        }

        private void AddMediaBackButton_Click(object sender, EventArgs e)
        {
            FilterPanel.BringToFront();
        }

        private void AddFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog.ShowDialog();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();
        }
    }
}
