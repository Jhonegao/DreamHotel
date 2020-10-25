using Entities;
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
using Correios.CEP;
using System.Reflection;
using BLL;
using Cmm;

namespace PresentationViews
{
    public partial class TelaTesteCadastroCliente : Form
    {
        public TelaTesteCadastroCliente()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddressBLL addressBLL = new AddressBLL();
            UserBLL userBLL = new UserBLL();
            User user = new User();
            //cepConsulta ceepAddress = correiosCEP.GetAddress("88345677");
            //Address address = new Address();
            //address.Pais = "Brasil";
            //address.Rua = ceepAddress.Rua;
            //address.CEP = ceepAddress.Cep;
            //address.Bairro = ceepAddress.Bairro;
            //address.Cidade = ceepAddress.Cidade;
            //address.UF = ceepAddress.UF;
            //address.Numero = "240";
            user.Nome = "Joana";
            user.Cpf = "28004996051";
            user.Rg = "567467";
            user.Senha = "Anaoj";
            user.Telefone = "479999995";
            user.Email = "twenty@gmail.com";
            user.EnderecoId = 2;
            Response response = userBLL.Insert(user);
            MessageBox.Show(response.Message);
        }
    }
}
