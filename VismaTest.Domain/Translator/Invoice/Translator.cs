using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VismaTest.Domain.Models;
using VismaTest.Domain.ViewModel;

namespace VismaTest.Domain.Translator.Invoice
{
    public static class Translator
    {
        public static InvoiceViewModel ViewModelTranslator(this InvoiceBindingModel model)
        {
            var invoiceViewModel = new InvoiceViewModel
            {
                InvoiceId = model.InvoiceId,
                EndDate = model.EndDate,
                InvoiceDate = model.InvoiceDate,
                InvoiceNo = model.InvoiceNo,
                StartDate = model.StartDate
            };

            return invoiceViewModel;
        }
    }
}
