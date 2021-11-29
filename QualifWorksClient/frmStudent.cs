using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataModel;

namespace QualifWorksClient
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();

            taSupervisorName.Fill(dsDataModel.SupervisorName);
            taQualifWorks.Fill(dsDataModel.QualifWorks);

            cboStudyLevel.DataSource = QualifLevel.Levels;
            cboStudyLevel.DisplayMember = QualifLevel.DisplayMember;
            cboStudyLevel.ValueMember = QualifLevel.ValueMember;
        }

        public void AddNew()
        {
            bsStudents.AddNew();
        }

        public void Edit(int studentId)
        {
            taStudents.FillByStudentID(dsDataModel.Students, studentId);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text.Length > 0)
            {
                erpStudent.SetError(this.txtStudentName, String.Empty);
            }
            else
            {
                erpStudent.SetError(this.txtStudentName, "Ievadiet vārdu!");
            }

            if (txtStudentSurname.Text.Length > 0)
            {
                erpStudent.SetError(this.txtStudentSurname, String.Empty);
            }
            else
            {
                erpStudent.SetError(this.txtStudentSurname, "Ievadiet uzvārdu");
            }

            if (cboStudyLevel.SelectedItem != null)
            {
                erpStudent.SetError(this.cboStudyLevel, String.Empty);
            }
            else
            {
                erpStudent.SetError(this.cboStudyLevel, "Izvēlieties līmeni!");
            }

            if (txtStudentId.MaskCompleted)
            {
                erpStudent.SetError(this.txtStudentId, String.Empty);
            }
            else
            {
                erpStudent.SetError(this.txtStudentId, "Ievadiet korektu apliecības numuru!");
            }

            if (String.IsNullOrEmpty(erpStudent.GetError(txtStudentName))
                && String.IsNullOrEmpty(erpStudent.GetError(txtStudentSurname))
                && String.IsNullOrEmpty(erpStudent.GetError(cboStudyLevel))
                && String.IsNullOrEmpty(erpStudent.GetError(txtStudentId)))
            {
                try
                {
                    bsStudents.EndEdit();
                    taStudents.Update(dsDataModel.Students);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsStudents.CancelEdit();
            DialogResult = DialogResult.Cancel;
        }

        private void cboSelectedTopic_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboSelectedTopic.SelectedIndex != -1)
            {
                object str = taSupervisorName.GetSupervisorNameBy((int)cboSelectedTopic.SelectedValue);
                lblTopicSupervisorName.Text = (string)str ?? "<Vadītājs tēmai netika atrasts!>";
            }
            else
                lblTopicSupervisorName.Text = "<nav izvēlēta tēma>";
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            txtStudentId.Mask = "000>LLL000";
        }
    }
}
