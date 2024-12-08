// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1TalentsRemoveToFolderBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>将人才从指定文件夹移除 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 将人才从指定文件夹移除 请求体
/// <para>根据人才 ID 列表将人才从指定文件夹移除。</para>
/// <para>接口ID：7418831232862617601</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/remove_to_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fremove_to_folder</para>
/// </summary>
public record PostHireV1TalentsRemoveToFolderBodyDto
{
    /// <summary>
    /// <para>人才 ID 列表，可通过[获取人才列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/list)接口获得</para>
    /// <para>必填：是</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("talent_id_list")]
    public string[] TalentIdList { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>文件夹 ID，可通过[获取人才文件夹列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_folder/list)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7039620186502138156</para>
    /// </summary>
    [JsonPropertyName("folder_id")]
    public string FolderId { get; set; } = string.Empty;
}
