using movie.core.ViewModels.Countries;

namespace movie.core.Contracts
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryViewModel>> GetAllCountriesAsync();
    }
}
