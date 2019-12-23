using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using PinnacleClasses.Converters;
using PinnacleClasses.Dto;
using RestSharp;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Http;
using System.Net;

namespace PinnacleClasses.PythonClients
{
    /// <summary>
    /// Класс для взаимодействия с api на python
    /// </summary>
 public class PythonClient
    {
        private  RestClient _pythonClient;
        
        HttpClient httpClient = new HttpClient((new HttpClientHandler { AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip }));
        string _url = "http://127.0.0.1:5000/data";
        public PythonClient()
        {



            this._pythonClient = new RestClient(_url);

        }
       
        /// <summary>
        /// Метод принимает параметры для api,возвращает результаты в виде словаря:ключ-исход,значение- очищенный рассчитанный коэффициент
        /// </summary>
        /// <param name="k1"></param>
        /// <param name="to"></param>
        /// <param name="tu"></param>
        /// <param name="k2"></param>
        /// <param name="hdp1"></param>
        /// <param name="hdp2"></param>
        /// <returns></returns>
        public  Dictionary<string, decimal>GetDataFromPythonApi(decimal k1, decimal to, decimal tu, decimal k2, decimal hdp1, decimal hdp2)
        {
         
          
            var request = new RestRequest(GetQueryParamsString(k1, to, tu, k2, hdp1, hdp2), Method.GET);

            request.Timeout =7000;

            Dictionary<string, decimal> resdict = new Dictionary<string, decimal>();
            IRestResponse response = this._pythonClient.Execute(request);
            string res = response.Content;
           
            try
            {
                resdict = JsonConvert.DeserializeObject<Dictionary<string,decimal>>(res);
                
               
                
                

                return resdict;
            }
            catch (Exception ex)
            {
                Console.WriteLine("excepted");
                return null;
            }
        }


            
        public async Task<Dictionary<string,decimal>> GetDataFromPythonApiAsync2(decimal k1, decimal to, decimal tu, decimal k2, decimal hdp1, decimal hdp2)
        {
            string path = GetQueryParamsString(k1, to, tu, k2, hdp1, hdp2);
            try
            {
                this.httpClient.Timeout = TimeSpan.FromSeconds(12);
                HttpResponseMessage message = await httpClient.GetAsync(this._url + path);



               string content = await message.Content.ReadAsStringAsync();

                
                
                Dictionary<string, decimal> result = JsonConvert.DeserializeObject<Dictionary<string, decimal>>(content);
                return result;
                
                }

            catch (Exception ex)
            {
                
                return null;
            }

        }




        /// <summary>
        /// Метод формирующий строку запроса на api,по 6 входящим параметрам
        /// </summary>
        /// <param name="k1">половинчатый тотал</param>
        /// <param name="to">over</param>
        /// <param name="tu">under</param>
        /// <param name="k2">половинчатый гандикап</param>
        /// <param name="hdp1">hdp home</param>
        /// <param name="hdp2">hdp away</param>
        /// <returns></returns>
        private static string GetQueryParamsString(decimal k1,decimal to,decimal tu,decimal k2,decimal hdp1,decimal hdp2)
        {
            
         return string.Format("?k1={0}+&to={1}+&tu={2}+&k2={3}+&hdp1={4}+&hdp2={5}", k1.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture), to.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture), tu.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture), k2.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture), hdp1.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture), hdp2.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
