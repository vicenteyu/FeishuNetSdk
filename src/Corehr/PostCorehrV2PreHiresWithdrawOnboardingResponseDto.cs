// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresWithdrawOnboardingResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销入职 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 撤销入职 响应体
/// <para>通过本接口对指定待入职，入职准备就绪的员工执行撤销入职操作，对应入职管理页面撤销入职按钮</para>
/// <para>接口ID：7450056310967664642</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/withdraw_onboarding</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fwithdraw_onboarding</para>
/// </summary>
public record PostCorehrV2PreHiresWithdrawOnboardingResponseDto
{
    /// <summary>
    /// <para>是否成功撤销入职</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}
