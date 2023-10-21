using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 创建自定义分组 请求体
/// <para>为清单或我负责的任务列表创建一个自定义分组。创建时可以需要提供名称和可选的配置。如果不指定位置，新分组会放到指定resource的自定义分组列表的最后。</para>
/// <para>当在清单中创建自定义分组时，需要设置`resourse_type`为"tasklist", `resource_id`设为清单的GUID。</para>
/// <para>当为我负责任务列表中创建自定义分组时，需要设置`resource_type`为"my_tasks"，不需要设置`resource_id`。调用身份只能为自己的我负责的任务列表创建自定义分组。</para>
/// <para>接口ID：7259330038033809436</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/section/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fsection%2fcreate</para>
/// </summary>
public record PostTaskV2SectionsBodyDto
{
    /// <summary>
    /// <para>自定义分组名。不允许为空，最大100个utf8字符。</para>
    /// <para>必填：是</para>
    /// <para>示例值：已经审核过的任务</para>
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义分组的资源类型，支持"tasklist"（清单）或者"my_tasks"（我负责的）。</para>
    /// <para>必填：是</para>
    /// <para>示例值：tasklist</para>
    /// <para>默认值：tasklist</para>
    /// </summary>
    [JsonProperty("resource_type")]
    public string ResourceType { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义分组要归属的资源id。当`resource_type`为"tasklist"时这里需要填写清单的GUID；当`resource_type`为"my_tasks"时，无需填写。</para>
    /// <para>必填：否</para>
    /// <para>示例值：cc371766-6584-cf50-a222-c22cd9055004</para>
    /// </summary>
    [JsonProperty("resource_id")]
    public string? ResourceId { get; set; }

    /// <summary>
    /// <para>要将新分组插入到自定义分分组的前面的目标分组的guid。</para>
    /// <para>`insert_before`和`insert_after`均不设置时表示将新分组放到已有的所有自定义分组之后。</para>
    /// <para>如果同时设置`insert_before`和`insert_after`，接口会报错。</para>
    /// <para>必填：否</para>
    /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("insert_before")]
    public string? InsertBefore { get; set; }

    /// <summary>
    /// <para>要将新分组插入到自定义分分组的后面的目标分组的guid。</para>
    /// <para>`insert_before`和`insert_after`均不设置时表示将新分组放到已有的所有自定义分组之后。</para>
    /// <para>如果同时设置`insert_before`和`insert_after`，接口会报错。</para>
    /// <para>必填：否</para>
    /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("insert_after")]
    public string? InsertAfter { get; set; }
}
