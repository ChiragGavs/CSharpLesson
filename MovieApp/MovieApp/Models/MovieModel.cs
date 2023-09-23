using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
 
namespace MovieApp.Models
{
    public class MovieModel
    {
//Create Table Movie(
//MID int Not Null ,
//Title nvarchar(20) Not NULL,
//MLanguage nvarchar(10) Not NULL,
//Hero nvarchar(30) Not NULL,
//Director nvarchar(30) NOT null,
//MusicDirector nvarchar Not null,
//ReleaseDate "datetime" NOT NULL,
//Cost numeric(18,0) Not null,
//MCollection int not null,

        [Key]
        public int MID { get; set; }
        public string Title { get; set;}
        public string MLanguage { get; set;}
        public string Hero { get; set;}
        public string Director { get; set;}
        public string MusicDirector { get; set;}
        public DateTime ReleaseDate { get; set;}
        public decimal Cost { get; set;}
        public int MCollection { get; set;}

    }
}
