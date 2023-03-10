using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Q2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex == 0)
            {
                img.ImageUrl = "images/fr.jpg";
            }
            else if (ListBox1.SelectedIndex == 1)
            {
                img.ImageUrl = "images/cdr.jpg";
            }
            else
                img.ImageUrl = "images/momo.jpg";

        }
        protected void Calculate(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex > -1)
            {
                int i = ListBox1.SelectedIndex;
                price.Text = " You Have selected " + ListBox1.SelectedItem.Value + " and it cost Rs.  ";
                if (i == 0)
                    price.Text += "200";
                else if (i == 1)
                    price.Text += "150";
                else
                    price.Text += "20";
            }
        }
    }
}