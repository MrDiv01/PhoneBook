using MetroFramework.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PhoneBook.Data;
using PhoneBook.Models;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PhoneBook
{
    public partial class ListForm : MetroForm
    {
        public ListForm()
        {
            InitializeComponent();
        }

        #region Load Function
        //void Refresh()
        //{
        //    lstPeople.Items.Clear();

        //    #region MyRegion

        //    using SqlConnection con = new(connection);
        //    using SqlCommand cmd = new();
        //    cmd.Connection = con;
        //    cmd.CommandText = "SELECT [Id], [FirstName], [LastName], [Phone], [Mail] FROM People";
        //    cmd.CommandType = CommandType.Text;

        //    if (con.State != ConnectionState.Open)
        //    {
        //        con.Open();
        //    }

        //    using SqlDataReader dr = cmd.ExecuteReader();
        //    List<Person> people = new();
        //    while (dr.Read())
        //    {
        //        #region Create new object
        //        //Person person = new()
        //        //{
        //        //    //Id = dr.GetInt32(0),
        //        //    //Id = Convert.ToInt32(dr["Id"]),
        //        //    //Id = dr[nameof(Person.Id)] as int? ?? 0,
        //        //    //Id = Convert.ToInt32(dr[0]),
        //        //    //Id        = Convert.ToInt32(dr[nameof(Person.Id)]),


        //        //    Id = dr.GetInt32(nameof(Person.Id)),
        //        //    FirstName = dr[nameof(Person.FirstName)] as string,
        //        //    LastName = dr[nameof(Person.LastName)] as string,
        //        //    Phone = dr.GetString(nameof(Person.Phone)),
        //        //    Mail = (string)dr[nameof(Person.Mail)]
        //        //};
        //        //people.Add(person); 
        //        #endregion

        //        ListViewItem item = new(dr.GetInt32(nameof(Person.Id)).ToString());
        //        item.SubItems.Add(dr[nameof(Person.FirstName)] as string);
        //        item.SubItems.Add(dr[nameof(Person.LastName)] as string);
        //        item.SubItems.Add(dr[nameof(Person.Phone)] as string);
        //        item.SubItems.Add(dr[nameof(Person.Mail)] as string);

        //        lstPeople.Items.Add(item);
        //    }
        //    #endregion

        //}
        #endregion

        void Refresh()
        {
            lstPeople.Items.Clear();

            using var context = new ApplicationDbContext();//AppDbContext`dən instance alırıq

         
            var people = context.People.Select//people variable daxilinə Context daxilindəki People Modelini yəni Dbdə olan məlumatları yığırıq
                (p => new
                {
                    p.Id,
                    p.FirstName,
                    p.LastName,
                    p.Phone,
                    p.Mail
                })
                .ToList();

            foreach (var person in people)//people Listi daxilində fırlanırıq 
            {
                ListViewItem item = new(person.Id.ToString())
                {
                    SubItems =
                    {
                        person.FirstName,
                        person.LastName,
                        person.Phone,
                        person.Mail
                    }
                };
                lstPeople.Items.Add(item);
            }
        }

        //string connection = Program.Configuration.GetConnectionString("default");
        string connection = Properties.PhoneBook.Default.Connection;
        private void ListForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private void cmsRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }


        private void cmsSil_Click(object sender, EventArgs e)
        {
            if (lstPeople.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select a record to delete.",
                    "Delete Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete the selected record?",
                "Delete Item",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);


            if (dialogResult == DialogResult.No)
            {
                return;
            }
            int selectedId = Convert.ToInt32(lstPeople.SelectedItems[0].Text);
            using var context = new ApplicationDbContext();

            var person = context.People.FirstOrDefault(p => p.Id == selectedId);
            if (person != null)
            {
                context.People.Remove(person);
                context.SaveChanges();
                lstPeople.SelectedItems[0].Remove();
                MessageBox.Show(
                    text: "Kayıt silindi",
                    caption: "Kayıt Silme Bildirimi",
                     buttons: MessageBoxButtons.OK,
                     icon: MessageBoxIcon.Asterisk
                    );
            }
            else 
            {
                MessageBox.Show(
                  text: "Kayıt Silinmedi",
                  caption: "Kayıt Silme Bildirimi",
                   buttons: MessageBoxButtons.OK,
                   icon: MessageBoxIcon.Error
                  );
            }
            #region MyRegion

            //string selectedId = lstPeople.SelectedItems[0].Text;
            //using SqlConnection con = new(connection);
            //using SqlCommand cmd = new();
            //cmd.Connection = con;
            //cmd.CommandText = "DELETE FROM People WHERE Id = @Id";
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("@Id", selectedId);

            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //}

            //bool result = cmd.ExecuteNonQuery() > 0;
            //con.Close();
            //if (result)
            //{
            //    lstPeople.SelectedItems[0].Remove();
            //}
         //   MessageBox.Show(
         //    text: result ? "Kayıt Silindi" : "İşlem Hatası",
         //    caption: "Kayıt Silme Bildirimi",
         //    buttons: MessageBoxButtons.OK,
         //    icon: result ? MessageBoxIcon.Asterisk : MessageBoxIcon.Error
         //);
            #endregion



        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainFormInstance.Show();
        }
        private void cmsEdit_Click(object sender, EventArgs e)
        {
            if (lstPeople.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select a record to update.",
                    "Update Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string selectedId = lstPeople.SelectedItems[0].Text;
            EditForm frm = new EditForm(selectedId);
            frm.ShowDialog();
            lstPeople.Items.Clear();
            var context = new ApplicationDbContext();
            var people = context.People.ToList();
            foreach (var person in people)
            {
                var item = new ListViewItem(person.Id.ToString());
                item.SubItems.Add(person.FirstName);
                item.SubItems.Add(person.LastName);
                item.SubItems.Add(person.Phone);
                item.SubItems.Add(person.Mail);
                lstPeople.Items.Add(item);
            }
         
        }
       

    }
}
