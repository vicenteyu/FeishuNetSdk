// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="DriveFilePermissionMemberAppliedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>文件协作者权限申请 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Events;
/// <summary>
/// 文件协作者权限申请 事件体
/// <para>当用户发起申请文件协作者权限时将触发此事件，协作者权限包括阅读、编辑和管理权限。</para>
/// <para>{使用示例}(url=/api/tools/api_explore/api_explore_config?project=drive&amp;version=v1&amp;resource=file&amp;event=permission_member_applied)</para>
/// <para>接口ID：7444011024166748164</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/events/permission_member_applied</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fevents%2fpermission_member_applied</para>
/// </summary>
public record DriveFilePermissionMemberAppliedV1EventBodyDto() : EventBodyDto("drive.file.permission_member_applied_v1")
{
    /// <summary>
    /// <para>文件对应的类型，与文件的 file_token 相匹配。</para>
    /// <para>**可选值有**：</para>
    /// <para>doc:旧版文档,sheet:电子表格,bitable:多维表格,docx:新版文档</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `50` 字符</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doc：旧版文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("file_type")]
    public string? FileType { get; set; }

    /// <summary>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`22` ～ `27` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string? FileToken { get; set; }

    /// <summary>
    /// <para>发起权限申请的操作人的 ID，可以是替操作人自己申请权限，也可以是替其他人申请权限</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }

    /// <summary>
    /// <para>审批人 ID。即收到协作者权限申请、负责处理该申请的用户 ID，一般是文件的所有者</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approver_id")]
    public UserIdSuffix? ApproverId { get; set; }

    /// <summary>
    /// <para>申请授权的用户 ID 列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `100`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("application_user_list")]
    public UserIdSuffix[]? ApplicationUserList { get; set; }

    /// <summary>
    /// <para>申请授权的群 open_chat_id 列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `100`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("application_chat_list")]
    public string[]? ApplicationChatList { get; set; }

    /// <summary>
    /// <para>申请授权的组织架构 open_department_id 列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `100`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("application_department_list")]
    public string[]? ApplicationDepartmentList { get; set; }

    /// <summary>
    /// <para>申请的协作者权限</para>
    /// <para>**可选值有**：</para>
    /// <para>view:可阅读权限角色,edit:可编辑权限角色,full_access:可管理权限角色</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `27` 字符</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>view：可阅读权限角色</item>
    /// <item>edit：可编辑权限角色</item>
    /// <item>full_access：可管理权限角色</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary>
    /// <para>订阅用户 ID 列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `100`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("subscriber_ids")]
    public UserIdSuffix[]? SubscriberIds { get; set; }
}
