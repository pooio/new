using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using MyTest311.Daos.Interfaces;
using MyTest311.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Daos
{
	public class ClassAItemDao : CommonObjectDao<ClassAItem>, IClassAItemDao
	{
		public class ClassAItemSqlBuilder : ObjectSqlBuilder
		{
			public ClassAItemSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"ClassAItem")
			{
				this.SqlInsert = "INSERT INTO ClassAItem (ClassAid," + this.SqlBaseFieldInsertFront + ") VALUES (@ClassAid," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE ClassAItem SET ClassAid=@ClassAid," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class ClassAItemResultHandler : CommonObjectResultHandler<ClassAItem>
		{
			public override void GetColumnValues(IDataReader reader, ClassAItem item)
			{
				base.GetColumnValues(reader, item);
				int ordinalClassAId = reader.GetOrdinal("ClassAId");
				item.ClassA = reader.IsDBNull(ordinalClassAId) ? null :reader.GetInt32(ordinalClassAId)==0?null:new ClassA { Id=reader.GetInt32(ordinalClassAId)};
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, ClassAItem item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "ClassAId", item.ClassA ==null? 0:item.ClassA.Id);

				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public ClassAItemDao(SqlDialect sqlDialect) : base(new ClassAItemSqlBuilder(sqlDialect), new ClassAItemResultHandler())
		{
		}

		public ClassAItemDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new ClassAItemSqlBuilder(sqlDialect), new ClassAItemResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
