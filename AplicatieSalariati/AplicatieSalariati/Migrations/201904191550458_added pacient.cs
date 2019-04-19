namespace AplicatieSalariati.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpacient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacients",
                c => new
                    {
                        CNP = c.String(nullable: false, maxLength: 128),
                        Nume = c.String(nullable: false),
                        Prenume = c.String(nullable: false),
                        Email = c.String(),
                        Adresa = c.String(nullable: false),
                        Numartelefon = c.String(),
                    })
                .PrimaryKey(t => t.CNP);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pacients");
        }
    }
}
