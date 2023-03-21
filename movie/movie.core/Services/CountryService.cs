using movie.core.Contracts;
using movie.core.ViewModels.Countries;

namespace movie.core.Services
{
    public class CountryService : ICountryService
    {
        public Task<IEnumerable<CountryViewModel>> GetAllCountriesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
