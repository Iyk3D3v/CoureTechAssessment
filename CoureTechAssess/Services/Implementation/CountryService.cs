using CoureTechAssess.Data;
using CoureTechAssess.Dto;
using CoureTechAssess.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoureTechAssess.Services.Implementation
{
    public class CountryService : ICountryService
    {
        private DataContext _context;

        public CountryService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Country>> GetAll()
        {
            try
            {
                var res = await _context.Countries.ToListAsync();
                return res;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<(CountryDto,List<CountryDetailsDto>)> GetCountryByCode(string phonenum)
        {
            try
            {
                var code = phonenum.Substring(0, 3);
                var res = await _context.Countries.FirstOrDefaultAsync(p => p.CountryCode == code);
                var details = await _context.CountryDetails.Where(p => p.CountryId == res.Id).ToListAsync();


                var resdto = new CountryDto
                {
                    Name = res.Name,
                    CountryCode = res.CountryCode,
                    CountryIso = res.CountryIso

                };

                var detailsdto = new List<CountryDetailsDto>();
                foreach(var item in details)
                {
                    detailsdto.Add(new CountryDetailsDto { Operator = item.Operator, OperatorCode = item.OperatorCode });
                }
                return (resdto, detailsdto);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
