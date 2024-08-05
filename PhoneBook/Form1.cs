using MetroFramework.Forms;
using Microsoft.Extensions.Configuration;
using PhoneBook.Data;
using PhoneBook.Models;
using System.Data;
using System.Data.SqlClient;

namespace PhoneBook
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Clear(Control ctrl)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox txt)
                {
                    txt.Clear();
                }
                else if (item is NumericUpDown nmr)
                {
                    nmr.Value = nmr.Minimum;
                }
                else if (item is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                }
            }
        }
        //gərəy qalmıyacaq çünki DbContextdən instance aldığımıza görə
        //string connection = Program.Configuration.GetConnectionString("default");


        private void btnSave_Click(object sender, EventArgs e)
        {
            var context = new ApplicationDbContext();
            
            Person person = new Person();
            person.FirstName= txtFirstName.Text;
            person.LastName= txtLastName.Text;
            person.Phone = txtPhone.Text;
            person.Mail = txtMail.Text;
            context.Add(person);
            context.SaveChanges();
            MessageBox.Show(
                 text:  "Kayıt Eklendi" ,
                 caption: "Kayıt Eklleme Bildirimi",
                 buttons: MessageBoxButtons.OK,
                 icon:MessageBoxIcon.Asterisk 
           );

            #region MyRegion

            //using SqlConnection con = new SqlConnection(connection); // using block to dispose the connection

            //using SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            ////cmd.CommandText = "INSERT INTO People (FirstName, LastName, Mail, Phone) VALUES ('Murat','Vuranok','murat.vuranok@code.edu.az','+994501234785')";
            ////cmd.CommandText = $"INSERT INTO People (FirstName, LastName, Mail, Phone) VALUES ('{txtFirstName.Text}','{txtLastName.Text}','{txtMail.Text}','{txtPhone.Text}')";

            //cmd.CommandText = "INSERT INTO People (FirstName, LastName, Mail, Phone) VALUES (@firstName,@lastName,@mail,@phone)";
            ////cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
            ////cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
            ////cmd.Parameters.AddWithValue("mail", txtMail.Text);
            ////cmd.Parameters.AddWithValue("phone", txtPhone.Text);

            //cmd.Parameters.Add("@firstName", SqlDbType.NVarChar, 100).Value = txtFirstName.Text;
            //cmd.Parameters.Add("@lastName", SqlDbType.NVarChar, 100).Value = txtLastName.Text;
            //cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 30).Value = txtPhone.Text;
            //cmd.Parameters.Add("@mail", SqlDbType.NVarChar, 100).Value = txtMail.Text;


            //cmd.CommandType = CommandType.Text;


            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //}

            //bool result = cmd.ExecuteNonQuery() > 0;
            //con.Close();
            //MessageBox.Show(result ? "Kayıt Eklendi" : "İşlem Hatası");
            #endregion

            //MessageBox.Show(
            //      text: result ? "Kayıt Eklendi" : "İşlem Hatası",
            //      caption: "Kayıt Eklleme Bildirimi",
            //      buttons: MessageBoxButtons.OK,
            //      icon: result ? MessageBoxIcon.Asterisk : MessageBoxIcon.Error
            //);

            //txtFirstName.Text = txtLastName.Text = txtMail.Text = txtPhone.Text = string.Empty; 
            //txtFirstName.Text = "";
            //txtLastName.Clear();
            //txtMail.Text = string.Empty;
            Clear(grbSavePerson);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           Program.MainFormInstance.Show();
        } 
    }
}
