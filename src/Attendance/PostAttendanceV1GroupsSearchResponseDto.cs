namespace FeishuNetSdk.Attendance;
/// <summary>
/// 按名称查询考勤组 响应体
/// <para>按考勤组名称查询考勤组摘要信息。查询条件支持名称精确匹配和模糊匹配两种方式。查询结果按考勤组修改时间 desc 排序，且最大记录数为 10 条。</para>
/// <para>接口ID：7044467124773781505</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/group/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fgroup%2fsearch</para>
/// </summary>
public record PostAttendanceV1GroupsSearchResponseDto
{
    /// <summary>
    /// <para>考勤组列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("group_list")]
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
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// <para>考勤组名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：考勤组1</para>
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; } = string.Empty;
    }
}
