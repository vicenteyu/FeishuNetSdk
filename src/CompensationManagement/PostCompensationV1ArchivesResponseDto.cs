// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-10
//
// Last Modified By : yxr
// Last Modified On : 2025-09-10
// ************************************************************************
// <copyright file="PostCompensationV1ArchivesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建薪资档案 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 创建薪资档案 响应体
/// <para>- 该接口适用于员工入职定薪、调薪或者更正档案场景，通过创建调薪任务的方式，为员工生成对应薪资档案数据。</para>
/// <para>- 当员工在调薪生效日期存在档案数据时，则是对该档案进行更正操作。</para>
/// <para>接口ID：7451269641491939329</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/archive/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2farchive%2fcreate</para>
/// </summary>
public record PostCompensationV1ArchivesResponseDto
{
    /// <summary>
    /// <para>定调薪任务创建的唯一ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：123e4567-e89b-42d3-a456-426614174000</para>
    /// </summary>
    [JsonPropertyName("unique_id")]
    public string? UniqueId { get; set; }

    /// <summary>
    /// <para>薪资档案的TID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7434007780111336970</para>
    /// </summary>
    [JsonPropertyName("archive_tid")]
    public string? ArchiveTid { get; set; }
}
