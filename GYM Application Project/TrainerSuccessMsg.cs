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
    public partial class TrainerSuccessMsg : Form
    {
        public TrainerSuccessMsg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trainer obj = new Trainer();
            TrainersForm obj1 = new TrainersForm();

            obj1.Hide();
            obj.Show();
            obj.GenerateDynamicUSerControl();      

            this.Hide();
        }

        private void TrainerSuccessMsg_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }
    }
}
