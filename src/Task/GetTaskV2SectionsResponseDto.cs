using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 获取自定义分组列表 响应体
/// <para>获取一个资源下所有的自定义分组列表。支持分页。返回结果按照自定义分组在界面上的顺序排序。</para>
/// <para>接口ID：7259330038033874972</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/section/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fsection%2flist</para>
/// </summary>
public record GetTaskV2SectionsResponseDto
{
    /// <summary>
    /// <para>自定义分组的摘要列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public SectionSummary[]? Items { get; set; }

    /// <summary>
    /// <para>自定义分组的摘要列表</para>
    /// </summary>
    public record SectionSummary
    {
        /// <summary>
        /// <para>自定义分组的全局唯一ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
        /// </summary>
        [JsonProperty("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>自定义分组的名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：审核过的任务</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>是否是默认分组</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：aWQ9NzEwMjMzMjMxMDE=</para>
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
