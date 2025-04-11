// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1AgenciesOperateAgencyAccountBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>禁用/取消禁用猎头 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 禁用/取消禁用猎头 请求体
/// <para>可根据猎头 ID 对猎头执行禁用/取消禁用操作。被禁用的猎头，不能推荐候选人与被分配职位。</para>
/// <para>接口ID：7413697955198042116</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/agency/operate_agency_account</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2foperate_agency_account</para>
/// </summary>
public record PostHireV1AgenciesOperateAgencyAccountBodyDto
{
    /// <summary>
    /// <para>操作类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：禁用</item>
    /// <item>2：取消禁用</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("option")]
    public int Option { get; set; }

    /// <summary>
    /// <para>猎头 ID，可通过[查询猎头供应商下猎头列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/agency/get_agency_account)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7398623155442682156</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// <para>禁用原因，仅当`option`为`1`时，必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：这个人特别不负责</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}
