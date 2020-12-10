using System;
using System.ComponentModel;
using System.Runtime.Serialization;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Entities
{
	[Serializable]
	public enum AEType
	{
		[EnumMember]
		[Description("AEType2")]
		AEType2 = 2,

		[EnumMember]
		[Description("AEType1")]
		AEType1 = 1,

		[EnumMember]
		[Description("AEType0")]
		AEType0 = 0,

		/*add customized code between this region*/
		/*add customized code between this region*/
	}
	/*add customized code between this region*/
	/*add customized code between this region*/
}
