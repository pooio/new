using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyTest311.Entities;
using MyTest311.Services.Interfaces;
using MyTest311.WebApi.Models;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.WebApi.Controllers
{
	[Route("/ClassAItemApi")]
	public class ClassAItemApiController : CommonApiController<ClassAItem, IClassAItemService>
	{


		[Route("SelectClassAItemByClassAs")]
		[HttpPost]
		public RequestResult SelectClassAItemByClassAs(int[] classAIds, bool isAggregatedChildren)
        {        
            try        
            {
                List<ClassAItem> entities = this.Service.SelectClassAItemByClassAs(classAIds,isAggregatedChildren);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch (Exception)
            {
                return new RequestResult { IsSucceed = false, Message = SelectFailed, Data = null };
            }
        }


		[Route("SelectWithPageByClassA")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByClassA(int pageIndex,int pageSize,int classAId)
        {
            try
            {
                List<ClassAItem> entities = this.Service.SelectByClassA(pageIndex,pageSize,classAId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByClassA")]
		[HttpGet]
		public virtual RequestResult SelectByClassA(int classAId)
         {
            try
            {
                List<ClassAItem> entities = this.Service.SelectByClassA(classAId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
