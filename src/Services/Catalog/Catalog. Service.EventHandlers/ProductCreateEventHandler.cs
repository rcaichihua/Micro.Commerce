using Catalog.Service.EventHandlers.Commands;
using Catalog.Persistence.Database;
using Catalog.Domain;
using MediatR;

namespace Catalog.Service.EventHandlers
{
	public class ProductCreateEventHandler
		: INotificationHandler<ProductCreateCommand>
	{
        private readonly ApplicationDbContext _context;

        public ProductCreateEventHandler(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task Handle(ProductCreateCommand command, CancellationToken cancellationToken)
		{
			await _context.AddAsync(new Product
			{
				Name = command.Name,
				Description = command.Description,
				Price = command.Price
			});
			await _context.SaveChangesAsync();
		}
    }
}

