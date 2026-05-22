// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="PostSparkV1IconResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传妙搭应用图标 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 上传妙搭应用图标 响应体
/// <para>上传妙搭应用图标</para>
/// <para>接口ID：7642228089434918069</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/icon</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2ficon</para>
/// </summary>
public record PostSparkV1IconResponseDto
{
    /// <summary>
    /// <para>IconURL 上传成功后的图标访问 URL。</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://spark-cdn.example.com/tenant/10001/app-icons/20240520/abcdef123456.png</para>
    /// </summary>
    [JsonPropertyName("icon_url")]
    public string? IconUrl { get; set; }
}
