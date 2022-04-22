using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VismaTest.DAL.IRespository;
using VismaTest.DAL.Store;
using VismaTest.Domain.ViewModel;

namespace VismaTest.DAL.Repository
{
    public class InvoiceRepository : BaseRepository, IInvoiceRepository
    {
        private IDictionary<int, InvoiceViewModel> _storeContext;
        public InvoiceRepository(IDataContext context):base(context)
        {
            _storeContext = context.invoices;
        }

        public InvoiceViewModel Add(InvoiceViewModel entity)
        {
            int id = _storeContext.Count + 1;
            entity.InvoiceId = id;

            _storeContext.Add(id, entity);

            return entity;
        }

        public bool Delete(int id)
        {
            _storeContext.Remove(id);
            return true;
        }

        public IEnumerable<InvoiceViewModel> GetAll()
        {
            return _storeContext.Values.ToList();
        }

        public IReadOnlyCollection<InvoiceViewModel> GetByInvoiceNumber(int invoiceNumber)
        {
            return _storeContext.Values.Where(e => e.InvoiceNo == invoiceNumber).ToList();
        }

        public InvoiceViewModel GetById(int id)
        {
            if (!_storeContext.ContainsKey(id))
                throw new ApplicationException("Booking not found");

            return _storeContext[id];
        }

        public InvoiceViewModel Update(InvoiceViewModel entity)
        {
            if (!_storeContext.ContainsKey(entity.InvoiceId))
                throw new ApplicationException("Invoice not found");

            InvoiceViewModel invoice = _storeContext[entity.InvoiceId];

            return invoice;
        }
    }
}
