using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo {
    public partial class Zasady : Form {
        public Zasady() {
            InitializeComponent();
        }

        private void Zasady_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Menu noweOkienko = new Menu();
            noweOkienko.Show();
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void iconButton1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
