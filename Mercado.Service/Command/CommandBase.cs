using FluentValidation.Results;
using Mercado.DomainCore.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Application.Command
{
    public abstract class CommandBase : Message
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected CommandBase()
        {
            Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}
