// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchImV2TagsByTagIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改标签 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 修改标签 请求体
/// <para>修改标签在各个语言下的名称。</para>
/// <para>接口ID：7315032956271296516</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/tag/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ftag%2fpatch</para>
/// </summary>
public record PatchImV2TagsByTagIdBodyDto
{
    /// <summary>
    /// <para>编辑标签</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("patch_tag")]
    public PatchImV2TagsByTagIdBodyDtoPatchTag? PatchTag { get; set; }

    /// <summary>
    /// <para>编辑标签</para>
    /// </summary>
    public record PatchImV2TagsByTagIdBodyDtoPatchTag
    {
        /// <summary>
        /// <para>标签 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：716168xxxxx</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>标签名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：标签名称</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>i18n 多语言名称集合</para>
        /// <para>必填：否</para>
        /// <para>最大长度：40</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("i18n_names")]
        public TagI18nName[]? I18nNames { get; set; }

        /// <summary>
        /// <para>i18n 多语言名称集合</para>
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
            /// <para>示例值：标签2</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }
    }
}
