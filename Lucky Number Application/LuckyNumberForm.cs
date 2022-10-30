using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_Number_Application
{
    public partial class LuckyNumberForm : Form
    {
        public LuckyNumberForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) // Form2 = LuckyNumberForm
        {
            Form1 frm = new Form1();
            label1.Text = frm.getLuckyNumber().ToString(); // label1 = The Lucky Number generated.  
        }
    }
}
