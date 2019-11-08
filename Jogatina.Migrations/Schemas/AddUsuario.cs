using FluentMigrator;

namespace Genius.Migrations.Schemas
{
    [Migration(2)]
    public class AddUsuario : Migration
    {
        readonly string TableName = "Jogador";    

        public override void Down()
        {
            Delete.Table(TableName);
        }

        public override void Up()
        {
            if (!Schema.Schema("dbo").Table(TableName).Exists())
            {
                Create.Table(TableName)
                .WithColumn("JogadorId").AsGuid().PrimaryKey()
                .WithColumn("Nome").AsString(255)
                .WithColumn("Email").AsString(255)                
                .WithColumn("Senha").AsString(30)                
                .WithColumn("UriFoto").AsInt32()                
                .WithColumn("Telefone").AsString(50);             
            }

            //Create.ForeignKey()
            //      .FromTable(TableName).ForeignColumn("TipoUsuarioId")
            //      .ToTable("TipoUsuario").PrimaryColumn("TipoUsuarioId");            
        }
    }
}