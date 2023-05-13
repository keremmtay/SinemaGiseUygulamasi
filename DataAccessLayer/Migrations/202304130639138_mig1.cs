namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Films", newName: "Movies");
            RenameTable(name: "dbo.Musteris", newName: "Customers");
            RenameTable(name: "dbo.Koltuks", newName: "Seats");
            RenameTable(name: "dbo.Salons", newName: "Theaters");
            RenameTable(name: "dbo.Personels", newName: "Employees");
            RenameTable(name: "dbo.Turs", newName: "Genres");
            RenameTable(name: "dbo.MusteriFilms", newName: "MovieCustomers");
            RenameTable(name: "dbo.SalonFilms", newName: "TheaterMovies");
            RenameTable(name: "dbo.SalonKoltuks", newName: "SeatTheaters");
            RenameColumn(table: "dbo.MovieCustomers", name: "Musteri_Id", newName: "Customer_Id");
            RenameColumn(table: "dbo.MovieCustomers", name: "Film_Id", newName: "Movie_Id");
            RenameColumn(table: "dbo.TheaterMovies", name: "Salon_Id", newName: "Theater_Id");
            RenameColumn(table: "dbo.TheaterMovies", name: "Film_Id", newName: "Movie_Id");
            RenameColumn(table: "dbo.SeatTheaters", name: "Salon_Id", newName: "Theater_Id");
            RenameColumn(table: "dbo.SeatTheaters", name: "Koltuk_Id", newName: "Seat_Id");
            RenameIndex(table: "dbo.MovieCustomers", name: "IX_Film_Id", newName: "IX_Movie_Id");
            RenameIndex(table: "dbo.MovieCustomers", name: "IX_Musteri_Id", newName: "IX_Customer_Id");
            RenameIndex(table: "dbo.TheaterMovies", name: "IX_Salon_Id", newName: "IX_Theater_Id");
            RenameIndex(table: "dbo.TheaterMovies", name: "IX_Film_Id", newName: "IX_Movie_Id");
            RenameIndex(table: "dbo.SeatTheaters", name: "IX_Koltuk_Id", newName: "IX_Seat_Id");
            RenameIndex(table: "dbo.SeatTheaters", name: "IX_Salon_Id", newName: "IX_Theater_Id");
            DropPrimaryKey("dbo.MovieCustomers");
            DropPrimaryKey("dbo.SeatTheaters");
            AddPrimaryKey("dbo.MovieCustomers", new[] { "Movie_Id", "Customer_Id" });
            AddPrimaryKey("dbo.SeatTheaters", new[] { "Seat_Id", "Theater_Id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SeatTheaters");
            DropPrimaryKey("dbo.MovieCustomers");
            AddPrimaryKey("dbo.SeatTheaters", new[] { "Salon_Id", "Koltuk_Id" });
            AddPrimaryKey("dbo.MovieCustomers", new[] { "Musteri_Id", "Film_Id" });
            RenameIndex(table: "dbo.SeatTheaters", name: "IX_Theater_Id", newName: "IX_Salon_Id");
            RenameIndex(table: "dbo.SeatTheaters", name: "IX_Seat_Id", newName: "IX_Koltuk_Id");
            RenameIndex(table: "dbo.TheaterMovies", name: "IX_Movie_Id", newName: "IX_Film_Id");
            RenameIndex(table: "dbo.TheaterMovies", name: "IX_Theater_Id", newName: "IX_Salon_Id");
            RenameIndex(table: "dbo.MovieCustomers", name: "IX_Customer_Id", newName: "IX_Musteri_Id");
            RenameIndex(table: "dbo.MovieCustomers", name: "IX_Movie_Id", newName: "IX_Film_Id");
            RenameColumn(table: "dbo.SeatTheaters", name: "Seat_Id", newName: "Koltuk_Id");
            RenameColumn(table: "dbo.SeatTheaters", name: "Theater_Id", newName: "Salon_Id");
            RenameColumn(table: "dbo.TheaterMovies", name: "Movie_Id", newName: "Film_Id");
            RenameColumn(table: "dbo.TheaterMovies", name: "Theater_Id", newName: "Salon_Id");
            RenameColumn(table: "dbo.MovieCustomers", name: "Movie_Id", newName: "Film_Id");
            RenameColumn(table: "dbo.MovieCustomers", name: "Customer_Id", newName: "Musteri_Id");
            RenameTable(name: "dbo.SeatTheaters", newName: "SalonKoltuks");
            RenameTable(name: "dbo.TheaterMovies", newName: "SalonFilms");
            RenameTable(name: "dbo.MovieCustomers", newName: "MusteriFilms");
            RenameTable(name: "dbo.Genres", newName: "Turs");
            RenameTable(name: "dbo.Employees", newName: "Personels");
            RenameTable(name: "dbo.Theaters", newName: "Salons");
            RenameTable(name: "dbo.Seats", newName: "Koltuks");
            RenameTable(name: "dbo.Customers", newName: "Musteris");
            RenameTable(name: "dbo.Movies", newName: "Films");
        }
    }
}
