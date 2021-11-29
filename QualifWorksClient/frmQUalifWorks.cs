﻿using DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualifWorksClient
{
    public partial class frmQualifWorks : Form
    {
        public frmQualifWorks()
        {
            InitializeComponent();

            levelDataGridViewTextBoxColumn.DataSource = QualifLevel.Levels;
            levelDataGridViewTextBoxColumn.DisplayMember = QualifLevel.DisplayMember;

            levelDataGridViewTextBoxColumn.ValueMember = QualifLevel.ValueMember;
        }

        private void btnUpdateSupervisors_Click(object sender, EventArgs e)
        {
            UpdateSupervisors("Vai tiešām saglabāt veiktās izmaiņas?");
        }

        private DialogResult UpdateSupervisors(string message)
        {
            DialogResult result = MessageBox.Show(message, "Darbu vadītāju datu saglabašana",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                // atceras tekošā raksta pozīciju
                int index = bsSupervisors.Position;
                taSupervisors.Update(dsDataModel.Supervisors);
                taSupervisors.Fill(dsDataModel.Supervisors);
                // atjauno tekošā taksta pozīciju
                bsSupervisors.Position = index;
            }

            return result;
        }

        private void btnCancelSupervisors_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Vai tiešām atcelt veiktās izmaiņas?",
                "Darbu vadītāju datu saglabāšana", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                dsDataModel.Supervisors.RejectChanges();
            }
        }

        private void tbpSupervisors_Leave(object sender, EventArgs e)
        {
            if (dsDataModel.HasChanges())
                UpdateSupervisors("Ir nesaglabāti labojumi darbu vadītāju datos." + " Vai saglabāt izmaiņas datu bāzē?");
        }

        private void frmQualifWorks_Load(object sender, EventArgs e)
        {
            taSupervisors.Fill(dsDataModel.Supervisors);
            taQualifWorksAndSupervisors.Fill(dsDataModel.QualifWorksAndSupervisors);
            taStudentsForGridView.Fill(dsDataModel.StudentsForGridView);

            Application.Idle += delegate (object Sender1, EventArgs e1)
            {
                // pogas Saglabāt un Atcelt iespējo tikai tad, ja datu kopā ir veiktas izmaiņas
                btnUpdateSupervisors.Enabled = dsDataModel.HasChanges();
                btnCancelSupervisors.Enabled = btnUpdateSupervisors.Enabled;
                btnTopicDelete.Enabled = btnTopicEdit.Enabled = bsQualifWorksAndSupervisors.Current != null;
                btnStudentEdit.Enabled = bsStudentsForGridView.Current != null;
                btnStudentDelete.Enabled = btnStudentEdit.Enabled;
            };
        }

        private void frmQualifWorks_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dsDataModel.HasChanges())
                if (DialogResult.Cancel == UpdateSupervisors("Ir nesaglabāti"
                    + " labojumi darbu vadītāju datos." + "Vai saglabāt izmaiņas datu bāzē?"))
                    e.Cancel = true;
        }

        private void btnTopicAdd_Click(object sender, EventArgs e)
        {
            frmQualifWorksTopic frm = new frmQualifWorksTopic();

            frm.AddNew();

            if (frm.ShowDialog() == DialogResult.OK)
                taQualifWorksAndSupervisors.Fill(dsDataModel.QualifWorksAndSupervisors);
        }

        private void btnTopicEdit_Click(object sender, EventArgs e)
        {
            frmQualifWorksTopic frm = new frmQualifWorksTopic();
            // ar šīm manipulāčijām tiek iegūts datu kešatmiņas
            // tekošā raksta objekts
            DataRowView rowView = (DataRowView)bsQualifWorksAndSupervisors.Current;

            if (rowView == null)
                return; // ja raksts nav izvēlēts (vai arī tāda nav), tad neturpināt

            DataModel.DataModelDataSet.QualifWorksAndSupervisorsRow row
                = (DataModel.DataModelDataSet.QualifWorksAndSupervisorsRow)rowView.Row;

            frm.Edit(row.TopicID);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                // saglabā raksta pozīciju
                int index = bsQualifWorksAndSupervisors.Position;
                taQualifWorksAndSupervisors.Fill(dsDataModel.QualifWorksAndSupervisors);
                // atjauno raksta pozīciju, jo metode Fill() to uzstāda uz 1
                bsQualifWorksAndSupervisors.Position = index;
            }
        }

        private void btnTopicDelete_Click(object sender, EventArgs e)
        {
            DataRowView rowView = (DataRowView)bsQualifWorksAndSupervisors.Current;
            if (rowView == null)
                return;
            DataModel.DataModelDataSet.QualifWorksAndSupervisorsRow row
                = (DataModel.DataModelDataSet.QualifWorksAndSupervisorsRow)rowView.Row;

            int index = bsQualifWorksAndSupervisors.Position;
            string errorMsg = "Tēmu neizdevās izdzēst! Pārbaudiet vai tā netiek izmantota un mēģiniet vēlreiz!";
            try
            {
                taQualifWorks.Delete(row.TopicID);
                taQualifWorksAndSupervisors.Fill(dsDataModel.QualifWorksAndSupervisors);
                bsQualifWorksAndSupervisors.Position = index;
            }
            catch (Exception)
            {
                MessageBox.Show(errorMsg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            frmStudent dlg = new frmStudent();
            dlg.AddNew();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                int index = bsStudentsForGridView.Position;
                taStudentsForGridView.Fill(dsDataModel.StudentsForGridView);
                if (-1 != index)
                    bsStudentsForGridView.Position = index;
            }
        }

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {
            DataRowView rowView = (DataRowView)bsStudentsForGridView.Current;
            if (rowView == null)
                return;

            DataModel.DataModelDataSet.StudentsForGridViewRow row
                = (DataModel.DataModelDataSet.StudentsForGridViewRow)rowView.Row;

            frmStudent dlg = new frmStudent();

            dlg.Edit(row.StudentID);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                int index = bsStudentsForGridView.Position;
                taStudentsForGridView.Fill(dsDataModel.StudentsForGridView);
                if (-1 != index)
                    bsStudentsForGridView.Position = index;
            }
        }
    }
}
