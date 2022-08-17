using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AppRpgEtec.Services
{
    public class Request
    {
        public async Task<string> PostReturnStringAsync(TResult)(string uri, TResult data)
        {
            HttpClient httpClient = new HttpClient();

        var content = new StringContent/ JsonConvert.SerializeObject(data);
        content Headers ContentType = new MediaTypeHeaderValue("application/json");

        }
    }

