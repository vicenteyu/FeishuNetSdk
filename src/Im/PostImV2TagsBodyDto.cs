// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV2TagsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建标签 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 创建标签 请求体
/// <para>创建标签并返回标签 ID。</para>
/// <para>接口ID：7315032956271280132</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/tag/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ftag%2fcreate</para>
/// </summary>
public record PostImV2TagsBodyDto
{
    /// <summary>
    /// <para>创建标签</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("create_tag")]
    public PostImV2TagsBodyDtoCreateTag CreateTag { get; set; } = new();

    /// <summary>
    /// <para>创建标签</para>
    /// </summary>
    public record PostImV2TagsBodyDtoCreateTag
    {
        /// <summary>
        /// <para>标签类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：tenant</para>
        /// <para>可选值：<list type="bullet">
        /// <item>tenant：租户类型标签</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("tag_type")]
        public string TagType { get; set; } = string.Empty;

        /// <summary>
        /// <para>标签默认名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：default name</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>i18n多语言标签名称集合</para>
        /// <para>必填：否</para>
        /// <para>最大长度：40</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("i18n_names")]
        public TagI18nName[]? I18nNames { get; set; }

        /// <summary>
        /// <para>i18n多语言标签名称集合</para>
        /// </summary>
        public record TagI18nName
        {
            /// <summary>
            /// <para>语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string Locale { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：标签1</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }
    }
}
