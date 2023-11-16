namespace FeishuNetSdk.Base;
/// <summary>
/// 新增视图 响应体
/// <para>在数据表中新增一个视图</para>
/// <para>接口ID：6978670625209614338</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-view/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-view%2fcreate</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdViewsResponseDto
{
    /// <summary>
    /// <para>视图</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("view")]
    public AppTableView? View { get; set; }

    /// <summary>
    /// <para>视图</para>
    /// </summary>
    public record AppTableView
    {
        /// <summary>
        /// <para>视图Id</para>
        /// <para>必填：否</para>
        /// <para>示例值：vewTpR1urY</para>
        /// </summary>
        [JsonPropertyName("view_id")]
        public string? ViewId { get; set; }

        /// <summary>
        /// <para>视图名字</para>
        /// <para>必填：否</para>
        /// <para>示例值：甘特视图1</para>
        /// </summary>
        [JsonPropertyName("view_name")]
        public string? ViewName { get; set; }

        /// <summary>
        /// <para>视图类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：gantt</para>
        /// </summary>
        [JsonPropertyName("view_type")]
        public string? ViewType { get; set; }
    }
}
