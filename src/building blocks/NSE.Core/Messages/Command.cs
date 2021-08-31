using FluentValidation.Results;
using MediatR;
using System;

namespace NSE.Core.Messages
{
    public abstract class Command : Message, IRequest<ValidationResult>
    {
        public Command()
        {
            Timestamp = DateTime.Now;
        }

        public DateTime Timestamp { get; private set; }

        public ValidationResult ValidationResult;

        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
