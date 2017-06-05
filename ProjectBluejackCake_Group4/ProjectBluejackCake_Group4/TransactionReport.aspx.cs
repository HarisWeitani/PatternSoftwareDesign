using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Member currentUser = (Member)Session["userLogin"];
            if (currentUser == null)
            {
                Response.Redirect("Home.aspx");
            }
            else if (currentUser != null)
            {
                if (currentUser.Type == "Admin")
                {
                    CrystalReportTransaction tr = new CrystalReportTransaction();
                    CrystalReportViewer1.ReportSource = tr;
                    tr.SetDataSource(GetData(TransactionRepositories.getAllTransaction()));
                }
                else if (currentUser.Type == "Customer")
                {
                    CrystalReportTransaction tr = new CrystalReportTransaction();
                    CrystalReportViewer1.ReportSource = tr;
                    tr.SetDataSource(GetData(TransactionRepositories.getTransactionByEmail(currentUser.Email)));
                }
            }
        }

        private DataSet1 GetData(List<TransactionHistory> transactions)
        {
            DataSet1 ds = new DataSet1();

            var TransactionTable = ds.TransactionHistory;

            foreach (TransactionHistory th in transactions)
            {
                var TransactionRow = TransactionTable.NewRow();
                TransactionRow["Id"] = th.Id;
                TransactionRow["TransactionDate"] = th.TransactionDate;
                TransactionRow["CustomerName"] = th.CustomerName;
                TransactionRow["CakeName"] = th.CakeName;
                TransactionRow["CakePrice"] = th.CakePrice;
                TransactionRow["ChocolatePlateGreeting"] = th.ChocolatePlateGreeting;
                TransactionRow["PromotionTitle"] = th.PromotionTitle;
                TransactionRow["PromotionDiscount"] = th.PromotionDiscount;
                TransactionRow["SubTotal"] = th.SubTotal;
                TransactionTable.Rows.Add(TransactionRow);
            }

            return ds;

        }
    }


}