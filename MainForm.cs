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
            // TODO: このコード行はデータを 'kintoneDataSet.顧客リスト' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.顧客リストTableAdapter.Fill(this.kintoneDataSet.顧客リスト);
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
                    var row = this.kintoneDataSet.顧客リスト.Rows.Cast<KintoneDataSet.顧客リストRow>()
                        .Where(o => o.メールアドレス == selected.Row.Email)
                        .FirstOrDefault();

                    if (row == null)
                    {
                        row = this.kintoneDataSet.顧客リスト.New顧客リストRow();
                        row.RecordId = selected.Index
                            + (this.kintoneDataSet.顧客リスト.Rows.Cast<KintoneDataSet.顧客リストRow>().Max(o => (int?)o.RecordId) ?? 0)
                            + 1;
                        row.Revision = 0;
                    }

                    row.メールアドレス = selected.Row.Email;
                    row.会社名 = selected.Row.IsAccountNameNull() ? "" : selected.Row.AccountName;
                    row.住所 = selected.Row.IsAccountAddressNull() ? "" : selected.Row.AccountAddress;
                    row.担当者名 = selected.Row.IsNameNull() ? "" : selected.Row.Name;
                    row.部署名 = selected.Row.IsDepartmentNull() ? "" : selected.Row.Department;
                    row._郵便番号_数字のみ_ = selected.Row.IsAccountBillingPostalCodeNull() ? "" : selected.Row.AccountBillingPostalCode.Replace("-", "");
                    row._TEL_数字のみ_ = selected.Row.IsPhoneNull() ? "" : selected.Row.Phone.Replace("-", "");
                    row._FAX_数字のみ_ = selected.Row.IsFaxNull() ? "" : selected.Row.Fax.Replace("-", "");
                    row.備考 = "";
                    row.経度 = "";
                    row.緯度 = "";

                    if (row.Revision == 0)
                    {
                        this.kintoneDataSet.顧客リスト.Rows.Add(row);
                    }

                    this.顧客リストTableAdapter.Update(this.kintoneDataSet);
                });

            this.顧客リストTableAdapter.Fill(this.kintoneDataSet.顧客リスト);

            this.btImport.Enabled = true;
        }
    }
}
