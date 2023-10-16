using Domain.Repositories;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DataCoffeeType = Infrustructure.DataAccess.Entities.CoffeeType;
using DomainCoffeeType = Domain.Entities.CoffeeType;

namespace Infrustructure.DataAccess.Repositories
{
    public class CoffeeTypeRepository : ICoffeeTypeRepository
    {
        CoffeeHouseDBContext _dbContext;
        private static MapperConfiguration _config = new MapperConfiguration(cfg => cfg.CreateMap<DomainCoffeeType, DataCoffeeType>().ReverseMap());
        private readonly Mapper _mapper= new Mapper(_config);
        //private readonly Mapper  d= new Mapper(_config).r
        public CoffeeTypeRepository(CoffeeHouseDBContext coffeeHouseDBContext) 
        {
            _dbContext = coffeeHouseDBContext;
        }

        public void Add(DomainCoffeeType entity)
        {
            _dbContext.CoffeeTypes.Add(_mapper.Map<DataCoffeeType>(entity));
            _dbContext.SaveChanges();
        }

        public IEnumerable<DomainCoffeeType> GetAll()
        {
            return _dbContext.CoffeeTypes
                .Select(x=>_mapper.Map<DomainCoffeeType>(x))
                .ToList();
        }
    }
}
