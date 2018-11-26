using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TesteResort
{
    public partial class CadFunc : UserControl
    {
        public CadFunc()
        {
        	
        	try
        	{
        		richTextBox1.LoadFile("Funcs.txt");

        	}
        	catch (Exception erro)
        	{

        	}
        	
        	InitializeComponent();
        	
        	listView1.View = View.Details;
        	listView1.FullRowSelect = true;
        	
        	//colunas
        	listView1.Columns.Add("Nome",100);
        	listView1.Columns.Add("CPF",100);
        	listView1.Columns.Add("Cargo",100);
        	listView1.Columns.Add("Hr Entrada",100);
        	listView1.Columns.Add("Hr Saída",100);
        	listView1.Columns.Add("Data Admissão",100);
        	listView1.Columns.Add("Login",100);
        }
        
        
        private void add(String nome, String cpf, String cargo, String hrEnt, String hrSai, String dtAdm, String login)
        {
        	//Linhas
        	String[] linha = {nome, cpf, cargo, hrEnt, hrSai, dtAdm, login};
        	
        	ListViewItem item = new ListViewItem(linha);
        	
        	
        	
        	listView1.Items.Add(item);
        	string colabs = textBox1.Text +'\t' + maskedTextBox1.Text + '\t' + textBox2.Text +'\t'+ textBox3.Text +'\t'+ textBox4.Text + '\t' + textBox5.Text +'\t' + textBox6.Text;
        	if (richTextBox1.Lines.Length != 0)
        		richTextBox1.AppendText("\n" + colabs);

        	else
        	{
        		richTextBox1.AppendText(colabs);
        	}

        	richTextBox1.SaveFile("Funcs.txt");

        	
        	
        	
        }
        
        
        private void atualizar()
        {
        	listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
        	listView1.SelectedItems[0].SubItems[1].Text = maskedTextBox1.Text;
        	listView1.SelectedItems[0].SubItems[2].Text = textBox2.Text;
        	listView1.SelectedItems[0].SubItems[3].Text = textBox3.Text;
        	listView1.SelectedItems[0].SubItems[4].Text = textBox4.Text;
        	listView1.SelectedItems[0].SubItems[5].Text = textBox5.Text;
        	listView1.SelectedItems[0].SubItems[6].Text = textBox6.Text;
        	
        	
        	//Limpa
        	textBox1.Text = "";
        	maskedTextBox1.Text = "";
        	textBox2.Text ="";
        	textBox3.Text = "";
        	textBox4.Text = "";
        	textBox5.Text = "";
        	textBox6.Text = "";
        	
        	
        	
        }
        
        
        private void deletar()
        {
        	if(MessageBox.Show("Tem certeza?","delete", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
        	{
        		listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        		//Limpa
        		textBox1.Text = "";
        		maskedTextBox1.Text = "";
        		textBox2.Text ="";
        		textBox3.Text = "";
        		textBox4.Text = "";
        		textBox5.Text = "";
        		textBox6.Text = "";
        		
        	}
        }
        void Button5Click(object sender, EventArgs e)
        {
        	if((textBox1.Text == "") || (maskedTextBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") ||(textBox4.Text == "") ||(textBox5.Text == "") ||(textBox6.Text == "")){
        		
        		
        		MessageBox.Show("Preencha Todos os Campos");
        		
        	}else{
        		add(textBox1.Text, maskedTextBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
        	}
        	
        	//Limpa
        	textBox1.Text = "";
        	maskedTextBox1.Text = "";
        	textBox2.Text ="";
        	textBox3.Text = "";
        	textBox4.Text = "";
        	textBox5.Text = "";
        	textBox6.Text = "";
        	
        	ListView lista = new ListView();
        	lista = listView1;
        	if(richTextBox1.Lines.Length != 0) {
        		richTextBox1.AppendText('\n' + lista.ToString());
        	}
        	else{
        		richTextBox1.AppendText(lista.ToString());
        		
        	}
        	
        	richTextBox1.SaveFile("Funcs.txt");
        	
        	
        }
        void Button4Click(object sender, EventArgs e)
        {
        	atualizar();
        }
        void Button3Click(object sender, EventArgs e)
        {
        	deletar();
        }
        void ListView1MouseClick(object sender, MouseEventArgs e)
        {
        	textBox1.Text =	listView1.SelectedItems[0].SubItems[0].Text;
        	maskedTextBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
        	textBox2.Text= listView1.SelectedItems[0].SubItems[2].Text;
        	textBox3.Text= listView1.SelectedItems[0].SubItems[3].Text;
        	textBox4.Text= listView1.SelectedItems[0].SubItems[4].Text;
        	textBox5.Text= listView1.SelectedItems[0].SubItems[5].Text;
        	textBox6.Text= listView1.SelectedItems[0].SubItems[6].Text;
        	
        	
        	
        	
        }
		void CadFuncLoad(object sender, EventArgs e)
		{
			
		}
    }
    
    
    
    
}

