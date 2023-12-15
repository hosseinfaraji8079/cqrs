using MediatR;

namespace cqrs.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
