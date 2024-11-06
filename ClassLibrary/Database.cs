using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ClassLibrary
{
    public class Database
    {
        private static Database _instance;
        public List<Movie> Movies { get; set; } // List to hold movie objects
        private string connectionString = "Server=localhost;Database=Movie_Database;User ID=root;Password=Q4WG9oU!fqzD!FiW@yVA;"; // MySQL connection string

        // Private constructor to initialize the movie list and load data
        private Database()
        {
            Movies = new List<Movie>();
            LoadMovies();
        }

        // Public static property to access the single instance of the database class
        public static Database Instance
        {
            get
            {
                // Create a new instance only if one doesn't exist yet
                if (_instance == null)
                    _instance = new Database();
                return _instance;
            }
        }

        // Loads all movie data from the database and populates the Movies list.
        private void LoadMovies()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); // Open the database connection
                string query = "SELECT * FROM movies";
                MySqlCommand cmd = new MySqlCommand(query, conn);  // Define the SQL query
                MySqlDataReader reader = cmd.ExecuteReader();  // Execute the query and retrieve the results

                // Process each record in the result set
                while (reader.Read())
                {
                    Movie movie = new Movie(
                        reader["name"].ToString(),
                        reader["release_date"].ToString(),
                        reader["genre"].ToString(),
                        reader["favorite_character"].ToString(),
                        Convert.ToDouble(reader["rating"])
                    );
                    Movies.Add(movie); // Add each movie to the Movies list
                }

                reader.Close();  // Close the reader after reading all data
            }
        }

        public void RefreshMovieList()
        {
            Movies.Clear();  // Clear the existing list
            LoadMovies();    // Reload movies from the database
        }

        //Inserts a new movie into the database with the given details.
        public string InsertMovie(Movie movie)
        {
            try
            {
                // Connect to the database and prepare an SQL INSERT query to add a new movie record.
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO movies (name, release_date, genre, favorite_character, rating) " +
                                   "VALUES (@name, @release_date, @genre, @favorite_character, @rating)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to avoid SQL injection and populate with movie details.
                    cmd.Parameters.AddWithValue("@name", movie.name);
                    cmd.Parameters.AddWithValue("@release_date", movie.relDate);
                    cmd.Parameters.AddWithValue("@genre", movie.genre);
                    cmd.Parameters.AddWithValue("@favorite_character", movie.favChar);
                    cmd.Parameters.AddWithValue("@rating", movie.rating);

                    // Execute the insert operation and return a success message.
                    cmd.ExecuteNonQuery();
                    return $"Movie '{movie.name}' inserted successfully.";
                }
            }
            catch (MySqlException ex)
            {
                // Handle database-related errors by returning an error message.
                return $"Database error: {ex.Message}";
            }
            catch (Exception ex)
            {
                // Handle any other exceptions by returning a generic error message.
                return $"An error occurred: {ex.Message}";
            }
        }

        //Updates the details of an existing movie in the database based on its name.
        public string UpdateMovie(Movie movie)
        {
            try
            {
                // Connect to the database and prepare an SQL UPDATE query to modify an existing movie record.
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE movies SET release_date = @release_date, genre = @genre, " +
                                   "favorite_character = @favorite_character, rating = @rating WHERE name = @name";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to bind movie properties to the query fields for secure updating.
                    cmd.Parameters.AddWithValue("@release_date", movie.relDate);
                    cmd.Parameters.AddWithValue("@genre", movie.genre);
                    cmd.Parameters.AddWithValue("@favorite_character", movie.favChar);
                    cmd.Parameters.AddWithValue("@rating", movie.rating);
                    cmd.Parameters.AddWithValue("@name", movie.name);

                    // Execute the update operation and check if the movie was found and updated.
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return $"Movie '{movie.name}' updated successfully.";
                    else
                        return $"No movie found with the name '{movie.name}'. Update failed.";
                }
            }
            catch (MySqlException ex)
            {
                // Return a specific error message for database issues.
                return $"Database error: {ex.Message}";
            }
            catch (Exception ex)
            {
                // Handle any other exceptions with a generic message.
                return $"An error occurred: {ex.Message}";
            }
        }

        //Searches for movies in the database based on a partial or full name match.
        public string SearchMovies(string name)
        {
            try
            {
                // Connect to the database and prepare a SELECT query to find movies by name.
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM movies WHERE name LIKE @name";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Bind the name parameter to match any movie containing the specified name string.
                    cmd.Parameters.AddWithValue("@name", $"%{name}%");

                    // Execute the query and check if the reader contains results.
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                        return $"Movie '{name}' exists in the Database.";
                    else
                        return $"No movie found with the name '{name}'.";
                }
            }
            catch (MySqlException ex)
            {
                // Handle database-related errors.
                return $"Database error: {ex.Message}";
            }
            catch (Exception ex)
            {
                // Handle general exceptions with a fallback message.
                return $"An error occurred: {ex.Message}";
            }
        }

        //Deletes a movie from the database based on the provided movie name.
        public string DeleteMovie(Movie movie)
        {
            try
            {
                // Connect to the database and prepare an SQL DELETE query to remove a movie record by name.
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM movies WHERE name = @name";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Bind the name parameter to ensure deletion only if the movie matches by name.
                    cmd.Parameters.AddWithValue("@name", movie.name);

                    // Execute the delete operation and check if any rows were affected.
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return $"Movie '{movie.name}' deleted successfully.";
                    else
                        return $"No movie found with the name '{movie.name}'.";
                }
            }
            catch (MySqlException ex)
            {
                // Provide feedback if a database error occurs.
                return $"Database error: {ex.Message}";
            }
            catch (Exception ex)
            {
                // Return a general error message for other exceptions.
                return $"An error occurred: {ex.Message}";
            }
        }
    }
}
