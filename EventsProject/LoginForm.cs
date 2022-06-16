using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DTO.JoysOwnerDTO joysOwner = new DTO.JoysOwnerDTO();
            //joysOwner.NameOwnerJoy = textBox1.Text;
            //joysOwner.IDOwnerJoys = textBox2.Text;
            //joysOwner.EmailOwnerJoys = textBox3.Text;
            //joysOwner.PhoneJoysOwner = textBox4.Text;
            //joysOwner.PasswordOwnerJoys = textBox5.Text;
            //bool x=new BL.LoginEventBL().Register(joysOwner);
            //while (!x)
            //{
            //    MessageBox.Show("error!" +
            //        "The password exists Please enter a different password");
                
            //    joysOwner.PasswordOwnerJoys = textBox5.Text;
            //    new BL.LoginEventBL().Register(joysOwner);
            //}
            //new SearchHallsForm().Show();
        }
    }
}
