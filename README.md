# TestNinja
Test project following Unit Testing for C# Developers Course at [CodeWithMosh.com](https://codewithmosh.com/)


#### Notes on created Unit Tests project by adding a Unit Test project
When choosing a project type in Visual Studio I did not choose the Nunit (.Net Core) or any of the .net core options, just a plain .Net Unit Test project. This may seem counterintuitive but it
worked better to go for plain old .Net Framework first. I also made sure the new project targeted the same framework as the TestNinja project (4.5). Once I had created my Unit Test project, I added the Nunit packages from Nuget as in the codewithmosh video. Everything worked pretty well after that - just remember to add a reference to the original project and get the namespace using directives corrected, just as in Mosh's instructions in the course.
