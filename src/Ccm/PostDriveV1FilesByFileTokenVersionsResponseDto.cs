// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1FilesByFileTokenVersionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建文档版本 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建文档版本 响应体
/// <para>创建文档版本。文档支持在线文档或电子表格。</para>
/// <para>接口ID：7156062028485033988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file-version/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-version%2fcreate</para>
/// </summary>
public record PostDriveV1FilesByFileTokenVersionsResponseDto
{
    /// <summary>
    /// <para>版本文档的标题</para>
    /// <para>必填：否</para>
    /// <para>示例值：项目文档 第 1 版</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>版本文档的版本标识</para>
    /// <para>必填：否</para>
    /// <para>示例值：fnJfyX</para>
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// <para>版本文档对应的源文档的 token</para>
    /// <para>必填：否</para>
    /// <para>示例值：doxbcyvqZlSc9WlHvQMlSJabcdf</para>
    /// </summary>
    [JsonPropertyName("parent_token")]
    public string? ParentToken { get; set; }

    /// <summary>
    /// <para>版本文档的所有者的 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：694699009591869450</para>
    /// </summary>
    [JsonPropertyName("owner_id")]
    public string? OwnerId { get; set; }

    /// <summary>
    /// <para>版本文档的创建者的 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：694699009591869451</para>
    /// </summary>
    [JsonPropertyName("creator_id")]
    public string? CreatorId { get; set; }

    /// <summary>
    /// <para>版本文档的创建时间，Unix 时间戳，单位为秒</para>
    /// <para>必填：否</para>
    /// <para>示例值：1660708537</para>
    /// </summary>
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// <para>版本文档的更新时间。创建文档版本时，不会返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：1660708537</para>
    /// </summary>
    [JsonPropertyName("update_time")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// <para>版本文档的状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：正常状态</item>
    /// <item>1：该版本已被删除</item>
    /// <item>2：回收站状态</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// <para>版本文档的类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：docx</para>
    /// <para>可选值：<list type="bullet">
    /// <item>docx：新版文档</item>
    /// <item>sheet：电子表格</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("obj_type")]
    public string? ObjType { get; set; }

    /// <summary>
    /// <para>源文档的类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：docx</para>
    /// <para>可选值：<list type="bullet">
    /// <item>docx：新版文档</item>
    /// <item>sheet：电子表格</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("parent_type")]
    public string? ParentType { get; set; }
}
