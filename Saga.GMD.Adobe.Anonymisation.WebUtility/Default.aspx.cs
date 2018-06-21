using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Saga.GMD.Adobe.Anonymisation.BLL;

namespace Saga.GMD.Adobe.Anonymisation.WebUtility
{
    public partial class _Default : Page
    {
        PersIDData _PersIDData = new PersIDData(ConfigurationManager.AppSettings["APIAddress"]);
        long persID;
        private readonly string apiErrorMessage = "Something went wrong. Please try another Pers ID and if error persists, please check with GMD";
        protected void Page_Load(object sender, EventArgs e)
        {
            string currentUser = HttpContext.Current.User.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Pers ID is required as a string to be run through TryParse and confirm numbers only
            string persIDString = Search_PersID.Text;

            if (IsSearchValid(persIDString))
            {
                TextArea1.Value = _PersIDData.GetObfuscatedDetails(persID.ToString());
                TextArea2.Value = _PersIDData.GetDeAnonymisedData(persID.ToString());

                if (TextArea1.Value==apiErrorMessage || TextArea2.Value==apiErrorMessage)
                {
                    // Issue in one of the returns from the API. Do not display
                    TextArea1.Value = TextArea2.Value = apiErrorMessage;
                }
            }
            else
            {
                // Input Pers ID is not a number so API call should not be made
                TextArea1.Value = TextArea2.Value = "Not a valid Pers ID (are there letters in your search term?)";
            }
        }

        protected void Search_PersID_TextChanged(object sender, EventArgs e)
        {
            if (IsSearchValid(Search_PersID.Text))
            {
                persID = Int64.Parse(Search_PersID.Text);
            }

        }

        private bool IsSearchValid(string pers_ID_String)
        {
            return Int64.TryParse(pers_ID_String, out persID);
        }
    }
}