using BaroPortal.Business.Abstract;
using BaroPortal.Core.Entities;
using BaroPortal.Core.Result;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Advertisement;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Concrete
{
    public class AdvTypeService : IAdvTypeService
    {
        IAdvTypeDal _typeDal;
        IConfiguration _configuration;
        public AdvTypeService(IAdvTypeDal typeDal,
        IConfiguration configuration)
        {
            _typeDal = typeDal;
            _configuration = configuration; 

        }
        public ListResultDto<AdvTypeDto> ShowList()
        {
            ListResultDto<AdvTypeDto> response = new ListResultDto<AdvTypeDto>();   
            var result = _typeDal.GetDetail();
            var data = new List<AdvTypeDto>();
            foreach (var item in result)
            {
                AdvTypeDto dto = new AdvTypeDto();

                dto.TypeId = item.TypeId;
                dto.Name = item.Name;


                data.Add(dto);

                
            }
            response.Data = data;
            

            if (response.Data  is not null)
            {
                response.HasError = false;
                response.Message = "Liste görüntülendi";
                return response;
            }
            else
            {
                response.HasError = true;
                response.Message = "Liste görüntülenmedi";
                return response;
            }
        }
    }
}
