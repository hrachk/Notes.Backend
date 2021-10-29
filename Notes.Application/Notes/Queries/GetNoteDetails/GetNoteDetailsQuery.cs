using MediatR;
using System;
 

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class GetNoteDetailsQuery : IRequest<NoteDeatilsVm>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }    
    }
}
