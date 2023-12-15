using cqrs.Model;
using MediatR;

namespace cqrs.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
