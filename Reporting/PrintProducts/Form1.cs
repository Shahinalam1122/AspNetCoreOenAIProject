using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintProducts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<GetDataOpenAI_Result> list = getDataOpenAIResultBindingSource.DataSource as List<GetDataOpenAI_Result>;
            if (list !=null)
            {
                using (frmPrint frm=new frmPrint(list))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (OpenAIDbEntities db=new OpenAIDbEntities())
            {
                getDataOpenAIResultBindingSource.DataSource=db.GetDataOpenAI().ToList();
            }
        }

    }
}
