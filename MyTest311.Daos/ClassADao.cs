using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using MyTest311.Daos.Interfaces;
using MyTest311.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Daos
{
	public class ClassADao : CommonObjectDao<ClassA>, IClassADao
	{
		public class ClassASqlBuilder : ObjectSqlBuilder
		{
			public ClassASqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"ClassA")
			{
				this.SqlInsert = "INSERT INTO ClassA (ClassBName,AEType,ClassBDescription,Description2,ClassBid," + this.SqlBaseFieldInsertFront + ") VALUES (@ClassBName,@AEType,@ClassBDescription,@Description2,@ClassBid," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE ClassA SET ClassBName=@ClassBName,AEType=@AEType,ClassBDescription=@ClassBDescription,Description2=@Description2,ClassBid=@ClassBid," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class ClassAResultHandler : CommonObjectResultHandler<ClassA>
		{
			public override void GetColumnValues(IDataReader reader, ClassA item)
			{
				base.GetColumnValues(reader, item);
				int ordinalAEType = reader.GetOrdinal("AEType");
				item.AEType = (AEType)reader.GetInt32(ordinalAEType);
				int ordinalClassBId = reader.GetOrdinal("ClassBId");
				int ordinalClassBName = reader.GetOrdinal("ClassBName");
				string classBName= reader.IsDBNull(ordinalClassBName) ? null :reader.GetString(ordinalClassBName);
				int ordinalClassBDescription = reader.GetOrdinal("ClassBDescription");
				string classBDescription= reader.IsDBNull(ordinalClassBDescription) ? null:reader.GetString(ordinalClassBDescription);
				item.ClassB = reader.IsDBNull(ordinalClassBId) ? null :reader.GetInt32(ordinalClassBId)==0?null:new ClassB { Id=reader.GetInt32(ordinalClassBId), Name = classBName, Description = classBDescription};
				int ordinalDescription2 = reader.GetOrdinal("Description2");
				item.Description2 = reader.IsDBNull(ordinalDescription2) ? null : reader.GetString(ordinalDescription2);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, ClassA item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "AEType", item.AEType);
				context.AddParameter(command, "ClassBId", item.ClassB ==null? 0:item.ClassB.Id);
                context.AddParameter(command, "ClassBName", item.ClassB ==null?(object)DBNull.Value : string.IsNullOrEmpty(item.ClassB.Name) ? (object)DBNull.Value : item.ClassB.Name);
                context.AddParameter(command, "ClassBDescription", item.ClassB ==null? (object)DBNull.Value : string.IsNullOrEmpty(item.ClassB.Description) ? (object)DBNull.Value : item.ClassB.Description);

				context.AddParameter(command, "Description2", item.Description2 ?? (object) DBNull.Value);
				/*add customized code between this region*/
				int a =1;
				int b = 2;
				int c = a + b;
				/*add customized code between this region*/
			}
		}

		public ClassADao(SqlDialect sqlDialect) : base(new ClassASqlBuilder(sqlDialect), new ClassAResultHandler())
		{
		}

		public ClassADao(SqlDialect sqlDialect, string schemaConnectionString) : base(new ClassASqlBuilder(sqlDialect), new ClassAResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		public ClassADao(string abc)
		{
		
		}
		/*add customized code between this region*/
	}
}
