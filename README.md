# 2022 NORAM Academy Project backend

## Visual Studio setup
The project scaffold was initialized with Visual Studio. To accomplish this:
### Create solution & *API* project
1. Launch Visual Studio
2. Click "Create a new project" button
3. Search for **ASP.NET Core Web API** and select
4. Name this project
5. Name the solution (this will include other projects, such as the *Tests* project)
6. Click "next"
7. Select Target Framework ".NET 5.0"
8. Click "create"

### Create & add *Tests* project to solution
With the above solution open in Visual Studio:
1. In the top toolbar, go to: -> "File" -> "Add" -> "New Project..."
2. Search for **NUnit Test Project**
3. Name the project
4. Select same .NET Target Framework as *API* project

### Create dependency from *Tests* project to API project
1. right-click *Tests* project in the solution explorer on the right of the screen
    - "Build Dependencies"
        - "Project Dependencies..."
2. Check the box next to the *API* project
3. Click "OK"

This will add the snippet below into the *Tests.csproj* project file
```
  <ItemGroup>
    <ProjectReference Include="..\ProjectNameAPI\ProjectNameAPI.csproj" />
  </ItemGroup>
```

## Nuget Package Manager
This tool can be utilized within Visual Studio:
- In the top toolbar, go to:
    - "Project"
        - "Manage Nuget Packages..."

The test project will have a few packages installed such as Coverlet, Nunit, and the Microsoft.NET test SDK. We will need to also install Moq, a mocking library, allowing easier testing of complex objects
1. Navigate back to the Nuget Packages
2. Search for *Moq*
3. Install the latest version allowed

This will add the snippet below into the *Tests.csproj* project file
```
<PackageReference Include="Moq" Version="x.x.x" />
```
