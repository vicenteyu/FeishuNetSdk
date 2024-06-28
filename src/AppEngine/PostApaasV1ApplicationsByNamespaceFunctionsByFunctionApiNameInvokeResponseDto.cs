// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-29
//
// Last Modified By : yxr
// Last Modified On : 2024-06-29
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceFunctionsByFunctionApiNameInvokeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>执行函数 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 执行函数 响应体
/// <para>执行基于飞书应用引擎开发的应用的自定义函数</para>
/// <para>接口ID：7385474062586281986</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/application-function/invoke</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-function%2finvoke</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceFunctionsByFunctionApiNameInvokeResponseDto
{
    /// <summary>
    /// <para>函数执行的返回结果（JSON 序列化后的字符串）</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"key1\":\"value1\",\"key2\":\"value2\",\"key3\":1718313981794}</para>
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}
