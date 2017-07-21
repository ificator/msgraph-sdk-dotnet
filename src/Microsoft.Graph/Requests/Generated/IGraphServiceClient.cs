// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityClient.cs.tt

namespace Microsoft.Graph
{

    /// <summary>
    /// The interface IGraphServiceClient.
    /// </summary>
    public partial interface IGraphServiceClient : IBaseClient
    {
    
        /// <summary>
        /// Gets the GraphServiceSchemaExtensions request builder.
        /// </summary>
        IGraphServiceSchemaExtensionsCollectionRequestBuilder SchemaExtensions { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryObjects request builder.
        /// </summary>
        IGraphServiceDirectoryObjectsCollectionRequestBuilder DirectoryObjects { get; }
    
        /// <summary>
        /// Gets the GraphServiceApplications request builder.
        /// </summary>
        IGraphServiceApplicationsCollectionRequestBuilder Applications { get; }
    
        /// <summary>
        /// Gets the GraphServiceAdministrativeUnits request builder.
        /// </summary>
        IGraphServiceAdministrativeUnitsCollectionRequestBuilder AdministrativeUnits { get; }
    
        /// <summary>
        /// Gets the GraphServiceAppRoleAssignments request builder.
        /// </summary>
        IGraphServiceAppRoleAssignmentsCollectionRequestBuilder AppRoleAssignments { get; }
    
        /// <summary>
        /// Gets the GraphServiceContacts request builder.
        /// </summary>
        IGraphServiceContactsCollectionRequestBuilder Contacts { get; }
    
        /// <summary>
        /// Gets the GraphServiceDevices request builder.
        /// </summary>
        IGraphServiceDevicesCollectionRequestBuilder Devices { get; }
    
        /// <summary>
        /// Gets the GraphServiceDomains request builder.
        /// </summary>
        IGraphServiceDomainsCollectionRequestBuilder Domains { get; }
    
        /// <summary>
        /// Gets the GraphServiceDomainDnsRecords request builder.
        /// </summary>
        IGraphServiceDomainDnsRecordsCollectionRequestBuilder DomainDnsRecords { get; }
    
        /// <summary>
        /// Gets the GraphServiceGroups request builder.
        /// </summary>
        IGraphServiceGroupsCollectionRequestBuilder Groups { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryRoles request builder.
        /// </summary>
        IGraphServiceDirectoryRolesCollectionRequestBuilder DirectoryRoles { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryRoleTemplates request builder.
        /// </summary>
        IGraphServiceDirectoryRoleTemplatesCollectionRequestBuilder DirectoryRoleTemplates { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectorySettingTemplates request builder.
        /// </summary>
        IGraphServiceDirectorySettingTemplatesCollectionRequestBuilder DirectorySettingTemplates { get; }
    
        /// <summary>
        /// Gets the GraphServiceOrganization request builder.
        /// </summary>
        IGraphServiceOrganizationCollectionRequestBuilder Organization { get; }
    
        /// <summary>
        /// Gets the GraphServiceOauth2PermissionGrants request builder.
        /// </summary>
        IGraphServiceOauth2PermissionGrantsCollectionRequestBuilder Oauth2PermissionGrants { get; }
    
        /// <summary>
        /// Gets the GraphServiceScopedRoleMemberships request builder.
        /// </summary>
        IGraphServiceScopedRoleMembershipsCollectionRequestBuilder ScopedRoleMemberships { get; }
    
        /// <summary>
        /// Gets the GraphServiceServicePrincipals request builder.
        /// </summary>
        IGraphServiceServicePrincipalsCollectionRequestBuilder ServicePrincipals { get; }
    
        /// <summary>
        /// Gets the GraphServiceSettings request builder.
        /// </summary>
        IGraphServiceSettingsCollectionRequestBuilder Settings { get; }
    
        /// <summary>
        /// Gets the GraphServiceSubscribedSkus request builder.
        /// </summary>
        IGraphServiceSubscribedSkusCollectionRequestBuilder SubscribedSkus { get; }
    
        /// <summary>
        /// Gets the GraphServiceUsers request builder.
        /// </summary>
        IGraphServiceUsersCollectionRequestBuilder Users { get; }
    
        /// <summary>
        /// Gets the GraphServicePolicies request builder.
        /// </summary>
        IGraphServicePoliciesCollectionRequestBuilder Policies { get; }
    
        /// <summary>
        /// Gets the GraphServiceContracts request builder.
        /// </summary>
        IGraphServiceContractsCollectionRequestBuilder Contracts { get; }
    
        /// <summary>
        /// Gets the GraphServiceWorkbooks request builder.
        /// </summary>
        IGraphServiceWorkbooksCollectionRequestBuilder Workbooks { get; }
    
        /// <summary>
        /// Gets the GraphServiceDrives request builder.
        /// </summary>
        IGraphServiceDrivesCollectionRequestBuilder Drives { get; }
    
        /// <summary>
        /// Gets the GraphServiceShares request builder.
        /// </summary>
        IGraphServiceSharesCollectionRequestBuilder Shares { get; }
    
        /// <summary>
        /// Gets the GraphServiceSites request builder.
        /// </summary>
        IGraphServiceSitesCollectionRequestBuilder Sites { get; }
    
        /// <summary>
        /// Gets the GraphServiceTasks request builder.
        /// </summary>
        IGraphServiceTasksCollectionRequestBuilder Tasks { get; }
    
        /// <summary>
        /// Gets the GraphServicePlans request builder.
        /// </summary>
        IGraphServicePlansCollectionRequestBuilder Plans { get; }
    
        /// <summary>
        /// Gets the GraphServiceBuckets request builder.
        /// </summary>
        IGraphServiceBucketsCollectionRequestBuilder Buckets { get; }
    
        /// <summary>
        /// Gets the GraphServiceSubscriptions request builder.
        /// </summary>
        IGraphServiceSubscriptionsCollectionRequestBuilder Subscriptions { get; }
    
        /// <summary>
        /// Gets the GraphServiceIdentityRiskEvents request builder.
        /// </summary>
        IGraphServiceIdentityRiskEventsCollectionRequestBuilder IdentityRiskEvents { get; }
    
        /// <summary>
        /// Gets the GraphServiceImpossibleTravelRiskEvents request builder.
        /// </summary>
        IGraphServiceImpossibleTravelRiskEventsCollectionRequestBuilder ImpossibleTravelRiskEvents { get; }
    
        /// <summary>
        /// Gets the GraphServiceLeakedCredentialsRiskEvents request builder.
        /// </summary>
        IGraphServiceLeakedCredentialsRiskEventsCollectionRequestBuilder LeakedCredentialsRiskEvents { get; }
    
        /// <summary>
        /// Gets the GraphServiceAnonymousIpRiskEvents request builder.
        /// </summary>
        IGraphServiceAnonymousIpRiskEventsCollectionRequestBuilder AnonymousIpRiskEvents { get; }
    
        /// <summary>
        /// Gets the GraphServiceSuspiciousIpRiskEvents request builder.
        /// </summary>
        IGraphServiceSuspiciousIpRiskEventsCollectionRequestBuilder SuspiciousIpRiskEvents { get; }
    
        /// <summary>
        /// Gets the GraphServiceUnfamiliarLocationRiskEvents request builder.
        /// </summary>
        IGraphServiceUnfamiliarLocationRiskEventsCollectionRequestBuilder UnfamiliarLocationRiskEvents { get; }
    
        /// <summary>
        /// Gets the GraphServiceMalwareRiskEvents request builder.
        /// </summary>
        IGraphServiceMalwareRiskEventsCollectionRequestBuilder MalwareRiskEvents { get; }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedRoles request builder.
        /// </summary>
        IGraphServicePrivilegedRolesCollectionRequestBuilder PrivilegedRoles { get; }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedRoleAssignments request builder.
        /// </summary>
        IGraphServicePrivilegedRoleAssignmentsCollectionRequestBuilder PrivilegedRoleAssignments { get; }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedOperationEvents request builder.
        /// </summary>
        IGraphServicePrivilegedOperationEventsCollectionRequestBuilder PrivilegedOperationEvents { get; }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedSignupStatus request builder.
        /// </summary>
        IGraphServicePrivilegedSignupStatusCollectionRequestBuilder PrivilegedSignupStatus { get; }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedApproval request builder.
        /// </summary>
        IGraphServicePrivilegedApprovalCollectionRequestBuilder PrivilegedApproval { get; }
    
        /// <summary>
        /// Gets the GraphServiceInvitations request builder.
        /// </summary>
        IGraphServiceInvitationsCollectionRequestBuilder Invitations { get; }
    
        /// <summary>
        /// Gets the GraphServiceIosMobileAppConfigurations request builder.
        /// </summary>
        IGraphServiceIosMobileAppConfigurationsCollectionRequestBuilder IosMobileAppConfigurations { get; }
    
        /// <summary>
        /// Gets the GraphServiceMobileAppGroupAssignments request builder.
        /// </summary>
        IGraphServiceMobileAppGroupAssignmentsCollectionRequestBuilder MobileAppGroupAssignments { get; }
    
        /// <summary>
        /// Gets the GraphServiceAppProvisioningConfigurationGroupAssignments request builder.
        /// </summary>
        IGraphServiceAppProvisioningConfigurationGroupAssignmentsCollectionRequestBuilder AppProvisioningConfigurationGroupAssignments { get; }
    
        /// <summary>
        /// Gets the GraphServiceMobileApps request builder.
        /// </summary>
        IGraphServiceMobileAppsCollectionRequestBuilder MobileApps { get; }
    
        /// <summary>
        /// Gets the GraphServiceAppConfigurationGroupAssignments request builder.
        /// </summary>
        IGraphServiceAppConfigurationGroupAssignmentsCollectionRequestBuilder AppConfigurationGroupAssignments { get; }
    
        /// <summary>
        /// Gets the GraphServiceImportedDeviceIdentityResults request builder.
        /// </summary>
        IGraphServiceImportedDeviceIdentityResultsCollectionRequestBuilder ImportedDeviceIdentityResults { get; }
    
        /// <summary>
        /// Gets the GraphServiceImportedAppleDeviceIdentityResults request builder.
        /// </summary>
        IGraphServiceImportedAppleDeviceIdentityResultsCollectionRequestBuilder ImportedAppleDeviceIdentityResults { get; }
    
        /// <summary>
        /// Gets the GraphServiceManagedDevices request builder.
        /// </summary>
        IGraphServiceManagedDevicesCollectionRequestBuilder ManagedDevices { get; }
    
        /// <summary>
        /// Gets the GraphServiceDetectedapps request builder.
        /// </summary>
        IGraphServiceDetectedappsCollectionRequestBuilder Detectedapps { get; }
    
        /// <summary>
        /// Gets the GraphServiceDeviceManagementScriptGroupAssignments request builder.
        /// </summary>
        IGraphServiceDeviceManagementScriptGroupAssignmentsCollectionRequestBuilder DeviceManagementScriptGroupAssignments { get; }
    
        /// <summary>
        /// Gets the GraphServiceDeviceConfigurationGroupAssignment request builder.
        /// </summary>
        IGraphServiceDeviceConfigurationGroupAssignmentCollectionRequestBuilder DeviceConfigurationGroupAssignment { get; }
    
        /// <summary>
        /// Gets the GraphServiceDeviceConfigurationAssignments request builder.
        /// </summary>
        IGraphServiceDeviceConfigurationAssignmentsCollectionRequestBuilder DeviceConfigurationAssignments { get; }
    
        /// <summary>
        /// Gets the GraphServiceDeviceCompliancePolicyGroupAssignment request builder.
        /// </summary>
        IGraphServiceDeviceCompliancePolicyGroupAssignmentCollectionRequestBuilder DeviceCompliancePolicyGroupAssignment { get; }
    
        /// <summary>
        /// Gets the GraphServiceDeviceCompliancePolicyAssignments request builder.
        /// </summary>
        IGraphServiceDeviceCompliancePolicyAssignmentsCollectionRequestBuilder DeviceCompliancePolicyAssignments { get; }
    
        /// <summary>
        /// Gets the GraphServiceDeviceComplianceScheduledActionForRule request builder.
        /// </summary>
        IGraphServiceDeviceComplianceScheduledActionForRuleCollectionRequestBuilder DeviceComplianceScheduledActionForRule { get; }
    
        /// <summary>
        /// Gets the GraphServiceManagedAppPolicies request builder.
        /// </summary>
        IGraphServiceManagedAppPoliciesCollectionRequestBuilder ManagedAppPolicies { get; }
    
        /// <summary>
        /// Gets the GraphServiceManagedAppRegistrations request builder.
        /// </summary>
        IGraphServiceManagedAppRegistrationsCollectionRequestBuilder ManagedAppRegistrations { get; }
    
        /// <summary>
        /// Gets the GraphServiceManagedAppStatuses request builder.
        /// </summary>
        IGraphServiceManagedAppStatusesCollectionRequestBuilder ManagedAppStatuses { get; }
    
        /// <summary>
        /// Gets the GraphServiceLocalizedNotificationMessages request builder.
        /// </summary>
        IGraphServiceLocalizedNotificationMessagesCollectionRequestBuilder LocalizedNotificationMessages { get; }
    
        /// <summary>
        /// Gets the GraphServiceEBookGroupAssignments request builder.
        /// </summary>
        IGraphServiceEBookGroupAssignmentsCollectionRequestBuilder EBookGroupAssignments { get; }
    
        /// <summary>
        /// Gets the GraphServiceCommands request builder.
        /// </summary>
        IGraphServiceCommandsCollectionRequestBuilder Commands { get; }
    
        /// <summary>
        /// Gets the GraphServicePayloadResponse request builder.
        /// </summary>
        IGraphServicePayloadResponseCollectionRequestBuilder PayloadResponse { get; }
    
        /// <summary>
        /// Gets the GraphServiceChannels request builder.
        /// </summary>
        IGraphServiceChannelsCollectionRequestBuilder Channels { get; }
    
        /// <summary>
        /// Gets the GraphServiceChatThreads request builder.
        /// </summary>
        IGraphServiceChatThreadsCollectionRequestBuilder ChatThreads { get; }
    
        /// <summary>
        /// Gets the GraphServiceMe request builder.
        /// </summary>
        IUserRequestBuilder Me { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectory request builder.
        /// </summary>
        IDirectoryRequestBuilder Directory { get; }
    
        /// <summary>
        /// Gets the GraphServiceDrive request builder.
        /// </summary>
        IDriveRequestBuilder Drive { get; }
    
        /// <summary>
        /// Gets the GraphServicePlanner request builder.
        /// </summary>
        IPlannerRequestBuilder Planner { get; }
    
        /// <summary>
        /// Gets the GraphServiceDeviceManagement request builder.
        /// </summary>
        IDeviceManagementRequestBuilder DeviceManagement { get; }
    
        /// <summary>
        /// Gets the GraphServiceDeviceAppManagement request builder.
        /// </summary>
        IDeviceAppManagementRequestBuilder DeviceAppManagement { get; }
    
        /// <summary>
        /// Gets the GraphServiceManagedDeviceOverview request builder.
        /// </summary>
        IManagedDeviceOverviewRequestBuilder ManagedDeviceOverview { get; }
    
        /// <summary>
        /// Gets the GraphServiceReports request builder.
        /// </summary>
        IReportRootRequestBuilder Reports { get; }
    
    }
}
