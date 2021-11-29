using DataModel;
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
    public partial class frmQualifWorksTopic : Form
    {
        public frmQualifWorksTopic()
        {
            InitializeComponent();

            cboLevel.DataSource = QualifLevel.Levels;
            cboLevel.DisplayMember = QualifLevel.DisplayMember;
            cboLevel.ValueMember = QualifLevel.ValueMember;

            taSupervisorName.Fill(dsDataModel.SupervisorName);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            if (txtTopic.Text.Length > 0)
            {
                erpQualifWorksTopic.SetError(this.txtTopic, String.Empty);
            }
            else
            {
                erpQualifWorksTopic.SetError(this.txtTopic, "Tēma ir tukša!");
            }

            if (cboSupervisor.SelectedItem != null)
            {
                erpQualifWorksTopic.SetError(this.cboSupervisor, String.Empty);
            }
            else
            {
                erpQualifWorksTopic.SetError(this.cboSupervisor, "Izvēlieties vadītāju!");
            }

            if (cboLevel.SelectedItem != null)
            {
                erpQualifWorksTopic.SetError(this.cboLevel, String.Empty);
            }
            else
            {
                erpQualifWorksTopic.SetError(this.cboLevel, "Izvēlieties līmeni!");
            }

            if (String.IsNullOrEmpty(erpQualifWorksTopic.GetError(txtTopic))
                && String.IsNullOrEmpty(erpQualifWorksTopic.GetError(cboSupervisor))
                && String.IsNullOrEmpty(erpQualifWorksTopic.GetError(cboLevel)))
            {
                try
                {
                    bsQualifWorks.EndEdit();
                    taQualifWorks.Update(dsDataModel.QualifWorks);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsQualifWorks.CancelEdit();
            this.DialogResult = DialogResult.Cancel;
        }

        public void AddNew()
        {
            // aktivizē jauna raksta pievienošanu
            bsQualifWorks.AddNew();
        }

        public void Edit(int topicId)
        {
            // aktivizē esoša raksta labošanu
            taQualifWorks.FillByTopicID(dsDataModel.QualifWorks, topicId);
        }
    }
}
