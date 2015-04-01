/*
 * Creado por SharpDevelop.
 * Usuario: BENITO
 * Fecha: 24/05/2011
 * Hora: 11:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CameratrapManager
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.msMain = new System.Windows.Forms.MenuStrip();
			this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.existingProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cameraStationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbRemoveStation = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbSelectStationImage = new System.Windows.Forms.ToolStripMenuItem();
			this.photoSamplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uploadSamplesToStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeCurrentSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbDataToExcel = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbCompletePDF = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbCreateAbundancesShapefiles = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tvProject = new System.Windows.Forms.TreeView();
			this.cmsTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ctxtsbAddStationImage = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxtsbRemoveStation = new System.Windows.Forms.ToolStripMenuItem();
			this.cntxtsbRemoveSample = new System.Windows.Forms.ToolStripMenuItem();
			this.cntxtsbUploadSamples = new System.Windows.Forms.ToolStripMenuItem();
			this.imgListForm = new System.Windows.Forms.ImageList(this.components);
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPag1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.lblUnknown = new System.Windows.Forms.Label();
			this.lblInvalid = new System.Windows.Forms.Label();
			this.lblManagement = new System.Windows.Forms.Label();
			this.btEmpty = new System.Windows.Forms.Button();
			this.btUnknown = new System.Windows.Forms.Button();
			this.btInvalid = new System.Windows.Forms.Button();
			this.btManagement = new System.Windows.Forms.Button();
			this.tabPag2 = new System.Windows.Forms.TabPage();
			this.lstViewData = new System.Windows.Forms.ListView();
			this.dgvSelectCount = new System.Windows.Forms.DataGridView();
			this.dgvSelectSpecies = new System.Windows.Forms.DataGridView();
			this.cmbSelectSpecies = new System.Windows.Forms.ComboBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.txtProcessStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.txtProcessStatus2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.msMain.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.cmsTreeView.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPag1.SuspendLayout();
			this.tabPag2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSelectCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSelectSpecies)).BeginInit();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.StatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// msMain
			// 
			this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.projectToolStripMenuItem,
									this.cameraStationsToolStripMenuItem,
									this.photoSamplesToolStripMenuItem,
									this.reportsToolStripMenuItem});
			resources.ApplyResources(this.msMain, "msMain");
			this.msMain.Name = "msMain";
			// 
			// projectToolStripMenuItem
			// 
			this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newProjectToolStripMenuItem,
									this.existingProjectToolStripMenuItem,
									this.toolStripSeparator3,
									this.saveProjectToolStripMenuItem,
									this.toolStripSeparator2,
									this.closeProjectToolStripMenuItem,
									this.toolStripSeparator1,
									this.exitProgramToolStripMenuItem});
			this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
			resources.ApplyResources(this.projectToolStripMenuItem, "projectToolStripMenuItem");
			// 
			// newProjectToolStripMenuItem
			// 
			this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
			resources.ApplyResources(this.newProjectToolStripMenuItem, "newProjectToolStripMenuItem");
			this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProjectToolStripMenuItemClick);
			// 
			// existingProjectToolStripMenuItem
			// 
			this.existingProjectToolStripMenuItem.Name = "existingProjectToolStripMenuItem";
			resources.ApplyResources(this.existingProjectToolStripMenuItem, "existingProjectToolStripMenuItem");
			this.existingProjectToolStripMenuItem.Click += new System.EventHandler(this.ExistingProjectToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
			// 
			// saveProjectToolStripMenuItem
			// 
			this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
			resources.ApplyResources(this.saveProjectToolStripMenuItem, "saveProjectToolStripMenuItem");
			this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.SaveProjectToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			// 
			// closeProjectToolStripMenuItem
			// 
			this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
			resources.ApplyResources(this.closeProjectToolStripMenuItem, "closeProjectToolStripMenuItem");
			this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.CloseProjectToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			// 
			// exitProgramToolStripMenuItem
			// 
			this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
			resources.ApplyResources(this.exitProgramToolStripMenuItem, "exitProgramToolStripMenuItem");
			this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.ExitProgramToolStripMenuItemClick);
			// 
			// cameraStationsToolStripMenuItem
			// 
			this.cameraStationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.loadStationToolStripMenuItem,
									this.tsbRemoveStation,
									this.tsbSelectStationImage});
			this.cameraStationsToolStripMenuItem.Name = "cameraStationsToolStripMenuItem";
			resources.ApplyResources(this.cameraStationsToolStripMenuItem, "cameraStationsToolStripMenuItem");
			// 
			// loadStationToolStripMenuItem
			// 
			this.loadStationToolStripMenuItem.Name = "loadStationToolStripMenuItem";
			resources.ApplyResources(this.loadStationToolStripMenuItem, "loadStationToolStripMenuItem");
			this.loadStationToolStripMenuItem.Click += new System.EventHandler(this.NewStationToolStripMenuItemClick);
			// 
			// tsbRemoveStation
			// 
			this.tsbRemoveStation.Name = "tsbRemoveStation";
			resources.ApplyResources(this.tsbRemoveStation, "tsbRemoveStation");
			this.tsbRemoveStation.Click += new System.EventHandler(this.tsbRemoveStationClick);
			// 
			// tsbSelectStationImage
			// 
			this.tsbSelectStationImage.Name = "tsbSelectStationImage";
			resources.ApplyResources(this.tsbSelectStationImage, "tsbSelectStationImage");
			this.tsbSelectStationImage.Click += new System.EventHandler(this.TsbSelectStationImageClick);
			// 
			// photoSamplesToolStripMenuItem
			// 
			this.photoSamplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.uploadSamplesToStationToolStripMenuItem,
									this.removeCurrentSampleToolStripMenuItem});
			this.photoSamplesToolStripMenuItem.Name = "photoSamplesToolStripMenuItem";
			resources.ApplyResources(this.photoSamplesToolStripMenuItem, "photoSamplesToolStripMenuItem");
			// 
			// uploadSamplesToStationToolStripMenuItem
			// 
			this.uploadSamplesToStationToolStripMenuItem.Name = "uploadSamplesToStationToolStripMenuItem";
			resources.ApplyResources(this.uploadSamplesToStationToolStripMenuItem, "uploadSamplesToStationToolStripMenuItem");
			this.uploadSamplesToStationToolStripMenuItem.Click += new System.EventHandler(this.tsbUploadSamplesClick);
			// 
			// removeCurrentSampleToolStripMenuItem
			// 
			this.removeCurrentSampleToolStripMenuItem.Name = "removeCurrentSampleToolStripMenuItem";
			resources.ApplyResources(this.removeCurrentSampleToolStripMenuItem, "removeCurrentSampleToolStripMenuItem");
			this.removeCurrentSampleToolStripMenuItem.Click += new System.EventHandler(this.tsbRemoveSampleClick);
			// 
			// reportsToolStripMenuItem
			// 
			this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsbDataToExcel,
									this.tsbCompletePDF,
									this.tsbCreateAbundancesShapefiles});
			this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
			resources.ApplyResources(this.reportsToolStripMenuItem, "reportsToolStripMenuItem");
			// 
			// tsbDataToExcel
			// 
			this.tsbDataToExcel.Name = "tsbDataToExcel";
			resources.ApplyResources(this.tsbDataToExcel, "tsbDataToExcel");
			this.tsbDataToExcel.Click += new System.EventHandler(this.tsbExportToExcelClick);
			// 
			// tsbCompletePDF
			// 
			this.tsbCompletePDF.Name = "tsbCompletePDF";
			resources.ApplyResources(this.tsbCompletePDF, "tsbCompletePDF");
			this.tsbCompletePDF.Click += new System.EventHandler(this.tsbCompletePDFClick);
			// 
			// tsbCreateAbundancesShapefiles
			// 
			this.tsbCreateAbundancesShapefiles.Name = "tsbCreateAbundancesShapefiles";
			resources.ApplyResources(this.tsbCreateAbundancesShapefiles, "tsbCreateAbundancesShapefiles");
			this.tsbCreateAbundancesShapefiles.Click += new System.EventHandler(this.tsbCreateAbundanceShapefilesClick);
			// 
			// splitContainer1
			// 
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tvProject);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			// 
			// tvProject
			// 
			this.tvProject.ContextMenuStrip = this.cmsTreeView;
			resources.ApplyResources(this.tvProject, "tvProject");
			this.tvProject.HideSelection = false;
			this.tvProject.ImageList = this.imgListForm;
			this.tvProject.Name = "tvProject";
			this.tvProject.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvProjectAfterSelect);
			// 
			// cmsTreeView
			// 
			this.cmsTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ctxtsbAddStationImage,
									this.ctxtsbRemoveStation,
									this.cntxtsbRemoveSample,
									this.cntxtsbUploadSamples});
			this.cmsTreeView.Name = "cmsTreeView";
			resources.ApplyResources(this.cmsTreeView, "cmsTreeView");
			// 
			// ctxtsbAddStationImage
			// 
			this.ctxtsbAddStationImage.Name = "ctxtsbAddStationImage";
			resources.ApplyResources(this.ctxtsbAddStationImage, "ctxtsbAddStationImage");
			this.ctxtsbAddStationImage.Click += new System.EventHandler(this.CtxtsbSelectStationImageClick);
			// 
			// ctxtsbRemoveStation
			// 
			this.ctxtsbRemoveStation.Name = "ctxtsbRemoveStation";
			resources.ApplyResources(this.ctxtsbRemoveStation, "ctxtsbRemoveStation");
			this.ctxtsbRemoveStation.Click += new System.EventHandler(this.CtxtsbRemoveStationClick);
			// 
			// cntxtsbRemoveSample
			// 
			this.cntxtsbRemoveSample.Name = "cntxtsbRemoveSample";
			resources.ApplyResources(this.cntxtsbRemoveSample, "cntxtsbRemoveSample");
			this.cntxtsbRemoveSample.Click += new System.EventHandler(this.CntxtsbRemoveSampleClick);
			// 
			// cntxtsbUploadSamples
			// 
			this.cntxtsbUploadSamples.Name = "cntxtsbUploadSamples";
			resources.ApplyResources(this.cntxtsbUploadSamples, "cntxtsbUploadSamples");
			this.cntxtsbUploadSamples.Click += new System.EventHandler(this.cntxttbUploadSamplesClick);
			// 
			// imgListForm
			// 
			this.imgListForm.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListForm.ImageStream")));
			this.imgListForm.TransparentColor = System.Drawing.Color.Transparent;
			this.imgListForm.Images.SetKeyName(0, "Folder-64.png");
			this.imgListForm.Images.SetKeyName(1, "Green-Camera-Symbol-128.png");
			this.imgListForm.Images.SetKeyName(2, "Black-Camera-Symbol-128.png");
			this.imgListForm.Images.SetKeyName(3, "Orange-Camera-Symbol-128.png");
			this.imgListForm.Images.SetKeyName(4, "Question.png");
			this.imgListForm.Images.SetKeyName(5, "Comment-empty-48.png");
			this.imgListForm.Images.SetKeyName(6, "Blue-Camera-Symbol-128.png");
			// 
			// splitContainer2
			// 
			this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.splitContainer2, "splitContainer2");
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// splitContainer3
			// 
			this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.splitContainer3, "splitContainer3");
			this.splitContainer3.Name = "splitContainer3";
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.tabControl);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.dgvSelectCount);
			this.splitContainer3.Panel2.Controls.Add(this.dgvSelectSpecies);
			this.splitContainer3.Panel2.Controls.Add(this.cmbSelectSpecies);
			// 
			// tabControl
			// 
			resources.ApplyResources(this.tabControl, "tabControl");
			this.tabControl.Controls.Add(this.tabPag1);
			this.tabControl.Controls.Add(this.tabPag2);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			// 
			// tabPag1
			// 
			this.tabPag1.Controls.Add(this.label1);
			this.tabPag1.Controls.Add(this.lblUnknown);
			this.tabPag1.Controls.Add(this.lblInvalid);
			this.tabPag1.Controls.Add(this.lblManagement);
			this.tabPag1.Controls.Add(this.btEmpty);
			this.tabPag1.Controls.Add(this.btUnknown);
			this.tabPag1.Controls.Add(this.btInvalid);
			this.tabPag1.Controls.Add(this.btManagement);
			resources.ApplyResources(this.tabPag1, "tabPag1");
			this.tabPag1.Name = "tabPag1";
			this.tabPag1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// lblUnknown
			// 
			resources.ApplyResources(this.lblUnknown, "lblUnknown");
			this.lblUnknown.Name = "lblUnknown";
			// 
			// lblInvalid
			// 
			resources.ApplyResources(this.lblInvalid, "lblInvalid");
			this.lblInvalid.Name = "lblInvalid";
			// 
			// lblManagement
			// 
			resources.ApplyResources(this.lblManagement, "lblManagement");
			this.lblManagement.Name = "lblManagement";
			// 
			// btEmpty
			// 
			resources.ApplyResources(this.btEmpty, "btEmpty");
			this.btEmpty.ImageList = this.imgListForm;
			this.btEmpty.Name = "btEmpty";
			this.btEmpty.UseVisualStyleBackColor = true;
			this.btEmpty.Click += new System.EventHandler(this.BtEmptyClick);
			// 
			// btUnknown
			// 
			resources.ApplyResources(this.btUnknown, "btUnknown");
			this.btUnknown.ImageList = this.imgListForm;
			this.btUnknown.Name = "btUnknown";
			this.btUnknown.UseVisualStyleBackColor = true;
			this.btUnknown.Click += new System.EventHandler(this.BtUnknownClick);
			// 
			// btInvalid
			// 
			resources.ApplyResources(this.btInvalid, "btInvalid");
			this.btInvalid.ImageList = this.imgListForm;
			this.btInvalid.Name = "btInvalid";
			this.btInvalid.UseVisualStyleBackColor = true;
			this.btInvalid.Click += new System.EventHandler(this.BtInvalidClick);
			// 
			// btManagement
			// 
			resources.ApplyResources(this.btManagement, "btManagement");
			this.btManagement.ImageList = this.imgListForm;
			this.btManagement.Name = "btManagement";
			this.btManagement.UseVisualStyleBackColor = true;
			this.btManagement.Click += new System.EventHandler(this.BtManagementClick);
			// 
			// tabPag2
			// 
			this.tabPag2.Controls.Add(this.lstViewData);
			resources.ApplyResources(this.tabPag2, "tabPag2");
			this.tabPag2.Name = "tabPag2";
			this.tabPag2.UseVisualStyleBackColor = true;
			// 
			// lstViewData
			// 
			resources.ApplyResources(this.lstViewData, "lstViewData");
			this.lstViewData.GridLines = true;
			this.lstViewData.Name = "lstViewData";
			this.lstViewData.UseCompatibleStateImageBehavior = false;
			// 
			// dgvSelectCount
			// 
			this.dgvSelectCount.AllowUserToAddRows = false;
			this.dgvSelectCount.AllowUserToDeleteRows = false;
			this.dgvSelectCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSelectCount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSelectCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSelectCount.ColumnHeadersVisible = false;
			resources.ApplyResources(this.dgvSelectCount, "dgvSelectCount");
			this.dgvSelectCount.Name = "dgvSelectCount";
			this.dgvSelectCount.ReadOnly = true;
			this.dgvSelectCount.RowHeadersVisible = false;
			this.dgvSelectCount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSelectCountClick);
			// 
			// dgvSelectSpecies
			// 
			this.dgvSelectSpecies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSelectSpecies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvSelectSpecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSelectSpecies.ColumnHeadersVisible = false;
			resources.ApplyResources(this.dgvSelectSpecies, "dgvSelectSpecies");
			this.dgvSelectSpecies.Name = "dgvSelectSpecies";
			this.dgvSelectSpecies.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvSelectSpecies.RowTemplate.Height = 30;
			this.dgvSelectSpecies.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvSelectSpeciesUserDeletedRow);
			this.dgvSelectSpecies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSelectSpeciesClick);
			// 
			// cmbSelectSpecies
			// 
			this.cmbSelectSpecies.AutoCompleteCustomSource.AddRange(new string[] {
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource1"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource2"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource3"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource4"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource5"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource6"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource7"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource8"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource9"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource10"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource11"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource12"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource13"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource14"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource15"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource16"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource17"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource18"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource19"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource20"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource21"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource22"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource23"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource24"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource25"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource26"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource27"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource28"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource29"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource30"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource31"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource32"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource33"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource34"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource35"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource36"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource37"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource38"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource39"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource40"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource41"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource42"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource43"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource44"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource45"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource46"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource47"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource48"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource49"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource50"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource51"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource52"),
									resources.GetString("cmbSelectSpecies.AutoCompleteCustomSource53")});
			this.cmbSelectSpecies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			resources.ApplyResources(this.cmbSelectSpecies, "cmbSelectSpecies");
			this.cmbSelectSpecies.FormattingEnabled = true;
			this.cmbSelectSpecies.Name = "cmbSelectSpecies";
			this.cmbSelectSpecies.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbSelectSpeciesKeyDown);
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.StatusStrip);
			// 
			// toolStripContainer1.ContentPanel
			// 
			resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
			resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.TopToolStripPanelVisible = false;
			// 
			// StatusStrip
			// 
			resources.ApplyResources(this.StatusStrip, "StatusStrip");
			this.StatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.txtProcessStatus,
									this.toolStripProgressBar1,
									this.txtProcessStatus2});
			this.StatusStrip.Name = "StatusStrip";
			// 
			// txtProcessStatus
			// 
			this.txtProcessStatus.Name = "txtProcessStatus";
			resources.ApplyResources(this.txtProcessStatus, "txtProcessStatus");
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
			// 
			// txtProcessStatus2
			// 
			this.txtProcessStatus2.Name = "txtProcessStatus2";
			resources.ApplyResources(this.txtProcessStatus2, "txtProcessStatus2");
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.msMain);
			this.Controls.Add(this.toolStripContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.msMain;
			this.Name = "MainForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.msMain.ResumeLayout(false);
			this.msMain.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.cmsTreeView.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tabPag1.ResumeLayout(false);
			this.tabPag2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSelectCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSelectSpecies)).EndInit();
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dgvSelectCount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblManagement;
		private System.Windows.Forms.Label lblInvalid;
		private System.Windows.Forms.Label lblUnknown;
		private System.Windows.Forms.Button btInvalid;
		private System.Windows.Forms.Button btUnknown;
		private System.Windows.Forms.Button btEmpty;
		private System.Windows.Forms.Button btManagement;
		private System.Windows.Forms.TabPage tabPag2;
		private System.Windows.Forms.TabPage tabPag1;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.StatusStrip StatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel txtProcessStatus;
		private System.Windows.Forms.ToolStripStatusLabel txtProcessStatus2;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripMenuItem cntxtsbUploadSamples;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ImageList imgListForm;
		private System.Windows.Forms.ComboBox cmbSelectSpecies;
		private System.Windows.Forms.TreeView tvProject;
		private System.Windows.Forms.DataGridView dgvSelectSpecies;
		private System.Windows.Forms.ToolStripMenuItem tsbSelectStationImage;
		private System.Windows.Forms.ToolStripMenuItem cntxtsbRemoveSample;
		private System.Windows.Forms.ToolStripMenuItem ctxtsbAddStationImage;
		private System.Windows.Forms.ToolStripMenuItem ctxtsbRemoveStation;
		private System.Windows.Forms.ToolStripMenuItem tsbRemoveStation;
		private System.Windows.Forms.ToolStripMenuItem tsbDataToExcel;
		private System.Windows.Forms.ToolStripMenuItem tsbCreateAbundancesShapefiles;
		private System.Windows.Forms.ToolStripMenuItem tsbCompletePDF;
		private System.Windows.Forms.ContextMenuStrip cmsTreeView;
		private System.Windows.Forms.MenuStrip msMain;
		private System.Windows.Forms.ListView lstViewData;
		private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeCurrentSampleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem uploadSamplesToStationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem photoSamplesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem existingProjectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadStationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cameraStationsToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
	}
}
