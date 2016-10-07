using KinderSecond.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderSecond.Data
{
    public interface IUowData : IDisposable
    {
        IRepository<Question> Questions { get; }

        IRepository<Quiz> Quizes { get; }

        IRepository<ApplicationUser> Users { get; }
        IRepository<Answer> Answers { get; }
        int SaveChanges();
    }
}
