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
    public partial class Poziom : Form {
        public Poziom() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            RozgrywkaTrudna noweOkno= new RozgrywkaTrudna();
            noweOkno.Show();
        }

        private void Easy_Click(object sender, EventArgs e) {
            Rozgrywka noweOkienko = new Rozgrywka();
            noweOkienko.Show();
        }
    }
}
