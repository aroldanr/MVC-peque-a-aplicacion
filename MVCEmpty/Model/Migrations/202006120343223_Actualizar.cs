namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Actualizar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tbl_Persona_Cuentas",
                c => new
                    {
                        IdPersona = c.Guid(nullable: false),
                        IdCuenta = c.Guid(nullable: false),
                        TipodeCuenta = c.Guid(),
                        NumerodeCuenta = c.Int(nullable: false),
                        Tbl_Tipo_cuenta_IdTipoCuenta = c.Guid(),
                    })
                .PrimaryKey(t => new { t.IdPersona, t.IdCuenta })
                .ForeignKey("dbo.Tbl_Persona", t => t.IdPersona, cascadeDelete: true)
                .ForeignKey("dbo.Tbl_Tipo_cuenta", t => t.Tbl_Tipo_cuenta_IdTipoCuenta)
                .Index(t => t.IdPersona)
                .Index(t => t.Tbl_Tipo_cuenta_IdTipoCuenta);
            
            CreateTable(
                "dbo.Tbl_Persona",
                c => new
                    {
                        IdPersona = c.Guid(nullable: false),
                        PrimerNombre = c.String(nullable: false, maxLength: 50),
                        SegundoNombre = c.String(maxLength: 50),
                        PrimerApellido = c.String(nullable: false, maxLength: 50),
                        SegundoApellido = c.String(maxLength: 50),
                        PersonaStatus = c.Int(),
                    })
                .PrimaryKey(t => t.IdPersona);
            
            CreateTable(
                "dbo.Tbl_Usuario",
                c => new
                    {
                        IdUsuario = c.Guid(nullable: false),
                        UserLoging = c.String(nullable: false, maxLength: 20),
                        Contraseña = c.String(nullable: false, maxLength: 50),
                        UsuarioStatus = c.Int(),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .ForeignKey("dbo.Tbl_Persona", t => t.IdUsuario)
                .Index(t => t.IdUsuario);
            
            CreateTable(
                "dbo.Tbl_Tipo_cuenta",
                c => new
                    {
                        IdTipoCuenta = c.Guid(nullable: false),
                        NombreCuenta = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.IdTipoCuenta);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tbl_Persona_Cuentas", "Tbl_Tipo_cuenta_IdTipoCuenta", "dbo.Tbl_Tipo_cuenta");
            DropForeignKey("dbo.Tbl_Usuario", "IdUsuario", "dbo.Tbl_Persona");
            DropForeignKey("dbo.Tbl_Persona_Cuentas", "IdPersona", "dbo.Tbl_Persona");
            DropIndex("dbo.Tbl_Usuario", new[] { "IdUsuario" });
            DropIndex("dbo.Tbl_Persona_Cuentas", new[] { "Tbl_Tipo_cuenta_IdTipoCuenta" });
            DropIndex("dbo.Tbl_Persona_Cuentas", new[] { "IdPersona" });
            DropTable("dbo.Tbl_Tipo_cuenta");
            DropTable("dbo.Tbl_Usuario");
            DropTable("dbo.Tbl_Persona");
            DropTable("dbo.Tbl_Persona_Cuentas");
        }
    }
}
