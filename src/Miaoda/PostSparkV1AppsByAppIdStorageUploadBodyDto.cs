// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-04-11
// ************************************************************************
// <copyright file="PostSparkV1AppsByAppIdStorageUploadBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传文件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 上传文件 请求体
/// <para>用于上传 20MB（含） 以内的文件</para>
/// <para>接口ID：7624421835341695937</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-storage/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-storage%2fupload</para>
/// </summary>
public record PostSparkV1AppsByAppIdStorageUploadBodyDto
{
    /// <summary>
    /// <para>文件名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：file_name</para>
    /// </summary>
    [JsonPropertyName("file_name")]
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件的十六进制 SHA-256 值，用于文件一致性校验。如果传入此值，服务端会在上传完成后对比接收到文件的 SHA-256 值，如果不一致，会返回上传失败。</para>
    /// <para>必填：否</para>
    /// <para>示例值：f8d80a7f68b820d99f5612b952140319991d6599d95f29699d076684b0977f99</para>
    /// </summary>
    [JsonPropertyName("check_sum")]
    public string? CheckSum { get; set; }
}
