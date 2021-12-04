using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelephoneDirectory.Business.Abstract;
using TelephoneDirectory.Business.Concrete;
using TelephoneDirectory.DataAccess.Concrete;
using TelephoneDirectory.DataAccess.Concrete.EntityFramework;
using TelephoneDirectory.Entities.Concrete;

namespace TelephoneDirectory.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _contactService = new ContactManager(new EfContactDal());
        }

        private IContactService _contactService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }
        private void LoadContacts()
        {
            dataGridView1.DataSource = _contactService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _contactService.Add(new Contact
            {
                ContactName = txbName.Text,
                ContactSurname = txbSurname.Text,
                ContactPhoneNumber = txbPhoneNumber.Text,
            });
            LoadContacts();
            MessageBox.Show("Kişi Kaydedildi!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _contactService.Update(new Contact
            {
                //güncelleme olduğu için id gönderilmeli
                ContactId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                ContactName = tbxNameUpdate.Text,
                ContactSurname = tbxSurnameUpdate.Text,
                ContactPhoneNumber = tbxPhoneNumberUpdate.Text,
            });
            LoadContacts();
            MessageBox.Show("Kişi Güncellendi!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxSurnameUpdate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxPhoneNumberUpdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _contactService.Delete(new Contact
            {
                ContactId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
            });
            LoadContacts();
            MessageBox.Show("Kişi Silindi!");
        }
    }
}
