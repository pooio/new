using MyTest311.Entities;
using System.Collections.Generic;
using MyTest311.Services.Interfaces;
using MyTest311.Web.Models;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;

/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Web.Controllers
{
	public class ClassAController:CommonController<ClassA, IClassAService, ClassAModel>
	{


		protected override void LoadViewReferenceData(ClassAModel model)
		{
			if (model == null) return;
			base.LoadViewReferenceData(model);

			IClassBService classBService = ServiceFactory.Instance.GetService<IClassBService>();
			model.ClassBs = classBService.SelectAll();

			model.AETypes = this.GetEnumValues(typeof(AEType));

		}

		protected override int DoInsert(ClassA entity)
	    {
            return this.Service.Insert(entity, true);
	    }

	    protected override int DoUpdate(ClassA entity)
	    {
            return this.Service.Update(entity, true);
	    }

	    protected override int DoDelete(ClassA entity)
	    {
            return this.Service.Delete(entity, true);
	    }

		protected override ClassA GetEntity(int id)
        {
            return this.Service.SelectById(new ClassA { Id = id }, true);
        }

		protected override List<ClassA> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<ClassA> lists = this.Service.SelectBy(pagerSearchModel.Pager,new ClassA { Name = pagerSearchModel.Name }, classA => classA.Name.Contains(pagerSearchModel.Name));
        return this.Service.SelectAllWithReferenceData(lists);
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
