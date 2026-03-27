// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="PostApplicationV7AppAvatarUploadResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传应用图标 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 上传应用图标 响应体
/// <para>上传应用图标</para>
/// <para>接口ID：7621030901518568407</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v7/application-v7/app_avatar-upload/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v7%2fapplication-v7%2fapp_avatar-upload%2fcreate</para>
/// </summary>
public record PostApplicationV7AppAvatarUploadResponseDto
{
    /// <summary>
    /// <para>图片 URL，给创建/更新应用使用</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://s3-imfile.feishucdn.com/static-resource/v1/v3_006n_24c0a858-0b0d-490b-a8d4-b1e2ef421c8g</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
