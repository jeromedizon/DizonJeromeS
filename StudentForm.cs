using Dizon_Jerome_Act_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizon_Jerome_Act_GUI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // Mock Student Data
            StudentNameLabel.Text = "Dizon, Jerome S.";
            StudentAgeLabel.Text = "20";
            StudentAddressLabel.Text = "Bongato East, Bayambang, Pangasinan";
            StudentContactLabel.Text = "09936292196";
            StudentEmailLabel.Text = "jeromeddizon@gmail.com";
            StudentCourseYearLabel.Text = "BSIT Third Year";
            ParentNameLabel.Text = "Thelma Dizon";
            ParentContactLabel.Text = "09098786563";
            HobbiesLabel.Text = "Billiard/Basketball";
            NicknameLabel.Text = "Jerome";

        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

    }
}