using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsernameProgram
{
    public partial class MainPage : UserControl
    {
        public static string user = "WEABOO";
        public static string pass = "WEABOO";
        public MainPage()
        {
            InitializeComponent();

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == user && passwordBox.Text == pass)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                SecondPage sp = new SecondPage();
                f.Controls.Add(sp);
            }
        }
    }
}
