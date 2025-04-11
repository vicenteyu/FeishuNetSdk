// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-02-21
//
// Last Modified By : yxr
// Last Modified On : 2025-02-21
// ************************************************************************
// <copyright file="PostCorehrV2JobChangesByJobChangeIdRevokeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销异动 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 撤销异动 响应体
/// <para>该接口用于撤销员工异动，若发起成功，会撤销一条已发起、待生效或已生效的异动数据，同时产生相应的事件：[异动状态变更事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_change/events/updated)。该接口无法撤销批量发起的多人异动。使用时需指定操作人，关联了流程的异动需要流程管理员和审批单管理员权限。</para>
/// <para>接口ID：7449328616456585235</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job_change/revoke</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_change%2frevoke</para>
/// </summary>
public record PostCorehrV2JobChangesByJobChangeIdRevokeResponseDto
{
    /// <summary>
    /// <para>撤销结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("result")]
    public bool? Result { get; set; }

    /// <summary>
    /// <para>撤销信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：成功</para>
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
