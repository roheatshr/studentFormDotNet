using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork;

namespace CourseworkForm
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {

            InitializeComponent();
            BindGrid();

            updateBtn.Visible = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            string id = txtId.Text;
            string firstName = txtFname.Text;
            string middleName = txtMname.Text;
            string lastName = txtLname.Text;
            obj.Name = firstName + " "+ middleName + " "+ lastName;
            obj.Address = txtAddress.Text;
            obj.RegDate = dpRegDate.Value;
            obj.ContactNo = txtContact.Text;
            obj.CourseEnrol = cbCourseEnrol.SelectedItem.ToString();
            obj.Add(obj);
            BindGrid();
            Clear();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.Id = int.Parse(txtId.Text);
            string firstName = txtFname.Text;
            string middleName = txtMname.Text;
            string lastName = txtLname.Text;
            obj.Name = firstName + " " + middleName + " " + lastName;
            obj.Address = txtAddress.Text;
            obj.RegDate = dpRegDate.Value;
            obj.ContactNo = txtContact.Text;
            obj.CourseEnrol = cbCourseEnrol.SelectedItem.ToString();
            obj.Edit(obj);
            BindGrid();
            Clear();
            updateBtn.Visible = false;
            addBtn.Visible = true;
        }
        private void BindGrid()
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listStudents);
            dataGridView1.DataSource = dt;
            BindChart(listStudents);
        }
        private void Clear()
        {
            txtId.Text = "";
            txtFname.Text = "";
            txtMname.Text = "";
            txtLname.Text = "";
            txtAddress.Text = "";
            dpRegDate.Value = DateTime.Today;
            txtContact.Text = "";
            cbCourseEnrol.SelectedItem = null;

        }

        private void BindChart(List<Student> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.CourseEnrol)
                    .Select(cl => new
                    {
                        cbCourseEnrol = cl.First().CourseEnrol,
                        Count = cl.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
           
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Student obj = new Student();
            if (e.ColumnIndex == 0)
            {
                //get the value of the clicked rows id column
                string value = dataGridView1[2, e.RowIndex].Value.ToString();
                int id = 0;
                if (String.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Invalid Data");
                }
                else
                {
                    id = int.Parse(value);
                    Student s = obj.List().Where(x => x.Id == id).FirstOrDefault();
                    txtId.Text = s.Id.ToString();
                    txtFname.Text = s.Name.Split(' ')[0];
                    txtMname.Text = s.Name.Split(' ')[1];
                    txtLname.Text = s.Name.Split(' ')[2];
                    txtAddress.Text = s.Address;
                    dpRegDate.Value = s.RegDate;
                    txtContact.Text = s.ContactNo;
                    cbCourseEnrol.SelectedItem = s.CourseEnrol;
                    addBtn.Visible = false;
                    updateBtn.Visible = true;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                string message = "Do you want to Delete this Record?";
                string title = "Delete Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    //get the value of the clicked rows id column
                    string value = dataGridView1[2, e.RowIndex].Value.ToString();
                    obj.Delete(int.Parse(value));
                    BindGrid();
                    MessageBox.Show("Record Successfully Deleted");
                }
            }
        }

    }
}
