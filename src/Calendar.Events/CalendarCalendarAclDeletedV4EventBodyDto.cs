// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CalendarCalendarAclDeletedV4EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除 ACL 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar.Events;
/// <summary>
/// 删除 ACL 事件体
/// <para>当订阅的日历上有访问控制被删除时，将会触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=calendar&amp;version=v4&amp;resource=calendar.acl&amp;event=deleted)</para>
/// <para>接口ID：7002206318614593540</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-acl/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-acl%2fevents%2fdeleted</para>
/// </summary>
public record CalendarCalendarAclDeletedV4EventBodyDto() : EventBodyDto("calendar.calendar.acl.deleted_v4")
{
    /// <summary>
    /// <para>访问控制 ID。该 ID 在单个日历实体内唯一，不同日历实体可能存在重复的访问控制 ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("acl_id")]
    public string? AclId { get; set; }

    /// <summary>
    /// <para>对日历的访问权限。</para>
    /// <para>**可选值有**：</para>
    /// <para>unknown:未知权限。,free_busy_reader:游客，只能看到忙碌、空闲信息。,reader:订阅者，可查看所有日程详情。,writer:编辑者，可创建及修改日程。,owner:管理员，可管理日历及共享设置。</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>unknown：未知权限。</item>
    /// <item>free_busy_reader：游客，只能看到忙碌、空闲信息。</item>
    /// <item>reader：订阅者，可查看所有日程详情。</item>
    /// <item>writer：编辑者，可创建及修改日程。</item>
    /// <item>owner：管理员，可管理日历及共享设置。</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// <para>权限生效范围。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("scope")]
    public AclScopeEvent? Scope { get; set; }

    /// <summary></summary>
    public record AclScopeEvent
    {
        /// <summary>
        /// <para>权限生效范围的类型。</para>
        /// <para>**可选值有**：</para>
        /// <para>user:用户</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：用户</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public UserIdSuffix? UserId { get; set; }
    }

    /// <summary>
    /// <para>需要推送事件的用户列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id_list")]
    public UserIdSuffix[]? UserIdList { get; set; }
}
