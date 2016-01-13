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
    class JobService
    {
        public static String userServicePath = "http://stintme.com";
        public JobService()
        {

        }

        public static async Task<HttpResponseModel> CreateJob(Job job)
        {
            var path = userServicePath + "/conn/job.asmx/CreateJob?JobPosition="+job.JobPosition+"&JobRequired="+job.JobRequired+"&JobDescription="+job.JobDescription+"&JobLocation="+job.JobLocation+"&JobArea="+job.JobArea+"&JobDate="+job.JobDate+"&JobTimeFrom="+job.JobTimeFrom+"&JobTimeTo="+job.JobTimeTo+"&JobDressCode="+job.JobDressCode+"&JobPay="+job.JobPay+"&PayType="+job.PayType+"&Photo1="+job.Photo1+"&Photo1Type="+job.Photo1Type+"&Photo2="+job.Photo2+"&Photo2Type="+job.Photo2Type+"&Photo3="+job.Photo3+"&Photo3Type="+job.Photo3Type+"&Photo4="+job.Photo4+"&Photo4Type="+job.Photo4Type+"&Login="+job.UserName+"&UserToken="+job.UserToken;
            var httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, path);
            var response = await httpClient.SendAsync(request);
            string a = await response.Content.ReadAsStringAsync();
            HttpResponseModel m = JsonConvert.DeserializeObject<HttpResponseModel>(a);
            return m;
        }

    }
}
