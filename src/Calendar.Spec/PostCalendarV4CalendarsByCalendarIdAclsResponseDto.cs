using Newtonsoft.Json;
namespace FeishuNetSdk.Calendar.Spec;
/// <summary>
/// 创建访问控制 响应体
/// <para>该接口用于以当前身份（应用 / 用户）给日历添加访问控制权限，即日历成员。</para>
/// <para>身份由 Header Authorization 的 Token 类型决定。</para>
/// <para>接口ID：6952888507002814491</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-acl/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-acl%2fcreate</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdAclsResponseDto
{
    /// <summary>
    /// <para>acl资源ID。参见[ACL ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-acl/introduction)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("acl_id")]
    public string? AclId { get; set; }

    /// <summary>
    /// <para>对日历的访问权限</para>
    /// <para>**可选值有**：</para>
    /// <para>unknown:未知权限,free_busy_reader:游客，只能看到忙碌/空闲信息,reader:订阅者，查看所有日程详情,writer:编辑者，创建及修改日程,owner:管理员，管理日历及共享设置</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>unknown：未知权限</item>
    /// <item>free_busy_reader：游客，只能看到忙碌/空闲信息</item>
    /// <item>reader：订阅者，查看所有日程详情</item>
    /// <item>writer：编辑者，创建及修改日程</item>
    /// <item>owner：管理员，管理日历及共享设置</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("role")]
    public string? Role { get; set; }

    /// <summary>
    /// <para>权限范围</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("scope")]
    public AclScope? Scope { get; set; }

    /// <summary></summary>
    public record AclScope
    {
        /// <summary>
        /// <para>权限类型，当type为User时，值为open_id/user_id/union_id</para>
        /// <para>**可选值有**：</para>
        /// <para>user:用户</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：用户</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>用户ID，参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}
