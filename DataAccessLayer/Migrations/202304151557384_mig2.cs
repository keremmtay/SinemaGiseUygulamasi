namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                        TheaterId = c.Int(nullable: false),
                        SeatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerBookings",
                c => new
                    {
                        Customer_Id = c.Int(nullable: false),
                        Booking_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Customer_Id, t.Booking_Id })
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Bookings", t => t.Booking_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Booking_Id);
            
            CreateTable(
                "dbo.MovieBookings",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Booking_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Booking_Id })
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Bookings", t => t.Booking_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Booking_Id);
            
            CreateTable(
                "dbo.TheaterBookings",
                c => new
                    {
                        Theater_Id = c.Int(nullable: false),
                        Booking_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Theater_Id, t.Booking_Id })
                .ForeignKey("dbo.Theaters", t => t.Theater_Id, cascadeDelete: true)
                .ForeignKey("dbo.Bookings", t => t.Booking_Id, cascadeDelete: true)
                .Index(t => t.Theater_Id)
                .Index(t => t.Booking_Id);
            
            CreateTable(
                "dbo.SeatBookings",
                c => new
                    {
                        Seat_Id = c.Int(nullable: false),
                        Booking_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Seat_Id, t.Booking_Id })
                .ForeignKey("dbo.Seats", t => t.Seat_Id, cascadeDelete: true)
                .ForeignKey("dbo.Bookings", t => t.Booking_Id, cascadeDelete: true)
                .Index(t => t.Seat_Id)
                .Index(t => t.Booking_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SeatBookings", "Booking_Id", "dbo.Bookings");
            DropForeignKey("dbo.SeatBookings", "Seat_Id", "dbo.Seats");
            DropForeignKey("dbo.TheaterBookings", "Booking_Id", "dbo.Bookings");
            DropForeignKey("dbo.TheaterBookings", "Theater_Id", "dbo.Theaters");
            DropForeignKey("dbo.MovieBookings", "Booking_Id", "dbo.Bookings");
            DropForeignKey("dbo.MovieBookings", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.CustomerBookings", "Booking_Id", "dbo.Bookings");
            DropForeignKey("dbo.CustomerBookings", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.SeatBookings", new[] { "Booking_Id" });
            DropIndex("dbo.SeatBookings", new[] { "Seat_Id" });
            DropIndex("dbo.TheaterBookings", new[] { "Booking_Id" });
            DropIndex("dbo.TheaterBookings", new[] { "Theater_Id" });
            DropIndex("dbo.MovieBookings", new[] { "Booking_Id" });
            DropIndex("dbo.MovieBookings", new[] { "Movie_Id" });
            DropIndex("dbo.CustomerBookings", new[] { "Booking_Id" });
            DropIndex("dbo.CustomerBookings", new[] { "Customer_Id" });
            DropTable("dbo.SeatBookings");
            DropTable("dbo.TheaterBookings");
            DropTable("dbo.MovieBookings");
            DropTable("dbo.CustomerBookings");
            DropTable("dbo.Bookings");
        }
    }
}
