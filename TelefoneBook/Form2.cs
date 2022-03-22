using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefoneBook
{
    public partial class Form2 : Form
    {
        List<Person> people;
        Person person = new Person();
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<Person>people)
        {
            InitializeComponent();
            this.people = people;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                person.Photo = openFileDialog.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            person.Name = textBox1.Text;
            person.Telephone = textBox2.Text;
            person.Bday = dateTimePicker1.Value;
            people.Add(person);
            Close();
        }
    }
}
