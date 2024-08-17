using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokedex.util;

namespace Pokedex
{
    public partial class WriteForm : Form
    {
        private DataBaseManager manager = new DataBaseManager("Server=localhost;Database=pokedex;Uid=root;Pwd=;");

        public WriteForm()
        {
            InitializeComponent();
            numNumber.Value = 1;

            DataTable tabela = manager.ConsultarBanco("SELECT * FROM Tipo");

            for(int i = 0; i < tabela.Rows.Count; i++)
            {
                cmbType1.Items.Add(tabela.Rows[i]["id_tipo"]);
                cmbType2.Items.Add(tabela.Rows[i]["id_tipo"]);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Ler as informações do formulário
            int id_pokemon = Convert.ToInt32(numNumber.Value);
            string nome = txtName.Text;
            string descricao = txtDescription.Text;
            string tipo1 = cmbType1.Text;
            string tipo2 = cmbType2.Text;  

            // Leitura da imagem
            Image imagem = picSprite.Image;
            byte[] spriteBlob = ImageManager.ImageToBlob(imagem);
            string spriteHex = "0x" + BitConverter.ToString(spriteBlob).Replace("-", string.Empty);

            string sql = $"UPDATE pokemon " +
                         $"SET nome = '{nome}', descrição = '{descricao}', tipo1 = '{tipo1}', tipo2='{tipo2}', sprite = {spriteHex} " +
                         $"WHERE id_pokemon = '{id_pokemon}'";

            // Atualizar o banco
            int linhas_afetadas = manager.AtualizarBanco(sql);

            if (linhas_afetadas > 0)
                MessageBox.Show("Registro atualizado com sucesso!");
            else
                MessageBox.Show("Nenhum registro foi atualizado. Favor entrar em contato com a central.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ler as informações do formulário
            int id_pokemon = Convert.ToInt32(numNumber.Value);

            string sql = $"DELETE FROM pokemon " +
                         $"WHERE id_pokemon = {id_pokemon}";

            // Atualizar o banco
            int linhas_afetadas = manager.AtualizarBanco(sql);

            if (linhas_afetadas > 0)
                MessageBox.Show("Registro removido com sucesso!");
            else
                MessageBox.Show("Nenhum registro foi removido. Favor entrar em contato com a central.");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Ler as informações do formulário
            int id_pokemon = Convert.ToInt32(numNumber.Value);
            string nome = txtName.Text;
            string descricao = txtDescription.Text;
            string tipo1 = cmbType1.Text;
            string tipo2 = cmbType2.Text;

            Image imagem = picSprite.Image;
            byte[] spriteBlob = ImageManager.ImageToBlob(imagem);
            string spriteHex = "0x" + BitConverter.ToString(spriteBlob).Replace("-", string.Empty);

            string sql = $"INSERT INTO pokemon " +
                         $"VALUES('{id_pokemon}', '{nome}','{descricao}','{tipo1}','{tipo2}',{spriteHex})";

            // Atualizar o banco
            int linhas_afetadas = manager.AtualizarBanco(sql);

            if (linhas_afetadas > 0)
                MessageBox.Show("Registro inserido com sucesso!");
            else
                MessageBox.Show("Nenhum registro foi inserido. Favor entrar em contato com a central.");
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            // Cria e configura a dialog box
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Selecione uma imagem";

                // Abre a dialog box e verifica se o usuário selecionou um arquivo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Pega o caminho do arquivo selecionado
                    string imagePath = openFileDialog.FileName;

                    // Carrega a imagem no PictureBox
                    picSprite.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void numNumber_ValueChanged(object sender, EventArgs e)
        {
            DataTable tabela = manager.ConsultarBanco($"SELECT * FROM pokemon WHERE id_pokemon = {numNumber.Value}");
            if (tabela.Rows.Count == 1)
            {

                string nome = Convert.ToString(tabela.Rows[0]["nome"]);
                string descricao = Convert.ToString(tabela.Rows[0]["descrição"]);
                string tipo1 = Convert.ToString(tabela.Rows[0]["tipo1"]);
                string tipo2 = Convert.ToString(tabela.Rows[0]["tipo2"]);

                byte[] spriteBlob = (byte[])tabela.Rows[0]["sprite"];
                Image sprite = ImageManager.BlobToImage(spriteBlob);

                txtName.Text = nome;
                txtDescription.Text = descricao;
                picSprite.Image = sprite;
                cmbType1.Text = tipo1;
                cmbType2.Text = tipo2;
            }
            else
            {
                txtName.Text = String.Empty;
                txtDescription.Text = String.Empty;
                picSprite.Image = null;
                MessageBox.Show("Nenhum registro encontrado!");
            }
        }
    }
}
