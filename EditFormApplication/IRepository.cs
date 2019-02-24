// <copyright file="IRepository.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication
{
    using System;
    using System.Data.Entity;
    using EditFormApplication.Models;

    /// <summary>
    /// Repository Service
    /// </summary>
    /// <typeparam name="T">The generic type parameter.</typeparam>
    public interface IRepository<T> : IDisposable
        where T : class
    {
        /// <summary>
        /// Method for getting by id
        /// </summary>
        /// <param name = "id">NewForm type model parameter</param>
        /// <returns>T object</returns>
        T GetNewForm(int id);

        /// <summary>
        /// Method for create NewForm
        /// </summary>
        /// /// <param name = "item">T type item parameter</param>
        void Create(T item);

        /// <summary>
        /// Method for update NewForm
        /// </summary>
        /// /// <param name = "item">T type item parameter</param>
        void Update(T item);

        /// <summary>
        /// Method for save data
        /// </summary>
        void Save();
    }

    /// <summary>
    /// Basic controller
    /// </summary>
    public class SQLNewFormRepository : IRepository<NewForm>
    {
        /// <summary>
        /// field of context
        /// </summary>
        private readonly NewFormContext db;

        /// <summary>
        /// dispose false
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLNewFormRepository"/> class
        /// </summary>
        public SQLNewFormRepository()
        {
            this.db = new NewFormContext();
        }

        /// <summary>
        /// Method for getting by id
        /// </summary>
        /// <param name = "id">NewForm type model parameter</param>
        /// <returns>T object</returns>
        public NewForm GetNewForm(int id)
        {
            return this.db.NewForms.Find(id);
        }

        /// <summary>
        /// Method for create NewForm
        /// </summary>
        /// <param name = "newForm">NewForm type newForm parameter</param>
        public void Create(NewForm newForm)
        {
            this.db.NewForms.Add(newForm);
        }

        /// <summary>
        /// Method for update NewForm
        /// </summary>
        /// /// <param name = "newForm">NewForm type newForm parameter</param>
        public void Update(NewForm newForm)
        {
            this.db.Entry(newForm).State = EntityState.Modified;
        }

        /// <summary>
        /// Method for save data
        /// </summary>
        public void Save()
        {
            this.db.SaveChanges();
        }

        /// <summary>
        /// Method for disposing
        /// </summary>
        /// <param name = "disposing">boolean type disposing parameter</param>
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.db.Dispose();
                }
            }

            this.disposed = true;
        }

        /// <summary>
        /// Method for dispose
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
