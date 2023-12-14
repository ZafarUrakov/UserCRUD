using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using UserCRUD.Models.Calculations;
using UserCRUD.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace UserCRUD.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Calculation> Calculations { get; set; }

        public async ValueTask<Calculation> InsertCalculationAsync(Calculation calculation) =>
            await InsertAsync(calculation);

        public IQueryable<Calculation> SelectAllCalculations() =>
            SelectAll<Calculation>();

        public async ValueTask<Calculation> SelectCalculationByIdAsync(Guid calculationId) =>
            await SelectAsync<Calculation>(calculationId);

        public async ValueTask<Calculation> UpdateCalculationAsync(Calculation calculation) =>
            await UpdateAsync(calculation);

        public async ValueTask<Calculation> DeleteCalculationAsync(Calculation calculation) =>
            await DeleteAsync(calculation);
    }
}
