using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokedex.util;

namespace Pokedex
{
    public partial class ReadForm : Form
    {
        private DataBaseManager manager = new DataBaseManager("Server=localhost;Database=pokedex;Uid=root;Pwd=;");

        public ReadForm()
        {
            InitializeComponent();
            numNumber.Value = 1;
        }

        private void numNumber_ValueChanged(object sender, EventArgs e)
        {
            // Obtendo a tabela do banco de acordo com a consulta
            DataTable tabela = manager.ConsultarBanco($"SELECT * FROM pokemon WHERE id_pokemon = {numNumber.Value}");
            if (tabela.Rows.Count == 1)
            {
                // Setando variáveis com os valores e tipos corretos da tabela
                string nome = Convert.ToString(tabela.Rows[0]["nome"]);
                string descricao = Convert.ToString(tabela.Rows[0]["descrição"]);
                string tipo1 = Convert.ToString(tabela.Rows[0]["tipo1"]);
                string tipo2 = Convert.ToString(tabela.Rows[0]["tipo1"]);

                byte[] spriteBlob = (byte[]) tabela.Rows[0]["sprite"];
                Image sprite = ImageManager.BlobToImage(spriteBlob);

                // Exibindo as informações
                lblName.Text = nome;
                txtDescription.Text = descricao;
                picSprite.Image = sprite;
                txtType1.Text = tipo1;
                txtType2.Text = tipo2;
            }
            else
                MessageBox.Show("Nenhum registro encontrado!");
        }
    }
}
