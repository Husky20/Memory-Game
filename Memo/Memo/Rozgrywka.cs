using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Memo {
    public partial class Rozgrywka : Form {
        State state;
        public Rozgrywka() {
            InitializeComponent();
            state = new State(4, 4);//wielkosc planszy
            state.MakeState(state.FileToArray());
            Board();
        }
        public Rozgrywka(int x, int y) {
            InitializeComponent();
            state = new State(x, y);//wielkosc planszy
            state.MakeState(state.FileToArray());
            Board();
        }
        public void Board() {
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
       
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {
            
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            
        }

        private void button3_Click(object sender, EventArgs e) {

        }

        private void button15_Click(object sender, EventArgs e) {

        }

        private void Rozgrywka_Load(object sender, EventArgs e) {
            
        }

        public void Warning_Load(object sender, EventArgs e) {
            
        }

        public string CanShow(Button clickedbutton) {
            int id = 0;
            if (clickedbutton.Name.Length > 1)
                id = int.Parse(clickedbutton.Name.Substring(0, 2));
            else
                id = int.Parse(clickedbutton.Name.Substring(0, 1));
            if (state.GetFieldById(id).hiden == isHiden.hiden)
                return "???";
            //clickedbutton.Text = "X";
            else if (state.GetFieldById(id).hiden == isHiden.show) {
                return state.GetTextIField(id);
                //clickedbutton.Text = 
            }
            else if (state.GetFieldById(id).hiden == isHiden.par_swhow) {
                return state.GetTextIField(id);
                //clickedbutton.Text = 
            }
            return "X";
        }

        private void button_click(object sender, EventArgs e) {
            logic_button(sender, e, tableLayoutPanel1);
        }

        public void logic_button(object sender, EventArgs e, TableLayoutPanel tableLayoutPanel1) {
            Button clickedbutton = sender as Button;
            int id = 0;
            if (clickedbutton != null) {
                if (clickedbutton.Name.Length > 1)
                    id = int.Parse(clickedbutton.Name.Substring(0, 2));
                else
                    id = int.Parse(clickedbutton.Name.Substring(0, 1));
                if (state.IsOKIN(id)) {
                    state.ShowCard(id);
                }
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++) {
                    if (tableLayoutPanel1.Controls[i] is Button) {
                        tableLayoutPanel1.Controls[i].Text = CanShow((Button)tableLayoutPanel1.Controls[i]);//state.GetTextIField(i);
                    }
                    else continue;
                }

                if (state.IsWin()) {
                    Wygrana noweOkno = new Wygrana();
                    noweOkno.Show();
                }
            }
        }
    }
}
