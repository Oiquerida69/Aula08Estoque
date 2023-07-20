using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula08Estoque
{
    public partial class Form1 : Form
    { 
        // Variaveis Globais

        List<string> Produtos_nomes = new List<string>();
        List<int> Quantidade_Produtos = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }
        Ultilidades ultilidades = new Ultilidades();
        void VerificarNomes()
        {
            
        }
        void AdicionaProduto()
        {

            if (ultilidades.textboxestavazio(txt_Nome) == true || ultilidades.textboxestavazio(txt_Quantidade) == true)
            {
                MessageBox.Show("Preencha os campos vazios");
                return;
            }
            
                string nome = txt_Nome.Text;
            ultilidades.textboxestavazio(txt_Quantidade);
                int quantidade = int.Parse(txt_Quantidade.Text);
                Produtos_nomes.Add(nome);
                Quantidade_Produtos.Add(quantidade);
            

        }
       

        
        void AtualizaInteface()
        {
            
            // contabiliza a quantidade cadastrada
            int quantidade_cadastrada = Produtos_nomes.Count();
            lbl_Cadastro.Text = $"{quantidade_cadastrada}";

            // contabiliza produtos em estoque
            int estoque = 0;
            for (int i = 0; i < Quantidade_Produtos.Count; i++)
            {
                int quantidade = Quantidade_Produtos[i];
                estoque += quantidade;
            }
            lbl_estoque.Text = $"{estoque}";



           
        }
        void LimparTudo()
        {
            txt_Nome.Text = "";
            txt_Quantidade.Text = "";
            txt_Nome.Focus();



        }
        void verproduto(bool primeiro)
        {
            if(ListaEstaVazia() == true)
            {
                MessageBox.Show("A lista esta vazia");
                return;
            }
            string nome;
            int quantidade;
            
            if (primeiro == true)
            {
                nome = Produtos_nomes[0];
                quantidade = Quantidade_Produtos[0];

            }
            else
            {
                nome = Produtos_nomes[Produtos_nomes.Count() - 1];
                quantidade = Quantidade_Produtos[Quantidade_Produtos.Count() - 1];
            }

            MessageBox.Show($"Nome : {nome}, Quantidade : {quantidade}");
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            AdicionaProduto();
            AtualizaInteface();
            LimparTudo();
            for (int i = 0; i < Produtos_nomes.Count; i++)
            {
                list.Items.Add(Produtos_nomes[i]);
            }
            if(Produtos_nomes.Count >= 1)
            {
            list.Show();

            }


            

        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }

        private void btn_Vp_Click(object sender, EventArgs e)
        {
            verproduto(true);
        }

        private void btn_VU_Click(object sender, EventArgs e)
        {
            verproduto(false);
        }
        void removerProduto()
        {
            if (ListaEstaVazia() == true)
            {
                MessageBox.Show("Você não pode remover");
                return;
            }
            Produtos_nomes.RemoveAt(0);
            Quantidade_Produtos.RemoveAt(0);
            AtualizaInteface();
        } 
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            removerProduto();
            MessageBox.Show("você excluiu o primeiro produto");
        }
        bool ListaEstaVazia()
        {
            if(Produtos_nomes.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ultilidades.mostraMensagem(); 
        }
    }
}
