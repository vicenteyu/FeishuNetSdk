// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresByPreHireIdCompleteResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>操作员工完成入职 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 操作员工完成入职 响应体
/// <para>操作待入职员工完成入职，正式入职建立员工和公司/组织的雇佣关系</para>
/// <para>接口ID：7357756972752699394</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/complete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fcomplete</para>
/// </summary>
public record PostCorehrV2PreHiresByPreHireIdCompleteResponseDto
{
    /// <summary>
    /// <para>是否成功完成入职</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}
