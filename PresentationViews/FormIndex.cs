using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.Size = new Size(475, 534);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Size = new Size(150, 534);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            address.Pais = "Brasil";
            address.UF = "SC";
            address.Rua = "SFHDFH";
            address.CEP = "46746756";
            address.Bairro = "SFHDSFADFH";
            address.Cidade = "SFHDDTURFH";
            User user = new User();
            user.Nome = "Joana";
            user.Cpf = "12345604952";
            user.Rg = "567467";
            user.Senha = "Joana";
            user.Telefones.Add("24457697808");
            user.Email = "wtrteytyty";
            user.EnderecoId = 1;
            MessageBox.Show();
        }
    }
}
