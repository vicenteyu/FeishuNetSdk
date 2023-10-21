using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取自定义字段列表 响应体
/// <para>获取「飞书人事」具体对象下的自定义字段列表。注：在「人员档案信息配置」-「个人信息」功能中添加的分组，实际上是一个自定义对象，可以通过该接口查询自定义对象的所有字段。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://bytedance.feishu.cn/docx/UZYmdBj1ho8RPixJwlKcpkzQn2b)</para>
/// <para>接口ID：7112009113388122140</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcustom_field%2fquery</para>
/// </summary>
public record GetCorehrV1CustomFieldsQueryResponseDto
{
    /// <summary>
    /// <para>自定义字段列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public CustomField[]? Items { get; set; }

    /// <summary>
    /// <para>自定义字段列表</para>
    /// </summary>
    public record CustomField
    {
        /// <summary>
        /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：custom_field_33</para>
        /// </summary>
        [JsonProperty("custom_api_name")]
        public string? CustomApiName { get; set; }

        /// <summary>
        /// <para>自定义字段名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("name")]
        public CustomFieldName Name { get; set; } = new();

        /// <summary>
        /// <para>自定义字段名称</para>
        /// </summary>
        public record CustomFieldName
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：cn</para>
            /// </summary>
            [JsonProperty("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：en</para>
            /// </summary>
            [JsonProperty("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("description")]
        public NameSuffix Description { get; set; } = new();

        /// <summary>
        /// <para>描述</para>
        /// </summary>
        public record NameSuffix
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：cn</para>
            /// </summary>
            [JsonProperty("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：en</para>
            /// </summary>
            [JsonProperty("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("is_open")]
        public bool IsOpen { get; set; }

        /// <summary>
        /// <para>是否必填</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("is_required")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// <para>是否唯一</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("is_unique")]
        public bool IsUnique { get; set; }

        /// <summary>
        /// <para>所属对象 apiname</para>
        /// <para>必填：是</para>
        /// <para>示例值：offboarding_info</para>
        /// </summary>
        [JsonProperty("object_api_name")]
        public string ObjectApiName { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义字段类型</para>
        /// <para>可选值有：</para>
        /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
        /// <para>- 2：布尔 Boolean</para>
        /// <para>- 3：数字 Number</para>
        /// <para>- 4：枚举 Option，“单选”和“多选”为该类型</para>
        /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组为该类型</para>
        /// <para>- 7：日期时间 Date time</para>
        /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// <para>创建时间，秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625542287</para>
        /// </summary>
        [JsonProperty("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间，秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625542639</para>
        /// </summary>
        [JsonProperty("update_time")]
        public string? UpdateTime { get; set; }
    }
}
