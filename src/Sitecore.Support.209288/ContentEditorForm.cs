using Sitecore.Security.AccessControl;

namespace Sitecore.Support.Shell.Applications.ContentManager
{
    public class ContentEditorForm : Sitecore.Shell.Applications.ContentManager.ContentEditorForm
    {
        protected new void Validator_ContextMenu(string markerId)
        {
            var field = Context.ContentDatabase.GetItem("{F47C0D78-61F9-479C-96DF-1159727D32C6}");
            if (AuthorizationManager.IsAllowed(field, AccessRight.FieldWrite, Context.User))
            {
                base.Validator_ContextMenu(markerId);
            }
        }
    }
}
