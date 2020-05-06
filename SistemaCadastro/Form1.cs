using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        class tdado
        {
            
        };
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void mostrar()
        {
                
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
        }
        void salvar()
        {
            BinaryWriter arq = new BinaryWriter(File.Open("fila.txt", FileMode.Create));
            arq.Write(deque.Count());
            foreach (tdado b in deque)
            {
                arq.Write(b.nome);
                arq.Write(b.cpf);
            }
            arq.Close();
            MessageBox.Show("Dados Salvos com Sucesso", "Mensagem");
        }
        void carregar()
        {

            BinaryReader arq = new BinaryReader(
                File.Open("fila.txt", FileMode.Open));
            if (File.Exists("fila.txt"))
            {
                qtd = arq.ReadInt32();
                for (int i = 0; i < qtd; i++)
                {
                    tdado b = new tdado();
                    b.nome = arq.ReadString();
                    b.cpf = arq.ReadString();
                    deque.AddFirst(b);                   
                }// fim for
                arq.Close();
                mostrar();
            }// fim if 
            else
                MessageBox.Show("Arquivo não encontrado", "Erro");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            carregar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRemFim_Click(object sender, EventArgs e)
        {
           
        }

        private void btnfim_Click(object sender, EventArgs e)
        {
            
        }
    }
}
