using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Shared.Abstractions.Commands
{
    public interface ICommandDispatcher
    {
        Task DispatchCommandAsync<TCommand>(TCommand command) where TCommand : class, ICommand;
    }
}
