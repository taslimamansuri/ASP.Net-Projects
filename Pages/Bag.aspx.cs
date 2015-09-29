using System;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pages
{

    public partial class Pages_Bag : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        private void FillPage()
        {

            ArrayList list = ConnectionClass.GetBagsByType(!IsPostBack ? "%" : DropDownList1.SelectedValue );
            StringBuilder sbuilder = new StringBuilder();

            foreach (Bag bags in list)
            {
                sbuilder.Append(string.Format(
                    @"<table class='bagsTable'>
                <tr>
                    <th rowspan='4' width='150px'> <img runat='server' src='{4}' </th>
                    <td width='50px'>Name: </td>
                    <td> {0}</td>
                </tr>

                <tr>
                    <th>Type:  </th>
                    <td> {1}</td>
                    
                </tr>

                <tr>
                    <th>Price:  </th>
                    <td>$ {2}</td>
                    
                </tr>

                <tr>
                    
                    <td colspan='2'>{3}  </td>
                </tr>

                </table>", bags.Name, bags.Type, bags.Price, bags.Review, bags.Image));
                lblOutput.Text = sbuilder.ToString();
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPage();
        }



    }

}