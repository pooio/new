using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using MyTest311.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Services.Interfaces
{
	public interface IClassAService : IPagingService<ClassA>
	{
	        List<ClassA> SelectAllWithReferenceData(List<ClassA> items);
	        List<ClassA> SelectClassAByAETypes(int[] aETypes, bool isAggregatedChildren = false);
	        List<ClassA> SelectClassAByAETypes(Pager pager,int[] aETypes, bool isAggregatedChildren = false);
	        List<ClassA> SelectClassAByClassBs(int[] classBIds, bool isAggregatedChildren = false);
	        List<ClassA> SelectClassAByClassBs(Pager pager,int[] classBIds, bool isAggregatedChildren = false);
	        List<ClassA> SelectByAEType(int pageIndex,int pageSize,int aEType);
	        List<ClassA> SelectByAEType(int aEType);
	        List<ClassA> SelectByAETypeClassB(int pageIndex,int pageSize,int aEType,int classBId);
	        List<ClassA> SelectByAETypeClassB(int aEType,int classBId);
	        List<ClassA> SelectByClassB(int pageIndex,int pageSize,int classBId);
	        List<ClassA> SelectByClassB(int classBId);
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
