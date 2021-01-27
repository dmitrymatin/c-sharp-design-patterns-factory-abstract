using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Factory_Pattern.Business.Models.Commerce;

namespace Abstract_Factory_Pattern.Business.Models.Commerce.Summary
{
    public interface ISummary
    {
        string CreateOrderSummary(Order order);
        void Send();
    }

    public class EmailSummary : ISummary
    {
        public string CreateOrderSummary(Order order)
        {
            return "This is an email summary!";
        }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }

    public class CsvSummary : ISummary
    {
        public string CreateOrderSummary(Order order)
        {
            return "This,is,a,CSV,summary";
        }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }
}
