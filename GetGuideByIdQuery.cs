using MediatR;
using Traveler.CQRS.Results.GuideResult;

namespace Traveler.CQRS.Queries.GuideQuery
{
    public class GetGuideByIdQuery:IRequest<GetGuideByIdQueryResult>
    {
        public GetGuideByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
