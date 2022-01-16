using DatabaseSequenceExample.Business.Abstract;
using DatabaseSequenceExample.DataAccess.Abstract;
using DatabaseSequenceExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSequenceExample.Business.Concrete
{
    public class CustomerService : ICustomerService, IDisposable
    {
        private readonly ICustomerData _customerData;
        public CustomerService(ICustomerData customerData)
        {
            _customerData = customerData;
        }
        public void AddCustomer()
        {
            try
            {

                var resultGetDatatableSequenceValue_CustomerId = _customerData.GetDatatableSequenceValue("Customer", "Id");
                if (!resultGetDatatableSequenceValue_CustomerId.Success)
                {
                    return;
                }


                Customer customer = new();
                customer.Id = resultGetDatatableSequenceValue_CustomerId.Data;
                customer.Name = "Tolga";
                customer.Surname = "Tandoğan";

                var resultAddCustomer = _customerData.Add(customer);

                /// control vs
                
           }
            catch (Exception ex)
            {
                //log etc
            }
            finally 
            { 
            // control vs
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
