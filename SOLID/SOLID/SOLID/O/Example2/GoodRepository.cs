using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O.Example2.Good
{
    public abstract class AbstractEntity
    {
    }

    public class AccountEntity : AbstractEntity
    {
    }

    public class RoleEntity : AbstractEntity
    {
    }

    public interface IRepository<T> where T : AbstractEntity
    {
        void Save(T entity);
    }

    public class AccountRepository : IRepository<AccountEntity>
    {
        public void Save(AccountEntity entity)
        {
            // специфические действия для AccountEntity
        }
    }

    public class RoleRepository : IRepository<RoleEntity>
    {
        public void Save(RoleEntity abstractEntity)
        {
            // специфические действия для RoleEntity
        }
    }
}
