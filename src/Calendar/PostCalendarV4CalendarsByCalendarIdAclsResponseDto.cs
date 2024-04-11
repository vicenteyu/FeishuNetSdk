namespace FeishuNetSdk.Calendar;
/// <summary>
/// 创建访问控制 响应体
/// <para>调用该接口以当前身份（应用或用户）为指定日历添加访问控制，即日历成员权限。</para>
/// <para>接口ID：6952888507002814491</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-acl/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-acl%2fcreate</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdAclsResponseDto
{
    /// <summary>
    /// <para>访问控制 ID。该 ID 在单个日历实体内唯一，不同日历实体可能存在重复的访问控制 ID。</para>
    /// <para>必填：是</para>
    /// <para>示例值：user_xxxxxx</para>
    /// </summary>
    [JsonPropertyName("acl_id")]
    public string AclId { get; set; } = string.Empty;

    /// <summary>
    /// <para>对日历的访问权限。</para>
    /// <para>必填：是</para>
    /// <para>示例值：writer</para>
    /// <para>可选值：<list type="bullet">
    /// <item>unknown：未知权限。</item>
    /// <item>free_busy_reader：游客，只能看到忙碌、空闲信息。</item>
    /// <item>reader：订阅者，可查看所有日程详情。</item>
    /// <item>writer：编辑者，可创建及修改日程。</item>
    /// <item>owner：管理员，可管理日历及共享设置。</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("role")]
    public string Role { get; set; } = string.Empty;

    /// <summary>
    /// <para>权限生效范围。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("scope")]
    public AclScope Scope { get; set; } = new();

    /// <summary>
    /// <para>权限生效范围。</para>
    /// </summary>
    public record AclScope
    {
        /// <summary>
        /// <para>权限生效范围的类型。</para>
        /// <para>必填：是</para>
        /// <para>示例值：user</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：用户</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户 ID，更多介绍可参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxxx</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
    }
}
