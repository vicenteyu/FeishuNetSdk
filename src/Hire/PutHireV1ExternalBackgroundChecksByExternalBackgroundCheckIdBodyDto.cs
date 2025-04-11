// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PutHireV1ExternalBackgroundChecksByExternalBackgroundCheckIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新外部背调 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新外部背调 请求体
/// <para>更新外部背调信息。</para>
/// <para>## 注意事项</para>
/// <para>该接口会对原背调内容进行全量覆盖更新。</para>
/// <para>接口ID：7407298680640929795</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-background-info/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_background_check%2fupdate</para>
/// </summary>
public record PutHireV1ExternalBackgroundChecksByExternalBackgroundCheckIdBodyDto
{
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
    /// </summary>
    [JsonPropertyName("attachment_id_list")]
    public string[]? AttachmentIdList { get; set; }
}
