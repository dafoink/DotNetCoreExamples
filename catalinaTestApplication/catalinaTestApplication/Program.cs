using System;
using System.Collections.Generic;
using RestSharp;

namespace catalinaTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
			Classes.ASCIIArt.PrintCatalina();
			Console.WriteLine("Please enter a customer to search for: ");
			string custID = Console.ReadLine();
			Console.WriteLine("----------------------------------------------------------------");
			try
			{
				var returnCustomers = GetCustomerData(custID);
				if(returnCustomers.Count > 0)
				{
					Console.WriteLine("Customers Retrieved: " + returnCustomers.Count.ToString());
					foreach(var customer in returnCustomers)
					{
						Console.WriteLine("Customer: " + customer.CustId.Trim() + " " + customer.Name.Trim());
						Console.WriteLine("Customer Class: " + customer.ClassId.Trim());
						Console.WriteLine("Terms: " + customer.Terms.Trim());
						Console.WriteLine("----------------------------------------------------------------");
					}
				}
				else
				{
					throw new Exception("No customer's retrieved for CustID = " + custID);
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine("Error Retrieving Customers!");
				Console.WriteLine(ex.Message);
			}
			
		}

		static List<Classes.Customer> GetCustomerData(string custID)
		{
			var client = new RestClient("http://yourserverhere/ctDynamicsSL/api/financial/accountsReceivable/customer/query/CustID=" + custID);
			var request = new RestRequest(Method.GET);
			request.AddHeader("Cache-Control", "no-cache");
			request.AddHeader("Content-Type", "application/json");
			request.AddHeader("SiteID", "DEFAULT");
			request.AddHeader("CpnyID", "0060");
			request.AddHeader("Authorization", "Basic YOURAUTHHERE");
			request.AddHeader("Accept", "application/json");
			IRestResponse response = client.Execute(request);

			
			try
			{
				if(response.StatusCode != System.Net.HttpStatusCode.OK)
				{
					throw new Exception(response.StatusDescription);
				}
				var returnCustomer = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Classes.Customer>>(response.Content);
				return returnCustomer;
			}
			catch(Exception ex)
			{
				throw new Exception("Error Executing API Call"+ ex.Message, ex);
			}
		}
    }
}
