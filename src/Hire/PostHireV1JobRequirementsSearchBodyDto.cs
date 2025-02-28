// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-02-28
// ************************************************************************
// <copyright file="PostHireV1JobRequirementsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取招聘需求信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取招聘需求信息 请求体
/// <para>根据「招聘需求ID」获取招聘需求信息，支持批量查询</para>
/// <para>接口ID：7218888199548633092</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_requirement/list_by_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_requirement%2flist_by_id</para>
/// </summary>
public record PostHireV1JobRequirementsSearchBodyDto
{
    /// <summary>
    /// <para>招聘需求ID列表，详情请参考：[获取招聘需求列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement/list)</para>
    /// <para>不允许和招聘需求编号列表同时使用，否则报错（详见错误码1002725）</para>
    /// <para>限制单次最大100条，该字段和编号列表都不传则返回空</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id_list")]
    public string[]? IdList { get; set; }

    /// <summary>
    /// <para>招聘需求编号列表，详情请参考：[获取招聘需求列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement/list)</para>
    /// <para>不允许和招聘需求ID列表同时使用，否则报错（详见错误码1002725）</para>
    /// <para>限制单次最大100条，该字段和ID列表都不传则返回空</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("short_code_list")]
    public string[]? ShortCodeList { get; set; }
}
