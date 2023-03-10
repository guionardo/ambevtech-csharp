// See https://aka.ms/new-console-template for more information

using AnemicDomainModels.Models;
using AnemicDomainModels.Services;

var customersJson = @"
[
  {
    ""id"": 1,
    ""name"": ""Guionardo"",
    ""document"": ""96980389904"",
    ""phone_number"": ""55 47 99552-1245""
  },




{



    ""id"": 2,
    ""name"": ""João"",
    ""document"": ""93658877987"",
    ""phone_number"": ""22 00000-0000""
  }



]
"
;


//var service = new CustomerService();
//var service = new RichCustomerService();
var service = new GenericService<AnemicCustomer>();

service.AddCustomersFromJson(customersJson);

var newJson = service.GetCustomersAsJson();
Console.WriteLine(newJson);

var service2 = new GenericService<RichCustomer>();
service2.AddCustomersFromJson(customersJson);
var newJson2 = service2.GetCustomersAsJson();
Console.WriteLine(newJson2);