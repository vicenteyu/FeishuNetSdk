// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-08
//
// Last Modified By : yxr
// Last Modified On : 2024-10-08
// ************************************************************************
// <copyright file="PatchCorehrV2JobGradesByJobGradeIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新职等 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 更新职等 请求体
/// <para>更新职等</para>
/// <para>接口ID：7422326822924566530</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_grade/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_grade%2fpatch</para>
/// </summary>
public record PatchCorehrV2JobGradesByJobGradeIdBodyDto
{
    /// <summary>
    /// <para>职等数值</para>
    /// <para>必填：否</para>
    /// <para>示例值：9999</para>
    /// <para>最大值：99999</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("grade_order")]
    public int? GradeOrder { get; set; }

    /// <summary>
    /// <para>编码</para>
    /// <para>必填：否</para>
    /// <para>示例值：A01234</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>名称</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("names")]
    public I18n[]? Names { get; set; }

    /// <summary>
    /// <para>名称</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>语言编码（IETF BCP 47）</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>文本内容</para>
        /// <para>- 名称不能包含「/」「；」「;」「\」「'」字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：中文示例</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>描述</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("descriptions")]
    public I18n[]? Descriptions { get; set; }

    /// <summary>
    /// <para>启用</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}
