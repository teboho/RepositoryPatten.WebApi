using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IDeveloperRepository : IGenericRepository<Developer>
    {
        /// <summary>
        /// Get top *count* developers
        /// </summary>
        /// <param name="count">How many developers to return</param>
        /// <returns>AN enumerbale of developer records</returns>
        IEnumerable<Developer> GetPopularDevelopers(int count);
    }
}
