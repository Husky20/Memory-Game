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
    public partial class RozgrywkaTrudna : Form {
        Rozgrywka r;
        public RozgrywkaTrudna() {
            InitializeComponent();
            Board();
        }
        public void Board() {
            r = new Rozgrywka(8, 8);
            Button button;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++) {
                if (tableLayoutPanel1.Controls[i] is Button) {
                    button = (Button)tableLayoutPanel1.Controls[i];
                    button.Name = i.ToString();
                    button.Text = "???";//state.GetTextIField(i);
                }
                else continue;
            }

        }
        private void RozgrywkaTrudna_Load(object sender, EventArgs e) {

        }

        private void button_click(object sender, EventArgs e) {
            r.logic_button(sender, e, tableLayoutPanel1);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
