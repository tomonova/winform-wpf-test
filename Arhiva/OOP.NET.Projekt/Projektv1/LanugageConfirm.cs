using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektv1
{
    public partial class LanugageConfirm : Form
    {
        public LanugageConfirm()
        {
            InitializeComponent();
        }

        private void LanugageConfirm_Load(object sender, EventArgs e)
        {
            AcceptButton = btnOK;
            CancelButton = btnCancel;
        }
    }
}
