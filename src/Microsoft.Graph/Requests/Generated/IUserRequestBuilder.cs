// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IUserRequestBuilder.
    /// </summary>
    public partial interface IUserRequestBuilder : IDirectoryObjectRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IUserRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IUserRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IUserExtensionsCollectionRequestBuilder"/>.</returns>
        IUserExtensionsCollectionRequestBuilder Extensions { get; }

        /// <summary>
        /// Gets the request builder for OwnedDevices.
        /// </summary>
        /// <returns>The <see cref="IUserOwnedDevicesCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserOwnedDevicesCollectionWithReferencesRequestBuilder OwnedDevices { get; }

        /// <summary>
        /// Gets the request builder for RegisteredDevices.
        /// </summary>
        /// <returns>The <see cref="IUserRegisteredDevicesCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserRegisteredDevicesCollectionWithReferencesRequestBuilder RegisteredDevices { get; }

        /// <summary>
        /// Gets the request builder for Manager.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        IDirectoryObjectWithReferenceRequestBuilder Manager { get; }

        /// <summary>
        /// Gets the request builder for DirectReports.
        /// </summary>
        /// <returns>The <see cref="IUserDirectReportsCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserDirectReportsCollectionWithReferencesRequestBuilder DirectReports { get; }

        /// <summary>
        /// Gets the request builder for MemberOf.
        /// </summary>
        /// <returns>The <see cref="IUserMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserMemberOfCollectionWithReferencesRequestBuilder MemberOf { get; }

        /// <summary>
        /// Gets the request builder for CreatedObjects.
        /// </summary>
        /// <returns>The <see cref="IUserCreatedObjectsCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserCreatedObjectsCollectionWithReferencesRequestBuilder CreatedObjects { get; }

        /// <summary>
        /// Gets the request builder for OwnedObjects.
        /// </summary>
        /// <returns>The <see cref="IUserOwnedObjectsCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserOwnedObjectsCollectionWithReferencesRequestBuilder OwnedObjects { get; }

        /// <summary>
        /// Gets the request builder for ScopedRoleMemberOf.
        /// </summary>
        /// <returns>The <see cref="IUserScopedRoleMemberOfCollectionRequestBuilder"/>.</returns>
        IUserScopedRoleMemberOfCollectionRequestBuilder ScopedRoleMemberOf { get; }

        /// <summary>
        /// Gets the request builder for LicenseDetails.
        /// </summary>
        /// <returns>The <see cref="IUserLicenseDetailsCollectionRequestBuilder"/>.</returns>
        IUserLicenseDetailsCollectionRequestBuilder LicenseDetails { get; }

        /// <summary>
        /// Gets the request builder for Outlook.
        /// </summary>
        /// <returns>The <see cref="IOutlookUserRequestBuilder"/>.</returns>
        IOutlookUserRequestBuilder Outlook { get; }

        /// <summary>
        /// Gets the request builder for Messages.
        /// </summary>
        /// <returns>The <see cref="IUserMessagesCollectionRequestBuilder"/>.</returns>
        IUserMessagesCollectionRequestBuilder Messages { get; }

        /// <summary>
        /// Gets the request builder for JoinedGroups.
        /// </summary>
        /// <returns>The <see cref="IUserJoinedGroupsCollectionRequestBuilder"/>.</returns>
        IUserJoinedGroupsCollectionRequestBuilder JoinedGroups { get; }

        /// <summary>
        /// Gets the request builder for MailFolders.
        /// </summary>
        /// <returns>The <see cref="IUserMailFoldersCollectionRequestBuilder"/>.</returns>
        IUserMailFoldersCollectionRequestBuilder MailFolders { get; }

        /// <summary>
        /// Gets the request builder for Calendar.
        /// </summary>
        /// <returns>The <see cref="ICalendarRequestBuilder"/>.</returns>
        ICalendarRequestBuilder Calendar { get; }

        /// <summary>
        /// Gets the request builder for Calendars.
        /// </summary>
        /// <returns>The <see cref="IUserCalendarsCollectionRequestBuilder"/>.</returns>
        IUserCalendarsCollectionRequestBuilder Calendars { get; }

        /// <summary>
        /// Gets the request builder for CalendarGroups.
        /// </summary>
        /// <returns>The <see cref="IUserCalendarGroupsCollectionRequestBuilder"/>.</returns>
        IUserCalendarGroupsCollectionRequestBuilder CalendarGroups { get; }

        /// <summary>
        /// Gets the request builder for CalendarView.
        /// </summary>
        /// <returns>The <see cref="IUserCalendarViewCollectionRequestBuilder"/>.</returns>
        IUserCalendarViewCollectionRequestBuilder CalendarView { get; }

        /// <summary>
        /// Gets the request builder for Events.
        /// </summary>
        /// <returns>The <see cref="IUserEventsCollectionRequestBuilder"/>.</returns>
        IUserEventsCollectionRequestBuilder Events { get; }

        /// <summary>
        /// Gets the request builder for People.
        /// </summary>
        /// <returns>The <see cref="IUserPeopleCollectionRequestBuilder"/>.</returns>
        IUserPeopleCollectionRequestBuilder People { get; }

        /// <summary>
        /// Gets the request builder for Contacts.
        /// </summary>
        /// <returns>The <see cref="IUserContactsCollectionRequestBuilder"/>.</returns>
        IUserContactsCollectionRequestBuilder Contacts { get; }

        /// <summary>
        /// Gets the request builder for ContactFolders.
        /// </summary>
        /// <returns>The <see cref="IUserContactFoldersCollectionRequestBuilder"/>.</returns>
        IUserContactFoldersCollectionRequestBuilder ContactFolders { get; }

        /// <summary>
        /// Gets the request builder for InferenceClassification.
        /// </summary>
        /// <returns>The <see cref="IInferenceClassificationRequestBuilder"/>.</returns>
        IInferenceClassificationRequestBuilder InferenceClassification { get; }

        /// <summary>
        /// Gets the request builder for Photo.
        /// </summary>
        /// <returns>The <see cref="IProfilePhotoRequestBuilder"/>.</returns>
        IProfilePhotoRequestBuilder Photo { get; }

        /// <summary>
        /// Gets the request builder for Photos.
        /// </summary>
        /// <returns>The <see cref="IUserPhotosCollectionRequestBuilder"/>.</returns>
        IUserPhotosCollectionRequestBuilder Photos { get; }

        /// <summary>
        /// Gets the request builder for Drive.
        /// </summary>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        IDriveRequestBuilder Drive { get; }

        /// <summary>
        /// Gets the request builder for Drives.
        /// </summary>
        /// <returns>The <see cref="IUserDrivesCollectionRequestBuilder"/>.</returns>
        IUserDrivesCollectionRequestBuilder Drives { get; }

        /// <summary>
        /// Gets the request builder for Insights.
        /// </summary>
        /// <returns>The <see cref="IOfficeGraphInsightsRequestBuilder"/>.</returns>
        IOfficeGraphInsightsRequestBuilder Insights { get; }

        /// <summary>
        /// Gets the request builder for Tasks.
        /// </summary>
        /// <returns>The <see cref="IUserTasksCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserTasksCollectionWithReferencesRequestBuilder Tasks { get; }

        /// <summary>
        /// Gets the request builder for Plans.
        /// </summary>
        /// <returns>The <see cref="IUserPlansCollectionWithReferencesRequestBuilder"/>.</returns>
        IUserPlansCollectionWithReferencesRequestBuilder Plans { get; }

        /// <summary>
        /// Gets the request builder for Planner.
        /// </summary>
        /// <returns>The <see cref="IPlannerUserRequestBuilder"/>.</returns>
        IPlannerUserRequestBuilder Planner { get; }

        /// <summary>
        /// Gets the request builder for Onenote.
        /// </summary>
        /// <returns>The <see cref="IOnenoteRequestBuilder"/>.</returns>
        IOnenoteRequestBuilder Onenote { get; }

        /// <summary>
        /// Gets the request builder for ManagedDevices.
        /// </summary>
        /// <returns>The <see cref="IUserManagedDevicesCollectionRequestBuilder"/>.</returns>
        IUserManagedDevicesCollectionRequestBuilder ManagedDevices { get; }

        /// <summary>
        /// Gets the request builder for ManagedAppRegistrations.
        /// </summary>
        /// <returns>The <see cref="IUserManagedAppRegistrationsCollectionRequestBuilder"/>.</returns>
        IUserManagedAppRegistrationsCollectionRequestBuilder ManagedAppRegistrations { get; }

        /// <summary>
        /// Gets the request builder for Devices.
        /// </summary>
        /// <returns>The <see cref="IUserDevicesCollectionRequestBuilder"/>.</returns>
        IUserDevicesCollectionRequestBuilder Devices { get; }

        /// <summary>
        /// Gets the request builder for JoinedTeams.
        /// </summary>
        /// <returns>The <see cref="IUserJoinedTeamsCollectionRequestBuilder"/>.</returns>
        IUserJoinedTeamsCollectionRequestBuilder JoinedTeams { get; }

        /// <summary>
        /// Gets the request builder for Activities.
        /// </summary>
        /// <returns>The <see cref="IUserActivitiesCollectionRequestBuilder"/>.</returns>
        IUserActivitiesCollectionRequestBuilder Activities { get; }
    
        /// <summary>
        /// Gets the request builder for UserAssignLicense.
        /// </summary>
        /// <returns>The <see cref="IUserAssignLicenseRequestBuilder"/>.</returns>
        IUserAssignLicenseRequestBuilder AssignLicense(
            IEnumerable<AssignedLicense> addLicenses,
            IEnumerable<Guid> removeLicenses);

        /// <summary>
        /// Gets the request builder for UserChangePassword.
        /// </summary>
        /// <returns>The <see cref="IUserChangePasswordRequestBuilder"/>.</returns>
        IUserChangePasswordRequestBuilder ChangePassword(
            string currentPassword = null,
            string newPassword = null);

        /// <summary>
        /// Gets the request builder for UserInvalidateAllRefreshTokens.
        /// </summary>
        /// <returns>The <see cref="IUserInvalidateAllRefreshTokensRequestBuilder"/>.</returns>
        IUserInvalidateAllRefreshTokensRequestBuilder InvalidateAllRefreshTokens();

        /// <summary>
        /// Gets the request builder for UserSendMail.
        /// </summary>
        /// <returns>The <see cref="IUserSendMailRequestBuilder"/>.</returns>
        IUserSendMailRequestBuilder SendMail(
            Message Message,
            bool? SaveToSentItems = null);

        /// <summary>
        /// Gets the request builder for UserFindMeetingTimesOLD.
        /// </summary>
        /// <returns>The <see cref="IUserFindMeetingTimesOLDRequestBuilder"/>.</returns>
        IUserFindMeetingTimesOLDRequestBuilder FindMeetingTimesOLD(
            IEnumerable<AttendeeBase> Attendees = null,
            LocationConstraint LocationConstraint = null,
            TimeConstraint TimeConstraint = null,
            Duration MeetingDuration = null,
            Int32? MaxCandidates = null,
            bool? IsOrganizerOptional = null,
            bool? ReturnSuggestionHints = null);

        /// <summary>
        /// Gets the request builder for UserFindMeetingTimes.
        /// </summary>
        /// <returns>The <see cref="IUserFindMeetingTimesRequestBuilder"/>.</returns>
        IUserFindMeetingTimesRequestBuilder FindMeetingTimes(
            IEnumerable<AttendeeBase> Attendees = null,
            LocationConstraint LocationConstraint = null,
            TimeConstraint TimeConstraint = null,
            Duration MeetingDuration = null,
            Int32? MaxCandidates = null,
            bool? IsOrganizerOptional = null,
            bool? ReturnSuggestionReasons = null,
            double? MinimumAttendeePercentage = null);

        /// <summary>
        /// Gets the request builder for UserGetMailTips.
        /// </summary>
        /// <returns>The <see cref="IUserGetMailTipsRequestBuilder"/>.</returns>
        IUserGetMailTipsRequestBuilder GetMailTips(
            IEnumerable<string> EmailAddresses,
            MailTipsType? MailTipsOptions = null);

        /// <summary>
        /// Gets the request builder for UserRemoveAllDevicesFromManagement.
        /// </summary>
        /// <returns>The <see cref="IUserRemoveAllDevicesFromManagementRequestBuilder"/>.</returns>
        IUserRemoveAllDevicesFromManagementRequestBuilder RemoveAllDevicesFromManagement();

        /// <summary>
        /// Gets the request builder for UserWipeManagedAppRegistrationByDeviceTag.
        /// </summary>
        /// <returns>The <see cref="IUserWipeManagedAppRegistrationByDeviceTagRequestBuilder"/>.</returns>
        IUserWipeManagedAppRegistrationByDeviceTagRequestBuilder WipeManagedAppRegistrationByDeviceTag(
            string deviceTag = null);

        /// <summary>
        /// Gets the request builder for UserReminderView.
        /// </summary>
        /// <returns>The <see cref="IUserReminderViewRequestBuilder"/>.</returns>
        IUserReminderViewRequestBuilder ReminderView(
            string StartDateTime,
            string EndDateTime = null);

        /// <summary>
        /// Gets the request builder for UserGetManagedAppDiagnosticStatuses.
        /// </summary>
        /// <returns>The <see cref="IUserGetManagedAppDiagnosticStatusesRequestBuilder"/>.</returns>
        IUserGetManagedAppDiagnosticStatusesRequestBuilder GetManagedAppDiagnosticStatuses();

        /// <summary>
        /// Gets the request builder for UserGetManagedAppPolicies.
        /// </summary>
        /// <returns>The <see cref="IUserGetManagedAppPoliciesRequestBuilder"/>.</returns>
        IUserGetManagedAppPoliciesRequestBuilder GetManagedAppPolicies();
    
    }
}
