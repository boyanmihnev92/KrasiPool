using System.Collections.Generic;

namespace KrasiPool.Services.Data
{
    public interface ISettingsService
    {
        int GetCount();

        IEnumerable<T> GetAll<T>();
    }
}
