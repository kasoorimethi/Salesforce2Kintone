using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Salesforce2Kintone
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'kintoneDataSet.kitone_顧客管理' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.kitone_顧客管理TableAdapter.Fill(this.kintoneDataSet.kitone_顧客管理);
            // TODO: このコード行はデータを 'salesforceDataSet.Contact' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.contactTableAdapter.Fill(this.salesforceDataSet.Contact);
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            //// エラー処理は省略

            this.btImport.Enabled = false;

            this.dgvSource.Rows.Cast<DataGridViewRow>()
                .Where(o => o.Selected)
                .Select((o, i) => new { Row = (SalesforceDataSet.ContactRow)((DataRowView)o.DataBoundItem).Row, Index = i })
                .ToList()
                .ForEach(selected =>
                {
                    var row = this.kintoneDataSet.kitone_顧客管理.Rows.Cast<KintoneDataSet.kitone_顧客管理Row>()
                        .Where(o => o.顧客番号 == selected.Row.Id)
                        .FirstOrDefault();

                    if (row == null)
                    {
                        row = this.kintoneDataSet.kitone_顧客管理.Newkitone_顧客管理Row();
                        row.RecordId = selected.Index + this.kintoneDataSet.kitone_顧客管理.Rows.Cast<KintoneDataSet.kitone_顧客管理Row>().Max(o => o.RecordId) + 1;
                        row.Revision = 0;
                    }
                    
                    row.顧客番号 = selected.Row.Id;
                    row.会社名 = selected.Row.IsAccountName__cNull() ? "-" : selected.Row.AccountName__c;
                    row.住所 = selected.Row.IsAccountAddress__cNull() ? "-" : selected.Row.AccountAddress__c;
                    row.担当者 = selected.Row.IsNameNull() ? "-" : selected.Row.Name;
                    row.肩書 = selected.Row.IsTitleNull() ? "-" : selected.Row.Title;
                    row.部署 = selected.Row.IsDepartmentNull() ? "-" : selected.Row.Department;
                    row.電話番号 = selected.Row.IsPhoneNull() ? "-" : selected.Row.Phone;
                    
                    if (row.Revision == 0)
                    {
                        this.kintoneDataSet.kitone_顧客管理.Rows.Add(row);
                    }

                    this.kitone_顧客管理TableAdapter.Update(this.kintoneDataSet);
                });

            this.kitone_顧客管理TableAdapter.Fill(this.kintoneDataSet.kitone_顧客管理);

            this.btImport.Enabled = true;
        }
    }
}
