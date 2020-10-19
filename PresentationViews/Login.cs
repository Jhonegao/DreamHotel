using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PresentationViews
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            AppMethodToTxtBox(this);
        }
        #region MoveForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        #region Methods
        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lbLogin;
        }
        public void AppMethodToTxtBox(Form form)
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                Control control = form.Controls[i];
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.Enter += Txt_Enter;
                    txt.Leave += Txt_Leave;
                }
            }
        }
        public void MoveForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void TextBoxChanges(TextBox txtBox, string texto, bool status)
        {
            if (status && txtBox.Text == "")
            {
                txtBox.Text = "USUARIO";
                txtBox.ForeColor = Color.SlateGray;
            }
            if (!status && txtBox.Text == "USUARIO")
            {
                txtBox.Text = "";
                txtBox.ForeColor = Color.AliceBlue;
                status = true;
            }
            if (!status && txtBox.Text == "")
            {
                txtBox.UseSystemPasswordChar = status;
                txtBox.Text = "SENHA";
                txtBox.ForeColor = Color.SlateGray;
            }
            if (status && txtBox.Text == "SENHA")
            {
                txtBox.UseSystemPasswordChar = status;
                txtBox.Text = "";
                txtBox.ForeColor = Color.AliceBlue;
            }
        }
        #endregion
        #region EventsForm
        private void Txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            TextBoxChanges(txt, txt.Text, txt.Name.Equals("txtUser"));
        }
        private void Txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            TextBoxChanges(txt, txt.Text, !txt.Name.Equals("txtUser"));
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }
        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
