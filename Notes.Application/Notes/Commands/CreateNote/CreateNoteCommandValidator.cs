using FluentValidation;
using System;
 
namespace Notes.Application.Notes.Commands.CreateNote
{
    public class CreateNoteCommandValidator:AbstractValidator<CreateNoteCommand>
    {
        public CreateNoteCommandValidator()
        {
            RuleFor(createCommand => createCommand.Title).NotEmpty().MaximumLength(250);
            RuleFor(createCommand => createCommand.UserId).NotEqual(Guid.Empty);
        }

    }
}
