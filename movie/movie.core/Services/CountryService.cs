using Microsoft.EntityFrameworkCore;
using movie.core.Contracts;
using movie.core.ViewModels.Countries;
using movie.data.Entities;
using movie.data.Repositories;

namespace movie.core.Services;

public class CountryService : ICountryService
{
    private readonly IRepository<Country> countriesRepository;

    public CountryService(IRepository<Country> countriesRepository)
    {
        this.countriesRepository = countriesRepository;
    }

    public async Task<IEnumerable<CountryViewModel>> GetAllCountriesAsync()
    {
        var countries = await countriesRepository
            .AllAsNoTracking()
            .Select(x => new CountryViewModel()
            {
                Id = x.Id,
                Name = x.Name
            })
            .ToListAsync();

        return countries;
    }
}