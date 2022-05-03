
using System.Collections.Generic;
using System.Threading.Tasks;

namespace netwebAPI.Repositories
{
    public interface IStudentRepository
    {
       Task<List<DataModels.Student>> GetStudentsAsync();
    }
}
