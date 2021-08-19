using FluentValidation.Results;
using System;

namespace NSE.Core.Messages
{
    public abstract class Command : Message
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
