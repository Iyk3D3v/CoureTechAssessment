using CoureTechAssess.Dto;
using CoureTechAssess.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoureTechAssess.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AssessmentController : ControllerBase
    {
        private ICountryService _service;

        public AssessmentController(ICountryService service)
        {
            _service = service;
        }

        //for question one
        [HttpPost]
        public IActionResult QuestionOne(int[] numbers)
        {
            try
            {
                int points = 0;
                //loop throgh
                foreach(var item in numbers)
                {
                    if(item == 8)
                    {
                        points += 5;
                    }
                    else if(item % 2 == 0)
                    {
                        points += 1;
                    }
                    else if(item % 2 != 0)
                    {
                        points += 3;
                    }

                }
                return Ok(points);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.InnerException.Message ?? ex.Message);
            }
        }

     

        //for question two
        [HttpGet]
        public async Task<IActionResult> QuestionTwo(string phoneNum)
        {
            try
            {
                var res = await _service.GetCountryByCode(phoneNum);
                
                return Ok(new CountryResponseDto
                {
                    PhoneNum = phoneNum,
                    Country = res.Item1,
                    CountryDetails = res.Item2
                });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message ?? ex.Message);
            }
        }

    
    }
}
