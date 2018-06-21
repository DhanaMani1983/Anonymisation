using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Specialized;
using Saga.GMD.Adobe.Anonymisation.API;
using System.Web;

namespace Saga.GMD.Adobe.Anonymisation.BLL
{
    public class PersIDData
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string _apiURL;

        public PersIDData(string apiAddress)
        {
            // Constructor takes API address passed in as a value. This allows it to be stored in
            // web.config for the utility and changed without rebuilding the API
            _apiURL = apiAddress;
        }

        public string GetObfuscatedDetails(string pers_id)
        {
            string apiEndPoint = "ExtractRecipients";
            return ReadData(Int64.Parse(pers_id), apiEndPoint);
        }

        public string GetDeAnonymisedData(string pers_id)
        {
            string apiEndPoint = "ExtractCPRecipients";
            return ReadData(Int64.Parse(pers_id), apiEndPoint);
        }


        public string ReadData(long pers_id, string apiEndpoint)
        {
            StringBuilder returnData = new StringBuilder();

            _log.Info(string.Format("API call made to {0}{1} for Pers ID {2}", _apiURL, apiEndpoint, pers_id.ToString()));

            try
            {
                using (var client = new WebClient())
                {
                    var values = new NameValueCollection();
                    values["Pers_ID"] = pers_id.ToString();

                    var response = client.UploadValues(_apiURL + apiEndpoint, values);
                    var jsonReturn = Encoding.Default.GetString(response);

                    jsonReturn = jsonReturn.Replace("{", "");
                    jsonReturn = jsonReturn.Replace("}", "");
                    string[] jsonArray = jsonReturn.ToString().Split(',');
                    foreach (string segment in jsonArray)
                    {
                        string strippedSeg = segment.Replace('"', ' ');
                        returnData.Append(strippedSeg + "\n");
                    }
                }
                return returnData.ToString();
                
            }
            catch (Exception ex)
            {
                try
                {
                    string.IsNullOrEmpty(ex.InnerException.ToString());
                    _log.Error(ex.InnerException.ToString());
                }
                catch (Exception)
                {
                    _log.Error(ex.ToString());
                }
                _log.Error(ex.StackTrace.ToString());
                return "Something went wrong. Please try another Pers ID and if error persists, please check with GMD";
            }
        }
    }
}
