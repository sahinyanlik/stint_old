using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        public static async Task<HttpResponseModel> CredentialControl(User user)
        {
            var path = userServicePath+ "/conn/user_selfservice.asmx/Login?Username=" + user.UserName + "&Password=" + user.UserPassword;
            var httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, path);
            var response = await httpClient.SendAsync(request);
            string a  = await response.Content.ReadAsStringAsync();
            HttpResponseModel m = JsonConvert.DeserializeObject<HttpResponseModel>(a);
           
            return m;
        }

        public static async Task<HttpResponseModel> createUserSendMail(User user)
        {
            var path = userServicePath + "/conn/user_selfservice.asmx/Register?Email=" + user.UserName;
            var httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, path);
            var response = await httpClient.SendAsync(request);
            string a = await response.Content.ReadAsStringAsync();
            HttpResponseModel m = JsonConvert.DeserializeObject<HttpResponseModel>(a);
            return m;
        }

       

        public static async Task<User> getUserInfo(HttpResponseModel model)
        {
            JArray _users = (JArray)model.objects["users"];
            IList<User> usersInfo = _users.ToObject<IList<User>>();
            return usersInfo[0];
        }


        public static async Task<bool> loginUser(User user)
        {
            HttpResponseModel content = await UserService.CredentialControl(user);
            if (content.succeeded == true)
            {
                //App.IsUserLoggedIn = true;
                App.IsUserLoggedIn = true;
                var userInfo = await UserService.getUserInfo(content);
                userInfo.UserPassword = user.UserPassword;
                App.User = userInfo;
                App.Current.Properties["User"] = JsonConvert.SerializeObject(userInfo);

                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
