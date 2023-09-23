using Microsoft.Data.SqlClient;
using System.Reflection;
using System.Data;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace MovieApp.Models   
{
    public class MovieRepository
    {
        public static List<MovieModel> GetMovies()
        {
            List<MovieModel> movieList = new List<MovieModel>();
            using (SqlConnection conn = SqlHelper.CreateConnection()) 
            {
                if(conn.State != System.Data.ConnectionState.Open) { conn.Open(); }

                SqlCommand cmd = conn.CreateCommand();
                string SelectAllMovie = "SELECT * FROM Movie";
                cmd.CommandText = SelectAllMovie;
                SqlDataReader mdr = cmd.ExecuteReader();
                while(mdr.Read())
                {
                    MovieModel movie = new MovieModel
                    {
                        MID = mdr.GetInt32(0),
                        Title = mdr.GetString(1),
                        MLanguage = mdr.GetString(2),
                        Hero = mdr.GetString(3),
                        Director = mdr.GetString(4),
                        MusicDirector = mdr.GetString(5),
                        ReleaseDate = mdr.GetDateTime(6),
                        Cost = mdr.GetDecimal(7),
                        MCollection =mdr.GetInt32(8),
                    };
                    movieList.Add(movie);
                }
            }
            return movieList;
        }
        public static MovieModel GetMovieById(int id) 
        {
            MovieModel movie = null; 
            using(SqlConnection conn = SqlHelper.CreateConnection()) 
            {
                if(conn.State != System.Data.ConnectionState.Open) { conn.Open();}
                SqlCommand cmd = conn.CreateCommand();
                String SelectMovie = "Select * from Movie where Mid=@id";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value=id;
                cmd.CommandText = SelectMovie;
                SqlDataReader mdr = cmd.ExecuteReader();
                while(mdr.Read())
                {
                    movie = new MovieModel
                    {
                        MID = mdr.GetInt32(0),
                        Title = mdr.GetString(1),
                        MLanguage = mdr.GetString(2),
                        Hero = mdr.GetString(3),
                        Director = mdr.GetString(4),
                        MusicDirector = mdr.GetString(5),
                        ReleaseDate = mdr.GetDateTime(6),
                        Cost = mdr.GetDecimal(7),
                        MCollection = mdr.GetInt32(8),
                    };
                }
            }return movie;
        }
        public static int AddMovie(MovieModel movie) 
        {
            int q_res = 0; 
            using (SqlConnection conn = SqlHelper.CreateConnection())
            {
                if(conn.State != ConnectionState.Open) { conn.Open();}
                SqlCommand cmd = conn.CreateCommand();
                string insertMovie = "insert into Movie value(@mid, @Title, @Mlanguage, @Hero, @Director, @MusicDirector, @ReleaseDate, @Cost, @Mcollection)";
                cmd.Parameters.Add("@mid", SqlDbType.Int).Value=movie.MID;
                cmd.Parameters.Add("@Title",SqlDbType.NVarChar).Value=movie.Title;
                cmd.Parameters.Add("@Mlanguage",SqlDbType.NVarChar).Value= movie.MLanguage;
                cmd.Parameters.Add("@Hero",SqlDbType.NVarChar).Value = movie.Hero;
                cmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = movie.Director;
                cmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = movie.MusicDirector;
                cmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = movie.ReleaseDate;
                cmd.Parameters.Add("@Cost", SqlDbType.Int).Value = movie.Cost;
                cmd.Parameters.Add("@Mcollection", SqlDbType.Int).Value = movie.MCollection;
                cmd.CommandText = insertMovie;
                q_res = cmd.ExecuteNonQuery();
            }
            return q_res;
        }
        public static int UpdateMovie(MovieModel movie)
        {
            int q_res = 0; 
            using (SqlConnection conn = SqlHelper.CreateConnection())
            {
                if(conn.State != ConnectionState.Open) { conn.Open(); }
                SqlCommand cmd = conn.CreateCommand();
                string insertMovie=  @"Update Movie set MID = @mid,Title= @Title,MLanguage=@Mlanguage,Hero= @Hero,Director= @Director,MusicDirector= @MusicDirector,ReleaseDate=@ReleaseDate,Cost=@Cost,MCollection=@Mcollection ";
                cmd.Parameters.Add("@mid", SqlDbType.Int).Value = movie.MID;
                cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = movie.Title;
                cmd.Parameters.Add("@Mlanguage", SqlDbType.NVarChar).Value = movie.MLanguage;
                cmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = movie.Hero;
                cmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = movie.Director;
                cmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = movie.MusicDirector;
                cmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = movie.ReleaseDate;
                cmd.Parameters.Add("@Cost", SqlDbType.Int).Value = movie.Cost;
                cmd.Parameters.Add("@Mcollection", SqlDbType.Int).Value = movie.MCollection;
                cmd.CommandText = insertMovie;
                q_res = cmd.ExecuteNonQuery();
            }
            return q_res;
        }
        public static void DeleteMovie(int id) 
        {

        }
    }
}
