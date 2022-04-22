using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VismaTest.Domain.ViewModel;

namespace VismaTest.DAL.Store
{
    public class DataContext : IDataContext
    {
        public Dictionary<int, InvoiceViewModel> invoices { get; set; }
    }
}
