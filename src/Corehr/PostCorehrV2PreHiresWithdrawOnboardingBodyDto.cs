// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresWithdrawOnboardingBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销入职 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 撤销入职 请求体
/// <para>通过本接口对指定待入职，入职准备就绪的员工执行撤销入职操作，对应入职管理页面撤销入职按钮</para>
/// <para>接口ID：7450056310967664642</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/withdraw_onboarding</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fwithdraw_onboarding</para>
/// </summary>
public record PostCorehrV2PreHiresWithdrawOnboardingBodyDto
{
    /// <summary>
    /// <para>待入职ID，可以通过[搜索待入职人员信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/search)接口获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：7345005664477775407</para>
    /// </summary>
    [JsonPropertyName("pre_hire_id")]
    public string PreHireId { get; set; } = string.Empty;

    /// <summary>
    /// <para>撤销原因，上限为500字</para>
    /// <para>必填：是</para>
    /// <para>示例值：withdraw reason</para>
    /// </summary>
    [JsonPropertyName("withdraw_reason")]
    public string WithdrawReason { get; set; } = string.Empty;
}
