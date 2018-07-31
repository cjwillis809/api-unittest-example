# .NET Core Api Unit Test Example
## Installation
To run the unit tests:
```
dotnet restore
cd RandomServiceTests
dotnet test
```
The tests can also be ran in the root directory but it will build both the main and test projects, which is unnecessary.

## Helpful Links
- [.NET Core Unit Testing with xUnit](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test)
- [Testing API controllers](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing?view=aspnetcore-2.1)

## Adding Tests from Scratch
1. Create a new directory to house the testing project
2. Change directory to the testing directory and run dotnet new xunit to create a new xUnit project template
    a. Run dotnet restore in the testing directory to make sure dependencies are confirmed. Do this whenever you add dependencies to any csproj file
3. Add tests in the project folder
4. Run dotnet test inside the test directory to run the tests

## Notes, Findings & Best Practices
- It is best to have the base and test project in separate project directories. I initially had trouble with using unit tests in an existing project because of duplicate files and the system thinking there were two Main() methods when I ran dotnet new xunit. Separating out as in the example repo is the best way to do it.
- In the xUnit link, it talks about adding the projects to a solution file. I’m not sure if the solution file is necessary to test the APIs, but I followed the tutorial so I wouldn’t miss anything. We could probably safely omit the solution file if we are not using Visual Studio, though there also may be benefits to having the solution file in case we need to use Visual Studio for something.
- I had to mirror a dependency in the test’s csproj file because the test file would not recognize the `controller.Get()` call due to it not recognizing the ActionResult type from the controller.
- It’s good practice to define the controller in the constructor if you are going to be using the controller a lot in the tests.
- I have not used Moq yet, but it seems like it would come in handy.
