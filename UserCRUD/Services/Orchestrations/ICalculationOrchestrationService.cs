using System.Threading.Tasks;
using UserCRUD.Models.Calculations;

namespace UserCRUD.Services.Orchestrations
{
    public interface ICalculationOrchestrationService
    {
        ValueTask<string> ManageAllFunctions(string userName, Calculation calculation);
    }
}
