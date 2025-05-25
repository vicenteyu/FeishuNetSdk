// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDriveV1FilesByFileTokenViewRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取文件访问记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取文件访问记录 响应体
/// <para>获取文档、电子表格、多维表格等文件的历史访问记录，包括访问者的 ID、姓名、头像和最近访问时间。</para>
/// <para>接口ID：7232207479622074371</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file-view_record/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-view_record%2flist</para>
/// </summary>
public record GetDriveV1FilesByFileTokenViewRecordsResponseDto : IPageableResponse<GetDriveV1FilesByFileTokenViewRecordsResponseDto.FileViewRecord>
{
    /// <summary>
    /// <para>访问记录列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public FileViewRecord[]? Items { get; set; }

    /// <summary>
    /// <para>访问记录列表</para>
    /// </summary>
    public record FileViewRecord
    {
        /// <summary>
        /// <para>访问者 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_cc19b2bfb93f8a44db4b4d6eababcef</para>
        /// </summary>
        [JsonPropertyName("viewer_id")]
        public string? ViewerId { get; set; }

        /// <summary>
        /// <para>访问者姓名</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>访问者头像的 URL</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://foo.icon.com/xxxx</para>
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// <para>最近访问时间。Unix 时间戳，单位为秒。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1679284285</para>
        /// </summary>
        [JsonPropertyName("last_view_time")]
        public string? LastViewTime { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1674037112--7189934631754563585</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
