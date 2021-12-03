using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sum
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int b=S(10, 11);
                Response.Write("The sum of Two Numbers is="+b);
            }

        }

        public int S(int a,int b)
        {
            int s;
            s = a + b;
            return s;

        }
    }
}