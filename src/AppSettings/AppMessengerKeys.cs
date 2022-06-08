namespace AppFramework
{
    /// <summary>
    /// 应用程序消息键
    /// </summary>
    public class AppMessengerKeys
    {
        /*
         * 作用: 该类用于管理统一订阅消息命名格式
         *
         * 说明:
         *      该类用于定义发布订阅消息的唯一键值对:subscriber/token
         *      subscriber: 代表指定模块当中的订阅者
         *      token: 代表订阅者中用于标记的某类消息(确保唯一)
         */

        public const string User = "UserView/UserChanged";
        public const string Role = "RoleVirw/RoleChanged";
        public const string Tenant = "TenantsView/TenantChanged";
        public const string Organization = "OrganizationView/OrganizationChanged";
        public const string Language = "LanguageView/LanguageChanged";
        public const string Edition = "EditionView/EditionChanged";
        public const string Dynamic = "DynamicPropertyView/DynamicChanged";
        public const string Auditlog = "AuditLogsView/AuditlogChanged";

        public const string Logout = "App/Logout";

        public const string RemoveAllRegion = "App/Regions";

        public const string LanguageRefresh = "Language/Refresh";

        public const string RefreshUI = "App/UI";
    }
}