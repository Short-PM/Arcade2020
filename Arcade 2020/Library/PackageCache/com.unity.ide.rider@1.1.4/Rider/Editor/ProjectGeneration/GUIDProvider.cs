<<<<<<< HEAD
using System;

namespace Packages.Rider.Editor {
  class GUIDProvider : IGUIDGenerator
  {
    public string ProjectGuid(string projectName, string assemblyName)
    {
      return SolutionGuidGenerator.GuidForProject(projectName + assemblyName);
    }

    public string SolutionGuid(string projectName, string extension)
    {
      return SolutionGuidGenerator.GuidForSolution(projectName, extension); // GetExtensionOfSourceFiles(assembly.sourceFiles)
    }
  }
}
=======
using System;

namespace Packages.Rider.Editor {
  class GUIDProvider : IGUIDGenerator
  {
    public string ProjectGuid(string projectName, string assemblyName)
    {
      return SolutionGuidGenerator.GuidForProject(projectName + assemblyName);
    }

    public string SolutionGuid(string projectName, string extension)
    {
      return SolutionGuidGenerator.GuidForSolution(projectName, extension); // GetExtensionOfSourceFiles(assembly.sourceFiles)
    }
  }
}
>>>>>>> master
