using FluentMigrator;
using System;

namespace MovieDB.Migrations.DefaultDB
{
    [Migration(20201123083300)]
    public class DefaultDB_20201123_083300_MovieKind : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Movie").InSchema("mov")
                .AddColumn("Kind").AsInt32().NotNullable()
                    .WithDefaultValue(1);
        }
    }
}