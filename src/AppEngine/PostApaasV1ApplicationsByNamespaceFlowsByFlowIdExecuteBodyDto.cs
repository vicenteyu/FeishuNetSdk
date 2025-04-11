// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-29
//
// Last Modified By : yxr
// Last Modified On : 2024-11-29
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceFlowsByFlowIdExecuteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发起流程 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 发起流程 请求体
/// <para>执行相应流程</para>
/// <para>接口ID：7442599557486624772</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/application-flow/execute</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-flow%2fexecute</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceFlowsByFlowIdExecuteBodyDto
{
    /// <summary>
    /// <para>是否异步执行(不传默认false)</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_async")]
    public bool? IsAsync { get; set; }

    /// <summary>
    /// <para>幂等键（建议本地生成uuid传入，重复的话请求会报错）</para>
    /// <para>必填：否</para>
    /// <para>示例值：iuhg23897489797</para>
    /// </summary>
    [JsonPropertyName("idempotent_key")]
    public string? IdempotentKey { get; set; }

    /// <summary>
    /// <para>循环标志信息(当前版本可不传)</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("loop_masks")]
    public string[]? LoopMasks { get; set; }

    /// <summary>
    /// <para>流程入参（json 字符串，无入参不传）</para>
    /// <para>必填：否</para>
    /// <para>示例值：`{\"variable_rgrtgqworiginal\": {\"_id\": 5454545}}`</para>
    /// </summary>
    [JsonPropertyName("params")]
    public string? Params { get; set; }

    /// <summary>
    /// <para>操作人（_id和email至少填一个，低代码平台用户的 id和email，需要从低代码平台获取，json字符串）</para>
    /// <para>必填：是</para>
    /// <para>示例值：`{\"_id\": 1111, \"email\": \"apaas@bytedance.com\"}`</para>
    /// </summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; } = string.Empty;
}
