namespace Salesforce2Kintone
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.dgvSource = new System.Windows.Forms.DataGridView();
            this.scRight = new System.Windows.Forms.SplitContainer();
            this.pbArrow = new System.Windows.Forms.PictureBox();
            this.btImport = new System.Windows.Forms.Button();
            this.dgvDestination = new System.Windows.Forms.DataGridView();
            this.kitone顧客管理BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kintoneDataSet = new Salesforce2Kintone.KintoneDataSet();
            this.kitone_顧客管理TableAdapter = new Salesforce2Kintone.KintoneDataSetTableAdapters.kitone_顧客管理TableAdapter();
            this.顧客番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.会社名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部署DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.肩書DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.担当者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.住所DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesforceDataSet = new Salesforce2Kintone.SalesforceDataSet();
            this.contactTableAdapter = new Salesforce2Kintone.SalesforceDataSetTableAdapters.ContactTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName__c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountAddress__c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salutationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherLatitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherLongitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailingStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailingCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailingStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailingPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailingCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailingLatitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailingLongitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportsToIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).BeginInit();
            this.scRight.Panel1.SuspendLayout();
            this.scRight.Panel2.SuspendLayout();
            this.scRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitone顧客管理BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kintoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesforceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMain.Location = new System.Drawing.Point(20, 49);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.dgvSource);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scRight);
            this.scMain.Size = new System.Drawing.Size(1097, 428);
            this.scMain.SplitterDistance = 481;
            this.scMain.TabIndex = 7;
            // 
            // dgvSource
            // 
            this.dgvSource.AllowUserToAddRows = false;
            this.dgvSource.AllowUserToDeleteRows = false;
            this.dgvSource.AllowUserToResizeRows = false;
            this.dgvSource.AutoGenerateColumns = false;
            this.dgvSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.AccountName__c,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.nameDataGridViewTextBoxColumn,
            this.AccountAddress__c,
            this.phoneDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.salutationDataGridViewTextBoxColumn,
            this.otherStreetDataGridViewTextBoxColumn,
            this.otherCityDataGridViewTextBoxColumn,
            this.otherStateDataGridViewTextBoxColumn,
            this.otherPostalCodeDataGridViewTextBoxColumn,
            this.otherCountryDataGridViewTextBoxColumn,
            this.otherLatitudeDataGridViewTextBoxColumn,
            this.otherLongitudeDataGridViewTextBoxColumn,
            this.mailingStreetDataGridViewTextBoxColumn,
            this.mailingCityDataGridViewTextBoxColumn,
            this.mailingStateDataGridViewTextBoxColumn,
            this.mailingPostalCodeDataGridViewTextBoxColumn,
            this.mailingCountryDataGridViewTextBoxColumn,
            this.mailingLatitudeDataGridViewTextBoxColumn,
            this.mailingLongitudeDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.mobilePhoneDataGridViewTextBoxColumn,
            this.homePhoneDataGridViewTextBoxColumn,
            this.otherPhoneDataGridViewTextBoxColumn,
            this.assistantPhoneDataGridViewTextBoxColumn,
            this.reportsToIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.dgvSource.DataSource = this.contactBindingSource;
            this.dgvSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSource.Location = new System.Drawing.Point(0, 0);
            this.dgvSource.Name = "dgvSource";
            this.dgvSource.ReadOnly = true;
            this.dgvSource.RowTemplate.Height = 21;
            this.dgvSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSource.Size = new System.Drawing.Size(481, 428);
            this.dgvSource.TabIndex = 1;
            // 
            // scRight
            // 
            this.scRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scRight.Location = new System.Drawing.Point(0, 0);
            this.scRight.Name = "scRight";
            // 
            // scRight.Panel1
            // 
            this.scRight.Panel1.Controls.Add(this.pbArrow);
            this.scRight.Panel1.Controls.Add(this.btImport);
            // 
            // scRight.Panel2
            // 
            this.scRight.Panel2.Controls.Add(this.dgvDestination);
            this.scRight.Size = new System.Drawing.Size(612, 428);
            this.scRight.SplitterDistance = 87;
            this.scRight.TabIndex = 0;
            // 
            // pbArrow
            // 
            this.pbArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbArrow.Image")));
            this.pbArrow.Location = new System.Drawing.Point(16, 171);
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.Size = new System.Drawing.Size(54, 33);
            this.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrow.TabIndex = 4;
            this.pbArrow.TabStop = false;
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Location = new System.Drawing.Point(7, 220);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(73, 27);
            this.btImport.TabIndex = 3;
            this.btImport.Text = "インポート";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // dgvDestination
            // 
            this.dgvDestination.AllowUserToAddRows = false;
            this.dgvDestination.AllowUserToDeleteRows = false;
            this.dgvDestination.AllowUserToResizeRows = false;
            this.dgvDestination.AutoGenerateColumns = false;
            this.dgvDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.顧客番号DataGridViewTextBoxColumn,
            this.会社名DataGridViewTextBoxColumn,
            this.部署DataGridViewTextBoxColumn,
            this.肩書DataGridViewTextBoxColumn,
            this.担当者DataGridViewTextBoxColumn,
            this.住所DataGridViewTextBoxColumn,
            this.電話番号DataGridViewTextBoxColumn});
            this.dgvDestination.DataSource = this.kitone顧客管理BindingSource;
            this.dgvDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDestination.Location = new System.Drawing.Point(0, 0);
            this.dgvDestination.Name = "dgvDestination";
            this.dgvDestination.ReadOnly = true;
            this.dgvDestination.RowTemplate.Height = 21;
            this.dgvDestination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestination.Size = new System.Drawing.Size(521, 428);
            this.dgvDestination.TabIndex = 2;
            // 
            // kitone顧客管理BindingSource
            // 
            this.kitone顧客管理BindingSource.DataMember = "kitone 顧客管理";
            this.kitone顧客管理BindingSource.DataSource = this.kintoneDataSet;
            // 
            // kintoneDataSet
            // 
            this.kintoneDataSet.DataSetName = "KintoneDataSet";
            this.kintoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitone_顧客管理TableAdapter
            // 
            this.kitone_顧客管理TableAdapter.ClearBeforeFill = true;
            // 
            // 顧客番号DataGridViewTextBoxColumn
            // 
            this.顧客番号DataGridViewTextBoxColumn.DataPropertyName = "顧客番号";
            this.顧客番号DataGridViewTextBoxColumn.HeaderText = "顧客番号";
            this.顧客番号DataGridViewTextBoxColumn.Name = "顧客番号DataGridViewTextBoxColumn";
            this.顧客番号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 会社名DataGridViewTextBoxColumn
            // 
            this.会社名DataGridViewTextBoxColumn.DataPropertyName = "会社名";
            this.会社名DataGridViewTextBoxColumn.HeaderText = "会社名";
            this.会社名DataGridViewTextBoxColumn.Name = "会社名DataGridViewTextBoxColumn";
            this.会社名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 部署DataGridViewTextBoxColumn
            // 
            this.部署DataGridViewTextBoxColumn.DataPropertyName = "部署";
            this.部署DataGridViewTextBoxColumn.HeaderText = "部署";
            this.部署DataGridViewTextBoxColumn.Name = "部署DataGridViewTextBoxColumn";
            this.部署DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 肩書DataGridViewTextBoxColumn
            // 
            this.肩書DataGridViewTextBoxColumn.DataPropertyName = "肩書";
            this.肩書DataGridViewTextBoxColumn.HeaderText = "肩書";
            this.肩書DataGridViewTextBoxColumn.Name = "肩書DataGridViewTextBoxColumn";
            this.肩書DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 担当者DataGridViewTextBoxColumn
            // 
            this.担当者DataGridViewTextBoxColumn.DataPropertyName = "担当者";
            this.担当者DataGridViewTextBoxColumn.HeaderText = "担当者";
            this.担当者DataGridViewTextBoxColumn.Name = "担当者DataGridViewTextBoxColumn";
            this.担当者DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 住所DataGridViewTextBoxColumn
            // 
            this.住所DataGridViewTextBoxColumn.DataPropertyName = "住所";
            this.住所DataGridViewTextBoxColumn.HeaderText = "住所";
            this.住所DataGridViewTextBoxColumn.Name = "住所DataGridViewTextBoxColumn";
            this.住所DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 電話番号DataGridViewTextBoxColumn
            // 
            this.電話番号DataGridViewTextBoxColumn.DataPropertyName = "電話番号";
            this.電話番号DataGridViewTextBoxColumn.HeaderText = "電話番号";
            this.電話番号DataGridViewTextBoxColumn.Name = "電話番号DataGridViewTextBoxColumn";
            this.電話番号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.salesforceDataSet;
            // 
            // salesforceDataSet
            // 
            this.salesforceDataSet.DataSetName = "SalesforceDataSet";
            this.salesforceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactTableAdapter
            // 
            this.contactTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AccountName__c
            // 
            this.AccountName__c.DataPropertyName = "AccountName__c";
            this.AccountName__c.HeaderText = "AccountName__c";
            this.AccountName__c.Name = "AccountName__c";
            this.AccountName__c.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn5.HeaderText = "Department";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn4.HeaderText = "Title";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AccountAddress__c
            // 
            this.AccountAddress__c.DataPropertyName = "AccountAddress__c";
            this.AccountAddress__c.HeaderText = "AccountAddress__c";
            this.AccountAddress__c.Name = "AccountAddress__c";
            this.AccountAddress__c.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // salutationDataGridViewTextBoxColumn
            // 
            this.salutationDataGridViewTextBoxColumn.DataPropertyName = "Salutation";
            this.salutationDataGridViewTextBoxColumn.HeaderText = "Salutation";
            this.salutationDataGridViewTextBoxColumn.Name = "salutationDataGridViewTextBoxColumn";
            this.salutationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherStreetDataGridViewTextBoxColumn
            // 
            this.otherStreetDataGridViewTextBoxColumn.DataPropertyName = "OtherStreet";
            this.otherStreetDataGridViewTextBoxColumn.HeaderText = "OtherStreet";
            this.otherStreetDataGridViewTextBoxColumn.Name = "otherStreetDataGridViewTextBoxColumn";
            this.otherStreetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherCityDataGridViewTextBoxColumn
            // 
            this.otherCityDataGridViewTextBoxColumn.DataPropertyName = "OtherCity";
            this.otherCityDataGridViewTextBoxColumn.HeaderText = "OtherCity";
            this.otherCityDataGridViewTextBoxColumn.Name = "otherCityDataGridViewTextBoxColumn";
            this.otherCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherStateDataGridViewTextBoxColumn
            // 
            this.otherStateDataGridViewTextBoxColumn.DataPropertyName = "OtherState";
            this.otherStateDataGridViewTextBoxColumn.HeaderText = "OtherState";
            this.otherStateDataGridViewTextBoxColumn.Name = "otherStateDataGridViewTextBoxColumn";
            this.otherStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherPostalCodeDataGridViewTextBoxColumn
            // 
            this.otherPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "OtherPostalCode";
            this.otherPostalCodeDataGridViewTextBoxColumn.HeaderText = "OtherPostalCode";
            this.otherPostalCodeDataGridViewTextBoxColumn.Name = "otherPostalCodeDataGridViewTextBoxColumn";
            this.otherPostalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherCountryDataGridViewTextBoxColumn
            // 
            this.otherCountryDataGridViewTextBoxColumn.DataPropertyName = "OtherCountry";
            this.otherCountryDataGridViewTextBoxColumn.HeaderText = "OtherCountry";
            this.otherCountryDataGridViewTextBoxColumn.Name = "otherCountryDataGridViewTextBoxColumn";
            this.otherCountryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherLatitudeDataGridViewTextBoxColumn
            // 
            this.otherLatitudeDataGridViewTextBoxColumn.DataPropertyName = "OtherLatitude";
            this.otherLatitudeDataGridViewTextBoxColumn.HeaderText = "OtherLatitude";
            this.otherLatitudeDataGridViewTextBoxColumn.Name = "otherLatitudeDataGridViewTextBoxColumn";
            this.otherLatitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherLongitudeDataGridViewTextBoxColumn
            // 
            this.otherLongitudeDataGridViewTextBoxColumn.DataPropertyName = "OtherLongitude";
            this.otherLongitudeDataGridViewTextBoxColumn.HeaderText = "OtherLongitude";
            this.otherLongitudeDataGridViewTextBoxColumn.Name = "otherLongitudeDataGridViewTextBoxColumn";
            this.otherLongitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailingStreetDataGridViewTextBoxColumn
            // 
            this.mailingStreetDataGridViewTextBoxColumn.DataPropertyName = "MailingStreet";
            this.mailingStreetDataGridViewTextBoxColumn.HeaderText = "MailingStreet";
            this.mailingStreetDataGridViewTextBoxColumn.Name = "mailingStreetDataGridViewTextBoxColumn";
            this.mailingStreetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailingCityDataGridViewTextBoxColumn
            // 
            this.mailingCityDataGridViewTextBoxColumn.DataPropertyName = "MailingCity";
            this.mailingCityDataGridViewTextBoxColumn.HeaderText = "MailingCity";
            this.mailingCityDataGridViewTextBoxColumn.Name = "mailingCityDataGridViewTextBoxColumn";
            this.mailingCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailingStateDataGridViewTextBoxColumn
            // 
            this.mailingStateDataGridViewTextBoxColumn.DataPropertyName = "MailingState";
            this.mailingStateDataGridViewTextBoxColumn.HeaderText = "MailingState";
            this.mailingStateDataGridViewTextBoxColumn.Name = "mailingStateDataGridViewTextBoxColumn";
            this.mailingStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailingPostalCodeDataGridViewTextBoxColumn
            // 
            this.mailingPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "MailingPostalCode";
            this.mailingPostalCodeDataGridViewTextBoxColumn.HeaderText = "MailingPostalCode";
            this.mailingPostalCodeDataGridViewTextBoxColumn.Name = "mailingPostalCodeDataGridViewTextBoxColumn";
            this.mailingPostalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailingCountryDataGridViewTextBoxColumn
            // 
            this.mailingCountryDataGridViewTextBoxColumn.DataPropertyName = "MailingCountry";
            this.mailingCountryDataGridViewTextBoxColumn.HeaderText = "MailingCountry";
            this.mailingCountryDataGridViewTextBoxColumn.Name = "mailingCountryDataGridViewTextBoxColumn";
            this.mailingCountryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailingLatitudeDataGridViewTextBoxColumn
            // 
            this.mailingLatitudeDataGridViewTextBoxColumn.DataPropertyName = "MailingLatitude";
            this.mailingLatitudeDataGridViewTextBoxColumn.HeaderText = "MailingLatitude";
            this.mailingLatitudeDataGridViewTextBoxColumn.Name = "mailingLatitudeDataGridViewTextBoxColumn";
            this.mailingLatitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailingLongitudeDataGridViewTextBoxColumn
            // 
            this.mailingLongitudeDataGridViewTextBoxColumn.DataPropertyName = "MailingLongitude";
            this.mailingLongitudeDataGridViewTextBoxColumn.HeaderText = "MailingLongitude";
            this.mailingLongitudeDataGridViewTextBoxColumn.Name = "mailingLongitudeDataGridViewTextBoxColumn";
            this.mailingLongitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobilePhoneDataGridViewTextBoxColumn
            // 
            this.mobilePhoneDataGridViewTextBoxColumn.DataPropertyName = "MobilePhone";
            this.mobilePhoneDataGridViewTextBoxColumn.HeaderText = "MobilePhone";
            this.mobilePhoneDataGridViewTextBoxColumn.Name = "mobilePhoneDataGridViewTextBoxColumn";
            this.mobilePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homePhoneDataGridViewTextBoxColumn
            // 
            this.homePhoneDataGridViewTextBoxColumn.DataPropertyName = "HomePhone";
            this.homePhoneDataGridViewTextBoxColumn.HeaderText = "HomePhone";
            this.homePhoneDataGridViewTextBoxColumn.Name = "homePhoneDataGridViewTextBoxColumn";
            this.homePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherPhoneDataGridViewTextBoxColumn
            // 
            this.otherPhoneDataGridViewTextBoxColumn.DataPropertyName = "OtherPhone";
            this.otherPhoneDataGridViewTextBoxColumn.HeaderText = "OtherPhone";
            this.otherPhoneDataGridViewTextBoxColumn.Name = "otherPhoneDataGridViewTextBoxColumn";
            this.otherPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assistantPhoneDataGridViewTextBoxColumn
            // 
            this.assistantPhoneDataGridViewTextBoxColumn.DataPropertyName = "AssistantPhone";
            this.assistantPhoneDataGridViewTextBoxColumn.HeaderText = "AssistantPhone";
            this.assistantPhoneDataGridViewTextBoxColumn.Name = "assistantPhoneDataGridViewTextBoxColumn";
            this.assistantPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportsToIdDataGridViewTextBoxColumn
            // 
            this.reportsToIdDataGridViewTextBoxColumn.DataPropertyName = "ReportsToId";
            this.reportsToIdDataGridViewTextBoxColumn.HeaderText = "ReportsToId";
            this.reportsToIdDataGridViewTextBoxColumn.Name = "reportsToIdDataGridViewTextBoxColumn";
            this.reportsToIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AssistantName";
            this.dataGridViewTextBoxColumn6.HeaderText = "AssistantName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LeadSource";
            this.dataGridViewTextBoxColumn7.HeaderText = "LeadSource";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Birthdate";
            this.dataGridViewTextBoxColumn8.HeaderText = "Birthdate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn9.HeaderText = "Description";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OwnerId";
            this.dataGridViewTextBoxColumn10.HeaderText = "OwnerId";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CreatedDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "CreatedDate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CreatedById";
            this.dataGridViewTextBoxColumn12.HeaderText = "CreatedById";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "LastModifiedDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "LastModifiedDate";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "LastModifiedById";
            this.dataGridViewTextBoxColumn14.HeaderText = "LastModifiedById";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SystemModstamp";
            this.dataGridViewTextBoxColumn15.HeaderText = "SystemModstamp";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "LastActivityDate";
            this.dataGridViewTextBoxColumn16.HeaderText = "LastActivityDate";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "LastCURequestDate";
            this.dataGridViewTextBoxColumn17.HeaderText = "LastCURequestDate";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "LastCUUpdateDate";
            this.dataGridViewTextBoxColumn18.HeaderText = "LastCUUpdateDate";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "LastViewedDate";
            this.dataGridViewTextBoxColumn19.HeaderText = "LastViewedDate";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "LastReferencedDate";
            this.dataGridViewTextBoxColumn20.HeaderText = "LastReferencedDate";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "EmailBouncedReason";
            this.dataGridViewTextBoxColumn21.HeaderText = "EmailBouncedReason";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "EmailBouncedDate";
            this.dataGridViewTextBoxColumn22.HeaderText = "EmailBouncedDate";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsEmailBounced";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsEmailBounced";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "PhotoUrl";
            this.dataGridViewTextBoxColumn23.HeaderText = "PhotoUrl";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Jigsaw";
            this.dataGridViewTextBoxColumn24.HeaderText = "Jigsaw";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "JigsawContactId";
            this.dataGridViewTextBoxColumn25.HeaderText = "JigsawContactId";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "CleanStatus";
            this.dataGridViewTextBoxColumn26.HeaderText = "CleanStatus";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Level__c";
            this.dataGridViewTextBoxColumn27.HeaderText = "Level__c";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Languages__c";
            this.dataGridViewTextBoxColumn28.HeaderText = "Languages__c";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 526);
            this.Controls.Add(this.scMain);
            this.Name = "MainForm";
            this.Text = "Salesforce -> kintone";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).EndInit();
            this.scRight.Panel1.ResumeLayout(false);
            this.scRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).EndInit();
            this.scRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitone顧客管理BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kintoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesforceDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.DataGridView dgvSource;
        private System.Windows.Forms.SplitContainer scRight;
        private System.Windows.Forms.PictureBox pbArrow;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.DataGridView dgvDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leadSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedByIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemModstampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastActivityDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCURequestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCUUpdateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastViewedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastReferencedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailBouncedReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailBouncedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEmailBouncedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jigsawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jigsawContactIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleanStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languagescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastClickedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastEmailedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastOpenedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private Salesforce2Kintone.SalesforceDataSet salesforceDataSet;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private Salesforce2Kintone.SalesforceDataSetTableAdapters.ContactTableAdapter contactTableAdapter;
        private KintoneDataSet kintoneDataSet;
        private System.Windows.Forms.BindingSource kitone顧客管理BindingSource;
        private KintoneDataSetTableAdapters.kitone_顧客管理TableAdapter kitone_顧客管理TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 会社名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部署DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 肩書DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 担当者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 住所DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName__c;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountAddress__c;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn salutationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherLatitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherLongitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailingStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailingCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailingStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailingPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailingCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailingLatitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailingLongitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportsToIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
    }
}

