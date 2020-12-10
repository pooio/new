using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MyTest311.Entities;
using MetaShare.Common.Core.Services;
using MyTest311.Daos.Interfaces;
using MyTest311.Services.Interfaces;

/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Services
{
	public class ClassAItemService : Service<ClassAItem>, IClassAItemService
	{
		public ClassAItemService() : base(typeof (IClassAItemDao))
		{
		}

		public List<ClassAItem> SelectClassAItemByClassAs(int[] classAIds, bool isAggregatedChildren = false)
        {
            List<ClassAItem> items = this.SelectByColumnIds("ClassAId",classAIds,isAggregatedChildren);
            return items;
        }
		public List<ClassAItem> SelectClassAItemByClassAs(Pager pager, int[] classAIds, bool isAggregatedChildren = false)
        {
            List<ClassAItem> items = this.SelectByColumnIds(pager,"ClassAId",classAIds,isAggregatedChildren);
            return items;
        }
		public List<ClassAItem> SelectByClassA(int pageIndex,int pageSize,int classAId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<ClassAItem> items = this.SelectBy(pager,new ClassAItem { ClassA = new MyTest311.Entities.ClassA{ Id = classAId } },new List<string> { "ClassAId" });
            return items;
        }
		public List<ClassAItem> SelectByClassA(int classAId)
        {
            List<ClassAItem> items = this.SelectBy(new ClassAItem { ClassA = new MyTest311.Entities.ClassA{ Id = classAId } },new List<string> { "ClassAId" });
            return items;
        }/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
