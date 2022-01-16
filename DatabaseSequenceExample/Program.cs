// See https://aka.ms/new-console-template for more information
using DatabaseSequenceExample;
using DatabaseSequenceExample.Business.Abstract;
using DatabaseSequenceExample.Business.Concrete;
using DatabaseSequenceExample.DataAccess.Abstract;
using DatabaseSequenceExample.DataAccess.Concrete;


ICustomerData customerData = new CustomerData();
ICustomerService customerService = new CustomerService(customerData);

customerService.AddCustomer();


var webAppBuilder = WebApplication.CreateBuilder();
var app = webAppBuilder.Build();
app.MapGet("/",()=> "Hello, World!");

app.Run();

