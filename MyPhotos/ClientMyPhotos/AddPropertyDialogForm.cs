using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientMyPhotos
{
    public partial class AddPropertyDialogForm : Form
    {
        public AddPropertyDialogForm()
        {
            InitializeComponent();
        }

        private void SaveNewPropButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelNewPropButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
