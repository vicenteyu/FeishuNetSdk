// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-02-06
//
// Last Modified By : yxr
// Last Modified On : 2026-02-06
// ************************************************************************
// <copyright file="PostCorehrV2ProcessStartResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发起流程 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 发起流程 响应体
/// <para>发起一个流程实例，目前只支持发起自定义业务类型的流程。</para>
/// <para>接口ID：7451908159096766468</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/process-instance/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess_start%2fcreate</para>
/// </summary>
public record PostCorehrV2ProcessStartResponseDto
{
    /// <summary>
    /// <para>流程运行实例 id，详细信息可通过[获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7437118147624175148</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }
}
