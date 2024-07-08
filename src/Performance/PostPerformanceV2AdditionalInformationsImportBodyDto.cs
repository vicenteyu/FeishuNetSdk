// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-09
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="PostPerformanceV2AdditionalInformationsImportBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量导入补充信息 请求体</summary>
namespace FeishuNetSdk.Performance;
/// <summary>
/// 批量导入补充信息 请求体
/// <para>可批量导入被评估人的补充信息作为评估参考（包括新增和更新场景）。</para>
/// <para>接口ID：7371009404255633412</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/additional_information/import</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fadditional_information%2fimport</para>
/// </summary>
public record PostPerformanceV2AdditionalInformationsImportBodyDto
{
    /// <summary>
    /// <para>评估周期 ID 列表，semester_id 可通过【获取周期】接口获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：7348736302176534547</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string SemesterId { get; set; } = string.Empty;

    /// <summary>
    /// <para>补充信息列表，一次最多 1000 个</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("additional_informations")]
    public AdditionalInformation[]? AdditionalInformations { get; set; }

    /// <summary>
    /// <para>补充信息列表，一次最多 1000 个</para>
    /// </summary>
    public record AdditionalInformation
    {
        /// <summary>
        /// <para>飞书绩效的事项 ID，只支持传入已存在的 item_id 用于更新事项。如需新增事项，无需传该值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：7350194523185610771</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// <para>外部系统的事项 ID，用于两个系统之间的数据映射。支持新建事项和更新关联的已有事项。如果同时传了 item_id，则优先按照 item_id 更新对应事项内容及其 external_id。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6789523104723558912</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// <para>被评估人 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_3245842393d09e9428ad4655da6e30b3</para>
        /// <para>最大长度：9999</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("reviewee_user_id")]
        public string RevieweeUserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>事项</para>
        /// <para>必填：是</para>
        /// <para>示例值：文本</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("item")]
        public string Item { get; set; } = string.Empty;

        /// <summary>
        /// <para>事项时间，格式为文本内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：2024-03-12</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; } = string.Empty;

        /// <summary>
        /// <para>事项详细描述</para>
        /// <para>必填：是</para>
        /// <para>示例值：多行文本</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("detailed_description")]
        public string DetailedDescription { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>导入记录名称，管理员可在补充信息管理的导入记录中查看。不传则默认为 API 导入。</para>
    /// <para>必填：否</para>
    /// <para>示例值：API导入</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("import_record_name")]
    public string? ImportRecordName { get; set; }
}
