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
	[Route("/ClassAApi")]
	public class ClassAApiController : CommonApiController<ClassA, IClassAService>
	{


		[Route("SelectClassAByAETypes")]
		[HttpPost]
		public RequestResult SelectClassAByAETypes(int[] aETypes, bool isAggregatedChildren)
        {        
            try        
            {
                List<ClassA> entities = this.Service.SelectClassAByAETypes(aETypes,isAggregatedChildren);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch (Exception)
            {
                return new RequestResult { IsSucceed = false, Message = SelectFailed, Data = null };
            }
        }

		[Route("SelectClassAByClassBs")]
		[HttpPost]
		public RequestResult SelectClassAByClassBs(int[] classBIds, bool isAggregatedChildren)
        {        
            try        
            {
                List<ClassA> entities = this.Service.SelectClassAByClassBs(classBIds,isAggregatedChildren);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch (Exception)
            {
                return new RequestResult { IsSucceed = false, Message = SelectFailed, Data = null };
            }
        }


		[Route("SelectWithPageByAEType")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByAEType(int pageIndex,int pageSize,int aEType)
        {
            try
            {
                List<ClassA> entities = this.Service.SelectByAEType(pageIndex,pageSize,aEType);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByAEType")]
		[HttpGet]
		public virtual RequestResult SelectByAEType(int aEType)
         {
            try
            {
                List<ClassA> entities = this.Service.SelectByAEType(aEType);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectWithPageByAETypeClassB")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByAETypeClassB(int pageIndex,int pageSize,int aEType,int classBId)
        {
            try
            {
                List<ClassA> entities = this.Service.SelectByAETypeClassB(pageIndex,pageSize,aEType,classBId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByAETypeClassB")]
		[HttpGet]
		public virtual RequestResult SelectByAETypeClassB(int aEType,int classBId)
         {
            try
            {
                List<ClassA> entities = this.Service.SelectByAETypeClassB(aEType,classBId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectWithPageByClassB")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByClassB(int pageIndex,int pageSize,int classBId)
        {
            try
            {
                List<ClassA> entities = this.Service.SelectByClassB(pageIndex,pageSize,classBId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByClassB")]
		[HttpGet]
		public virtual RequestResult SelectByClassB(int classBId)
         {
            try
            {
                List<ClassA> entities = this.Service.SelectByClassB(classBId);
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
