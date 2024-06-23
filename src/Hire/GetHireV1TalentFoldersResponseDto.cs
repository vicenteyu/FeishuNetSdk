// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1TalentFoldersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取人才文件夹信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取人才文件夹信息 响应体
/// <para>用于获取招聘系统中人才文件夹信息。</para>
/// <para>接口ID：7054018845564796956</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_folder%2flist</para>
/// </summary>
public record GetHireV1TalentFoldersResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJvZmZzZXQiOjEsInRpbWVzdGFtcCI6MTY0MDc2NTYzMjA4OCwiaWQiOm51bGx9</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>文件夹列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public TalentFolderForList[]? Items { get; set; }

    /// <summary>
    /// <para>文件夹列表</para>
    /// </summary>
    public record TalentFolderForList
    {
        /// <summary>
        /// <para>文件夹ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7041806543797995820</para>
        /// </summary>
        [JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// <para>名字</para>
        /// <para>必填：是</para>
        /// <para>示例值：人才文件夹A1</para>
        /// </summary>
        [JsonPropertyName("folder_name")]
        public string FolderName { get; set; } = string.Empty;

        /// <summary>
        /// <para>所有者ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_85bb308c57f597471cd2bb5b4f580245</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }
    }
}
