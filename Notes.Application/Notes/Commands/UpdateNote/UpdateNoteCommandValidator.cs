using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommandValidator : AbstractValidator<UpdateNoteCommand>
    {
        public UpdateNoteCommandValidator()
        {
            RuleFor(updateCommand => updateCommand.UserId).NotEqual(Guid.Empty);
            RuleFor(updateCommand => updateCommand.Id).NotEqual(Guid.Empty);
            RuleFor(updateCommand => updateCommand.Title).NotEmpty().MaximumLength(250);
           
        }
    }
}
