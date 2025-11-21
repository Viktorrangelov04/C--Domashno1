using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        private StudentManager manager = new StudentManager();
        public Form1()
        {
            InitializeComponent();
            ValidateInputs();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student(txtName.Text.Trim(), txtFN.Text.Trim(), txtCourse.Text.Trim());
            manager.AddStudent(newStudent);
            UpdateList();
            ClearFields();//Създава нов студент с въведените данни, добавя го към мениджъра, обновява листа и изчиства полетата
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();// изчиства текстовите полета
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void txtFN_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }
        private void ValidateInputs()
        {
            btnAdd.Enabled = !(
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtFN.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text)// проверява дали всички полета са попълнени
            );
        }
        private void UpdateList()
        {
            listBox1.Items.Clear();// изчиства текущите елементи в листа

            var allStudents = manager.GetAllStudents();// взима всички студенти от мениджъра

            for (int i = 0; i < allStudents.Count; i++)
            {
                string line = $"{i + 1}. {allStudents[i].ToString()}";// форматира всеки студент с номер
                listBox1.Items.Add(line);// добавя всеки студент в листа
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtFN.Clear();
            txtCourse.Clear();// изчиства текстовите полета
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;// взима индекса на селектирания елемент в листа

            if (selectedIndex >= 0)
            {
                manager.RemoveStudent(selectedIndex);// премахва студента от мениджъра
                UpdateList();// обновява листа
            }
            else
            {
                MessageBox.Show("Please select a student to delete",
                    "No student selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);// показва съобщение ако няма селектиран студент
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
