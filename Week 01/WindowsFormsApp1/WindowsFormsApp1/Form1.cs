using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxCategory.Items.Add("Database Systems");
            comboBoxCategory.Items.Add("Programming");
            comboBoxCategory.Items.Add("Artificial Intelligence");

            textBoxIssueTo.Enabled = false;
            dateTimePickerIssueDate.Enabled = false;

        }


        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubCategory.Items.Clear();

            if (comboBoxCategory.SelectedIndex== 0)
            {
                comboBoxSubCategory.Items.Add("ERD");
                comboBoxSubCategory.Items.Add("SQL");
                comboBoxSubCategory.Items.Add("OLAP");
                comboBoxSubCategory.Items.Add("Datamining");
            }

            else if (comboBoxCategory.SelectedIndex == 1)
            {
                comboBoxSubCategory.Items.Add("C#");
                comboBoxSubCategory.Items.Add("Java");
                comboBoxSubCategory.Items.Add("Web Programming");
            }

            else if (comboBoxCategory.SelectedIndex == 2)
            {
                comboBoxSubCategory.Items.Add("Machine Learning");
                comboBoxSubCategory.Items.Add("Robotics");
                comboBoxSubCategory.Items.Add("Computer Vision");
            }

        }

        private void comboBoxSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxAuthorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxAuthorName.Items.Add(textBoxAuthorName.Text);
        }

        private void checkBoxIssued_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIssued.Checked== true)
            {
                textBoxIssueTo.Enabled= true;
                dateTimePickerIssueDate.Enabled = true;
            }

            if (checkBoxIssued.Checked == false)
            {
                textBoxIssueTo.Enabled = false;
                dateTimePickerIssueDate.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxISBN.Text.Length != 12)
            {
                MessageBox.Show("ISBN must be 12 digits.", MessageBoxButtons.RetryCancel.ToString());
            }

            if (dateTimePickerPurchasedOn.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Date of Purchase cannot be greater than Current Date.");
            }

            if (radioButtonJournal.Checked== true && textBoxAuthorName.Text.Length>0)
            {
                MessageBox.Show("Type 'Journal' must have no authors.");
            }
            if ((radioButtonReferenceBook.Checked == true || radioButtonTextBook.Checked== true) && 
                textBoxAuthorName.Text.Length == 0)
            {
                MessageBox.Show("Type 'Reference Book' and 'Text Book' must have authors.");
            }

            if (checkBoxIssued.Checked== true && textBoxIssueTo.Text.Length== 0)
            {
                MessageBox.Show("Name of book issuer must be specified. ");
            }
            if (checkBoxIssued.Checked== true && (dateTimePickerIssueDate.Value.Date< dateTimePickerPurchasedOn.Value.Date ||
                dateTimePickerIssueDate.Value.Date> DateTime.Now.Date))
            {
                MessageBox.Show("Error in Issue Date");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            myForm.Show();
        }
    }
}