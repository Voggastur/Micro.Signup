# React Signup Page - A full stack .NET application


This is Johans demo application using a sqlite server with .Net webapi and react frontend to make a signup page.

## A. To setup the app

## C. Tools and setup

Use the database from the earlier labs - we have copied the Dockerfile into this repository.

## D. Lab instructions

- Create a new application using `dotnet new react -n ReactIMDB`

- Start with a simple model `Movie.cs` that only hold Title (string), ReleaseDate (DateTime), ImageUrl (string) and Genre (string).
- Create an API using the [scaffolding tools](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio-code)
- Create a UI to list, add, delete and update Movies with the data

- Once you are done select one or more of the following tasks
  - Create a search
  - Make the front-page look stylish
  - Change the `Genre` field to a model class. A Movie has one Genre, A Genre has many Movies
    - Make an API endpoint for all Movies of a certain Genre
    - Make an API endpoint for all Genres
    - Create a dropdown box that let's you filter all movies by genre on the list-all-movies-page
  - Add an `Actor` model class, with Name, PhotoUrl and BirthYear. An actor has many movies and a movies has many Actors
    - Make an API endpoint for all Movies that an Actor acts in
    - Make an API endpoint for all Actors
    - Make an Actor page that lists all movies for the actor

---

Good luck and have fun!
