// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="PostHireV1ExternalBackgroundChecksBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建外部背调 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建外部背调 请求体
/// <para>创建外部背调，可用于导入来自其他系统的背调信息。</para>
/// <para>接口ID：6992822583076372483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_background_check%2fcreate</para>
/// </summary>
public record PostHireV1ExternalBackgroundChecksBodyDto
{
    /// <summary>
    /// <para>外部系统背调主键 （仅用于幂等）</para>
    /// <para>- 若不传此值，则不进行幂等校验</para>
    /// <para>- 若传此值，则用于幂等校验，同一`external_id` 24小时内仅可创建一次</para>
    /// <para>必填：否</para>
    /// <para>示例值：7003247299220982060</para>
    /// </summary>
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// <para>外部投递 ID，可通过[查询外部投递列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/external_application/list)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7003247299220982060</para>
    /// </summary>
    [JsonPropertyName("external_application_id")]
    public string ExternalApplicationId { get; set; } = string.Empty;

    /// <summary>
    /// <para>背调日期，毫秒时间戳（字段类型为：int64）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1626602069393</para>
    /// </summary>
    [JsonPropertyName("date")]
    public long? Date { get; set; }

    /// <summary>
    /// <para>背调名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：张三的背调</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>背调结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：已通过</para>
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>
    /// <para>背调附件 ID 列表，可通过[创建附件](https://open.feishu.cn/document/ukTMukTMukTM/uIDN1YjLyQTN24iM0UjN/create_attachment)接口返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：6989181065243969836</para>
    /// </summary>
    [JsonPropertyName("attachment_id_list")]
    public string[]? AttachmentIdList { get; set; }
}
