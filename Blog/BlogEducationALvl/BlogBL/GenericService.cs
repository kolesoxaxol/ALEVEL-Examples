using BlogDAL.Repository;

namespace BlogBL
{
    public interface IGenereicService<BLModel>
        where BLModel : class
       
    {
        BLModel FindById(int id);
    }

    public abstract class GenericService<BLModel, DModel> : IGenereicService<BLModel>
        where BLModel : class
        where DModel : class
    {
        private readonly IGenericRepository<DModel> _repositroy;
        public GenericService()
        { 
            _repositroy = new GenericRepository<DModel>();
        }

        public virtual BLModel FindById(int id)
        {
            var entity = _repositroy.FindById(id);
            return Map(entity);
        }

        public abstract BLModel Map(DModel entity);
        public abstract DModel Map(BLModel blmodel);

    }
}
