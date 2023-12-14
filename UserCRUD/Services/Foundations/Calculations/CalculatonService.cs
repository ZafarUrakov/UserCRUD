using System;
using System.Linq;
using System.Threading.Tasks;
using UserCRUD.Brokers.Storages;
using UserCRUD.Models.Calculations;

namespace CalculationCRUD.Services.Foundations.Calculations
{
    public class CalculatonService : ICalculatonService
    {
        private readonly IStorageBroker storageBroker;

        public CalculatonService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Calculation> AddCalculationAsync(Calculation calculation) =>
            await this.storageBroker.InsertCalculationAsync(calculation);

        public async ValueTask<Calculation> ModifyCalculationAsync(Calculation calculation) =>
            await this.storageBroker.UpdateCalculationAsync(calculation);

        public IQueryable<Calculation> RetrieveAllCalculations() =>
            this.storageBroker.SelectAllCalculations();

        public async ValueTask<Calculation> RemoveCalculationAsync(Guid calculationId)
        {
            var calculation = await this.storageBroker.SelectCalculationByIdAsync(calculationId);

            return await this.storageBroker.DeleteCalculationAsync(calculation);
        }

        public async ValueTask<Calculation> RetrieveCalculationByIdAsync(Guid calculationId) =>
            await this.storageBroker.SelectCalculationByIdAsync(calculationId);
    }
}
