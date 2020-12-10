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
	public class ClassAItemController:CommonController<ClassAItem, IClassAItemService, ClassAItemModel>
	{


		protected override List<ClassAItem> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<ClassAItem> lists = this.Service.SelectBy(pagerSearchModel.Pager,new ClassAItem { Name = pagerSearchModel.Name }, classAItem => classAItem.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
