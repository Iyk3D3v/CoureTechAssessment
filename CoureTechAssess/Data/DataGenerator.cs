using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoureTechAssess.Data
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                if(context.Countries.Any())
                {
                    return; //means data already seeded
                }

                context.Countries.AddRange(
                    new Country
                    {
                        Id = 1,
                        CountryCode = "234",
                        Name = "Name",
                        CountryIso = "NG"
                    },
                     new Country
                     {
                         Id = 2,
                         CountryCode = "233",
                         Name = "Ghana",
                         CountryIso = "GH"
                     },
                      new Country
                      {
                          Id = 3,
                          CountryCode = "229",
                          Name = "Benin Republic",
                          CountryIso = "BN"
                      },
                       new Country
                       {
                           Id = 4,
                           CountryCode = "225",
                           Name = "Cote d'Ivoire",
                           CountryIso = "CIV"
                       }
                    );

                context.CountryDetails.AddRange(
                    new CountryDetails
                    {
                        Id = 1,
                        CountryId = 1,
                        Operator = "MTN NIgeria",
                        OperatorCode = "MTN NG"
                    },
                    new CountryDetails
                    {
                        Id = 2,
                        CountryId = 1,
                        Operator = "Airtel Nigeria",
                        OperatorCode = "ANG"
                    },
                    new CountryDetails
                    {
                        Id = 3,
                        CountryId = 1,
                        Operator = "9 Mobile Nigeria",
                        OperatorCode = "ETN"
                    },
                    new CountryDetails
                    {
                        Id = 4,
                        CountryId = 1,
                        Operator = "Globacom Nigeria",
                        OperatorCode = "GLO NG"
                    },
                    new CountryDetails
                    {
                        Id = 5,
                        CountryId = 2,
                        Operator = "Vodafone Ghana",
                        OperatorCode = "Vodafone GH"
                    },
                    new CountryDetails
                    {
                        Id = 6,
                        CountryId = 2,
                        Operator = "MTN Ghana",
                        OperatorCode = "MTN Ghana"
                    },
                    new CountryDetails
                    {
                        Id = 7,
                        CountryId = 2,
                        Operator = "Tigo Ghana",
                        OperatorCode = "Tigo Ghana"
                    },
                    new CountryDetails
                    {
                        Id = 8,
                        CountryId = 3,
                        Operator = "MTN Benin",
                        OperatorCode = "MTN Benin"
                    },
                    new CountryDetails
                    {
                        Id = 9,
                        CountryId = 3,
                        Operator = "Moov Benin",
                        OperatorCode = "Moov Benin"
                    },
                    new CountryDetails
                    {
                        Id = 10,
                        CountryId = 4,
                        Operator = "MTN Cote d'Ivoire",
                        OperatorCode = "MTN Cote d'Ivoire"
                    });

                context.SaveChanges();
            }
        }
    }
}
