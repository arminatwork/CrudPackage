using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using Crud.BaseDTO;
using Crud.BaseRepository;
using Crud.Entity;

namespace Crud.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TDto, TSelectDto, TEntity, TKey> : ControllerBase
    where TDto : BaseDto<TDto, TEntity, TKey>, new()
    where TSelectDto : BaseDto<TSelectDto, TEntity, TKey>, new()
    where TEntity : class, IEntity<TKey>, new()
    {
        protected readonly IBaseRepository<TEntity> Repository;
        protected readonly IMapper _mapper;

        public BaseController(IBaseRepository<TEntity> repostiory, IMapper mapper)
        {
            Repository = repostiory;
            _mapper = mapper;
        }

        [HttpGet]
        public virtual async Task<ActionResult<List<TSelectDto>>> Get(CancellationToken cancellationToken)
        {
            var list = await Repository.TableNoTracking.ProjectTo<TSelectDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

            return Ok(list);
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TSelectDto>> Get(TKey id, CancellationToken cancellationToken)
        {
            var dto = await Repository.TableNoTracking.ProjectTo<TSelectDto>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(p => p.Id.Equals(id), cancellationToken);

            if (dto is null) return NotFound($"Dto TSelectDto Id:{id} not found!...");

            return dto;
        }

        [HttpPost]
        public virtual async Task<ActionResult<TSelectDto>> Create(TDto dto, CancellationToken cancellationToken)
        {
            var model = dto.ToEntity(_mapper);

            await Repository.AddAsync(model, cancellationToken);

            var resultDto = await Repository.TableNoTracking.ProjectTo<TSelectDto>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(p => p.Id.Equals(model.Id), cancellationToken);
            if (resultDto is null) return NotFound($"ResultDto TSelectDto Id:{model.Id} not found!...");


            return resultDto;
        }

        [HttpPut("{id}")]
        public virtual async Task<ActionResult<TSelectDto>> Update(TKey id, TDto dto, CancellationToken cancellationToken)
        {
            var model = await Repository.GetByIdAsync(cancellationToken, id);

            model = dto.ToEntity(_mapper, model);
            if (model is null) return NotFound($"ResultDto TSelectDto Id:{id} not found!...");

            await Repository.UpdateAsync(model, cancellationToken);

            var resultDto = await Repository.TableNoTracking.ProjectTo<TSelectDto>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync(p => p.Id.Equals(model.Id), cancellationToken);


            return resultDto;
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(TKey id, CancellationToken cancellationToken)
        {
            var model = await Repository.GetByIdAsync(cancellationToken, id);
            if (model is null) return NotFound($"Entity TKey Id:{id} not found!...");

            await Repository.DeleteAsync(model, cancellationToken);

            return Ok();
        }
    }
    public class BaseController<TDto, TSelectDto, TEntity> : BaseController<TDto, TSelectDto, TEntity, int>
        where TDto : BaseDto<TDto, TEntity, int>, new()
        where TSelectDto : BaseDto<TSelectDto, TEntity, int>, new()
        where TEntity : class, IEntity<int>, new()
    {
        public BaseController(IBaseRepository<TEntity> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }

    public class BaseController<TDto, TEntity> : BaseController<TDto, TDto, TEntity, int>
           where TDto : BaseDto<TDto, TEntity, int>, new()
           where TEntity : class, IEntity<int>, new()
    {
        public BaseController(IBaseRepository<TEntity> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}