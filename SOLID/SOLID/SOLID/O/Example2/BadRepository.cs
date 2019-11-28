namespace SOLID.O.Example2
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

    public class Repository
    {
        public void Save(AbstractEntity entity)
        {
            if (entity is AccountEntity)
            {
                // специфические действия для AccountEntity
            }
            if (entity is RoleEntity)
            {
                // специфические действия для RoleEntity
            }
        }
    }
}
