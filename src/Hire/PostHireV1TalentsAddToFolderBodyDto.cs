// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-06-26
// ************************************************************************
// <copyright file="PostHireV1TalentsAddToFolderBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>将人才加入指定文件夹 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 将人才加入指定文件夹 请求体
/// <para>将人才加入指定文件夹。</para>
/// <para>接口ID：7044465232156999708</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/add_to_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fadd_to_folder</para>
/// </summary>
public record PostHireV1TalentsAddToFolderBodyDto
{
    /// <summary>
    /// <para>人才 ID 列表，可通过[获取人才列表](https://open.larkoffice.com/document/server-docs/hire-v1/candidate-management/talent/list)接口查询ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6039620186502138151</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("talent_id_list")]
    public string[]? TalentIdList { get; set; }

    /// <summary>
    /// <para>文件夹 ID，可通过[获取人才文件夹信息](https://open.larkoffice.com/document/server-docs/hire-v1/candidate-management/talent/list-2)接口查询ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：7039620186502138156</para>
    /// </summary>
    [JsonPropertyName("folder_id")]
    public string FolderId { get; set; } = string.Empty;
}
