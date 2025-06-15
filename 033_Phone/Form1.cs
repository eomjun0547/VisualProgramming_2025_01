using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces; 
using FireSharp.Config;
using FireSharp.Response;

namespace _033_Phone
{
    public partial class Form1: Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "eP3lj8FgPAUW83V3IbpaYheCqWBbfVTHCdZZiOYz",
            BasePath = "https://vp01-81af5-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Connection 성공!");
            }
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = txtId.Text,
                SId = txtSId.Text,
                Name = txtName.Text,
                Phone = txtPhone.Text
            };

            SetResponse response = await client.SetAsync("Phonebook/"+txtId.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Data Inserted : Id = {0}, Name = {1} " + result.Id, result.Name);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtSId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("Phonebook/" + txtId.Text);
            Data data = response.ResultAs<Data>();

            if (data != null) { 
                txtId.Text = data.Id;
                txtSId.Text = data.SId;
                txtName.Text = data.Name;
                txtPhone.Text = data.Phone;
                MessageBox.Show("Data reterived successfully!");
            }

            else
            {
                MessageBox.Show("Data not found!");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = txtId.Text,
                SId = txtSId.Text,
                Name = txtName.Text,
                Phone = txtPhone.Text
            };

            FirebaseResponse response = await client.UpdateAsync("Phonebook/" + txtId.Text, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Data updated successfully! : id =" + result.Id);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteAsync("Phonebook/" + txtId.Text);

            MessageBox.Show("Deleted! : id = " + txtId.Text);

            txtId.Text = "";
            txtSId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private async void btnDeleteAll_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteAsync("Phonebook");

            txtId.Text = "";
            txtSId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";

            MessageBox.Show("All Data at Phonebook/ Deleted!");
        }
    }
}
