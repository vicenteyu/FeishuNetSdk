// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV1PersonsUploadBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传文件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 上传文件 请求体
/// <para>上传文件。</para>
/// <para>接口ID：7076346346946543644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/person/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fperson%2fupload</para>
/// </summary>
public record PostCorehrV1PersonsUploadBodyDto
{
    /// <summary>
    /// <para>文件名称（需带有文件后缀）</para>
    /// <para>必填：是</para>
    /// <para>示例值：个人信息.xlsx</para>
    /// </summary>
    [JsonPropertyName("file_name")]
    public string FileName { get; set; } = string.Empty;
}
