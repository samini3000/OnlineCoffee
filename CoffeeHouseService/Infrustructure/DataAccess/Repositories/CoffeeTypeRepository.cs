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

        //a bi directional mapper added
        private static MapperConfiguration _config = new MapperConfiguration(cfg => cfg.CreateMap<DomainCoffeeType, DataCoffeeType>().ReverseMap());
        private readonly Mapper _mapper= new Mapper(_config);

        public CoffeeTypeRepository(CoffeeHouseDBContext coffeeHouseDBContext) 
        {
            _dbContext = coffeeHouseDBContext;
        }

        public async Task Add(DomainCoffeeType entity)
        {
            await _dbContext.CoffeeTypes.AddAsync(_mapper.Map<DataCoffeeType>(entity));
            await _dbContext.SaveChangesAsync();
        }

        public async Task <IEnumerable<DomainCoffeeType>> GetAll() //to do : come back and make it async
        {
            return _dbContext.CoffeeTypes
                .Select(x=>_mapper.Map<DomainCoffeeType>(x))
                .ToList();

        }
    }
}
