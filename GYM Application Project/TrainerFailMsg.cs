using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Application_Project
{
    public partial class TrainerFailMsg : Form
    {
        public TrainerFailMsg()
        {
            InitializeComponent();
        }

        private void TrainerFailMsg_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trainer obj = new Trainer();
            TrainersForm obj1 = new TrainersForm();

            obj1.clear();
            obj1.Hide();
            this.Hide();
        }
    }
}
