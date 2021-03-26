using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Fanfarra.Api.Application.Commands;
using Fanfarra.Api.Application.Responses;
using Fanfarra.Domain.Connectors;

namespace Fanfarra.Api.Application.Handlers
{
    public class RendaFixaHandler : RendaFixaCommand
    {
        private readonly IRendaFixaConnector _rendaFixaConnnector;

        public RendaFixaHandler()
        {
        }

        public async Task<RendaFixaResponse> Handle(RendaFixaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
