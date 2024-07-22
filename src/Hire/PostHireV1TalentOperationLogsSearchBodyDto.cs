// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1TalentOperationLogsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询操作人对人才的操作记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询操作人对人才的操作记录 请求体
/// <para>查询操作人对人才的操作记录。</para>
/// <para>接口ID：7098526921012936706</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2ftalent_operation_log%2fsearch</para>
/// </summary>
public record PostHireV1TalentOperationLogsSearchBodyDto
{
    /// <summary>
    /// <para>职位 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：6949805467799537964</para>
    /// </summary>
    [JsonPropertyName("job_id_list")]
    public string[]? JobIdList { get; set; }

    /// <summary>
    /// <para>操作人 ID 列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_e6139117c300506837def50545420c6a</para>
    /// </summary>
    [JsonPropertyName("operator_id_list")]
    public string[] OperatorIdList { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>操作类型 ID 列表</para>
    /// <para>必填：是</para>
    /// <para>示例值："3001"</para>
    /// </summary>
    [JsonPropertyName("operation_list")]
    public int[] OperationList { get; set; } = Array.Empty<int>();
}
