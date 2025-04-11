// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresRestoreFlowInstanceBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>恢复入职 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 恢复入职 请求体
/// <para>通过本接口对指定已撤销的待入职员工执行恢复入职操作，对应入职管理页面恢复入职按钮</para>
/// <para>接口ID：7450056310967681026</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/restore_flow_instance</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2frestore_flow_instance</para>
/// </summary>
public record PostCorehrV2PreHiresRestoreFlowInstanceBodyDto
{
    /// <summary>
    /// <para>待入职ID,可从[待入职列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/search)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7345005664477775407</para>
    /// </summary>
    [JsonPropertyName("pre_hire_id")]
    public string PreHireId { get; set; } = string.Empty;

    /// <summary>
    /// <para>是否强制占编；true为强制占编；false为非强制占编</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("confirm_workforce")]
    public bool? ConfirmWorkforce { get; set; }
}
