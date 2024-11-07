# Movie Database

A Windows Forms-based application built using C# to manage a movie database. Users can add, edit, remove, search, display, and sort movie details. The application uses MySQL for database management and follows object-oriented programming principles.

## Features

### 1. Add Movies
- Allows users to insert new movie records into the database.
- Users input the movie's name, release date, genre, favorite character, and rating.
- The application will validate input, especially the rating (must be between 0 and 10).
- After entering the data, the movie is added to the database, and the list is refreshed.

### 2. Edit Movies
- Allows users to update details of an existing movie.
- Users can change the movie's name, release date, genre, favourite character, and rating.
- The application validates the input, especially ensuring the rating is within the range.
- Once edited, the updated movie is saved back to the database.

### 3. Remove Movies
- Allows users to remove a movie from the database.
- The user provides the movie name; if the movie is found, it is deleted from the database.
- The movie list is then refreshed to reflect the removal.

### 4. Search Movies
- Allows users to search for movies by name.
- The application uses a "LIKE" query to find movies that match or partially match the name entered by the user.
- If a match is found, the movie details are displayed; otherwise, a "Movie not found" message is shown.

### 5. Display Movies
- Displays a list of all movies in the database.
- Users can view the list sorted either by movie name or by rating.
- This feature allows for easy navigation and viewing of movie records in an ordered format.

## Technologies Used
- **C#** for application logic and UI (Windows Forms).
- **MySQL** for database management.
- **Object-Oriented Programming (OOP)** principles to structure the code and maintain the application.

## Setup Instructions

### Prerequisites
1. **Install Visual Studio** for building and running the C# application.
2. **Install MySQL** for managing the database.
3. **Clone the repository** to your local machine:
   ```bash
   git clone https://github.com/Danial-Changez/Movie-Database.git

## Database Configuration

1. Create a MySQL database `Movie_Database` if you haven't already.
2. Ensure the `movies` table is set up with the following fields:

   - `name` (TEXT)
   - `release_date` (DATE)
   - `genre` (TEXT)
   - `favorite_character` (TEXT)
   - `rating` (REAL)

   Example SQL:

   ```sql
   CREATE TABLE movies (
       name TEXT(255) PRIMARY KEY,
       release_date TEXT,   -- DATE could also be used, the result should be the same
       genre TEXT(100),
       favorite_character TEXT(100),
       rating REAL
   );

## Running the Application

1. Open the project in Visual Studio.
2. Ensure your database connection string is correctly set in the `Database` class (inside `connectionString`).
3. Build and run the project.

## Usage

1. After launching the application, use the buttons to add, edit, remove, or search for movies.
2. The list of movies will be displayed, and you can sort them by name or rating.
3. The database will automatically be updated whenever a movie is added, edited, or removed.
