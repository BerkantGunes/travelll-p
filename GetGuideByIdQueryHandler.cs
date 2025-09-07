using DataAccessLayer.Concrete;
using MediatR;
using NuGet.Protocol.Plugins;
using Traveler.CQRS.Queries.GuideQuery;
using Traveler.CQRS.Results.GuideResult;

namespace Traveler.CQRS.Handlers.GuideHandler
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideId = values.GuideId,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
