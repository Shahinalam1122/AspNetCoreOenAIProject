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
    public partial class frmPrint : Form
    {
        List<GetDataOpenAI_Result> list;
        public frmPrint(List<GetDataOpenAI_Result> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ProductReport1.SetDataSource(list);
            crystalReportViewer1.Refresh();
        }
    }
}
