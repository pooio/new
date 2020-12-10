using MetaShare.Common.Core.DataSchema;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Daos.DataSchema
{
	public class ClassADdlBuilder : DdlBuilder
	{
		public override string GetSqlCreateTable()
		{
			return @"CREATE TABLE ClassA(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,,,Name nvarchar(255),ClassBId nvarchar(255),Description nvarchar(255),Description2 ntext,Description nvarchar(255),Owner_Id int,Entity_Status int)";
		}

		public override string GetSqlDropTable()
		{
			return @"DROP TABLE ClassA";
		}

		public override string GetSqlExistTable()
		{
			return @"SELECT COUNT(*) FROM Information_Schema.COLUMNS WHERE TABLE_NAME = 'ClassA'";
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
