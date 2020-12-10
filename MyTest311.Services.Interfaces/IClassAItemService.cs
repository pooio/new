using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using MyTest311.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Services.Interfaces
{
	public interface IClassAItemService : IPagingService<ClassAItem>
	{
	        List<ClassAItem> SelectClassAItemByClassAs(int[] classAIds, bool isAggregatedChildren = false);
	        List<ClassAItem> SelectClassAItemByClassAs(Pager pager,int[] classAIds, bool isAggregatedChildren = false);
	        List<ClassAItem> SelectByClassA(int pageIndex,int pageSize,int classAId);
	        List<ClassAItem> SelectByClassA(int classAId);
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
