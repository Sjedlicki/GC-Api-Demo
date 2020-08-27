using MockAssessment7DonutApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssessment7DonutApi.Services
{
    public interface IHallOfFameService
    {
        Task<HallOfFame> GetAll();
    }
}
