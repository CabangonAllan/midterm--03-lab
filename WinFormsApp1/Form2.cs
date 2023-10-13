using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            studno.Text = studentInFormationClass.SetStudentNo.ToString();
            name.Text = studentInFormationClass.SetFullName;
            program.Text = studentInFormationClass.SetProgram;
            bday.Text = studentInFormationClass.SetBirthday;
            gender.Text = studentInFormationClass.SetGender;
            contactno.Text = studentInFormationClass.SetContactNo.ToString();
            age.Text = studentInFormationClass.SetAge.ToString();
        }
    }
}
