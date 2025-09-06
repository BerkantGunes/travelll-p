namespace Traveler.CQRS.Commands.DestinationCommand
{
    public class RemoveDestinationCommand
    {
        public RemoveDestinationCommand(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
