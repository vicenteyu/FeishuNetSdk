// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostCorehrV2JobChangesByJobChangeIdRevokeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销异动 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 撤销异动 请求体
/// <para>该接口用于撤销员工异动，若发起成功，会撤销一条已发起、待生效或已生效的异动数据，同时产生相应的事件：[异动状态变更事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_change/events/updated)。该接口无法撤销批量发起的多人异动。</para>
/// <para>接口ID：7449328616456585235</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_change/revoke</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_change%2frevoke</para>
/// </summary>
public record PostCorehrV2JobChangesByJobChangeIdRevokeBodyDto
{
    /// <summary>
    /// <para>操作人id，[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search) 获取ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_a294793e8fa21529f2a60e3e9de45520</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string OperatorId { get; set; } = string.Empty;
}
