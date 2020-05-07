﻿namespace Storly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberShipData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MemberShips (Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(1,0,0,0)");
            Sql("Insert Into MemberShips (Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(2,30,1,10)");
            Sql("Insert Into MemberShips (Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(3,90,3,15)");
            Sql("Insert Into MemberShips (Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(4,300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
