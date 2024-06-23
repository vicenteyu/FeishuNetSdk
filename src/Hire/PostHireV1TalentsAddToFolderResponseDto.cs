// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1TalentsAddToFolderResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>将人才加入指定文件夹 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 将人才加入指定文件夹 响应体
/// <para>将人才加入指定文件夹。</para>
/// <para>接口ID：7044465232156999708</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/add_to_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fadd_to_folder</para>
/// </summary>
public record PostHireV1TalentsAddToFolderResponseDto
{
    /// <summary>
    /// <para>人才 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("talent_id_list")]
    public string[]? TalentIdList { get; set; }

    /// <summary>
    /// <para>文件夹 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7039620186502138156</para>
    /// </summary>
    [JsonPropertyName("folder_id")]
    public string? FolderId { get; set; }
}
