namespace FeishuNetSdk.Base;
/// <summary>
/// 列出仪表盘 响应体
/// <para>根据 app_token，获取多维表格下的所有仪表盘</para>
/// <para>接口ID：7127206859065638914</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-dashboard/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-dashboard%2flist</para>
/// </summary>
public record GetBitableV1AppsByAppTokenDashboardsResponseDto
{
    /// <summary>
    /// <para>仪表盘信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("dashboards")]
    public AppDashboard[] Dashboards { get; set; } = Array.Empty<AppDashboard>();

    /// <summary>
    /// <para>仪表盘信息</para>
    /// </summary>
    public record AppDashboard
    {
        /// <summary>
        /// <para>仪表盘 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：blknkqrP3RqUkcAW</para>
        /// </summary>
        [JsonPropertyName("block_id")]
        public string BlockId { get; set; } = string.Empty;

        /// <summary>
        /// <para>仪表盘名字</para>
        /// <para>必填：是</para>
        /// <para>示例值：仪表盘1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：blknkqrP3RqUkcAW</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string PageToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }
}
