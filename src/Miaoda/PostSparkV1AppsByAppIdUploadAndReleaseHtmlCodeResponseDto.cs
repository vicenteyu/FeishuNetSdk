// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="PostSparkV1AppsByAppIdUploadAndReleaseHtmlCodeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传 HTML 代码并发布 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 上传 HTML 代码并发布 响应体
/// <para>上传 HTML 代码并发布</para>
/// <para>接口ID：7642228089434852533</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/upload_html_code_and_release</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fupload_html_code_and_release</para>
/// </summary>
public record PostSparkV1AppsByAppIdUploadAndReleaseHtmlCodeResponseDto
{
    /// <summary>
    /// <para>发布成功后的在线访问地址。</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://spark.example.com/apps/MDA20240516001</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
