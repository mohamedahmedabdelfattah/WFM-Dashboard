namespace WFMDashboard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colFormType = new System.Windows.Forms.TabControl();
            this.tabAdherenceAdjustment = new System.Windows.Forms.TabPage();
            this.comboFollowerLeader = new System.Windows.Forms.ComboBox();
            this.leadersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wFMDashboardDataSet = new WFMDashboard.WFMDashboardDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAttachment = new System.Windows.Forms.Button();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblFollowedBy = new System.Windows.Forms.Label();
            this.lblProblemEnd = new System.Windows.Forms.Label();
            this.lblProblemStart = new System.Windows.Forms.Label();
            this.lblProblemType = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTeamLeader = new System.Windows.Forms.Label();
            this.lblAgentName = new System.Windows.Forms.Label();
            this.dateProblemStart = new System.Windows.Forms.DateTimePicker();
            this.dateProblemEnd = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.comboFollowerWFM = new System.Windows.Forms.ComboBox();
            this.wFMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioLeaders = new System.Windows.Forms.RadioButton();
            this.radioWFM = new System.Windows.Forms.RadioButton();
            this.comboProblemType = new System.Windows.Forms.ComboBox();
            this.problemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboAgentName = new System.Windows.Forms.ComboBox();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAgentID = new System.Windows.Forms.TextBox();
            this.comboLeadername = new System.Windows.Forms.ComboBox();
            this.leadersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabSwap = new System.Windows.Forms.TabPage();
            this.tabExcuse = new System.Windows.Forms.TabPage();
            this.tabBreakModification = new System.Windows.Forms.TabPage();
            this.tabAnnual = new System.Windows.Forms.TabPage();
            this.tabSick = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.problemsTableAdapter = new WFMDashboard.WFMDashboardDataSetTableAdapters.ProblemsTableAdapter();
            this.agentsTableAdapter = new WFMDashboard.WFMDashboardDataSetTableAdapters.AgentsTableAdapter();
            this.leadersTableAdapter = new WFMDashboard.WFMDashboardDataSetTableAdapters.LeadersTableAdapter();
            this.wFMTableAdapter = new WFMDashboard.WFMDashboardDataSetTableAdapters.WFMTableAdapter();
            this.colFormType.SuspendLayout();
            this.tabAdherenceAdjustment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wFMDashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wFMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // colFormType
            // 
            this.colFormType.Controls.Add(this.tabAdherenceAdjustment);
            this.colFormType.Controls.Add(this.tabSwap);
            this.colFormType.Controls.Add(this.tabExcuse);
            this.colFormType.Controls.Add(this.tabBreakModification);
            this.colFormType.Controls.Add(this.tabAnnual);
            this.colFormType.Controls.Add(this.tabSick);
            this.colFormType.Location = new System.Drawing.Point(0, 0);
            this.colFormType.Name = "colFormType";
            this.colFormType.SelectedIndex = 0;
            this.colFormType.Size = new System.Drawing.Size(793, 459);
            this.colFormType.TabIndex = 1;
            // 
            // tabAdherenceAdjustment
            // 
            this.tabAdherenceAdjustment.Controls.Add(this.comboFollowerLeader);
            this.tabAdherenceAdjustment.Controls.Add(this.dateTimePicker1);
            this.tabAdherenceAdjustment.Controls.Add(this.lblDate);
            this.tabAdherenceAdjustment.Controls.Add(this.pictureBox1);
            this.tabAdherenceAdjustment.Controls.Add(this.btnAttachment);
            this.tabAdherenceAdjustment.Controls.Add(this.lblAttachment);
            this.tabAdherenceAdjustment.Controls.Add(this.btnSubmit);
            this.tabAdherenceAdjustment.Controls.Add(this.lblNote);
            this.tabAdherenceAdjustment.Controls.Add(this.lblFollowedBy);
            this.tabAdherenceAdjustment.Controls.Add(this.lblProblemEnd);
            this.tabAdherenceAdjustment.Controls.Add(this.lblProblemStart);
            this.tabAdherenceAdjustment.Controls.Add(this.lblProblemType);
            this.tabAdherenceAdjustment.Controls.Add(this.lblID);
            this.tabAdherenceAdjustment.Controls.Add(this.lblTeamLeader);
            this.tabAdherenceAdjustment.Controls.Add(this.lblAgentName);
            this.tabAdherenceAdjustment.Controls.Add(this.dateProblemStart);
            this.tabAdherenceAdjustment.Controls.Add(this.dateProblemEnd);
            this.tabAdherenceAdjustment.Controls.Add(this.txtNotes);
            this.tabAdherenceAdjustment.Controls.Add(this.comboFollowerWFM);
            this.tabAdherenceAdjustment.Controls.Add(this.radioLeaders);
            this.tabAdherenceAdjustment.Controls.Add(this.radioWFM);
            this.tabAdherenceAdjustment.Controls.Add(this.comboProblemType);
            this.tabAdherenceAdjustment.Controls.Add(this.comboAgentName);
            this.tabAdherenceAdjustment.Controls.Add(this.txtAgentID);
            this.tabAdherenceAdjustment.Controls.Add(this.comboLeadername);
            this.tabAdherenceAdjustment.Location = new System.Drawing.Point(4, 22);
            this.tabAdherenceAdjustment.Name = "tabAdherenceAdjustment";
            this.tabAdherenceAdjustment.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdherenceAdjustment.Size = new System.Drawing.Size(785, 433);
            this.tabAdherenceAdjustment.TabIndex = 0;
            this.tabAdherenceAdjustment.Text = "Adherence Adjustment";
            this.tabAdherenceAdjustment.UseVisualStyleBackColor = true;
            // 
            // comboFollowerLeader
            // 
            this.comboFollowerLeader.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboFollowerLeader.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboFollowerLeader.DataSource = this.leadersBindingSource1;
            this.comboFollowerLeader.DisplayMember = "Name";
            this.comboFollowerLeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFollowerLeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFollowerLeader.FormattingEnabled = true;
            this.comboFollowerLeader.Location = new System.Drawing.Point(121, 243);
            this.comboFollowerLeader.Name = "comboFollowerLeader";
            this.comboFollowerLeader.Size = new System.Drawing.Size(253, 24);
            this.comboFollowerLeader.TabIndex = 51;
            this.comboFollowerLeader.Visible = false;
            // 
            // leadersBindingSource1
            // 
            this.leadersBindingSource1.DataMember = "Leaders";
            this.leadersBindingSource1.DataSource = this.wFMDashboardDataSet;
            // 
            // wFMDashboardDataSet
            // 
            this.wFMDashboardDataSet.DataSetName = "WFMDashboardDataSet";
            this.wFMDashboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 20);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(15, 158);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 49;
            this.lblDate.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WFMDashboard.Properties.Resources.C20715CA;
            this.pictureBox1.Location = new System.Drawing.Point(394, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // btnAttachment
            // 
            this.btnAttachment.Location = new System.Drawing.Point(471, 19);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(71, 32);
            this.btnAttachment.TabIndex = 47;
            this.btnAttachment.Text = "Insert";
            this.btnAttachment.UseVisualStyleBackColor = true;
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachment.Location = new System.Drawing.Point(391, 27);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(74, 16);
            this.lblAttachment.TabIndex = 46;
            this.lblAttachment.Text = "Attachment";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(319, 380);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(146, 40);
            this.btnSubmit.TabIndex = 45;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(15, 276);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(37, 16);
            this.lblNote.TabIndex = 44;
            this.lblNote.Text = "Note";
            // 
            // lblFollowedBy
            // 
            this.lblFollowedBy.AutoSize = true;
            this.lblFollowedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowedBy.Location = new System.Drawing.Point(15, 216);
            this.lblFollowedBy.Name = "lblFollowedBy";
            this.lblFollowedBy.Size = new System.Drawing.Size(82, 16);
            this.lblFollowedBy.TabIndex = 43;
            this.lblFollowedBy.Text = "Followed By";
            // 
            // lblProblemEnd
            // 
            this.lblProblemEnd.AutoSize = true;
            this.lblProblemEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemEnd.Location = new System.Drawing.Point(246, 186);
            this.lblProblemEnd.Name = "lblProblemEnd";
            this.lblProblemEnd.Size = new System.Drawing.Size(26, 16);
            this.lblProblemEnd.TabIndex = 42;
            this.lblProblemEnd.Text = "Till";
            // 
            // lblProblemStart
            // 
            this.lblProblemStart.AutoSize = true;
            this.lblProblemStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemStart.Location = new System.Drawing.Point(118, 186);
            this.lblProblemStart.Name = "lblProblemStart";
            this.lblProblemStart.Size = new System.Drawing.Size(39, 16);
            this.lblProblemStart.TabIndex = 41;
            this.lblProblemStart.Text = "From";
            // 
            // lblProblemType
            // 
            this.lblProblemType.AutoSize = true;
            this.lblProblemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemType.Location = new System.Drawing.Point(15, 124);
            this.lblProblemType.Name = "lblProblemType";
            this.lblProblemType.Size = new System.Drawing.Size(94, 16);
            this.lblProblemType.TabIndex = 40;
            this.lblProblemType.Text = "Problem Type";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(15, 93);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 16);
            this.lblID.TabIndex = 39;
            this.lblID.Text = "ID";
            // 
            // lblTeamLeader
            // 
            this.lblTeamLeader.AutoSize = true;
            this.lblTeamLeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamLeader.Location = new System.Drawing.Point(15, 60);
            this.lblTeamLeader.Name = "lblTeamLeader";
            this.lblTeamLeader.Size = new System.Drawing.Size(90, 16);
            this.lblTeamLeader.TabIndex = 38;
            this.lblTeamLeader.Text = "Team Leader";
            // 
            // lblAgentName
            // 
            this.lblAgentName.AutoSize = true;
            this.lblAgentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentName.Location = new System.Drawing.Point(15, 27);
            this.lblAgentName.Name = "lblAgentName";
            this.lblAgentName.Size = new System.Drawing.Size(83, 16);
            this.lblAgentName.TabIndex = 37;
            this.lblAgentName.Text = "Agent Name";
            // 
            // dateProblemStart
            // 
            this.dateProblemStart.Checked = false;
            this.dateProblemStart.CustomFormat = "hh:mm";
            this.dateProblemStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateProblemStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateProblemStart.Location = new System.Drawing.Point(161, 183);
            this.dateProblemStart.Name = "dateProblemStart";
            this.dateProblemStart.ShowUpDown = true;
            this.dateProblemStart.Size = new System.Drawing.Size(57, 22);
            this.dateProblemStart.TabIndex = 36;
            // 
            // dateProblemEnd
            // 
            this.dateProblemEnd.Checked = false;
            this.dateProblemEnd.CustomFormat = "hh:mm";
            this.dateProblemEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateProblemEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateProblemEnd.Location = new System.Drawing.Point(278, 183);
            this.dateProblemEnd.Name = "dateProblemEnd";
            this.dateProblemEnd.ShowUpDown = true;
            this.dateProblemEnd.Size = new System.Drawing.Size(57, 22);
            this.dateProblemEnd.TabIndex = 35;
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.LightGray;
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotes.DetectUrls = false;
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(121, 276);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(253, 87);
            this.txtNotes.TabIndex = 34;
            this.txtNotes.Text = "";
            // 
            // comboFollowerWFM
            // 
            this.comboFollowerWFM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboFollowerWFM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboFollowerWFM.DataSource = this.wFMBindingSource;
            this.comboFollowerWFM.DisplayMember = "Name";
            this.comboFollowerWFM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFollowerWFM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFollowerWFM.FormattingEnabled = true;
            this.comboFollowerWFM.Location = new System.Drawing.Point(121, 243);
            this.comboFollowerWFM.Name = "comboFollowerWFM";
            this.comboFollowerWFM.Size = new System.Drawing.Size(253, 24);
            this.comboFollowerWFM.TabIndex = 32;
            // 
            // wFMBindingSource
            // 
            this.wFMBindingSource.DataMember = "WFM";
            this.wFMBindingSource.DataSource = this.wFMDashboardDataSet;
            // 
            // radioLeaders
            // 
            this.radioLeaders.AutoSize = true;
            this.radioLeaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLeaders.Location = new System.Drawing.Point(249, 214);
            this.radioLeaders.Name = "radioLeaders";
            this.radioLeaders.Size = new System.Drawing.Size(69, 20);
            this.radioLeaders.TabIndex = 31;
            this.radioLeaders.Text = "Leader";
            this.radioLeaders.UseVisualStyleBackColor = true;
            this.radioLeaders.CheckedChanged += new System.EventHandler(this.radioLeaders_CheckedChanged);
            // 
            // radioWFM
            // 
            this.radioWFM.AutoSize = true;
            this.radioWFM.Checked = true;
            this.radioWFM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWFM.Location = new System.Drawing.Point(121, 214);
            this.radioWFM.Name = "radioWFM";
            this.radioWFM.Size = new System.Drawing.Size(97, 20);
            this.radioWFM.TabIndex = 30;
            this.radioWFM.TabStop = true;
            this.radioWFM.Text = "WFM (5200)";
            this.radioWFM.UseVisualStyleBackColor = true;
            // 
            // comboProblemType
            // 
            this.comboProblemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboProblemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboProblemType.DataSource = this.problemsBindingSource;
            this.comboProblemType.DisplayMember = "Name";
            this.comboProblemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProblemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProblemType.FormattingEnabled = true;
            this.comboProblemType.Location = new System.Drawing.Point(121, 121);
            this.comboProblemType.Name = "comboProblemType";
            this.comboProblemType.Size = new System.Drawing.Size(253, 24);
            this.comboProblemType.TabIndex = 25;
            // 
            // problemsBindingSource
            // 
            this.problemsBindingSource.AllowNew = true;
            this.problemsBindingSource.DataMember = "Problems";
            this.problemsBindingSource.DataSource = this.wFMDashboardDataSet;
            // 
            // comboAgentName
            // 
            this.comboAgentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboAgentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAgentName.DataSource = this.agentsBindingSource;
            this.comboAgentName.DisplayMember = "Name";
            this.comboAgentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAgentName.FormattingEnabled = true;
            this.comboAgentName.Location = new System.Drawing.Point(121, 24);
            this.comboAgentName.Name = "comboAgentName";
            this.comboAgentName.Size = new System.Drawing.Size(253, 24);
            this.comboAgentName.TabIndex = 24;
            // 
            // agentsBindingSource
            // 
            this.agentsBindingSource.DataMember = "Agents";
            this.agentsBindingSource.DataSource = this.wFMDashboardDataSet;
            // 
            // txtAgentID
            // 
            this.txtAgentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentID.Location = new System.Drawing.Point(121, 90);
            this.txtAgentID.Name = "txtAgentID";
            this.txtAgentID.Size = new System.Drawing.Size(253, 22);
            this.txtAgentID.TabIndex = 21;
            // 
            // comboLeadername
            // 
            this.comboLeadername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboLeadername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboLeadername.DataSource = this.leadersBindingSource;
            this.comboLeadername.DisplayMember = "Name";
            this.comboLeadername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLeadername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLeadername.FormattingEnabled = true;
            this.comboLeadername.Location = new System.Drawing.Point(121, 57);
            this.comboLeadername.Name = "comboLeadername";
            this.comboLeadername.Size = new System.Drawing.Size(253, 24);
            this.comboLeadername.TabIndex = 19;
            // 
            // leadersBindingSource
            // 
            this.leadersBindingSource.DataMember = "Leaders";
            this.leadersBindingSource.DataSource = this.wFMDashboardDataSet;
            // 
            // tabSwap
            // 
            this.tabSwap.Location = new System.Drawing.Point(4, 22);
            this.tabSwap.Name = "tabSwap";
            this.tabSwap.Padding = new System.Windows.Forms.Padding(3);
            this.tabSwap.Size = new System.Drawing.Size(785, 433);
            this.tabSwap.TabIndex = 2;
            this.tabSwap.Text = "Swap";
            this.tabSwap.UseVisualStyleBackColor = true;
            // 
            // tabExcuse
            // 
            this.tabExcuse.Location = new System.Drawing.Point(4, 22);
            this.tabExcuse.Name = "tabExcuse";
            this.tabExcuse.Padding = new System.Windows.Forms.Padding(3);
            this.tabExcuse.Size = new System.Drawing.Size(785, 433);
            this.tabExcuse.TabIndex = 3;
            this.tabExcuse.Text = "Excuse";
            this.tabExcuse.UseVisualStyleBackColor = true;
            // 
            // tabBreakModification
            // 
            this.tabBreakModification.Location = new System.Drawing.Point(4, 22);
            this.tabBreakModification.Name = "tabBreakModification";
            this.tabBreakModification.Padding = new System.Windows.Forms.Padding(3);
            this.tabBreakModification.Size = new System.Drawing.Size(785, 433);
            this.tabBreakModification.TabIndex = 1;
            this.tabBreakModification.Text = "Break Modification";
            this.tabBreakModification.UseVisualStyleBackColor = true;
            // 
            // tabAnnual
            // 
            this.tabAnnual.Location = new System.Drawing.Point(4, 22);
            this.tabAnnual.Name = "tabAnnual";
            this.tabAnnual.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnnual.Size = new System.Drawing.Size(785, 433);
            this.tabAnnual.TabIndex = 4;
            this.tabAnnual.Text = "Annual";
            this.tabAnnual.UseVisualStyleBackColor = true;
            // 
            // tabSick
            // 
            this.tabSick.Location = new System.Drawing.Point(4, 22);
            this.tabSick.Name = "tabSick";
            this.tabSick.Padding = new System.Windows.Forms.Padding(3);
            this.tabSick.Size = new System.Drawing.Size(785, 433);
            this.tabSick.TabIndex = 5;
            this.tabSick.Text = "Sick";
            this.tabSick.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter");
            this.openFileDialog1.Title = "Choose Picture";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(5, 463);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(174, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "mohamed.aabdelfattah@tedata.net";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(732, 464);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(46, 13);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "v0.0.0.0";
            // 
            // problemsTableAdapter
            // 
            this.problemsTableAdapter.ClearBeforeFill = true;
            // 
            // agentsTableAdapter
            // 
            this.agentsTableAdapter.ClearBeforeFill = true;
            // 
            // leadersTableAdapter
            // 
            this.leadersTableAdapter.ClearBeforeFill = true;
            // 
            // wFMTableAdapter
            // 
            this.wFMTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.colFormType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WFM Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.colFormType.ResumeLayout(false);
            this.tabAdherenceAdjustment.ResumeLayout(false);
            this.tabAdherenceAdjustment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wFMDashboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wFMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl colFormType;
        private System.Windows.Forms.TabPage tabAdherenceAdjustment;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.ComboBox comboFollowerWFM;
        private System.Windows.Forms.RadioButton radioLeaders;
        private System.Windows.Forms.RadioButton radioWFM;
        private System.Windows.Forms.ComboBox comboProblemType;
        private System.Windows.Forms.ComboBox comboAgentName;
        private System.Windows.Forms.TextBox txtAgentID;
        private System.Windows.Forms.ComboBox comboLeadername;
        private System.Windows.Forms.TabPage tabSwap;
        private System.Windows.Forms.TabPage tabExcuse;
        private System.Windows.Forms.TabPage tabBreakModification;
        private System.Windows.Forms.TabPage tabAnnual;
        private System.Windows.Forms.TabPage tabSick;
        private System.Windows.Forms.DateTimePicker dateProblemStart;
        private System.Windows.Forms.DateTimePicker dateProblemEnd;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblFollowedBy;
        private System.Windows.Forms.Label lblProblemEnd;
        private System.Windows.Forms.Label lblProblemStart;
        private System.Windows.Forms.Label lblProblemType;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTeamLeader;
        private System.Windows.Forms.Label lblAgentName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAttachment;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblVersion;
        private WFMDashboardDataSet wFMDashboardDataSet;
        private System.Windows.Forms.BindingSource problemsBindingSource;
        private WFMDashboardDataSetTableAdapters.ProblemsTableAdapter problemsTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private WFMDashboardDataSetTableAdapters.AgentsTableAdapter agentsTableAdapter;
        private System.Windows.Forms.BindingSource leadersBindingSource;
        private WFMDashboardDataSetTableAdapters.LeadersTableAdapter leadersTableAdapter;
        private System.Windows.Forms.ComboBox comboFollowerLeader;
        private System.Windows.Forms.BindingSource wFMBindingSource;
        private WFMDashboardDataSetTableAdapters.WFMTableAdapter wFMTableAdapter;
        private System.Windows.Forms.BindingSource leadersBindingSource1;

    }
}

