using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadForm readForm = new ReadForm();
            this.Hide();
            readForm.ShowDialog();
            this.Show();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            WriteForm writeForm = new WriteForm();
            this.Hide();
            writeForm.ShowDialog();
            this.Show();
        }
    }
}
