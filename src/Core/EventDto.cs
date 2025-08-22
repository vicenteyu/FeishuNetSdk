// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="EventDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>事件序列化定义</summary>
// ************************************************************************
namespace FeishuNetSdk.Core;

/// <summary>事件序列化定义</summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = FeishuNetSdkOptions.Discriminator,
    UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor,
    IgnoreUnrecognizedTypeDiscriminators = true)]
[JsonDerivedType(typeof(UrlVerificationDto), typeDiscriminator: "url_verification")]
//【审批】审批抄送状态变更
[JsonDerivedType(typeof(EventV1Dto<Approval.Events.ApprovalCcEventBodyDto>), typeDiscriminator: "approval_cc")]
//【审批】审批任务状态变更
[JsonDerivedType(typeof(EventV1Dto<Approval.Events.ApprovalTaskEventBodyDto>), typeDiscriminator: "approval_task")]
//【审批】审批实例状态变更
[JsonDerivedType(typeof(EventV1Dto<Approval.Events.ApprovalInstanceEventBodyDto>), typeDiscriminator: "approval_instance")]
//【审批】审批通过通知
[JsonDerivedType(typeof(EventV1Dto<Approval.Events.ApprovalEventBodyDto>), typeDiscriminator: "approval")]
//【审批】请假撤销
[JsonDerivedType(typeof(EventV1Dto<Approval.Events.LeaveApprovalRevertEventBodyDto>), typeDiscriminator: "leave_approval_revert")]
//【审批】审批通过并撤销
[JsonDerivedType(typeof(EventV1Dto<Approval.Events.OutApprovalRevertEventBodyDto>), typeDiscriminator: "out_approval_revert")]
//【审批】加班审批通过并撤销
[JsonDerivedType(typeof(EventV1Dto<Approval.Events.WorkApprovalRevertEventBodyDto>), typeDiscriminator: "work_approval_revert")]
//【回调】拉取链接预览数据
[JsonDerivedType(typeof(CallbackV2Dto<CallbackEvents.UrlPreviewGetEventBodyDto>), typeDiscriminator: "url.preview.get")]
//【回调】卡片回传交互
[JsonDerivedType(typeof(CallbackV2Dto<CallbackEvents.CardActionTriggerEventBodyDto>), typeDiscriminator: "card.action.trigger")]
//【审批】补卡审批
[JsonDerivedType(typeof(EventV1Dto<Approval.Events.ApprovalInstanceRemedyGroupUpdateV4EventBodyDto>), typeDiscriminator: "approval.instance.remedy_group_update_v4")]
//【审批】出差审批
[JsonDerivedType(typeof(EventV1Dto<Approval.Events.ApprovalInstanceTripGroupUpdateV4EventBodyDto>), typeDiscriminator: "approval.instance.trip_group_update_v4")]
//【审批】请假审批
[JsonDerivedType(typeof(EventV1Dto<Approval.Events.LeaveApprovalV2EventBodyDto>), typeDiscriminator: "leave_approvalV2")]
//【审批】外出审批
[JsonDerivedType(typeof(EventV1Dto<Approval.Events.OutApprovalEventBodyDto>), typeDiscriminator: "out_approval")]
//【审批】换班审批
[JsonDerivedType(typeof(EventV1Dto<Approval.Events.ShiftApprovalEventBodyDto>), typeDiscriminator: "shift_approval")]
//【审批】加班审批
[JsonDerivedType(typeof(EventV1Dto<Approval.Events.WorkApprovalEventBodyDto>), typeDiscriminator: "work_approval")]
//【会议室】第三方会议室日程变动
[JsonDerivedType(typeof(EventV1Dto<MeetingRoom.Events.ThirdPartyMeetingRoomEventCreatedEventBodyDto>), typeDiscriminator: "third_party_meeting_room_event_created")]
//【智能门禁】新增门禁访问记录
[JsonDerivedType(typeof(EventV2Dto<Acs.Events.AcsAccessRecordCreatedV1EventBodyDto>), typeDiscriminator: "acs.access_record.created_v1")]
//【智能门禁】用户信息变更
[JsonDerivedType(typeof(EventV2Dto<Acs.Events.AcsUserUpdatedV1EventBodyDto>), typeDiscriminator: "acs.user.updated_v1")]
//【应用信息】应用审核
[JsonDerivedType(typeof(EventV2Dto<Application.Events.ApplicationApplicationAppVersionAuditV6EventBodyDto>), typeDiscriminator: "application.application.app_version.audit_v6")]
//【应用信息】申请发布应用
[JsonDerivedType(typeof(EventV2Dto<Application.Events.ApplicationApplicationAppVersionPublishApplyV6EventBodyDto>), typeDiscriminator: "application.application.app_version.publish_apply_v6")]
//【应用信息】撤回应用发布申请
[JsonDerivedType(typeof(EventV2Dto<Application.Events.ApplicationApplicationAppVersionPublishRevokeV6EventBodyDto>), typeDiscriminator: "application.application.app_version.publish_revoke_v6")]
//【应用信息】应用创建
[JsonDerivedType(typeof(EventV2Dto<Application.Events.ApplicationApplicationCreatedV6EventBodyDto>), typeDiscriminator: "application.application.created_v6")]
//【应用信息】新增应用反馈
[JsonDerivedType(typeof(EventV2Dto<Application.Events.ApplicationApplicationFeedbackCreatedV6EventBodyDto>), typeDiscriminator: "application.application.feedback.created_v6")]
//【应用信息】反馈更新
[JsonDerivedType(typeof(EventV2Dto<Application.Events.ApplicationApplicationFeedbackUpdatedV6EventBodyDto>), typeDiscriminator: "application.application.feedback.updated_v6")]
//【应用信息】员工免审安装应用
[JsonDerivedType(typeof(EventV2Dto<Application.Events.ApplicationApplicationVisibilityAddedV6EventBodyDto>), typeDiscriminator: "application.application.visibility.added_v6")]
//【应用信息】机器人自定义菜单事件
[JsonDerivedType(typeof(EventV2Dto<Application.Events.ApplicationBotMenuV6EventBodyDto>), typeDiscriminator: "application.bot.menu_v6")]
//【审批】审批定义更新
[JsonDerivedType(typeof(EventV2Dto<Approval.Events.ApprovalApprovalUpdatedV4EventBodyDto>), typeDiscriminator: "approval.approval.updated_v4")]
//【日历】创建 ACL
[JsonDerivedType(typeof(EventV2Dto<Calendar.Events.CalendarCalendarAclCreatedV4EventBodyDto>), typeDiscriminator: "calendar.calendar.acl.created_v4")]
//【日历】删除 ACL
[JsonDerivedType(typeof(EventV2Dto<Calendar.Events.CalendarCalendarAclDeletedV4EventBodyDto>), typeDiscriminator: "calendar.calendar.acl.deleted_v4")]
//【日历】日历变更
[JsonDerivedType(typeof(EventV2Dto<Calendar.Events.CalendarCalendarChangedV4EventBodyDto>), typeDiscriminator: "calendar.calendar.changed_v4")]
//【日历】日程变更
[JsonDerivedType(typeof(EventV2Dto<Calendar.Events.CalendarCalendarEventChangedV4EventBodyDto>), typeDiscriminator: "calendar.calendar.event.changed_v4")]
//【云文档】多维表格字段变更
[JsonDerivedType(typeof(EventV2Dto<Ccm.Events.DriveFileBitableFieldChangedV1EventBodyDto>), typeDiscriminator: "drive.file.bitable_field_changed_v1")]
//【云文档】多维表格记录变更
[JsonDerivedType(typeof(EventV2Dto<Ccm.Events.DriveFileBitableRecordChangedV1EventBodyDto>), typeDiscriminator: "drive.file.bitable_record_changed_v1")]
//【云文档】文件夹下文件创建
[JsonDerivedType(typeof(EventV2Dto<Ccm.Events.DriveFileCreatedInFolderV1EventBodyDto>), typeDiscriminator: "drive.file.created_in_folder_v1")]
//【云文档】文件编辑
[JsonDerivedType(typeof(EventV2Dto<Ccm.Events.DriveFileEditV1EventBodyDto>), typeDiscriminator: "drive.file.edit_v1")]
//【云文档】文件协作者权限申请
[JsonDerivedType(typeof(EventV2Dto<Ccm.Events.DriveFilePermissionMemberAppliedV1EventBodyDto>), typeDiscriminator: "drive.file.permission_member_applied_v1")]
//【通讯录】成员字段变更
[JsonDerivedType(typeof(EventV2Dto<Contact.Events.ContactCustomAttrEventUpdatedV3EventBodyDto>), typeDiscriminator: "contact.custom_attr_event.updated_v3")]
//【通讯录】部门新建
[JsonDerivedType(typeof(EventV2Dto<Contact.Events.ContactDepartmentCreatedV3EventBodyDto>), typeDiscriminator: "contact.department.created_v3")]
//【通讯录】部门被删除
[JsonDerivedType(typeof(EventV2Dto<Contact.Events.ContactDepartmentDeletedV3EventBodyDto>), typeDiscriminator: "contact.department.deleted_v3")]
//【通讯录】部门信息变化
[JsonDerivedType(typeof(EventV2Dto<Contact.Events.ContactDepartmentUpdatedV3EventBodyDto>), typeDiscriminator: "contact.department.updated_v3")]
//【通讯录】启用人员类型
[JsonDerivedType(typeof(EventV2Dto<Contact.Events.ContactEmployeeTypeEnumActivedV3EventBodyDto>), typeDiscriminator: "contact.employee_type_enum.actived_v3")]
//【通讯录】新建人员类型
[JsonDerivedType(typeof(EventV2Dto<Contact.Events.ContactEmployeeTypeEnumCreatedV3EventBodyDto>), typeDiscriminator: "contact.employee_type_enum.created_v3")]
//【通讯录】停用人员类型
[JsonDerivedType(typeof(EventV2Dto<Contact.Events.ContactEmployeeTypeEnumDeactivatedV3EventBodyDto>), typeDiscriminator: "contact.employee_type_enum.deactivated_v3")]
//【通讯录】删除人员类型
[JsonDerivedType(typeof(EventV2Dto<Contact.Events.ContactEmployeeTypeEnumDeletedV3EventBodyDto>), typeDiscriminator: "contact.employee_type_enum.deleted_v3")]
//【通讯录】修改人员类型名称
[JsonDerivedType(typeof(EventV2Dto<Contact.Events.ContactEmployeeTypeEnumUpdatedV3EventBodyDto>), typeDiscriminator: "contact.employee_type_enum.updated_v3")]
//【通讯录】通讯录权限范围变更
[JsonDerivedType(typeof(EventV2Dto<Contact.Events.ContactScopeUpdatedV3EventBodyDto>), typeDiscriminator: "contact.scope.updated_v3")]
//【通讯录】员工入职
[JsonDerivedType(typeof(EventV2Dto<Contact.Events.ContactUserCreatedV3EventBodyDto>), typeDiscriminator: "contact.user.created_v3")]
//【通讯录】员工离职
[JsonDerivedType(typeof(EventV2Dto<Contact.Events.ContactUserDeletedV3EventBodyDto>), typeDiscriminator: "contact.user.deleted_v3")]
//【通讯录】员工信息被修改
[JsonDerivedType(typeof(EventV2Dto<Contact.Events.ContactUserUpdatedV3EventBodyDto>), typeDiscriminator: "contact.user.updated_v3")]
//【飞书人事（企业版）】组织架构调整状态变更事件
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrApprovalGroupsUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.approval_groups.updated_v2")]
//【飞书人事（企业版）】创建公司
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrCompanyCreatedV2EventBodyDto>), typeDiscriminator: "corehr.company.created_v2")]
//【飞书人事（企业版）】删除公司
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrCompanyDeletedV2EventBodyDto>), typeDiscriminator: "corehr.company.deleted_v2")]
//【飞书人事（企业版）】更新公司
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrCompanyUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.company.updated_v2")]
//【飞书人事（企业版）】创建成本中心
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrCostCenterCreatedV2EventBodyDto>), typeDiscriminator: "corehr.cost_center.created_v2")]
//【飞书人事（企业版）】删除成本中心
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrCostCenterDeletedV2EventBodyDto>), typeDiscriminator: "corehr.cost_center.deleted_v2")]
//【飞书人事（企业版）】更新成本中心
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrCostCenterUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.cost_center.updated_v2")]
//【飞书人事（企业版）】自定义组织被创建
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrCustomOrgCreatedV2EventBodyDto>), typeDiscriminator: "corehr.custom_org.created_v2")]
//【飞书人事（企业版）】自定义组织被删除
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrCustomOrgDeletedV2EventBodyDto>), typeDiscriminator: "corehr.custom_org.deleted_v2")]
//【飞书人事（企业版）】自定义组织被更新
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrCustomOrgUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.custom_org.updated_v2")]
//【飞书人事（企业版）】创建部门V2
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrDepartmentCreatedV2EventBodyDto>), typeDiscriminator: "corehr.department.created_v2")]
//【飞书人事（企业版）】更新部门V2
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrDepartmentUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.department.updated_v2")]
//【飞书人事（企业版）】人员信息变更
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrEmployeeDomainEventV2EventBodyDto>), typeDiscriminator: "corehr.employee.domain_event_v2")]
//【飞书人事（企业版）】异动状态变更
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrJobChangeStatusUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.job_change.status_updated_v2")]
//【飞书人事（企业版）】异动信息变更
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrJobChangeUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.job_change.updated_v2")]
//【飞书人事（企业版）】创建序列
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrJobFamilyCreatedV2EventBodyDto>), typeDiscriminator: "corehr.job_family.created_v2")]
//【飞书人事（企业版）】删除序列
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrJobFamilyDeletedV2EventBodyDto>), typeDiscriminator: "corehr.job_family.deleted_v2")]
//【飞书人事（企业版）】更新序列
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrJobFamilyUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.job_family.updated_v2")]
//【飞书人事（企业版）】创建职等
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrJobGradeCreatedV2EventBodyDto>), typeDiscriminator: "corehr.job_grade.created_v2")]
//【飞书人事（企业版）】删除职等
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrJobGradeDeletedV2EventBodyDto>), typeDiscriminator: "corehr.job_grade.deleted_v2")]
//【飞书人事（企业版）】更新职等
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrJobGradeUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.job_grade.updated_v2")]
//【飞书人事（企业版）】创建职级
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrJobLevelCreatedV2EventBodyDto>), typeDiscriminator: "corehr.job_level.created_v2")]
//【飞书人事（企业版）】删除职级
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrJobLevelDeletedV2EventBodyDto>), typeDiscriminator: "corehr.job_level.deleted_v2")]
//【飞书人事（企业版）】更新职级
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrJobLevelUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.job_level.updated_v2")]
//【飞书人事（企业版）】创建地点
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrLocationCreatedV2EventBodyDto>), typeDiscriminator: "corehr.location.created_v2")]
//【飞书人事（企业版）】删除地点
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrLocationDeletedV2EventBodyDto>), typeDiscriminator: "corehr.location.deleted_v2")]
//【飞书人事（企业版）】更新地点
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrLocationUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.location.updated_v2")]
//【飞书人事（企业版）】离职流转状态变更
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrOffboardingChecklistUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.offboarding.checklist_updated_v2")]
//【飞书人事（企业版）】离职申请状态变更
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrOffboardingStatusUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.offboarding.status_updated_v2")]
//【飞书人事（企业版）】离职信息变更
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrOffboardingUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.offboarding.updated_v2")]
//【飞书人事（企业版）】通道创建
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrPathwayCreatedV2EventBodyDto>), typeDiscriminator: "corehr.pathway.created_v2")]
//【飞书人事（企业版）】通道删除
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrPathwayDeletedV2EventBodyDto>), typeDiscriminator: "corehr.pathway.deleted_v2")]
//【飞书人事（企业版）】通道更新
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrPathwayUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.pathway.updated_v2")]
//【飞书人事（企业版）】入职流程状态变更
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrPreHireOnboardingTaskChangedV2EventBodyDto>), typeDiscriminator: "corehr.pre_hire.onboarding_task_changed_v2")]
//【飞书人事（企业版）】试用期状态变更
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrProbationUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.probation.updated_v2")]
//【飞书人事（企业版）】审批任务状态变更
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrProcessApproverUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.process.approver.updated_v2")]
//【飞书人事（企业版）】抄送单据状态变更
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrProcessCcUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.process.cc.updated_v2")]
//【飞书人事（企业版）】流程节点状态变更
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrProcessNodeUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.process.node.updated_v2")]
//【飞书人事（企业版）】流程实例状态变化
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrProcessStatusUpdateV2EventBodyDto>), typeDiscriminator: "corehr.process.status.update_v2")]
//【飞书人事（企业版）】流程实例信息变更
[JsonDerivedType(typeof(EventV2Dto<Corehr.Events.CorehrProcessUpdatedV2EventBodyDto>), typeDiscriminator: "corehr.process.updated_v2")]
//【组织架构】部门新建
[JsonDerivedType(typeof(EventV2Dto<Directory.Events.DirectoryDepartmentCreatedV1EventBodyDto>), typeDiscriminator: "directory.department.created_v1")]
//【组织架构】部门被删除
[JsonDerivedType(typeof(EventV2Dto<Directory.Events.DirectoryDepartmentDeletedV1EventBodyDto>), typeDiscriminator: "directory.department.deleted_v1")]
//【组织架构】部门信息被修改
[JsonDerivedType(typeof(EventV2Dto<Directory.Events.DirectoryDepartmentUpdatedV1EventBodyDto>), typeDiscriminator: "directory.department.updated_v1")]
//【组织架构】员工入职
[JsonDerivedType(typeof(EventV2Dto<Directory.Events.DirectoryEmployeeCreatedV1EventBodyDto>), typeDiscriminator: "directory.employee.created_v1")]
//【组织架构】待离职恢复为在职
[JsonDerivedType(typeof(EventV2Dto<Directory.Events.DirectoryEmployeeRegularV1EventBodyDto>), typeDiscriminator: "directory.employee.regular_v1")]
//【组织架构】员工离职
[JsonDerivedType(typeof(EventV2Dto<Directory.Events.DirectoryEmployeeResignedV1EventBodyDto>), typeDiscriminator: "directory.employee.resigned_v1")]
//【组织架构】离职恢复在职
[JsonDerivedType(typeof(EventV2Dto<Directory.Events.DirectoryEmployeeResurrectV1EventBodyDto>), typeDiscriminator: "directory.employee.resurrect_v1")]
//【组织架构】员工被设置为待离职
[JsonDerivedType(typeof(EventV2Dto<Directory.Events.DirectoryEmployeeToBeResignedV1EventBodyDto>), typeDiscriminator: "directory.employee.to_be_resigned_v1")]
//【组织架构】员工信息被修改
[JsonDerivedType(typeof(EventV2Dto<Directory.Events.DirectoryEmployeeUpdatedV1EventBodyDto>), typeDiscriminator: "directory.employee.updated_v1")]
//【eLearning】课程学习进度新增事件
[JsonDerivedType(typeof(EventV2Dto<Elearning.Events.ElearningCourseRegistrationCreatedV2EventBodyDto>), typeDiscriminator: "elearning.course_registration.created_v2")]
//【eLearning】课程学习进度删除事件
[JsonDerivedType(typeof(EventV2Dto<Elearning.Events.ElearningCourseRegistrationDeletedV2EventBodyDto>), typeDiscriminator: "elearning.course_registration.deleted_v2")]
//【eLearning】课程学习进度更新事件
[JsonDerivedType(typeof(EventV2Dto<Elearning.Events.ElearningCourseRegistrationUpdatedV2EventBodyDto>), typeDiscriminator: "elearning.course_registration.updated_v2")]
//【飞书人事】用户ID映射变更
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrCommonDataIdUserMappingChangedV1EventBodyDto>), typeDiscriminator: "corehr.common_data.id.user_mapping_changed_v1")]
//【飞书人事】元数据信息变更
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrCommonDataMetaDataUpdatedV1EventBodyDto>), typeDiscriminator: "corehr.common_data.meta_data.updated_v1")]
//【飞书人事】合同创建
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrContractCreatedV1EventBodyDto>), typeDiscriminator: "corehr.contract.created_v1")]
//【飞书人事】合同删除
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrContractDeletedV1EventBodyDto>), typeDiscriminator: "corehr.contract.deleted_v1")]
//【飞书人事】合同更新
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrContractUpdatedV1EventBodyDto>), typeDiscriminator: "corehr.contract.updated_v1")]
//【飞书人事】创建部门
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrDepartmentCreatedV1EventBodyDto>), typeDiscriminator: "corehr.department.created_v1")]
//【飞书人事】删除部门
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrDepartmentDeletedV1EventBodyDto>), typeDiscriminator: "corehr.department.deleted_v1")]
//【飞书人事】更新部门
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrDepartmentUpdatedV1EventBodyDto>), typeDiscriminator: "corehr.department.updated_v1")]
//【飞书人事】员工完成转正
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrEmploymentConvertedV1EventBodyDto>), typeDiscriminator: "corehr.employment.converted_v1")]
//【飞书人事】【事件】创建雇佣信息
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrEmploymentCreatedV1EventBodyDto>), typeDiscriminator: "corehr.employment.created_v1")]
//【飞书人事】【事件】删除雇佣信息
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrEmploymentDeletedV1EventBodyDto>), typeDiscriminator: "corehr.employment.deleted_v1")]
//【飞书人事】员工完成离职
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrEmploymentResignedV1EventBodyDto>), typeDiscriminator: "corehr.employment.resigned_v1")]
//【飞书人事】【事件】更新雇佣信息
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrEmploymentUpdatedV1EventBodyDto>), typeDiscriminator: "corehr.employment.updated_v1")]
//【飞书人事】异动状态变更（不推荐）
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrJobChangeUpdatedV1EventBodyDto>), typeDiscriminator: "corehr.job_change.updated_v1")]
//【飞书人事】创建职务
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrJobCreatedV1EventBodyDto>), typeDiscriminator: "corehr.job.created_v1")]
//【飞书人事】员工完成异动
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrJobDataChangedV1EventBodyDto>), typeDiscriminator: "corehr.job_data.changed_v1")]
//【飞书人事】任职信息创建
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrJobDataCreatedV1EventBodyDto>), typeDiscriminator: "corehr.job_data.created_v1")]
//【飞书人事】任职信息删除
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrJobDataDeletedV1EventBodyDto>), typeDiscriminator: "corehr.job_data.deleted_v1")]
//【飞书人事】员工完成入职
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrJobDataEmployedV1EventBodyDto>), typeDiscriminator: "corehr.job_data.employed_v1")]
//【飞书人事】任职信息更新
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrJobDataUpdatedV1EventBodyDto>), typeDiscriminator: "corehr.job_data.updated_v1")]
//【飞书人事】删除职务
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrJobDeletedV1EventBodyDto>), typeDiscriminator: "corehr.job.deleted_v1")]
//【飞书人事】更新职务
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrJobUpdatedV1EventBodyDto>), typeDiscriminator: "corehr.job.updated_v1")]
//【飞书人事】离职申请状态变更（不推荐）
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrOffboardingUpdatedV1EventBodyDto>), typeDiscriminator: "corehr.offboarding.updated_v1")]
//【飞书人事】【事件】组织角色授权变更
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrOrgRoleAuthorizationUpdatedV1EventBodyDto>), typeDiscriminator: "corehr.org_role_authorization.updated_v1")]
//【飞书人事】【事件】个人信息创建
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrPersonCreatedV1EventBodyDto>), typeDiscriminator: "corehr.person.created_v1")]
//【飞书人事】【事件】个人信息删除
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrPersonDeletedV1EventBodyDto>), typeDiscriminator: "corehr.person.deleted_v1")]
//【飞书人事】【事件】更新个人信息
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrPersonUpdatedV1EventBodyDto>), typeDiscriminator: "corehr.person.updated_v1")]
//【飞书人事】入职信息变更
[JsonDerivedType(typeof(EventV2Dto<FeishuPeople.Events.CorehrPreHireUpdatedV1EventBodyDto>), typeDiscriminator: "corehr.pre_hire.updated_v1")]
//【服务台】推送审核通知
[JsonDerivedType(typeof(EventV2Dto<Helpdesk.Events.HelpdeskNotificationApproveV1EventBodyDto>), typeDiscriminator: "helpdesk.notification.approve_v1")]
//【服务台】创建工单
[JsonDerivedType(typeof(EventV2Dto<Helpdesk.Events.HelpdeskTicketCreatedV1EventBodyDto>), typeDiscriminator: "helpdesk.ticket.created_v1")]
//【服务台】工单消息事件
[JsonDerivedType(typeof(EventV2Dto<Helpdesk.Events.HelpdeskTicketMessageCreatedV1EventBodyDto>), typeDiscriminator: "helpdesk.ticket_message.created_v1")]
//【服务台】工单状态变更
[JsonDerivedType(typeof(EventV2Dto<Helpdesk.Events.HelpdeskTicketUpdatedV1EventBodyDto>), typeDiscriminator: "helpdesk.ticket.updated_v1")]
//【招聘】删除投递
[JsonDerivedType(typeof(EventV2Dto<Hire.Events.HireApplicationDeletedV1EventBodyDto>), typeDiscriminator: "hire.application.deleted_v1")]
//【招聘】投递阶段变更
[JsonDerivedType(typeof(EventV2Dto<Hire.Events.HireApplicationStageChangedV1EventBodyDto>), typeDiscriminator: "hire.application.stage_changed_v1")]
//【招聘】账号绑定
[JsonDerivedType(typeof(EventV2Dto<Hire.Events.HireEcoAccountCreatedV1EventBodyDto>), typeDiscriminator: "hire.eco_account.created_v1")]
//【招聘】终止背调
[JsonDerivedType(typeof(EventV2Dto<Hire.Events.HireEcoBackgroundCheckCanceledV1EventBodyDto>), typeDiscriminator: "hire.eco_background_check.canceled_v1")]
//【招聘】创建背调
[JsonDerivedType(typeof(EventV2Dto<Hire.Events.HireEcoBackgroundCheckCreatedV1EventBodyDto>), typeDiscriminator: "hire.eco_background_check.created_v1")]
//【招聘】创建笔试
[JsonDerivedType(typeof(EventV2Dto<Hire.Events.HireEcoExamCreatedV1EventBodyDto>), typeDiscriminator: "hire.eco_exam.created_v1")]
//【招聘】导入 e-HR（实习 Offer）
[JsonDerivedType(typeof(EventV2Dto<Hire.Events.HireEhrImportTaskForInternshipOfferImportedV1EventBodyDto>), typeDiscriminator: "hire.ehr_import_task_for_internship_offer.imported_v1")]
//【招聘】导入 e-HR
[JsonDerivedType(typeof(EventV2Dto<Hire.Events.HireEhrImportTaskImportedV1EventBodyDto>), typeDiscriminator: "hire.ehr_import_task.imported_v1")]
//【招聘】Offer 状态变更
[JsonDerivedType(typeof(EventV2Dto<Hire.Events.HireOfferStatusChangedV1EventBodyDto>), typeDiscriminator: "hire.offer.status_changed_v1")]
//【招聘】内推账户余额变更
[JsonDerivedType(typeof(EventV2Dto<Hire.Events.HireReferralAccountAssetsUpdateV1EventBodyDto>), typeDiscriminator: "hire.referral_account.assets_update_v1")]
//【招聘】删除人才
[JsonDerivedType(typeof(EventV2Dto<Hire.Events.HireTalentDeletedV1EventBodyDto>), typeDiscriminator: "hire.talent.deleted_v1")]
//【招聘】人才进展变更事件
[JsonDerivedType(typeof(EventV2Dto<Hire.Events.HireTalentTagSubscriptionV1EventBodyDto>), typeDiscriminator: "hire.talent.tag_subscription_v1")]
//【消息与群组】用户进入与机器人的会话
[JsonDerivedType(typeof(EventV2Dto<Im.Events.ImChatAccessEventBotP2pChatEnteredV1EventBodyDto>), typeDiscriminator: "im.chat.access_event.bot_p2p_chat_entered_v1")]
//【消息与群组】群解散
[JsonDerivedType(typeof(EventV2Dto<Im.Events.ImChatDisbandedV1EventBodyDto>), typeDiscriminator: "im.chat.disbanded_v1")]
//【消息与群组】机器人进群
[JsonDerivedType(typeof(EventV2Dto<Im.Events.ImChatMemberBotAddedV1EventBodyDto>), typeDiscriminator: "im.chat.member.bot.added_v1")]
//【消息与群组】机器人被移出群
[JsonDerivedType(typeof(EventV2Dto<Im.Events.ImChatMemberBotDeletedV1EventBodyDto>), typeDiscriminator: "im.chat.member.bot.deleted_v1")]
//【消息与群组】用户进群
[JsonDerivedType(typeof(EventV2Dto<Im.Events.ImChatMemberUserAddedV1EventBodyDto>), typeDiscriminator: "im.chat.member.user.added_v1")]
//【消息与群组】用户出群
[JsonDerivedType(typeof(EventV2Dto<Im.Events.ImChatMemberUserDeletedV1EventBodyDto>), typeDiscriminator: "im.chat.member.user.deleted_v1")]
//【消息与群组】撤销拉用户进群
[JsonDerivedType(typeof(EventV2Dto<Im.Events.ImChatMemberUserWithdrawnV1EventBodyDto>), typeDiscriminator: "im.chat.member.user.withdrawn_v1")]
//【消息与群组】群配置修改
[JsonDerivedType(typeof(EventV2Dto<Im.Events.ImChatUpdatedV1EventBodyDto>), typeDiscriminator: "im.chat.updated_v1")]
//【消息与群组】消息已读
[JsonDerivedType(typeof(EventV2Dto<Im.Events.ImMessageMessageReadV1EventBodyDto>), typeDiscriminator: "im.message.message_read_v1")]
//【消息与群组】新增消息表情回复
[JsonDerivedType(typeof(EventV2Dto<Im.Events.ImMessageReactionCreatedV1EventBodyDto>), typeDiscriminator: "im.message.reaction.created_v1")]
//【消息与群组】删除消息表情回复
[JsonDerivedType(typeof(EventV2Dto<Im.Events.ImMessageReactionDeletedV1EventBodyDto>), typeDiscriminator: "im.message.reaction.deleted_v1")]
//【消息与群组】撤回消息
[JsonDerivedType(typeof(EventV2Dto<Im.Events.ImMessageRecalledV1EventBodyDto>), typeDiscriminator: "im.message.recalled_v1")]
//【消息与群组】接收消息
[JsonDerivedType(typeof(EventV2Dto<Im.Events.ImMessageReceiveV1EventBodyDto>), typeDiscriminator: "im.message.receive_v1")]
//【邮箱】收信通知
[JsonDerivedType(typeof(EventV2Dto<Mail.Events.MailUserMailboxEventMessageReceivedV1EventBodyDto>), typeDiscriminator: "mail.user_mailbox.event.message_received_v1")]
//【会议室】会议室创建
[JsonDerivedType(typeof(EventV2Dto<MeetingRoom.Events.MeetingRoomMeetingRoomCreatedV1EventBodyDto>), typeDiscriminator: "meeting_room.meeting_room.created_v1")]
//【会议室】会议室删除
[JsonDerivedType(typeof(EventV2Dto<MeetingRoom.Events.MeetingRoomMeetingRoomDeletedV1EventBodyDto>), typeDiscriminator: "meeting_room.meeting_room.deleted_v1")]
//【会议室】会议室状态信息变更
[JsonDerivedType(typeof(EventV2Dto<MeetingRoom.Events.MeetingRoomMeetingRoomStatusChangedV1EventBodyDto>), typeDiscriminator: "meeting_room.meeting_room.status_changed_v1")]
//【会议室】会议室属性变更
[JsonDerivedType(typeof(EventV2Dto<MeetingRoom.Events.MeetingRoomMeetingRoomUpdatedV1EventBodyDto>), typeDiscriminator: "meeting_room.meeting_room.updated_v1")]
//【公司圈】发布评论
[JsonDerivedType(typeof(EventV2Dto<Moments.Events.MomentsCommentCreatedV1EventBodyDto>), typeDiscriminator: "moments.comment.created_v1")]
//【公司圈】删除评论
[JsonDerivedType(typeof(EventV2Dto<Moments.Events.MomentsCommentDeletedV1EventBodyDto>), typeDiscriminator: "moments.comment.deleted_v1")]
//【公司圈】发布帖子
[JsonDerivedType(typeof(EventV2Dto<Moments.Events.MomentsPostCreatedV1EventBodyDto>), typeDiscriminator: "moments.post.created_v1")]
//【公司圈】删除帖子
[JsonDerivedType(typeof(EventV2Dto<Moments.Events.MomentsPostDeletedV1EventBodyDto>), typeDiscriminator: "moments.post.deleted_v1")]
//【公司圈】帖子统计数据变更
[JsonDerivedType(typeof(EventV2Dto<Moments.Events.MomentsPostStatisticsUpdatedV1EventBodyDto>), typeDiscriminator: "moments.post_statistics.updated_v1")]
//【公司圈】表情互动
[JsonDerivedType(typeof(EventV2Dto<Moments.Events.MomentsReactionCreatedV1EventBodyDto>), typeDiscriminator: "moments.reaction.created_v1")]
//【公司圈】取消表情互动
[JsonDerivedType(typeof(EventV2Dto<Moments.Events.MomentsReactionDeletedV1EventBodyDto>), typeDiscriminator: "moments.reaction.deleted_v1")]
//【Payroll】发薪活动封存
[JsonDerivedType(typeof(EventV2Dto<Payroll.Events.PayrollPaymentActivityApprovedV1EventBodyDto>), typeDiscriminator: "payroll.payment_activity.approved_v1")]
//【Payroll】发薪活动变更
[JsonDerivedType(typeof(EventV2Dto<Payroll.Events.PayrollPaymentActivityStatusChangedV1EventBodyDto>), typeDiscriminator: "payroll.payment_activity.status_changed_v1")]
//【绩效】绩效详情变更
[JsonDerivedType(typeof(EventV2Dto<Performance.Events.PerformanceReviewDataChangedV2EventBodyDto>), typeDiscriminator: "performance.review_data.changed_v2")]
//【绩效】绩效结果开通
[JsonDerivedType(typeof(EventV2Dto<Performance.Events.PerformanceStageTaskOpenResultV2EventBodyDto>), typeDiscriminator: "performance.stage_task.open_result_v2")]
//【任务】任务评论信息变更
[JsonDerivedType(typeof(EventV2Dto<Task.Events.TaskTaskCommentUpdatedV1EventBodyDto>), typeDiscriminator: "task.task.comment.updated_v1")]
//【任务】任务信息变更（应用维度）
[JsonDerivedType(typeof(EventV2Dto<Task.Events.TaskTaskUpdatedV1EventBodyDto>), typeDiscriminator: "task.task.updated_v1")]
//【任务】任务信息变更（租户维度）
[JsonDerivedType(typeof(EventV2Dto<Task.Events.TaskTaskUpdateTenantV1EventBodyDto>), typeDiscriminator: "task.task.update_tenant_v1")]
//【视频会议】企业会议结束
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcMeetingAllMeetingEndedV1EventBodyDto>), typeDiscriminator: "vc.meeting.all_meeting_ended_v1")]
//【视频会议】企业会议开始
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcMeetingAllMeetingStartedV1EventBodyDto>), typeDiscriminator: "vc.meeting.all_meeting_started_v1")]
//【视频会议】加入会议
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcMeetingJoinMeetingV1EventBodyDto>), typeDiscriminator: "vc.meeting.join_meeting_v1")]
//【视频会议】离开会议
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcMeetingLeaveMeetingV1EventBodyDto>), typeDiscriminator: "vc.meeting.leave_meeting_v1")]
//【视频会议】会议结束
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcMeetingMeetingEndedV1EventBodyDto>), typeDiscriminator: "vc.meeting.meeting_ended_v1")]
//【视频会议】会议开始
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcMeetingMeetingStartedV1EventBodyDto>), typeDiscriminator: "vc.meeting.meeting_started_v1")]
//【视频会议】停止录制
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcMeetingRecordingEndedV1EventBodyDto>), typeDiscriminator: "vc.meeting.recording_ended_v1")]
//【视频会议】录制完成
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcMeetingRecordingReadyV1EventBodyDto>), typeDiscriminator: "vc.meeting.recording_ready_v1")]
//【视频会议】开始录制
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcMeetingRecordingStartedV1EventBodyDto>), typeDiscriminator: "vc.meeting.recording_started_v1")]
//【视频会议】结束屏幕共享
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcMeetingShareEndedV1EventBodyDto>), typeDiscriminator: "vc.meeting.share_ended_v1")]
//【视频会议】开始屏幕共享
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcMeetingShareStartedV1EventBodyDto>), typeDiscriminator: "vc.meeting.share_started_v1")]
//【视频会议】更新会议室预定限制
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcReserveConfigUpdatedV1EventBodyDto>), typeDiscriminator: "vc.reserve_config.updated_v1")]
//【视频会议】创建会议室
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcRoomCreatedV1EventBodyDto>), typeDiscriminator: "vc.room.created_v1")]
//【视频会议】删除会议室
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcRoomDeletedV1EventBodyDto>), typeDiscriminator: "vc.room.deleted_v1")]
//【视频会议】创建会议室层级
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcRoomLevelCreatedV1EventBodyDto>), typeDiscriminator: "vc.room_level.created_v1")]
//【视频会议】删除会议室层级
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcRoomLevelDeletedV1EventBodyDto>), typeDiscriminator: "vc.room_level.deleted_v1")]
//【视频会议】更新会议室层级
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcRoomLevelUpdatedV1EventBodyDto>), typeDiscriminator: "vc.room_level.updated_v1")]
//【视频会议】更新会议室
[JsonDerivedType(typeof(EventV2Dto<Vc.Events.VcRoomUpdatedV1EventBodyDto>), typeDiscriminator: "vc.room.updated_v1")]
//【云文档】文件彻底删除
[JsonDerivedType(typeof(ResourceEventV2Dto<Ccm.Events.DriveFileDeletedV1EventBodyDto>), typeDiscriminator: "drive.file.deleted_v1")]
//【云文档】文件协作者添加
[JsonDerivedType(typeof(ResourceEventV2Dto<Ccm.Events.DriveFilePermissionMemberAddedV1EventBodyDto>), typeDiscriminator: "drive.file.permission_member_added_v1")]
//【云文档】文件协作者移除
[JsonDerivedType(typeof(ResourceEventV2Dto<Ccm.Events.DriveFilePermissionMemberRemovedV1EventBodyDto>), typeDiscriminator: "drive.file.permission_member_removed_v1")]
//【云文档】文件已读
[JsonDerivedType(typeof(ResourceEventV2Dto<Ccm.Events.DriveFileReadV1EventBodyDto>), typeDiscriminator: "drive.file.read_v1")]
//【云文档】文件标题变更
[JsonDerivedType(typeof(ResourceEventV2Dto<Ccm.Events.DriveFileTitleUpdatedV1EventBodyDto>), typeDiscriminator: "drive.file.title_updated_v1")]
//【云文档】文件删除到回收站
[JsonDerivedType(typeof(ResourceEventV2Dto<Ccm.Events.DriveFileTrashedV1EventBodyDto>), typeDiscriminator: "drive.file.trashed_v1")]
public record EventDto
{
    /// <summary>类型鉴别器</summary>
    [JsonPropertyName(FeishuNetSdkOptions.Discriminator), JsonPropertyOrder(-1)]
    public virtual string? Discriminator { get; set; }

    /// <summary>事件 Token，即Verification Token。用于验证来自于同一个应用</summary>
    [JsonPropertyName("token")]
    public virtual string Token { get; set; } = string.Empty;

    /// <summary>事件唯一Id</summary>
    [JsonPropertyName("event_id")]
    public virtual string EventId { get; set; } = string.Empty;
}
