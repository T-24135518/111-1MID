using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MID {
    public partial class Q2 : System.Web.UI.Page {
        string[] s_City = new string[3] { "台北市", "新北市", "台中市" };
        string[,] s_Area = new string[3, 3] {
            {"中正區", "文山區", "大安區"},
            {"淡水區", "石碇區", "土城區"},
            {"西屯區", "北屯區", "東區"}
        };

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rbl_Phone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbl_Phone.SelectedIndex == 2)
            {
                txt_Phone.Visible = false;
            }
            else
            {
                txt_Phone.Visible = true;
            }
        }
    }
}