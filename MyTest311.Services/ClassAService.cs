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
	public class ClassAService : Service<ClassA>, IClassAService
	{
		public ClassAService() : base(typeof (IClassADao))
		{
			ServiceAggregationInfo classAItemServiceAggregation = this.ServiceAggregationInfo.AddCompositeCollectionChild("ClassAItem", typeof(MyTest311.Entities.ClassAItem), typeof(MyTest311.Daos.Interfaces.IClassAItemDao), "ClassA");
			ServiceAggregationInfo classBServiceAggregationInfo =  this.ServiceAggregationInfo.AddReferenceChild("ClassB", typeof(MyTest311.Entities.ClassB), typeof(MyTest311.Daos.Interfaces.IClassBDao));
		}

		public List<ClassA> SelectAllWithReferenceData(List<ClassA> items)
        {
            if (items != null && items.Count > 0)
            {
                return this.SelectBy(items, this.CreateReferenceInfoAggregation());
            }
            return items;
        }

        private ServiceAggregationInfo CreateReferenceInfoAggregation()
        {
            ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(ClassA), typeof(IClassADao));
		    aggregation.AddReferenceChild("ClassB", typeof(MyTest311.Entities.ClassB), typeof(MyTest311.Daos.Interfaces.IClassBDao));

		    return aggregation;
        }

		public List<ClassA> SelectClassAByAETypes(int[] aETypes, bool isAggregatedChildren = false)
        {
            List<ClassA> items = this.SelectByColumnIds("AEType",aETypes,isAggregatedChildren);
            return items;
        }
		public List<ClassA> SelectClassAByAETypes(Pager pager, int[] aETypes, bool isAggregatedChildren = false)
        {
            List<ClassA> items = this.SelectByColumnIds(pager,"AEType",aETypes,isAggregatedChildren);
            return items;
        }
		public List<ClassA> SelectClassAByClassBs(int[] classBIds, bool isAggregatedChildren = false)
        {
            List<ClassA> items = this.SelectByColumnIds("ClassBId",classBIds,isAggregatedChildren);
            return items;
        }
		public List<ClassA> SelectClassAByClassBs(Pager pager, int[] classBIds, bool isAggregatedChildren = false)
        {
            List<ClassA> items = this.SelectByColumnIds(pager,"ClassBId",classBIds,isAggregatedChildren);
            return items;
        }
		public List<ClassA> SelectByAEType(int pageIndex,int pageSize,int aEType)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<ClassA> items = this.SelectBy(pager,new ClassA { AEType = (MyTest311.Entities.AEType)aEType },new List<string> { "AEType" });
            return items;
        }
		public List<ClassA> SelectByAEType(int aEType)
        {
            List<ClassA> items = this.SelectBy(new ClassA { AEType = (MyTest311.Entities.AEType)aEType },new List<string> { "AEType" });
            return items;
        }
		public List<ClassA> SelectByAETypeClassB(int pageIndex,int pageSize,int aEType,int classBId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<ClassA> items = this.SelectBy(pager,new ClassA { AEType = (MyTest311.Entities.AEType)aEType,ClassB = new MyTest311.Entities.ClassB{ Id = classBId } },new List<string> { "AEType","ClassBId" });
            return items;
        }
		public List<ClassA> SelectByAETypeClassB(int aEType,int classBId)
        {
            List<ClassA> items = this.SelectBy(new ClassA { AEType = (MyTest311.Entities.AEType)aEType,ClassB = new MyTest311.Entities.ClassB{ Id = classBId } },new List<string> { "AEType","ClassBId" });
            return items;
        }
		public List<ClassA> SelectByClassB(int pageIndex,int pageSize,int classBId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<ClassA> items = this.SelectBy(pager,new ClassA { ClassB = new MyTest311.Entities.ClassB{ Id = classBId } },new List<string> { "ClassBId" });
            return items;
        }
		public List<ClassA> SelectByClassB(int classBId)
        {
            List<ClassA> items = this.SelectBy(new ClassA { ClassB = new MyTest311.Entities.ClassB{ Id = classBId } },new List<string> { "ClassBId" });
            return items;
        }/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
