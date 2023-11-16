namespace FeishuNetSdk.Task;
/// <summary>
/// 更新自定义分组 请求体
/// <para>更新自定义分组，可以更新自定义分组的名称和位置。</para>
/// <para>更新时，将`update_fields`字段中填写所有要修改的字段名，同时在`section`字段中填写要修改的字段的新值即可。调用约定详情见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 关于资源的更新”章节。</para>
/// <para>目前支持更新的字段包括：</para>
/// <para>* `name` - 自定义字段名字;</para>
/// <para>* `insert_before` - 要让当前自定义分组放到某个自定义分组前面的secion_guid，用于改变当前自定义分组的位置;</para>
/// <para>* `insert_after` - 要让当前自定义分组放到某个自定义分组后面的secion_guid，用于改变当前自定义分组的位置。</para>
/// <para>`insert_before`和`insert_after`如果填写，必须是同一个资源的合法section_guid。注意不能同时设置`insert_before`和`insert_after`。</para>
/// <para>接口ID：7259330038033842204</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/section/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fsection%2fpatch</para>
/// </summary>
public record PatchTaskV2SectionsBySectionGuidBodyDto
{
    /// <summary>
    /// <para>要更新的自定义分组的数据。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("section")]
    public InputSection Section { get; set; } = new();

    /// <summary>
    /// <para>要更新的自定义分组的数据。</para>
    /// </summary>
    public record InputSection
    {
        /// <summary>
        /// <para>自定义分组名。如更新，不允许设为空，支持最大100个utf8字符。</para>
        /// <para>必填：否</para>
        /// <para>示例值：已经审核过的任务</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>要将新分组插入到自定义分分组的前面的目标分组的guid。</para>
        /// <para>必填：否</para>
        /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("insert_before")]
        public string? InsertBefore { get; set; }

        /// <summary>
        /// <para>要将新分组插入到自定义分分组的后面的目标分组的guid。</para>
        /// <para>必填：否</para>
        /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("insert_after")]
        public string? InsertAfter { get; set; }
    }

    /// <summary>
    /// <para>要更新的字段名，支持：</para>
    /// <para>* `name` - 自定义字段名字</para>
    /// <para>* `insert_before` - 要让当前自定义分组放到某个自定义分组前面的secion_guid，用于改变当前自定义分组的位置。</para>
    /// <para>* `insert_after` - 要让当前自定义分组放到某个自定义分组后面的secion_guid，用于改变当前自定义分组的位置。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// </summary>
    [JsonPropertyName("update_fields")]
    public string[] UpdateFields { get; set; } = Array.Empty<string>();
}
