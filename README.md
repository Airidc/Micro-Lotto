# Micro-Lotto
Micro Lotto web app build with Angular 8 and .Net Core 

# Get it running

The following steps are required for you to run this web app.
* Update `appsettings.json` with your MySql connection string.
* Run `dotnet restore` to install dependencies.
* Run `dotnet ef database update` to init db.
* Then just run the project from Visual studio or build it and run it with `dotnet run`.

# Project status

Unfortunately the project is not in an ideal situation. It's more close to a MVP.

Areas to improve:
* Add validation.
* In real environment should contain more DTOs to not send irrelevant information to client side.
* Add logging.
* Add Swagger for some API documentation.
* Add unit tests.
* Some business logic is not where it should be.
* For larger app I would have considered going repository pattern, but for this scope having Db context in service layer should be sufficient.


# Fun fact
I've spent over 2000€ before getting my first 3 ball win (100€). Hope the odds of you liking this project will be bigger 😅
