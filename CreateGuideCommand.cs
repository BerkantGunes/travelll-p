using MediatR;

namespace Traveler.CQRS.Commands.GuideCommand
{
    public class CreateGuideCommand:IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
