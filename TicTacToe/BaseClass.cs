using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToe
{
    public class BaseClass : System.Web.UI.Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            //Theme = "style";
            base.OnPreInit(e);
            
        }
    }
}