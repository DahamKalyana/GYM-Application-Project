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
    public partial class profileuser : UserControl
    {
        public profileuser()
        {
            InitializeComponent();
        }

        private Image _icon;
        private string _name;
        private string _email;
        private string _age;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pbprofile.Image = value; }
        }

        [Category("Custom Props")]
        public new string Name
        {
            get { return _name; }
            set { _name = value; lblname.Text = value; }
        }

        [Category("Custom Props")]
        public string Email
        {
            get { return _email; }
            set { _email = value; lblemail.Text = value; }
        }

        public string Age
        {
            get { return _age; }
            set { _age = value; lblage.Text = value; }
        }

    }
}
