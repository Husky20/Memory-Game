using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Memo {
    public partial class Menu : Form {

        private IconButton bierzacyPrzycisk;
        private Panel lewyPrzycisk;
        private Form bierzacyForm;

        public Menu() {
            InitializeComponent();
            lewyPrzycisk = new Panel();
            lewyPrzycisk.Size = new Size(7, 60);
            panelMenu.Controls.Add(lewyPrzycisk);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors {
            public static Color color1 = Color.Gold;
            public static Color color2 = Color.LimeGreen;
            public static Color color3 = Color.DarkRed;
            public static Color color4 = Color.FromArgb(255, 140, 0);
        }

        private void AktywujPrzycisk(object senderBtn, Color color) {
            if (senderBtn != null) { 
                AktywacjaPrzycisku();
           
                bierzacyPrzycisk = (IconButton)senderBtn;
                bierzacyPrzycisk.BackColor = Color.Teal;
                bierzacyPrzycisk.ForeColor = color;
                bierzacyPrzycisk.TextAlign = ContentAlignment.MiddleCenter;
                bierzacyPrzycisk.IconColor = color;
                bierzacyPrzycisk.TextImageRelation = TextImageRelation.TextBeforeImage;
                bierzacyPrzycisk.ImageAlign = ContentAlignment.MiddleRight;

                lewyPrzycisk.BackColor = color;
                lewyPrzycisk.Location = new Point(0, bierzacyPrzycisk.Location.Y);
                lewyPrzycisk.Visible = true;
                lewyPrzycisk.BringToFront();

                iconCurrentChildForm.IconChar = bierzacyPrzycisk.IconChar;
                iconCurrentChildForm.IconColor = color;

                

            }
        }

        private void AktywacjaPrzycisku (){
            if (bierzacyPrzycisk != null) {
                bierzacyPrzycisk.BackColor = Color.CadetBlue;
                bierzacyPrzycisk.ForeColor = Color.Black;
                bierzacyPrzycisk.TextAlign = ContentAlignment.MiddleCenter;
                bierzacyPrzycisk.IconColor = Color.Black;
                bierzacyPrzycisk.TextImageRelation = TextImageRelation.ImageBeforeText;
                bierzacyPrzycisk.ImageAlign = ContentAlignment.MiddleLeft;
                
            }
           
        }

        private void OpenChildForm(Form childForm) {
            if (bierzacyForm != null) {
                bierzacyForm.Close();
            }
            bierzacyForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleChildForm.Text = childForm.Text;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Zasady noweOkienko = new Zasady();
            noweOkienko.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            Kontakt noweOkienko = new Kontakt();
            noweOkienko.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void Menu_Load(object sender, EventArgs e) {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {



        }

        private void panelMenu_Paint(object sender, PaintEventArgs e) {
        }

        private void iconButton1_Click(object sender, EventArgs e) {
            AktywujPrzycisk(sender, RGBColors.color1);
            OpenChildForm(new Zasady());
        }

        private void iconButton2_Click(object sender, EventArgs e) {
            AktywujPrzycisk(sender, RGBColors.color2);
            OpenChildForm(new Rozgrywka());
        }

        private void iconButton3_Click(object sender, EventArgs e) {
            AktywujPrzycisk(sender, RGBColors.color3);
            OpenChildForm(new RozgrywkaTrudna());
        }

        private void iconButton4_Click(object sender, EventArgs e) {
            AktywujPrzycisk(sender, RGBColors.color4);
            OpenChildForm(new Kontakt());
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e) {

        }

        private void MemoGame_Click(object sender, EventArgs e) {

        }

        private void BTNHome_Click(object sender, EventArgs e) {
            if(bierzacyForm != null) {
                bierzacyForm.Close();
                Reset();
            }
            
        }

        private void Reset() {
            AktywacjaPrzycisku();
            lewyPrzycisk.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Dice;
            iconCurrentChildForm.IconColor = Color.FromArgb(102, 0, 102);
            labelTitleChildForm.Text = "Witaj w grze memo!!!";
        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e) {
           
        }

        private void iconButton5_Click(object sender, EventArgs e) {
            OpenChildForm(new Rozgrywka());
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e) {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RelaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e) {
            RelaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void minimizeBtn_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeBtn_Click(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void iconButton1_Click_1(object sender, EventArgs e) {
            OpenChildForm(new RozgrywkaTrudna());
        }
    }
}
