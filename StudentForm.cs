using Soriano_Paul_Jhustine_Act_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soriano_Paul_Jhustine_Act_GUI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // Mock Student Data
            StudentNameLabel.Text = "Soriano, Paul Jhustine E.";
            StudentAgeLabel.Text = "20";
            StudentAddressLabel.Text = "Poblacion East Alcala Pangasinan";
            StudentContactLabel.Text = "09196431445";
            StudentEmailLabel.Text = "p.j.soriano@gmail.com";
            StudentCourseYearLabel.Text = "BSIT Third";
            ParentNameLabel.Text = "Romulo Soriano";
            ParentContactLabel.Text = "09123456789";
            HobbiesLabel.Text = "Gaming/Reading";
            NicknameLabel.Text = "PJ/Tine";

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