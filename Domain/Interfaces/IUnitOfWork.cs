using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Repository object
        /// </summary>
        IDeveloperRepository Developers { get; }

        /// <summary>
        /// Repository object
        /// </summary>
        IProjectRepository Projects { get; }

        /// <summary>
        /// Save changes to the database
        /// </summary>
        /// <returns>save code</returns>
        int Complete();
    }
}
