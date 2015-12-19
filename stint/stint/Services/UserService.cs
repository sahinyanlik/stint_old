using stint.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace stint.Services
{
    class UserService
    {
        
        public static String userServicePath = "http://stintme.com";
        public UserService()
        {
          
        }

        public static async Task<string> CredentialControl(User user)
        {
            var path = userServicePath+ "/conn/user_selfservice.asmx/Login?Username=" + user.UserName + "&Password=" + user.UserPassword;
            var httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, path);
            var response = await httpClient.SendAsync(request);
            string a  = await response.Content.ReadAsStringAsync();
            return a;
        }



    }
}
