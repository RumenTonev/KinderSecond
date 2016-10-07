using KinderSecond.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderSecond.Data
{
    public class UowData : IUowData
    {
        private readonly ApplicationDbContext context;
        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public UowData()
            : this(new ApplicationDbContext())
        {
        }

        public UowData(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IRepository<Quiz> Quizes
        {
            get
            {
                return this.GetRepository<Quiz>();
            }
        }

        public IRepository<Answer> Answers
        {
            get
            {
                return this.GetRepository<Answer>();
            }
        }

        public IRepository<ApplicationUser> Users
        {
            get
            {
                return this.GetRepository<ApplicationUser>();
            }
        }
        public IRepository<Question> Questions
        {
            get
            {
                return this.GetRepository<Question>();
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            if (this.context != null)
            {
                this.context.Dispose();
            }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}


