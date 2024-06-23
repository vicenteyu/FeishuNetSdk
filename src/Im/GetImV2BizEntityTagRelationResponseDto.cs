// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetImV2BizEntityTagRelationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询实体与标签的绑定关系 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 查询实体与标签的绑定关系 响应体
/// <para>查询实体与标签的绑定关系</para>
/// <para>接口ID：7350335258430816257</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/biz_entity_tag_relation/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fbiz_entity_tag_relation%2fget</para>
/// </summary>
public record GetImV2BizEntityTagRelationResponseDto
{
    /// <summary>
    /// <para>标签内容及绑定时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tag_info_with_bind_versions")]
    public TagInfoWithBindVersion[]? TagInfoWithBindVersions { get; set; }

    /// <summary>
    /// <para>标签内容及绑定时间</para>
    /// </summary>
    public record TagInfoWithBindVersion
    {
        /// <summary>
        /// <para>标签内容</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tag_info")]
        public TagInfoWithBindVersionTagInfo? TagInfo { get; set; }

        /// <summary>
        /// <para>标签内容</para>
        /// </summary>
        public record TagInfoWithBindVersionTagInfo
        {
            /// <summary>
            /// <para>id</para>
            /// <para>必填：否</para>
            /// <para>示例值：716168xxxxx</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>标签类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：tenant</para>
            /// </summary>
            [JsonPropertyName("tag_type")]
            public string? TagType { get; set; }

            /// <summary>
            /// <para>name</para>
            /// <para>必填：否</para>
            /// <para>示例值：tagName1</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>i18n name</para>
            /// <para>必填：否</para>
            /// <para>最大长度：40</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("i18n_names")]
            public TagI18nName[]? I18nNames { get; set; }

            /// <summary>
            /// <para>i18n name</para>
            /// </summary>
            public record TagI18nName
            {
                /// <summary>
                /// <para>语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("locale")]
                public string Locale { get; set; } = string.Empty;

                /// <summary>
                /// <para>名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：tagName1</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }
            }

            /// <summary>
            /// <para>创建时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1700793403850</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>更新时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1700793403850</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public string? UpdateTime { get; set; }
        }

        /// <summary>
        /// <para>绑定时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1710401562336</para>
        /// </summary>
        [JsonPropertyName("bind_version")]
        public string? BindVersion { get; set; }
    }
}
