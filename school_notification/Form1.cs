using Microsoft.VisualBasic.Devices;
using static Mysqlx.Expect.Open.Types;
using System.Drawing;
using System.Xml.Linq;
using ModelLayer;
using BussinessLayer;

namespace school_notification
{
    public partial class Form1 : Form
    {

        byte[] image_data;
        public Form1()
        {
            InitializeComponent();
        }

        private void schEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    image_data = ms.ToArray();

                    SchoolClass lb = new SchoolClass()
                    {
                        schNotification = schNotification.Text,
                        schDate = schDate.Text,
                        schTime = schTime.Text,
                        schValidation = schValidation.Text,
                        schContact = schContact.Text,
                        schSms = schSms.Text,
                        schCell = schCell.Text,
                        schEmail = schEmail.Text,


                        pictureBox1 = image_data
                    };
                    SchoolBussiness.businessClass(lb);
                    MessageBox.Show("New Notification Added Successfully");
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Please Select Picture first ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void ResetForm()
        {
            schNotification.Clear();
            schDate.Clear();
            schTime.Clear();
            schValidation.Clear();
            schContact.Clear();
            schSms.Clear();
            schCell.Clear();
            schEmail.Clear();
            pictureBox1.Image = null;
            schNotification.ReadOnly = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                lblPic.Text = Path.GetFileName(open.FileName);
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                image_data = ms.ToArray();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SchoolBussiness.businesstable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            schNotification.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            schDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            schTime.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            schValidation.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            schContact.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            schSms.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            schCell.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            schEmail.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

            byte[] imageBytes = (byte[])dataGridView1.SelectedRows[0].Cells[8].Value;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            SchoolClass obj = new SchoolClass()
            {
                schNotification = schNotification.Text,
                schDate = schDate.Text,
                schTime = schTime.Text,
                schValidation = schValidation.Text,
                schContact = schContact.Text,
                schSms = schSms.Text,
                schCell = schCell.Text,
                schEmail = schEmail.Text,

            };
            SchoolBussiness.deleteBusiness(obj);
            MessageBox.Show("Data Deleted Sucessfully");
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    image_data = ms.ToArray();
                }

                SchoolClass obj = new SchoolClass()
                {
                    schNotification = schNotification.Text,
                    schDate = schDate.Text,
                    schTime = schTime.Text,
                    schValidation = schValidation.Text,
                    schContact = schContact.Text,
                    schSms = schSms.Text,
                    schCell = schCell.Text,
                    schEmail = schEmail.Text,
                    pictureBox1 = image_data
                };
               SchoolBussiness.UpdateBusiness(obj);
                MessageBox.Show("Data Updated Successfully");
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }




}
