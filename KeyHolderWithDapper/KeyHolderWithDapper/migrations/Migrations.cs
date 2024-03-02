using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyHolderWithDapper.migrations
{
    [Migration(1)]
    public class Migrations : Migration
    {
        public override void Up()
        {
            Create.Table("Key")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Description").AsString(255).NotNullable()
                .WithColumn("CreatedAt").AsDateTime().NotNullable().WithDefaultValue(DateTime.Now);
            
            Create.Table("Holder")
               .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
               .WithColumn("Name").AsString(255).NotNullable()
               .WithColumn("CreatedAt").AsDateTime().NotNullable().WithDefaultValue(DateTime.Now);

            Create.Table("KeyHolder")
               .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
               .WithColumn("StartDate").AsDateTime().NotNullable().WithDefaultValue(DateTime.Now)
               .WithColumn("EndDate").AsDateTime().NotNullable().WithDefaultValue(DateTime.Now);
            
            Create.ForeignKey()
               .FromTable("KeyHolder").ForeignColumn("KeyId")
               .ToTable("Key").PrimaryColumn("Id");
            Create.ForeignKey().
                FromTable("KeyHolder").ForeignColumn("HolderId")
               .ToTable("Holder").PrimaryColumn("Id");
        }

        public override void Down()
        {
            Delete.Table("KeyHolder");
            Delete.Table("Key");
            Delete.Table("Holder");
        }
    }
}
