using System.Collections.Generic;
using System.Linq;

using KrasiPool.Data.Common.Repositories;
using KrasiPool.Data.Models;
using KrasiPool.Services.Mapping;

namespace KrasiPool.Services.Data
{
    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.AllAsNoTracking().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}
