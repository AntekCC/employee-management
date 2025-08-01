using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Versioning;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace management_system
{
    public  class JsonApi
    {
        string spreadsheetId = "1CFqJudqVVOeSI2cNZI6FzOPUpNEpXywUzto7m60B_EI";
        string range = "json!A:C";
        string ApiKey = "AIzaSyBJZPHAsPhpFNz4f7kicQTlPtw_MbUQPM8";
        string jsonFile;
        public JsonApi(string JFile)
        {
            jsonFile = JFile;
        }
       public async Task PostApi()
        {
          

            string PostApi = $"https://sheets.googleapis.com/v4/spreadsheets/{spreadsheetId}/values/{range}:append?valueInputOption=USER_ENTERED&key={ApiKey}";
            using (HttpClient client = new HttpClient()) {
                var content = new StringContent(jsonFile, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(PostApi, content);
            
                MessageBox.Show($"Request Body: {jsonFile}");

                if (response.IsSuccessStatusCode) {
                    MessageBox.Show("jsonFile");
                }
                else
                {
                    MessageBox.Show("siemaa");

                }
                var result = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Status: {response.StatusCode}\n{result}");
            }
        }
    }
}
