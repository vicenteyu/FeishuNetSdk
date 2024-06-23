// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1JobRequirementsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取招聘需求信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取招聘需求信息 请求体
/// <para>根据「招聘需求ID」获取招聘需求信息，支持批量查询，限制最大的查询量为100条</para>
/// <para>接口ID：7218888199548633092</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_requirement/list_by_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_requirement%2flist_by_id</para>
/// </summary>
public record PostHireV1JobRequirementsSearchBodyDto
{
    /// <summary>
    /// <para>招聘需求ID列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id_list")]
    public string[]? IdList { get; set; }
}
