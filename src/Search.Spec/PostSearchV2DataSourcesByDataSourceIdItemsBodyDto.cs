using Newtonsoft.Json;
namespace FeishuNetSdk.Search.Spec;
/// <summary>
/// 为指定数据项创建索引 请求体
/// <para>索引一条数据记录。</para>
/// <para>接口ID：6953505452630163459</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/data_source-item/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdata_source-item%2fcreate</para>
/// </summary>
public record PostSearchV2DataSourcesByDataSourceIdItemsBodyDto
{
    /// <summary>
    /// <para>item 在 datasource 中的唯一标识，只允许英文字母、数字和下划线</para>
    /// <para>**示例值**："my_item_01010111"</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 最大长度：`128` 字符</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// <para>item 的访问权限控制。 acl 字段为空数组，则默认数据不可见。如果数据是全员可见，需要设置 access="allow"; type="user"; value="everyone"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("acl")]
    public AclSuffix[] Acl { get; set; } = Array.Empty<AclSuffix>();

    public record AclSuffix
    {
        /// <summary>
        /// <para>权限类型，优先级：Deny &gt; Allow。</para>
        /// <para>**示例值**："allow"</para>
        /// <para>**可选值有**：</para>
        /// <para>allow:允许访问,deny:禁止访问</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>allow：允许访问</item>
        /// <item>deny：禁止访问</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("access")]
        public string? Access { get; set; }

        /// <summary>
        /// <para>设置的权限值，例如 userID ，依赖 type 描述。</para>
        /// <para>**注**：在 type 为 user 且 access 为 allow 时，可填 "everyone" 来表示该数据项对全员可见；</para>
        /// <para>**示例值**："d35e3c23"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// <para>权限值类型</para>
        /// <para>**示例值**："user"</para>
        /// <para>**可选值有**：</para>
        /// <para>user:访问权限控制中指定“用户”可以访问或拒绝访问该条数据,group:(已下线)访问权限控制中指定“用户组”可以访问或拒绝访问该条数据,open_id:用户的open_id</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：访问权限控制中指定“用户”可以访问或拒绝访问该条数据</item>
        /// <item>group：(已下线)访问权限控制中指定“用户组”可以访问或拒绝访问该条数据</item>
        /// <item>open_id：用户的open_id</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

    }

    /// <summary>
    /// <para>item 的元信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("metadata")]
    public ItemMetadata Metadata { get; set; } = new();

    public record ItemMetadata
    {
        /// <summary>
        /// <para>该条数据记录对应的标题</para>
        /// <para>**示例值**："工单：无法创建文章"</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// <para>该条数据记录对应的跳转url</para>
        /// <para>**示例值**："http://www.abc.com.cn"</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("source_url")]
        public string SourceUrl { get; set; } = string.Empty;

        /// <summary>
        /// <para>数据项的创建时间。Unix 时间，单位为秒</para>
        /// <para>**示例值**：1618831236</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// <para>数据项的更新时间。Unix 时间，单位为秒</para>
        /// <para>**示例值**：1618831236</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("update_time")]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// <para>移动端搜索命中的跳转地址。如果您PC端和移动端有不同的跳转地址，可以在这里写入移动端专用的url，我们会在搜索时为您选择合适的地址</para>
        /// <para>**示例值**："https://www.feishu.cn"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("source_url_mobile")]
        public string? SourceUrlMobile { get; set; }
    }

    /// <summary>
    /// <para>结构化数据（以 json 字符串传递），这些字段是搜索结果的展示字段(特殊字段无须在此另外指定);具体格式可参参考 [接入指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/search-v2/common-template-intergration-handbook) **请求创建数据项**部分。这里的示例遵循了”创建数据范式“部分中的数据范式示例，请按自己定义的数据范式填写数据</para>
    /// <para>**示例值**："{"description":"问题出现的环境和复现方法描述……", "priority":"HIGH"}"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("structured_data")]
    public string StructuredData { get; set; } = string.Empty;

    /// <summary>
    /// <para>非结构化数据，如文档文本，飞书搜索会用来做召回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("content")]
    public ItemContent? Content { get; set; }

    public record ItemContent
    {
        /// <summary>
        /// <para>内容的格式</para>
        /// <para>**示例值**："html"</para>
        /// <para>**可选值有**：</para>
        /// <para>html:html格式,plaintext:纯文本格式</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>html：html格式</item>
        /// <item>plaintext：纯文本格式</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("format")]
        public string? Format { get; set; }

        /// <summary>
        /// <para>全文数据</para>
        /// <para>**示例值**："这是一个很长的文本"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("content_data")]
        public string? ContentData { get; set; }
    }
}
