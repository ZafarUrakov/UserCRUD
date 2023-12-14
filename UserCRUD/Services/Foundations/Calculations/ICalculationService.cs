using System.Linq;
using System.Threading.Tasks;
using System;
using UserCRUD.Models.Calculations;

namespace CalculationCRUD.Services.Foundations.Calculations
{
    public interface ICalculationService
    {
        ValueTask<Calculation> AddCalculationAsync(Calculation calculation);
        ValueTask<Calculation> RetrieveCalculationByIdAsync(Guid calculationId);
        IQueryable<Calculation> RetrieveAllCalculations();
        ValueTask<Calculation> ModifyCalculationAsync(Calculation calculation);
        ValueTask<Calculation> RemoveCalculationAsync(Guid calculationId);
    }
}
