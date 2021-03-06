using System;
using MediatR;

namespace TicketManagement.Application.Features
{
    public class GetEventDetailQuery : IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}