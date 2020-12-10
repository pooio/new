using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using MyTest311.Daos.Interfaces;
using MyTest311.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Daos
{
	public class ClassBDao : CommonObjectDao<ClassB>, IClassBDao
	{
		public class ClassBSqlBuilder : ObjectSqlBuilder
		{
			public ClassBSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"ClassB")
			{
				this.SqlInsert = "INSERT INTO ClassB (" + this.SqlBaseFieldInsertFront + ") VALUES (" + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE ClassB SET " + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class ClassBResultHandler : CommonObjectResultHandler<ClassB>
		{
			public override void GetColumnValues(IDataReader reader, ClassB item)
			{
				base.GetColumnValues(reader, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, ClassB item)
			{
				base.AddInsertParameters(context, command, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public ClassBDao(SqlDialect sqlDialect) : base(new ClassBSqlBuilder(sqlDialect), new ClassBResultHandler())
		{
		}

		public ClassBDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new ClassBSqlBuilder(sqlDialect), new ClassBResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
