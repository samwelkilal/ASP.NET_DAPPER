using InviceGeneration.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InviceGeneration.Application.Query
{
    public class GetInvoiceQuery:IRequest<List<Payment>>
    {
    }
}
