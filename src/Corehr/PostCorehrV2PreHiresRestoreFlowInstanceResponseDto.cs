// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresRestoreFlowInstanceResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>恢复入职 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 恢复入职 响应体
/// <para>通过本接口对指定已撤销的待入职员工执行恢复入职操作，对应入职管理页面恢复入职按钮</para>
/// <para>接口ID：7450056310967681026</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/restore_flow_instance</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2frestore_flow_instance</para>
/// </summary>
public record PostCorehrV2PreHiresRestoreFlowInstanceResponseDto
{
    /// <summary>
    /// <para>是否成功恢复入职</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}
