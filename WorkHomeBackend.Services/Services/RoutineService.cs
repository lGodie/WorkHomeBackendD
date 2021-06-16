using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorkHomeBackend.Common.Responses;
using WorkHomeBackend.Data.Context;
using WorkHomeBackend.Data.Repository.Interfaces;
using WorkHomeBackend.Services.Services.Interfaces;

namespace WorkHomeBackend.Services.Services
{
    public class RoutineService : IRoutineService
    {
        private readonly IGenericRepository _genericRepository;
        public RoutineService (IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }


        public async Task<Response<Routine>> Create(Routine entity)
        {
            Routine exists = await _genericRepository.GetByAsync<Routine>(r => r.Name == entity.Name);

            if (exists != null)
            {
                return new Response<Routine>
                {
                    Success = false,
                    Message = "Ya hay un registro con este ID."
                };
            }

            Routine save = await _genericRepository.CreateAsync<Routine>(entity);

            return new Response<Routine>
            {
                Success = true,
                Message = "Se ha creado el registro correctamente."
            };
        }

        public Task<Response<bool>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<Routine>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Response<Routine>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> Update(Routine entity)
        {
            throw new NotImplementedException();
        }
    }
}
