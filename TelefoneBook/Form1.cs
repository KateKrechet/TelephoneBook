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
    public partial class Form1 : Form
    {
        List<Person> people;
        void RefreshList()
        {
            listBox1.Items.Clear();
            foreach(Person person in people)
            {
                listBox1.Items.Add(person.Name);
            }
        }
        public Form1()
        {
            InitializeComponent();
            people = new List<Person>();

            Person Igor = new Person();
            Igor.Name = "Игорь";
            Igor.Photo = "C:\\Users\\nimba\\Desktop\\1.png";
            Igor.Telephone = "89203265306";
            Igor.Bday = new DateTime(1990, 3, 17);

            people.Add(Igor);

            people.Add(new Person()
            {
                Bday = new DateTime(1988, 7, 28),
                Name = "Ольга",
                Photo = "C:\\Users\\nimba\\Desktop\\1.png",
                Telephone = "8920664818"
            });
            RefreshList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            if(listBox1.SelectedIndex>=0)
            {
                int index = listBox1.SelectedIndex;
                pictureBox1.Image = Image.FromFile(people[index].Photo);
                label1.Text = "Имя: "+people[index].Name;
                label2.Text = "Тефон: "+people[index].Telephone;
                label3.Text = $"Возраст: { people[index].Age}";
                label4.Text = "Дата рождения: "+people[index].Bday.ToString("dd.MM.yyyy");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(people);
            form2.ShowDialog();
            RefreshList();
        }
    }
}
