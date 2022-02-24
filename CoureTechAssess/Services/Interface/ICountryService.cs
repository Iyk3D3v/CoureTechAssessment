using CoureTechAssess.Data;
using CoureTechAssess.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoureTechAssess.Services.Interface
{
    public interface ICountryService
    {
        Task<List<Country>> GetAll();
        Task<(CountryDto, List<CountryDetailsDto>)> GetCountryByCode(string phonenum);
    }
}
