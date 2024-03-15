using InviceGeneration.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InviceGeneration.Application.RepositoryInterface
{
    public interface IInvoiceRepository
    {
        Task<List<Payment>> GetInvoice();
    }
}
