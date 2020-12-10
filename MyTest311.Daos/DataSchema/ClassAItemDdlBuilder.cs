using MetaShare.Common.Core.DataSchema;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Daos.DataSchema
{
	public class ClassAItemDdlBuilder : DdlBuilder
	{
		public override string GetSqlCreateTable()
		{
			return @"CREATE TABLE ClassAItem(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,Name nvarchar(255),ClassAId nvarchar(255),Description nvarchar(255),Description nvarchar(255),Owner_Id int,Entity_Status int)";
		}

		public override string GetSqlDropTable()
		{
			return @"DROP TABLE ClassAItem";
		}

		public override string GetSqlExistTable()
		{
			return @"SELECT COUNT(*) FROM Information_Schema.COLUMNS WHERE TABLE_NAME = 'ClassAItem'";
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
