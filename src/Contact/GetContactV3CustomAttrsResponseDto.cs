// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3CustomAttrsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取企业自定义用户字段 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取企业自定义用户字段 响应体
/// <para>调用该接口查询当前企业内自定义用户字段的配置信息。</para>
/// <para>## 使用限制</para>
/// <para>- 仅当企业管理员在[管理后台](https://feishu.cn/admin/index) &gt; **组织架构** &gt; **字段管理** 页面添加了自定义用户字段，并且在 **API 调用设置** 中开启了 **允许开放平台通讯录 API 调用** 开关，当前接口才会获取到自定义用户字段数据。</para>
/// <para>- 仅可获取字段来源为 **通用信息** 的自定义用户字段数据。如果字段来源为 **人事**，则无法通过该接口查询到对应的数据。</para>
/// <para>- 仅可获取字段归属为 **成员** 的自定义字段数据。如果字段归属为 **部门**，则无法通过该接口查询到对应的数据。</para>
/// <para>接口ID：6986108081861476354</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/custom_attr/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fcustom_attr%2flist</para>
/// </summary>
public record GetContactV3CustomAttrsResponseDto : IPageableResponse<GetContactV3CustomAttrsResponseDto.CustomAttr>
{
    /// <summary>
    /// <para>自定义字段信息集合。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CustomAttr[]? Items { get; set; }

    /// <summary>
    /// <para>自定义字段信息集合。</para>
    /// </summary>
    public record CustomAttr
    {
        /// <summary>
        /// <para>自定义字段 ID。</para>
        /// <para>必填：是</para>
        /// <para>示例值：C-6965457429001748507</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义字段类型。</para>
        /// <para>**可能值有：**</para>
        /// <para>- `TEXT`：文本类型</para>
        /// <para>- `HREF`：网页类型</para>
        /// <para>- `ENUMERATION`：枚举类型</para>
        /// <para>- `GENERIC_USER`：用户类型</para>
        /// <para>- `PICTURE_ENUM`：图片类型</para>
        /// <para>关于自定义字段类型的更多信息，可参见[自定义用户字段资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/custom_attr/overview)。</para>
        /// <para>必填：是</para>
        /// <para>示例值：TEXT</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>选项定义，当 type 为 `ENUMERATION` 或者 `PICTURE_ENUM` 时此项有值，将列举所有可选项。</para>
        /// <para>必填：否</para>
        /// <para>示例值：{}</para>
        /// </summary>
        [JsonPropertyName("options")]
        public CustomAttrOptions? Options { get; set; }

        /// <summary>
        /// <para>选项定义，当 type 为 `ENUMERATION` 或者 `PICTURE_ENUM` 时此项有值，将列举所有可选项。</para>
        /// </summary>
        public record CustomAttrOptions
        {
            /// <summary>
            /// <para>默认选项 ID。</para>
            /// <para>必填：否</para>
            /// <para>示例值：qasdefgr</para>
            /// </summary>
            [JsonPropertyName("default_option_id")]
            public string? DefaultOptionId { get; set; }

            /// <summary>
            /// <para>选项类型。</para>
            /// <para>必填：是</para>
            /// <para>示例值：TEXT</para>
            /// <para>可选值：<list type="bullet">
            /// <item>TEXT：文本选项</item>
            /// <item>PICTURE：图片选项</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("option_type")]
            public string OptionType { get; set; } = string.Empty;

            /// <summary>
            /// <para>选项列表。</para>
            /// <para>必填：是</para>
            /// <para>示例值：[]</para>
            /// </summary>
            [JsonPropertyName("options")]
            public CustomAttrOption[] Options { get; set; } = Array.Empty<CustomAttrOption>();

            /// <summary>
            /// <para>选项列表。</para>
            /// </summary>
            public record CustomAttrOption
            {
                /// <summary>
                /// <para>枚举类型选项 ID。</para>
                /// <para>必填：是</para>
                /// <para>示例值：qasdefgr</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string Id { get; set; } = string.Empty;

                /// <summary>
                /// <para>选项值。</para>
                /// <para>- 当 option_type 为 `TEXT` 时，取值为文本值。</para>
                /// <para>- 当 option_type 为 `PICTURE` 时，取值为图片链接。</para>
                /// <para>必填：是</para>
                /// <para>示例值：Option</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;

                /// <summary>
                /// <para>图片名称，仅 option_type 为 PICTURE 时有效。</para>
                /// <para>必填：否</para>
                /// <para>示例值：Name</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }
            }
        }

        /// <summary>
        /// <para>自定义字段的字段名称。</para>
        /// <para>必填：否</para>
        /// <para>示例值：{}</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public I18nContent[]? I18nNames { get; set; }

        /// <summary>
        /// <para>自定义字段的字段名称。</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语言版本。</para>
            /// <para>**可能值有：**</para>
            /// <para>- zh_cn：中文</para>
            /// <para>- en_us：英文</para>
            /// <para>- ja_jp：日文</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>语言版本对应的字段名称。</para>
            /// <para>必填：否</para>
            /// <para>示例值：多语言内容</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/RYU5lvOM4s6zgbeeNNaWd%2BVKwAsoreeRWk0J2noGvJy</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
