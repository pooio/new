using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyTest311.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Web.Models
{
	public class ClassBModel: CommonModel<ClassB>
	{

		public override void PopulateFrom(ClassB entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(ClassB entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
