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
    public partial class Quartos : UserControl
    {
        public Quartos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableAdapterManager.tbl_quartosTableAdapter.InsertQuarto(textBox2.Text, textBox3.Text, int.Parse(textBox6.Text), decimal.Parse(textBox4.Text), textBox5.Text, comboBox1.SelectedItem.ToString());
        }

        private void tbl_quartosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_quartosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_piDataSet);

        }

        private void tbl_quartosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_quartosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_piDataSet);

        }

        private void tbl_quartosBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_quartosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_piDataSet);

        }
    }
}
