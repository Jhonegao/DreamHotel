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
            cepConsulta ceepAddress = correiosCEP.GetAddress("89041003");
            Address address = new Address();
            address.Pais = "Brasil";
            address.Rua = ceepAddress.Rua;
            address.CEP = ceepAddress.Cep;
            address.Bairro = ceepAddress.Bairro;
            address.Cidade = ceepAddress.Cidade;
            address.UF = ceepAddress.UF;
            address.Numero = "1248";
            //CheckAttributeLength.AttributeLength<Address>(address);
            Response response = addressBLL.Insert(address);
            MessageBox.Show(response.Message);
            //User user = new User();
            //user.Nome = "Joana";
            //user.Cpf = "12345604952";
            //user.Rg = "567467";
            //user.Senha = "Joana";
            //user.Telefones.Add("47997220501");
            //user.Email = "twenty@gmail.com";
            //user.EnderecoId = 1;
        }
    }
}
