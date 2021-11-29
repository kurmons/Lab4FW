
namespace QualifWorksClient
{
    partial class frmQualifWorks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQualifWorks));
            this.tbcQualifWorks = new System.Windows.Forms.TabControl();
            this.tbpSupervisors = new System.Windows.Forms.TabPage();
            this.grbSupervisor = new System.Windows.Forms.GroupBox();
            this.cmbDegree = new System.Windows.Forms.ComboBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancelSupervisors = new System.Windows.Forms.Button();
            this.btnUpdateSupervisors = new System.Windows.Forms.Button();
            this.dgvSupervisors = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsSupervisors = new System.Windows.Forms.BindingSource(this.components);
            this.dsDataModel = new DataModel.DataModelDataSet();
            this.bnSupervisors = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbpStudents = new System.Windows.Forms.TabPage();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnStudentEdit = new System.Windows.Forms.Button();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStudentsForGridView = new System.Windows.Forms.BindingSource(this.components);
            this.btnTopicDelete = new System.Windows.Forms.Button();
            this.btnTopicEdit = new System.Windows.Forms.Button();
            this.btnTopicAdd = new System.Windows.Forms.Button();
            this.dgvQualifWorksTopics = new System.Windows.Forms.DataGridView();
            this.supervisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.topicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsQualifWorksAndSupervisors = new System.Windows.Forms.BindingSource(this.components);
            this.lblQualifWorksTopics = new System.Windows.Forms.Label();
            this.fKQualifWorksSupervisorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taQualifWorks = new DataModel.DataModelDataSetTableAdapters.QualifWorksTableAdapter();
            this.taSupervisors = new DataModel.DataModelDataSetTableAdapters.SupervisorsTableAdapter();
            this.taQualifWorksAndSupervisors = new DataModel.DataModelDataSetTableAdapters.QualifWorksAndSupervisorsTableAdapter();
            this.taStudentsForGridView = new DataModel.DataModelDataSetTableAdapters.StudentsForGridViewTableAdapter();
            this.tbcQualifWorks.SuspendLayout();
            this.tbpSupervisors.SuspendLayout();
            this.grbSupervisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupervisors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupervisors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnSupervisors)).BeginInit();
            this.bnSupervisors.SuspendLayout();
            this.tbpStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudentsForGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualifWorksTopics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQualifWorksAndSupervisors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQualifWorksSupervisorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcQualifWorks
            // 
            this.tbcQualifWorks.Controls.Add(this.tbpSupervisors);
            this.tbcQualifWorks.Controls.Add(this.tbpStudents);
            this.tbcQualifWorks.Location = new System.Drawing.Point(0, 0);
            this.tbcQualifWorks.Name = "tbcQualifWorks";
            this.tbcQualifWorks.SelectedIndex = 0;
            this.tbcQualifWorks.Size = new System.Drawing.Size(735, 554);
            this.tbcQualifWorks.TabIndex = 0;
            // 
            // tbpSupervisors
            // 
            this.tbpSupervisors.Controls.Add(this.grbSupervisor);
            this.tbpSupervisors.Controls.Add(this.btnCancelSupervisors);
            this.tbpSupervisors.Controls.Add(this.btnUpdateSupervisors);
            this.tbpSupervisors.Controls.Add(this.dgvSupervisors);
            this.tbpSupervisors.Controls.Add(this.bnSupervisors);
            this.tbpSupervisors.Location = new System.Drawing.Point(4, 25);
            this.tbpSupervisors.Name = "tbpSupervisors";
            this.tbpSupervisors.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSupervisors.Size = new System.Drawing.Size(727, 525);
            this.tbpSupervisors.TabIndex = 0;
            this.tbpSupervisors.Text = "Darbu vadītāji";
            this.tbpSupervisors.UseVisualStyleBackColor = true;
            this.tbpSupervisors.Leave += new System.EventHandler(this.tbpSupervisors_Leave);
            // 
            // grbSupervisor
            // 
            this.grbSupervisor.Controls.Add(this.cmbDegree);
            this.grbSupervisor.Controls.Add(this.txtSurname);
            this.grbSupervisor.Controls.Add(this.txtName);
            this.grbSupervisor.Controls.Add(this.lblPosition);
            this.grbSupervisor.Controls.Add(this.lblDegree);
            this.grbSupervisor.Controls.Add(this.lblSurname);
            this.grbSupervisor.Controls.Add(this.lblName);
            this.grbSupervisor.Location = new System.Drawing.Point(8, 291);
            this.grbSupervisor.Name = "grbSupervisor";
            this.grbSupervisor.Size = new System.Drawing.Size(359, 208);
            this.grbSupervisor.TabIndex = 4;
            this.grbSupervisor.TabStop = false;
            this.grbSupervisor.Text = "Darba vadītājs";
            // 
            // cmbDegree
            // 
            this.cmbDegree.FormattingEnabled = true;
            this.cmbDegree.Location = new System.Drawing.Point(175, 101);
            this.cmbDegree.Name = "cmbDegree";
            this.cmbDegree.Size = new System.Drawing.Size(164, 24);
            this.cmbDegree.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(175, 70);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(164, 22);
            this.txtSurname.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 22);
            this.txtName.TabIndex = 4;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(21, 130);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(51, 17);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "&Amats:";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(21, 101);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(127, 17);
            this.lblDegree.TabIndex = 2;
            this.lblDegree.Text = "&Zinātniskais grāds:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(21, 73);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 17);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "&Uzvārds:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "&Vārds:";
            // 
            // btnCancelSupervisors
            // 
            this.btnCancelSupervisors.Location = new System.Drawing.Point(613, 467);
            this.btnCancelSupervisors.Name = "btnCancelSupervisors";
            this.btnCancelSupervisors.Size = new System.Drawing.Size(84, 32);
            this.btnCancelSupervisors.TabIndex = 3;
            this.btnCancelSupervisors.Text = "Atcelt";
            this.btnCancelSupervisors.UseVisualStyleBackColor = true;
            this.btnCancelSupervisors.Click += new System.EventHandler(this.btnCancelSupervisors_Click);
            // 
            // btnUpdateSupervisors
            // 
            this.btnUpdateSupervisors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateSupervisors.Location = new System.Drawing.Point(507, 467);
            this.btnUpdateSupervisors.Name = "btnUpdateSupervisors";
            this.btnUpdateSupervisors.Size = new System.Drawing.Size(83, 32);
            this.btnUpdateSupervisors.TabIndex = 2;
            this.btnUpdateSupervisors.Text = "Saglabāt";
            this.btnUpdateSupervisors.UseVisualStyleBackColor = true;
            this.btnUpdateSupervisors.Click += new System.EventHandler(this.btnUpdateSupervisors_Click);
            // 
            // dgvSupervisors
            // 
            this.dgvSupervisors.AutoGenerateColumns = false;
            this.dgvSupervisors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupervisors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.dgvSupervisors.DataSource = this.bsSupervisors;
            this.dgvSupervisors.Location = new System.Drawing.Point(0, 35);
            this.dgvSupervisors.MultiSelect = false;
            this.dgvSupervisors.Name = "dgvSupervisors";
            this.dgvSupervisors.RowHeadersWidth = 51;
            this.dgvSupervisors.RowTemplate.Height = 24;
            this.dgvSupervisors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupervisors.Size = new System.Drawing.Size(732, 250);
            this.dgvSupervisors.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Vārds";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Uzvārds";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "Degree";
            this.degreeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.degreeDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Zinātniskais grāds";
            this.degreeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Dr.habil.sc.ing.",
            "Dr.sc.ing.",
            "Mg.sc.ing."});
            this.degreeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            this.degreeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.degreeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.degreeDataGridViewTextBoxColumn.Width = 120;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.positionDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.positionDataGridViewTextBoxColumn.HeaderText = "Amats";
            this.positionDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "akad.",
            "asist.",
            "asoc.prof.",
            "doc.",
            "lekt.",
            "prof."});
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.positionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.positionDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsSupervisors
            // 
            this.bsSupervisors.DataMember = "Supervisors";
            this.bsSupervisors.DataSource = this.dsDataModel;
            this.bsSupervisors.Sort = "Surname";
            // 
            // dsDataModel
            // 
            this.dsDataModel.DataSetName = "DataModelDataSet";
            this.dsDataModel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bnSupervisors
            // 
            this.bnSupervisors.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnSupervisors.BindingSource = this.bsSupervisors;
            this.bnSupervisors.CountItem = this.bindingNavigatorCountItem;
            this.bnSupervisors.CountItemFormat = "no {0}";
            this.bnSupervisors.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnSupervisors.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnSupervisors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bnSupervisors.Location = new System.Drawing.Point(3, 3);
            this.bnSupervisors.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnSupervisors.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnSupervisors.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnSupervisors.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnSupervisors.Name = "bnSupervisors";
            this.bnSupervisors.PositionItem = this.bindingNavigatorPositionItem;
            this.bnSupervisors.Size = new System.Drawing.Size(721, 27);
            this.bnSupervisors.TabIndex = 0;
            this.bnSupervisors.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "no {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbpStudents
            // 
            this.tbpStudents.Controls.Add(this.btnStudentDelete);
            this.tbpStudents.Controls.Add(this.btnStudentEdit);
            this.tbpStudents.Controls.Add(this.btnStudentAdd);
            this.tbpStudents.Controls.Add(this.dgvStudents);
            this.tbpStudents.Controls.Add(this.btnTopicDelete);
            this.tbpStudents.Controls.Add(this.btnTopicEdit);
            this.tbpStudents.Controls.Add(this.btnTopicAdd);
            this.tbpStudents.Controls.Add(this.dgvQualifWorksTopics);
            this.tbpStudents.Controls.Add(this.lblQualifWorksTopics);
            this.tbpStudents.Location = new System.Drawing.Point(4, 25);
            this.tbpStudents.Name = "tbpStudents";
            this.tbpStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tbpStudents.Size = new System.Drawing.Size(727, 525);
            this.tbpStudents.TabIndex = 1;
            this.tbpStudents.Text = "Studenti";
            this.tbpStudents.UseVisualStyleBackColor = true;
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(173, 142);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(75, 27);
            this.btnStudentDelete.TabIndex = 8;
            this.btnStudentDelete.Text = "Dzēst";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            // 
            // btnStudentEdit
            // 
            this.btnStudentEdit.Location = new System.Drawing.Point(92, 142);
            this.btnStudentEdit.Name = "btnStudentEdit";
            this.btnStudentEdit.Size = new System.Drawing.Size(75, 27);
            this.btnStudentEdit.TabIndex = 7;
            this.btnStudentEdit.Text = "Labot";
            this.btnStudentEdit.UseVisualStyleBackColor = true;
            this.btnStudentEdit.Click += new System.EventHandler(this.btnStudentEdit_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(6, 142);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(80, 27);
            this.btnStudentAdd.TabIndex = 6;
            this.btnStudentAdd.Text = "Pievienot";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentDataGridViewTextBoxColumn,
            this.topicDataGridViewTextBoxColumn1,
            this.supervisorDataGridViewTextBoxColumn1,
            this.reviewerDataGridViewTextBoxColumn});
            this.dgvStudents.DataSource = this.bsStudentsForGridView;
            this.dgvStudents.Location = new System.Drawing.Point(4, 10);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(465, 126);
            this.dgvStudents.TabIndex = 5;
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Students";
            this.studentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentDataGridViewTextBoxColumn.Width = 93;
            // 
            // topicDataGridViewTextBoxColumn1
            // 
            this.topicDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.topicDataGridViewTextBoxColumn1.DataPropertyName = "Topic";
            this.topicDataGridViewTextBoxColumn1.HeaderText = "Noslēguma darba tēma";
            this.topicDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.topicDataGridViewTextBoxColumn1.Name = "topicDataGridViewTextBoxColumn1";
            this.topicDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // supervisorDataGridViewTextBoxColumn1
            // 
            this.supervisorDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.supervisorDataGridViewTextBoxColumn1.DataPropertyName = "Supervisor";
            this.supervisorDataGridViewTextBoxColumn1.HeaderText = "Vadītājs";
            this.supervisorDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.supervisorDataGridViewTextBoxColumn1.Name = "supervisorDataGridViewTextBoxColumn1";
            this.supervisorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.supervisorDataGridViewTextBoxColumn1.Width = 87;
            // 
            // reviewerDataGridViewTextBoxColumn
            // 
            this.reviewerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.reviewerDataGridViewTextBoxColumn.DataPropertyName = "Reviewer";
            this.reviewerDataGridViewTextBoxColumn.HeaderText = "Recenzents";
            this.reviewerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reviewerDataGridViewTextBoxColumn.Name = "reviewerDataGridViewTextBoxColumn";
            this.reviewerDataGridViewTextBoxColumn.ReadOnly = true;
            this.reviewerDataGridViewTextBoxColumn.Width = 112;
            // 
            // bsStudentsForGridView
            // 
            this.bsStudentsForGridView.AllowNew = false;
            this.bsStudentsForGridView.DataMember = "StudentsForGridView";
            this.bsStudentsForGridView.DataSource = this.dsDataModel;
            // 
            // btnTopicDelete
            // 
            this.btnTopicDelete.Location = new System.Drawing.Point(173, 339);
            this.btnTopicDelete.Name = "btnTopicDelete";
            this.btnTopicDelete.Size = new System.Drawing.Size(75, 27);
            this.btnTopicDelete.TabIndex = 4;
            this.btnTopicDelete.Text = "Dzēst";
            this.btnTopicDelete.UseVisualStyleBackColor = true;
            this.btnTopicDelete.Click += new System.EventHandler(this.btnTopicDelete_Click);
            // 
            // btnTopicEdit
            // 
            this.btnTopicEdit.Location = new System.Drawing.Point(92, 339);
            this.btnTopicEdit.Name = "btnTopicEdit";
            this.btnTopicEdit.Size = new System.Drawing.Size(75, 27);
            this.btnTopicEdit.TabIndex = 3;
            this.btnTopicEdit.Text = "Labot";
            this.btnTopicEdit.UseVisualStyleBackColor = true;
            this.btnTopicEdit.Click += new System.EventHandler(this.btnTopicEdit_Click);
            // 
            // btnTopicAdd
            // 
            this.btnTopicAdd.Location = new System.Drawing.Point(6, 339);
            this.btnTopicAdd.Name = "btnTopicAdd";
            this.btnTopicAdd.Size = new System.Drawing.Size(80, 27);
            this.btnTopicAdd.TabIndex = 2;
            this.btnTopicAdd.Text = "Pievienot";
            this.btnTopicAdd.UseVisualStyleBackColor = true;
            this.btnTopicAdd.Click += new System.EventHandler(this.btnTopicAdd_Click);
            // 
            // dgvQualifWorksTopics
            // 
            this.dgvQualifWorksTopics.AllowUserToAddRows = false;
            this.dgvQualifWorksTopics.AllowUserToDeleteRows = false;
            this.dgvQualifWorksTopics.AutoGenerateColumns = false;
            this.dgvQualifWorksTopics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQualifWorksTopics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supervisorDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.topicDataGridViewTextBoxColumn,
            this.supervisorIDDataGridViewTextBoxColumn,
            this.topicIDDataGridViewTextBoxColumn});
            this.dgvQualifWorksTopics.DataSource = this.bsQualifWorksAndSupervisors;
            this.dgvQualifWorksTopics.Location = new System.Drawing.Point(4, 196);
            this.dgvQualifWorksTopics.MultiSelect = false;
            this.dgvQualifWorksTopics.Name = "dgvQualifWorksTopics";
            this.dgvQualifWorksTopics.ReadOnly = true;
            this.dgvQualifWorksTopics.RowHeadersWidth = 51;
            this.dgvQualifWorksTopics.RowTemplate.Height = 24;
            this.dgvQualifWorksTopics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQualifWorksTopics.Size = new System.Drawing.Size(465, 137);
            this.dgvQualifWorksTopics.TabIndex = 1;
            // 
            // supervisorDataGridViewTextBoxColumn
            // 
            this.supervisorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.supervisorDataGridViewTextBoxColumn.DataPropertyName = "Supervisor";
            this.supervisorDataGridViewTextBoxColumn.HeaderText = "Tēmas piedāvātājs";
            this.supervisorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supervisorDataGridViewTextBoxColumn.Name = "supervisorDataGridViewTextBoxColumn";
            this.supervisorDataGridViewTextBoxColumn.ReadOnly = true;
            this.supervisorDataGridViewTextBoxColumn.Width = 143;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.levelDataGridViewTextBoxColumn.HeaderText = "Studiju līmenis";
            this.levelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            this.levelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.levelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.levelDataGridViewTextBoxColumn.Width = 125;
            // 
            // topicDataGridViewTextBoxColumn
            // 
            this.topicDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.topicDataGridViewTextBoxColumn.DataPropertyName = "Topic";
            this.topicDataGridViewTextBoxColumn.HeaderText = "Tēma";
            this.topicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.topicDataGridViewTextBoxColumn.Name = "topicDataGridViewTextBoxColumn";
            this.topicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supervisorIDDataGridViewTextBoxColumn
            // 
            this.supervisorIDDataGridViewTextBoxColumn.DataPropertyName = "SupervisorID";
            this.supervisorIDDataGridViewTextBoxColumn.HeaderText = "SupervisorID";
            this.supervisorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supervisorIDDataGridViewTextBoxColumn.Name = "supervisorIDDataGridViewTextBoxColumn";
            this.supervisorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supervisorIDDataGridViewTextBoxColumn.Visible = false;
            this.supervisorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // topicIDDataGridViewTextBoxColumn
            // 
            this.topicIDDataGridViewTextBoxColumn.DataPropertyName = "TopicID";
            this.topicIDDataGridViewTextBoxColumn.HeaderText = "TopicID";
            this.topicIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.topicIDDataGridViewTextBoxColumn.Name = "topicIDDataGridViewTextBoxColumn";
            this.topicIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.topicIDDataGridViewTextBoxColumn.Visible = false;
            this.topicIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsQualifWorksAndSupervisors
            // 
            this.bsQualifWorksAndSupervisors.AllowNew = false;
            this.bsQualifWorksAndSupervisors.DataMember = "QualifWorksAndSupervisors";
            this.bsQualifWorksAndSupervisors.DataSource = this.dsDataModel;
            // 
            // lblQualifWorksTopics
            // 
            this.lblQualifWorksTopics.AutoSize = true;
            this.lblQualifWorksTopics.Location = new System.Drawing.Point(6, 172);
            this.lblQualifWorksTopics.Name = "lblQualifWorksTopics";
            this.lblQualifWorksTopics.Size = new System.Drawing.Size(166, 17);
            this.lblQualifWorksTopics.TabIndex = 0;
            this.lblQualifWorksTopics.Text = "Noslēguma darbu tēmas:";
            // 
            // fKQualifWorksSupervisorsBindingSource
            // 
            this.fKQualifWorksSupervisorsBindingSource.DataMember = "FK_QualifWorks_Supervisors";
            this.fKQualifWorksSupervisorsBindingSource.DataSource = this.bsSupervisors;
            // 
            // taQualifWorks
            // 
            this.taQualifWorks.ClearBeforeFill = true;
            // 
            // taSupervisors
            // 
            this.taSupervisors.ClearBeforeFill = true;
            // 
            // taQualifWorksAndSupervisors
            // 
            this.taQualifWorksAndSupervisors.ClearBeforeFill = true;
            // 
            // taStudentsForGridView
            // 
            this.taStudentsForGridView.ClearBeforeFill = true;
            // 
            // frmQualifWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 553);
            this.Controls.Add(this.tbcQualifWorks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQualifWorks";
            this.Text = "Noslēguma darbi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQualifWorks_FormClosing);
            this.Load += new System.EventHandler(this.frmQualifWorks_Load);
            this.tbcQualifWorks.ResumeLayout(false);
            this.tbpSupervisors.ResumeLayout(false);
            this.tbpSupervisors.PerformLayout();
            this.grbSupervisor.ResumeLayout(false);
            this.grbSupervisor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupervisors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupervisors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnSupervisors)).EndInit();
            this.bnSupervisors.ResumeLayout(false);
            this.bnSupervisors.PerformLayout();
            this.tbpStudents.ResumeLayout(false);
            this.tbpStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudentsForGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualifWorksTopics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQualifWorksAndSupervisors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQualifWorksSupervisorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcQualifWorks;
        private System.Windows.Forms.TabPage tbpSupervisors;
        private System.Windows.Forms.TabPage tbpStudents;
        private DataModel.DataModelDataSet dsDataModel;
        private DataModel.DataModelDataSetTableAdapters.QualifWorksTableAdapter taQualifWorks;
        private DataModel.DataModelDataSetTableAdapters.SupervisorsTableAdapter taSupervisors;
        private System.Windows.Forms.DataGridView dgvSupervisors;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn degreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsSupervisors;
        private System.Windows.Forms.BindingNavigator bnSupervisors;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnUpdateSupervisors;
        private System.Windows.Forms.Button btnCancelSupervisors;
        private System.Windows.Forms.GroupBox grbSupervisor;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbDegree;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.BindingSource fKQualifWorksSupervisorsBindingSource;
        private System.Windows.Forms.DataGridView dgvQualifWorksTopics;
        private System.Windows.Forms.Label lblQualifWorksTopics;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsQualifWorksAndSupervisors;
        private DataModel.DataModelDataSetTableAdapters.QualifWorksAndSupervisorsTableAdapter taQualifWorksAndSupervisors;
        private System.Windows.Forms.Button btnTopicDelete;
        private System.Windows.Forms.Button btnTopicEdit;
        private System.Windows.Forms.Button btnTopicAdd;
        private System.Windows.Forms.DataGridView dgvStudents;
        private DataModel.DataModelDataSetTableAdapters.StudentsForGridViewTableAdapter taStudentsForGridView;
        private System.Windows.Forms.BindingSource bsStudentsForGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentEdit;
        private System.Windows.Forms.Button btnStudentAdd;
    }
}

