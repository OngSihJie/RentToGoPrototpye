using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RentToGo_Finall.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RentToGo_Finall
{
    class DetailsManager
    {
        /* public static List<Customer> GetCustomerData()
      {
          var httpClient = new HttpClient();
          var response = httpClient.GetStringAsync("http://10.0.2.2:65463/api/Customers");
          var Customer_Data = JsonConvert.DeserializeObject<List<Customer>>(response.Result);
          return Customer_Data.ToList();
      } */
        public static List<Property> GetPropertyData()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetStringAsync("http://10.0.2.2:53917/api/Properties");
            var Property_Data = JsonConvert.DeserializeObject<List<Property>>(response.Result);
            return Property_Data.ToList();
        }
        public static List<Agent> GetAgentData()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetStringAsync("http://10.0.2.2:53917/api/Agents");
            var Agent_Data = JsonConvert.DeserializeObject<List<Agent>>(response.Result);
            return Agent_Data.ToList();
        }
        public static void registercustomer(string username, string name, string phn, string address, string pass)
        {
            try
            {
                Customer Customer_Data = new Customer
                {
                    CustUsername = username,
                    CustName = name,
                    CustPhnNumber = Int32.Parse(phn),
                    CustAddress = address,
                    CustPassword = pass
                };
                var httpClient = new HttpClient();
                var Json = JsonConvert.SerializeObject(Customer_Data);
                HttpContent httpContent = new StringContent(Json);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/Json");
                httpClient.PostAsync(string.Format("http://10.0.2.2:53917/api/Customers"), httpContent);
            }
            catch (Exception e)
            {
                Console.WriteLine("Insert data error" + e.Message);
            }

        }
        public static void editcustomer(string username, string name, int phn, string address, string pass)
        {
            try
            {
                Customer Customer_Data = new Customer
                {
                    CustUsername = username,
                    CustName = name,
                    CustPhnNumber = phn,
                    CustAddress = address,
                    CustPassword = pass
                };
                var httpClient = new HttpClient();
                var Json = JsonConvert.SerializeObject(Customer_Data);
                HttpContent httpContent = new StringContent(Json);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/Json");
                httpClient.PutAsync(string.Format("http://10.0.2.2:53917/api/Customers/{0}", username), httpContent);


            }
            catch (Exception e)
            {
                Console.WriteLine("Insert data error" + e.Message);
            }

        }
    }
}
