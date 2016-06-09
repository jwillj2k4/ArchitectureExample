using System;
using System.Reflection;

namespace WK.Orion.Applications.SPA.CRM.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}