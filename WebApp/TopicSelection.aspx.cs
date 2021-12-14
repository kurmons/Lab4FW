using DataModel.DataModelDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class TopicSelection : System.Web.UI.Page
    {
        // Pirmā soļa - tēmu saraksta skata sagatavošana rādīšanai
        private void SetupView0()
        {
            // uzstāda pārlūka lapā rādāmo View kontroli
            mvTopicSelection.SetActiveView(vwTopicSelection);
            btnNext.Visible = true;
            // ļaut turpināt tikai tad, kad ir izvēlēta tēma
            btnNext.Enabled = gvTopicSelection.SelectedIndex != -1;
            btnBack.Visible = btnReserve.Visible = false;
        }

        // Otrā soļa - studenta datu skata sagatavošana rādīšanai
        private void SetupView1()
        {
            mvTopicSelection.SetActiveView(vwStudentData);
            btnNext.Visible = false;
            btnBack.Visible = btnReserve.Visible = true;
            lblTopicName.Text = "Tēma: " + gvTopicSelection.SelectedRow.Cells[1].Text;
            lblTopicSupervisor.Text = " Vadītājs: " + gvTopicSelection.SelectedRow.Cells[0].Text;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // atverot lapu, pēc noklusēšanas tiek rādīts pirmais solis:
            SetupView0();

            if (!btnNext.Enabled)
                lblStatus.Text = "Lai turpinātu, izvēlēties sev vēlamo studiju līmeni un noslēguma darba tēmu.";
        }

        protected void gvTopicSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = (gvTopicSelection.SelectedIndex != -1);

            if (btnNext.Enabled)
                lblStatus.Text = "";
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            SetupView0();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            SetupView1();
        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            if (!IsValid)   // Ja formas lauki nav veiksmīgi validēti,
                SetupView1(); // tad paliek otrajā solī.
            else try
                {
                    // izmantojot noģenerētās klases, piekļūt tabulas Students datiem
                    var taStudents = new StudentsTableAdapter();

                    var tblStudents = new DataModel.DataModelDataSet.StudentsDataTable();

                    // izveido jaunu raksta instanci
                    var newRow = tblStudents.NewStudentsRow();

                    if (taStudents.GetTopic(txtStudentId.Text, txtStudentName.Text, txtStudentSurname.Text) != null)
                    {
                        // uzstāda informāciju lietotājam par neveiksmīgu pievienošanu
                        lblStatus.Text = "Tēma jau ir reģistrēta šādam lietotājam!";
                        // inicializē laukus, sagatavojot jaunas tēmas ievadīšanai
                        txtStudentName.Text = txtStudentSurname.Text = "";
                        gvTopicSelection.SelectedIndex = -1;
                        SetupView0(); // lai pārietu uz pirmo soli
                    }
                    else
                    {
                        // uzstāda jaunā raksta vērtības
                        newRow.Name = txtStudentName.Text;
                        newRow.Surname = txtStudentSurname.Text;
                        newRow.IDCard = txtStudentId.Text;
                        newRow.Level = Convert.ToInt32(ddlQualifLevel.SelectedValue);
                        newRow.Notes = "Rezervēts no tīmekļa.";
                        newRow.TopicID = (int)gvTopicSelection.SelectedDataKey["TopicID"];

                        // pievieno raksta instanci lokālajai datu kešatmiņai
                        tblStudents.AddStudentsRow(newRow);
                        // aktualizē izmaiņas datu bāzē
                        taStudents.Update(tblStudents);
                        // aktualizē tēmu saraksta tabulas datus tīmekļa lapā
                        gvTopicSelection.DataBind();
                        // uzstāda informāciju lietotājam par veiksmīgu pievienošanu
                        lblStatus.Text = "Paldies, tēmas rezervēšana bija veiksmīga!";
                        // inicializē laukus, sagatavojot jaunas tēmas ievadīšanai
                        txtStudentName.Text = txtStudentSurname.Text = "";
                        gvTopicSelection.SelectedIndex = -1;
                        SetupView0(); // lai pārietu uz pirmo soli
                    }
                    
                }
                catch (Exception ex)
                {
                    lblStatus.Text = ex.Message;
                    SetupView1(); // lai paliktu otrajā solī
                }
        }
    }
}