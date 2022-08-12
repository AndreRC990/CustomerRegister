using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace CustomerRegister
{
    public partial class frmCadastro : Form
    {
        int counter = 0;

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            this.Size = new Size(452, 371);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString(); //Test
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            counter = dgvCadastrados.Rows.Count;
            this.dgvCadastrados.Rows.Add(counter.ToString(), txtFirstName.Text, txtEndereco.Text, txtCidade.Text, dwnEstado.Text, txtCpf.Text);

        }

        private void clearFields()
        {
            txtFirstName.Clear();
            txtEndereco.Clear();
            txtCpf.Clear();
            txtCidade.Clear();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedIndex == 0)
            {
                this.Size = new Size(452,371); 
            }

            if(this.tabControl.SelectedIndex == 1)
            {
                this.Size = new Size(740, 469);
            }
        }
    }
}
