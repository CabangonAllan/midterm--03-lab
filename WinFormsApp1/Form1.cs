using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private static string _FullName;
        private static int _Age;
        private static long _ContactNo;
        private static long _StudentNo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListofProgram = new string[]
            {
                "BS Information Technology",
                "BS Information System",
                "BS Business Management",
                "BS Computer Engineer",
                "BS Education"
            };
            for (int i = 0; i < ListofProgram.Length; i++)
            {
                comboBox1.Items.Add(ListofProgram[i].ToString());
            }

        }
        /////return methods 
        public long StudentNumber(string studNum)
        {

            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
           

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                throw new FormatException("Invalid Format!");
            }
            

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                throw new FormatException("Invalid Input!");
            }

            return _Age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentInFormationClass.SetFullName = FullName(textBox2.Text,textBox3.Text, textBox4.Text);
            studentInFormationClass.SetStudentNo = (int)StudentNumber(textBox1.Text);
            studentInFormationClass.SetProgram = comboBox1.Text;
           

            studentInFormationClass.SetGender = comboBox2.Text;
            studentInFormationClass.SetContactNo =(int) ContactNo(textBox6.Text.ToString());
            studentInFormationClass.SetAge = Age(textBox5.Text);
            studentInFormationClass.SetBirthday = dateTimePicker1.Value.ToString("yyyyMM-dd");
            Form2 frm = new Form2();
            frm.ShowDialog();

            try
            {
                studentInFormationClass.SetFullName = FullName(textBox2.Text, textBox3.Text, textBox4.Text);
                studentInFormationClass.SetStudentNo = (int)StudentNumber(textBox1.Text);
                studentInFormationClass.SetProgram = comboBox1.Text;
                studentInFormationClass.SetGender = comboBox2.Text;
                studentInFormationClass.SetContactNo = (int)ContactNo(textBox6.Text.ToString());
                studentInFormationClass.SetAge = Age(textBox5.Text);
                studentInFormationClass.SetBirthday = dateTimePicker1.Value.ToString("yyyyMM-dd");
            }
            catch (FormatException FE)
            {
                MessageBox.Show(FE.Message);
            }
            catch (ArgumentNullException ANE)
            { 
              MessageBox.Show(ANE.Message);
            }
            catch(IndexOutOfRangeException IOR)
            {
                MessageBox.Show(IOR.Message);
            }
            
            Form2 form2 = new Form2();

            if(form2.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                dateTimePicker1.Text = "";
            }



        }

       
    }
}