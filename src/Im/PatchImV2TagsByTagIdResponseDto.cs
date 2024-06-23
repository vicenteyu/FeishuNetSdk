// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchImV2TagsByTagIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改标签 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 修改标签 响应体
/// <para>修改标签在各个语言下的名称。</para>
/// <para>接口ID：7315032956271296516</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/tag/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ftag%2fpatch</para>
/// </summary>
public record PatchImV2TagsByTagIdResponseDto
{
    /// <summary>
    /// <para>编辑后的标签信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tag_info")]
    public PatchImV2TagsByTagIdResponseDtoTagInfo? TagInfo { get; set; }

    /// <summary>
    /// <para>编辑后的标签信息</para>
    /// </summary>
    public record PatchImV2TagsByTagIdResponseDtoTagInfo
    {
        /// <summary>
        /// <para>标签 ID</para>
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
        /// <para>标签名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：标签1</para>
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
    /// <para>修改失败原因</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("patch_tag_fail_reason")]
    public PatchImV2TagsByTagIdResponseDtoPatchTagFailReason? PatchTagFailReason { get; set; }

    /// <summary>
    /// <para>修改失败原因</para>
    /// </summary>
    public record PatchImV2TagsByTagIdResponseDtoPatchTagFailReason
    {
        /// <summary>
        /// <para>名称重复的标签id</para>
        /// <para>必填：否</para>
        /// <para>示例值：716168xxxxx</para>
        /// </summary>
        [JsonPropertyName("duplicate_id")]
        public string? DuplicateId { get; set; }
    }
}
