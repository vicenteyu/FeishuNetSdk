// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-29
//
// Last Modified By : yxr
// Last Modified On : 2026-08-29
// ************************************************************************
// <copyright file="PostMinutesV1MinutesUploadBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>云空间文件生成妙记 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Minutes;
/// <summary>
/// 云空间文件生成妙记 请求体
/// <para>先获取云空间文件的token，再根据给定的云空间文件token生成妙记。云空间文件token的获取方式请参考[云空间文件概述](https://open.feishu.cn/document/docs/drive-v1/file/file-overview)</para>
/// <para>接口ID：7673720420097412036</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fupload</para>
/// </summary>
public record PostMinutesV1MinutesUploadBodyDto
{
    /// <summary>
    /// <para>云空间文件token。云空间文件token的获取方式请参考[云空间文件概述](https://open.feishu.cn/document/docs/drive-v1/file/file-overview)</para>
    /// <para>必填：是</para>
    /// <para>示例值：doccnfYZzTlvXqZIGTdAHKabcef</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string FileToken { get; set; } = string.Empty;
}
