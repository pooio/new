using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyTest311.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Web.Models
{
	public class ClassAModel: CommonModel<ClassA>
	{
		public List<ClassAItem> ClassAItem {get; set;}
		public AEType AEType {get; set;}
		public List<SelectListItem> AETypes { get; set; }
		public ClassB ClassB {get; set;}
		public List<ClassB> ClassBs { get; set; }
		public string Description2 {get; set;}

		public override void PopulateFrom(ClassA entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.ClassAItem = entity.ClassAItem;
			this.AEType = entity.AEType;
			this.ClassB = entity.ClassB;
			this.Description2 = entity.Description2;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(ClassA entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.ClassAItem = this.ClassAItem;

			entity.AEType = this.AEType;

			entity.ClassB = this.ClassB;
			if (this.ClassBs != null && this.ClassBs.Count > 0)
		    {
		        entity.ClassB = this.ClassBs.Find(p => entity.ClassB != null && entity.ClassB.Id == p.Id);
            }
			entity.Description2 = this.Description2;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
