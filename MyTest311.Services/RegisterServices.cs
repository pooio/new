using MetaShare.Common.Core.CommonService;
using MyTest311.Services.Interfaces;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}

		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(IClassBService), new ClassBService(), isRegister);
			factory.Register(typeof(IClassAItemService), new ClassAItemService(), isRegister);
			factory.Register(typeof(IClassAService), new ClassAService(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
