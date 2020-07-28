namespace OnlineParkingManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminUser : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO USERS (Firstname, Lastname, Gender, Email, Mobileno, Password) VALUES ('Admin','Admin','MFO','admin@domain.com','1234567890','Admin')");
        }
        
        public override void Down()
        {
        }
    }
}
