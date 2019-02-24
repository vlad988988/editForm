// <copyright file="IRepository.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication
{
    using EditFormApplication.Models;
    using System;
    using System.Data.Entity;

    interface IRepository<T> : IDisposable
        where T : class
    {
        T GetNewForm(int id);
        void Create(T item);
        void Update(T item);
        void Save();
    }

    public class SQLNewFormRepository : IRepository<NewForm>
    {
        private NewFormContext db;

        public SQLNewFormRepository()
        {
            this.db = new NewFormContext();
        }

        public NewForm GetNewForm(int id)
        {
            return db.NewForms.Find(id);
        }

        public void Create(NewForm newForm)
        {
            db.NewForms.Add(newForm);
        }

        public void Update(NewForm newForm)
        {
            db.Entry(newForm).State = EntityState.Modified;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
