using System.Collections.Generic;
using System.Linq;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi.CSharp.Tree;

namespace AsyncConverter.AsyncHelpers.RenameCheckers
{
    [SolutionComponent]
    public class RenameChecker : IRenameChecker
    {
        private readonly IConcreateRenameChecker[] concreateCheckers;

        public RenameChecker(IEnumerable<IConcreateRenameChecker> concreateCheckers)
        {
            this.concreateCheckers = concreateCheckers.ToArray();
        }

        public bool NeedRename(IMethodDeclaration method)
        {
            return concreateCheckers.All(x => x.NeedRename(method));
        }
    }
}