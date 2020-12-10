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
	public class ClassBService : Service<ClassB>, IClassBService
	{
		public ClassBService() : base(typeof (IClassBDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
