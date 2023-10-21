using Newtonsoft.Json;
namespace FeishuNetSdk.Calendar.Spec;
/// <summary>
/// 获取访问控制列表 响应体
/// <para>该接口用于以当前身份（应用 / 用户）获取日历的控制权限列表。</para>
/// <para>身份由 Header Authorization 的 Token 类型决定。</para>
/// <para>接口ID：6953067803433009153</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-acl/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-acl%2flist</para>
/// </summary>
public record GetCalendarV4CalendarsByCalendarIdAclsResponseDto
{
    /// <summary>
    /// <para>入参日历对应的acl列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("acls")]
    public CalendarAcl[]? Acls { get; set; }

    public record CalendarAcl
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

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }
}
