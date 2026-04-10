// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-04-11
// ************************************************************************
// <copyright file="GetSparkV1AppsByAppIdStorageResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>下载文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 下载文件 响应体
/// <para>用于下传 20MB（含） 以内的文件</para>
/// <para>接口ID：7624421835341679553</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-storage/download</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-storage%2fdownload</para>
/// </summary>
public record GetSparkV1AppsByAppIdStorageResponseDto
{
    /// <summary>
    /// <para>文件的MIME</para>
    /// <para>必填：是</para>
    /// <para>示例值：image/jpeg</para>
    /// </summary>
    [JsonPropertyName("content_type")]
    public string ContentType { get; set; } = string.Empty;
}
