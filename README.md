# React Signup Page - A full stack .NET application


This is my demo application built in one day in Salts full stack bootcamp.
It uses a sqlite server with .Net webapi backend and react frontend to make a signup page.

The frontend contains three components, a sign in page, a sign up page, and a home page where you will land after successful signup/signin.

Signup creates users in the docker sql server which can be played around with via tools such as Sequel Pro or Azure data studio.

## A. To setup the app after cloning

First open a terminal

from root of this repo run this to start sqlserver in docker:
$ docker-compose up -d

then run from inside /userapi
$ dotnet restore
$ dotnet run

Open new terminal and run this from inside /signupdemo
$ npm i
$ npm start
From this terminal pick up the localhost:3000 adress of the frontend application to test it.

## C. Tools and setup
* EntityFrameworkCore
* .NET
* React Typescript

Good luck!
