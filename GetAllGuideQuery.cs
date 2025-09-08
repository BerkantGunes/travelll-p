using MediatR;
using Traveler.CQRS.Results.GuideResult;

namespace Traveler.CQRS.Queries.GuideQuery
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {

    }
}
