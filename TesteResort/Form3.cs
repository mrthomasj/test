using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TesteResort
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tbl_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_piDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_piDataSet.tbl_quartos' table. You can move, or remove it, as needed.
            this.tbl_quartosTableAdapter.Fill(this.db_piDataSet.tbl_quartos);
            // TODO: This line of code loads data into the 'db_piDataSet.tbl_cliente' table. You can move, or remove it, as needed.
            this.tbl_clienteTableAdapter.Fill(this.db_piDataSet.tbl_cliente);

        }
    }
}
