using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Entities
{
	public class ClassA : MetaShare.Common.Core.Entities.Common
	{
		[DataMember]
		public List<ClassAItem> ClassAItem {get; set;}

		[DataMember]
		public AEType AEType {get; set;}

		[DataMember]
		public ClassB ClassB {get; set;}

		[DataMember]
		public string Description2 {get; set;}

	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
