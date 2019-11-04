using FluentMigrator;

namespace Genius.Migrations.Schemas
{
    [Migration(1)]
    public class AddTipoUsuario : Migration
    {
        readonly string TableName = "TipoUsuario";    

        public override void Down()
        {
            Delete.Table(TableName);
        }

        public override void Up()
        {
            if (!Schema.Schema("dbo").Table(TableName).Exists())
            {
                Create.Table(TableName)
                .WithColumn("TipoUsuarioId").AsGuid().PrimaryKey()
                .WithColumn("Descricao").AsString(255);
            }            
        }
    }
}