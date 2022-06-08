namespace AppFramework.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                return false;
            }

            var permissionService = ContainerLocator.Container.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}