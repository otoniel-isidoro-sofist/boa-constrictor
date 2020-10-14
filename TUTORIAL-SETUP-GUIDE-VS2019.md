# Boa Constrictor Tutorial Setup Guide Using Visual Studio 2019

This guide is an in-depth walkthrough of setting up your environment for the Boa Constrictor [quickstart tutorial](TUTORIAL.md) using Visual Studio 2019.

### 1. Create the project
Open *Visual Studio 2019* and select **Create a new project**.

![Create New Project](Images/CreateNewProject.png?raw=true)

### 2. Select the Project Type
Select **NUnit Test Project** as the project type.

![Select Project Type](Images/SelectProjectType.png?raw=true)

### 3. Name the Project
Name the project *Boa.Constrictor.Example*.
Note that the *Location* field is the path to the folder where the project will be created.
You may keep the *Solution name* the default name given.

![Name Project](Images/NameProject.png?raw=true)

### 4. Manage NuGet Packages
Right click the *Solution* in Solution Explorer and select **Manage Nuget Packages for Solution...**.

![Manage Nuget Packages](Images/ManageNugetPackages.png?raw=true)

### 5. Install NuGet Packages
Go to the browse tab, Search for the NuGet package you would like to install, select the project, and click install.

![Install Nuget Package](Images/InstallNugetPackage.png?raw=true)

You will need to install the following packages:
- Boa.Constrictor
- FluentAssertions
- Selenium.Support
- Selenium.WebDriver

You will also need the following NUnit packages. 
They should have automatically been added from the project creation, but add them manually if they were not:
- NUnit
- NUnit3TestAdapter

### 6. Remove the Auto-Generated Class
Right click the *UnitTest1.cs* class file in Solution Explorer and select **Delete**.

![Remove Auto Generated Class](Images/RemoveAutoGeneratedClass.png?raw=true)

### 7. Add a Test Class
Right click the *Project* in Solution Explorer, expand the *Add* option, and select **Class..**.

![Add Class To Project](Images/AddClassToProject.png?raw=true)

### 8. Name the Class
Name the class *DuckDuckGotTest.cs*.

![Name Class](Images/NameClass.png?raw=true)

### 9. Add the Class Contents
Replace the auto-generated code in the *DuckDuckGoTest.cs* class with the following code:
```csharp
using NUnit.Framework;

namespace Boa.Constrictor.Example
{
    public class DuckDuckGoTest
    {
        [Test]
        public void TestDuckDuckGoSearch()
        {

        }
    }
}
```

### 10. Start the Tutorial
Congratulations, your project is now ready. 
Please follow the [Tutorial Instructions](TUTORIAL.md#tutorial-instructions) in the Boa Constrictor [quickstart tutorial](TUTORIAL.md).