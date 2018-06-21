using System;
using System.Reflection;

namespace Saga.GMD.Adobe.Anonymisation.API.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}