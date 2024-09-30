using Registro.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Person> persons;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.FirstName = tbFirstName.Text;
            person.LastName = tbLastName.Text;
            person.Birthdate = dtpBirthDate.Value;
            persons.Add(person);
            ShowPersons();
            ClearTb();
        }

        private void ShowPersons()
        {
            dgvPersons.DataSource = null;
            dgvPersons.DataSource = persons;
        }

        private void ClearTb()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            dtpBirthDate.Value = DateTime.Now;
            tbFirstName.Focus();
        }
    }
}
