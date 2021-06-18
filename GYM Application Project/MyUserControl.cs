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
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Image _icon;
        private string _name;
        private string _email;
        private string _rate;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pb_Icon.Image = value; }
        }

        [Category("Custom Props")]
        public new string Name
        {
            get { return _name; }
            set { _name = value; lbl_Name.Text = value; }
        }

        [Category("Custom Props")]
        public string Email
        {
            get { return _email; }
            set { _email = value; lbl_Email.Text = value; }
        }

        public string Rate
        {
            get { return _rate; }
            set { _rate = value; lbl_Rate.Text = value; }
        }



    }
}
