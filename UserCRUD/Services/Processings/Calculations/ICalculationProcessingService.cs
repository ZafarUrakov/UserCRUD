using System.Threading.Tasks;
using UserCRUD.Models.Calculations;
using UserCRUD.Models.Users;

namespace UserCRUD.Services.Processings.Calculations
{
    public interface ICalculationProcessingService
    {
        ValueTask<string> Calculate(Calculation calculation, User user);
    }
}
