using AppFramework.ApiClient.Models;
using AppFramework.Auditing.Dto;
using AppFramework.Auditlogs;
using AppFramework.Authorization.Permissions.Dto;
using AppFramework.Authorization.Roles.Dto;
using AppFramework.Authorization.Users.Dto;
using AppFramework.Configuration.Dto;
using AppFramework.Configuration.Host.Dto;
using AppFramework.DynamicEntityProperties.Dto;
using AppFramework.Editions.Dto;
using AppFramework.Localization.Dto;
using AppFramework.Models.Configuration;
using AppFramework.Models.Tenants;
using AppFramework.MultiTenancy.Dto;
using AppFramework.Organizations.Dto;
using AppFramework.Sessions.Dto;
using AutoMapper;

namespace AppFramework
{
    public class AppMapper : Profile
    {
        public AppMapper()
        {
            CreateMap<GetAuditLogsFilter, GetAuditLogsInput>().ReverseMap();
            CreateMap<GetEntityChangeFilter, GetEntityChangeInput>().ReverseMap();
            CreateMap<GetTenantsFilter, GetTenantsInput>().ReverseMap();
            CreateMap<FlatPermissionWithLevelDto, PermissionModel>().ReverseMap();

            //系统模块中实体映射关系
            CreateMap<UserListDto, UserListModel>().ReverseMap();
            CreateMap<UserEditDto, UserEditModel>().ReverseMap();
            CreateMap<RoleListDto, RoleListModel>().ReverseMap();
            CreateMap<RoleEditDto, RoleEditModel>().ReverseMap();
            CreateMap<TenantListDto, TenantListModel>().ReverseMap();
            CreateMap<TenantEditDto, TenantListModel>().ReverseMap();
            CreateMap<AuditLogListDto, AuditLogListModel>().ReverseMap();
            CreateMap<UserCreateOrUpdateModel, CreateOrUpdateUserInput>().ReverseMap();
            CreateMap<DynamicPropertyDto, DynamicPropertyModel>().ReverseMap();
            CreateMap<OrganizationUnitDto, OrganizationListModel>().ReverseMap();
            CreateMap<OrganizationUnitDto, OrganizationUnitModel>().ReverseMap();
            CreateMap<LanguageListModel, ApplicationLanguageListDto>().ReverseMap();
            CreateMap<LanguageTextListModel, LanguageTextListDto>().ReverseMap();
            CreateMap<UserLoginInfoDto, UserLoginInfoModel>().ReverseMap();
            CreateMap<UserLoginInfoDto, UserLoginInfoPersistanceModel>().ReverseMap();
            CreateMap<AbpAuthenticateResultModel, AuthenticateResultPersistanceModel>().ReverseMap();
            CreateMap<TenantInformation, TenantInformationPersistanceModel>().ReverseMap();
            CreateMap<TenantLoginInfoDto, TenantLoginInfoPersistanceModel>().ReverseMap();
            CreateMap<ApplicationInfoDto, ApplicationInfoPersistanceModel>().ReverseMap();
            CreateMap<EditionListDto, EditionListModel>().ReverseMap();
            CreateMap<EditionCreateDto, EditionCreateModel>().ReverseMap();
            CreateMap<EditionEditDto, EditionCreateModel>().ReverseMap();
            CreateMap<FlatFeatureDto, FlatFeatureModel>().ReverseMap();
            CreateMap<FlatPermissionDto, PermissionModel>().ReverseMap();
            CreateMap<GetUserForEditOutput, UserForEditModel>().ReverseMap();
            CreateMap<GetCurrentLoginInformationsOutput, CurrentLoginInformationPersistanceModel>().ReverseMap();
            CreateMap<TenantListModel, CreateTenantInput>().ReverseMap();

            #region 系统设置

            CreateMap<HostSettingsEditModel, HostSettingsEditDto>().ReverseMap();
            CreateMap<GeneralSettingsEditModel, GeneralSettingsEditDto>().ReverseMap();
            CreateMap<HostUserManagementSettingsEditModel, HostUserManagementSettingsEditDto>().ReverseMap();
            CreateMap<EmailSettingsEditModel, EmailSettingsEditDto>().ReverseMap();
            CreateMap<TenantManagementSettingsEditModel, TenantManagementSettingsEditDto>().ReverseMap();
            CreateMap<SecuritySettingsEditModel, SecuritySettingsEditDto>().ReverseMap();
            CreateMap<HostBillingSettingsEditModel, HostBillingSettingsEditDto>().ReverseMap();
            CreateMap<OtherSettingsEditModel, OtherSettingsEditDto>().ReverseMap();
            CreateMap<ExternalLoginProviderSettingsEditModel, ExternalLoginProviderSettingsEditDto>().ReverseMap();
            CreateMap<UserLockOutSettingsEditModel, UserLockOutSettingsEditDto>().ReverseMap();
            CreateMap<TwoFactorLoginSettingsEditModel, TwoFactorLoginSettingsEditDto>().ReverseMap();
            CreateMap<SessionTimeOutSettingsEditModel, SessionTimeOutSettingsEditDto>().ReverseMap();
            CreateMap<UserPasswordSettingsEditModel, UserPasswordSettingsEditDto>().ReverseMap();

            #endregion 系统设置

            /*
             * 以下可添加更多的实体映射关系
             */
        }
    }
}