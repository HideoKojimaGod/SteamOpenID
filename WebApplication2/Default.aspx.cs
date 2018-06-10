using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DotNetOpenAuth.OpenId.RelyingParty;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var openId = new OpenIdRelyingParty();
            var response = openId.GetResponse();

            if (response != null)
            {
                switch (response.Status)
                {
                    case AuthenticationStatus.Authenticated:
                        StatusLabel.Text = $"Вы авторизованы под пользователем c ID {response.ClaimedIdentifier.ToString()}";
                        break;
                    case AuthenticationStatus.Canceled:
                        StatusLabel.Text = $"Авторизация не удалась";
                        break;
                    case AuthenticationStatus.Failed:
                        StatusLabel.Text = $"Авторизация не удалась";
                        break;
                }
            }
            else
            {
                StatusLabel.Text = $"Вы не авторизованы";
            }
        }

        protected void AuthorizeButton_Click(object sender, EventArgs e)
        {
            Authorize();
        }
        protected void Authorize()
        {          
            using (OpenIdRelyingParty openId = new OpenIdRelyingParty())
            {
                IAuthenticationRequest request = openId.CreateRequest("http://steamcommunity.com/openid");
                request.RedirectToProvider();
            }   
        }

        
    }
}