using InviceGeneration.Application.Query;
using InviceGeneration.Application.RepositoryInterface;
using InviceGeneration.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InviceGeneration.Application.QueryHandler
{
    public class GetInvoiceQueryHandler : IRequestHandler<GetInvoiceQuery, List<Payment>>
    {
        private readonly IInvoiceRepository _repo;

        public GetInvoiceQueryHandler(IInvoiceRepository repo)
        {
            _repo = repo;
        }
        public Task<List<Payment>> Handle(GetInvoiceQuery request, CancellationToken cancellationToken)
        {
            var res = _repo.GetInvoice();
            return res;
            
        }
    }
}
