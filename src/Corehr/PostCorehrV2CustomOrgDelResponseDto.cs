// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="PostCorehrV2CustomOrgDelResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除人员自定义组织变更记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 删除人员自定义组织变更记录 响应体
/// <para>根据记录版本 ID 删除员工某一自定义组织某一版本记录信息</para>
/// <para>接口ID：7425878850969387012</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/employee-custom_org/del</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee-custom_org%2fdel</para>
/// </summary>
public record PostCorehrV2CustomOrgDelResponseDto
{
    /// <summary>
    /// <para>返回值</para>
    /// <para>必填：是</para>
    /// <para>示例值：success</para>
    /// </summary>
    [JsonPropertyName("data")]
    public string Data { get; set; } = string.Empty;
}
