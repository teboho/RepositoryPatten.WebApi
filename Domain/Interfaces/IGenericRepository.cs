using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    /// <summary>
    /// Our template repository interface
    /// </summary>
    /// <typeparam name="T">generic type of the entity we wanna access throufh theis repository</typeparam>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Get the entity record by id
        /// </summary>
        /// <param name="id">the id of the record we are looking for</param>
        /// <returns>the record that matches the given id</returns>
        T GetById(int id);

        /// <summary>
        /// Get All the records in the entity table
        /// </summary>
        /// <returns>An enumerable of the records</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Find all the entity records in the table that match the expression
        /// <br />
        /// expression is a lambda expression that takes in an entiy returns true or false
        /// </summary>
        /// <param name="expression">the qualifying expression that sifts the entity records :)</param>
        /// <returns>An enumerable of the qualifying records</returns>
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        /// <summary>
        /// Adding a new entity record to the table
        /// </summary>
        /// <param name="entity">the record we are adding to the table</param>
        void Add(T entity);

        /// <summary>
        /// Add a bunch of entity records to the table all at once (kinda)
        /// </summary>
        /// <param name="entities">An enumerable of the entity records we are adding</param>
        void AddRange(IEnumerable<T> entities);

        /// <summary>
        /// Remove an entity record from the table
        /// </summary>
        /// <param name="entity">The entity to remove</param>
        void Remove(T entity);

        /// <summary>
        /// Remove an enumerable of entities all at once
        /// </summary>
        /// <param name="entities">The enumerbale of entities to remove</param>
        void RemoveRange(IEnumerable<T> entities);

        /// <summary>
        /// Update an existing entity record
        /// </summary>
        /// <param name="entity">The entity to update, with new details</param>
        void Update(T entity);
    }
}
