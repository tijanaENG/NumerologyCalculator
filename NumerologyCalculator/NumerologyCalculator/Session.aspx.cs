using System;
using System.Web.UI;

namespace NumerologyCalculator
{
    public partial class Session : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSendData_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Default.aspx?Username=" + TextBoxUsername.Text.Replace("&","%26") +
            //     "&UserEmail=" + TextBoxEmail.Text.Replace("&","%26"));

            Response.Redirect("Default.aspx?UserName=" + Server.UrlEncode(TextBoxEmail.Text)
                + "&UserEmail=" + Server.UrlEncode(TextBoxEmail.Text));
        }
    }
}