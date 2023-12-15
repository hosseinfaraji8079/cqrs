using cqrs.Model;
using MediatR;

namespace cqrs.Queries
{
    public class GetStudentListQuery : IRequest<List<StudentDetails>>
    {
    }
}
