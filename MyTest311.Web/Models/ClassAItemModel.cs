using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyTest311.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Web.Models
{
	public class ClassAItemModel: CommonModel<ClassAItem>
	{
		public ClassA ClassA {get; set;}

		public override void PopulateFrom(ClassAItem entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.ClassA = entity.ClassA;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(ClassAItem entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.ClassA = this.ClassA;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
