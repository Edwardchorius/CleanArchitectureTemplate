using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ProjectTemplate.Persistence.Commands.Base
{
    public abstract class CommandDbContext : DbContext
    {
        private readonly IMediator _mediator;

        public CommandDbContext(DbContextOptions options, IMediator mediator)
            : base(options)
        {
            _mediator = mediator;
        }

        // More work to be done
    }
}
