using FluentMigrator;

namespace Genius.Migrations.Schemas
{
    [Migration(2)]
    public class AddUsuario : Migration
    {
        readonly string TableName = "Usuarios";    

        public override void Down()
        {
            Delete.Table(TableName);
        }

        public override void Up()
        {
            if (!Schema.Schema("dbo").Table(TableName).Exists())
            {
                Create.Table(TableName)
                .WithColumn("UsuarioId").AsGuid().PrimaryKey()
                .WithColumn("Nome").AsString(255)
                .WithColumn("TipoUsuarioId").AsGuid()
                .WithColumn("Email").AsString(255)                
                .WithColumn("Senha").AsString(30)                
                .WithColumn("Status").AsInt32()                
                .WithColumn("Telefone").AsString(50);             
            }

            Create.ForeignKey()
                  .FromTable(TableName).ForeignColumn("TipoUsuarioId")
                  .ToTable("TipoUsuario").PrimaryColumn("TipoUsuarioId");            
        }
    }
}