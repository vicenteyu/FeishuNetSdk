using Newtonsoft.Json;
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询所有考勤组 响应体
/// <para>翻页获取所有考勤组列表。</para>
/// <para>接口ID：7098332552943697922</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/group/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fgroup%2flist</para>
/// </summary>
public record GetAttendanceV1GroupsResponseDto
{
    /// <summary>
    /// <para>考勤组列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("group_list")]
    public GroupMeta[]? GroupLists { get; set; }

    /// <summary>
    /// <para>考勤组列表</para>
    /// </summary>
    public record GroupMeta
    {
        /// <summary>
        /// <para>考勤组 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6919358128597097404</para>
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// <para>考勤组名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：考勤组1</para>
        /// </summary>
        [JsonProperty("group_name")]
        public string GroupName { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：wgNOR1rmxogRvAsGl6CXlQ==</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
