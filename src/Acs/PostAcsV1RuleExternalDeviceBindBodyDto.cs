// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAcsV1RuleExternalDeviceBindBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>设备绑定权限组 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Acs;
/// <summary>
/// 设备绑定权限组 请求体
/// <para>设备绑定权限组</para>
/// <para>接口ID：7321978105899073564</para>
/// <para>文档地址：https://open.feishu.cn/document/acs-v1/rule_external/device_bind</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2frule_external%2fdevice_bind</para>
/// </summary>
public record PostAcsV1RuleExternalDeviceBindBodyDto
{
    /// <summary>
    /// <para>设备id</para>
    /// <para>必填：是</para>
    /// <para>示例值：6939433228970082593</para>
    /// </summary>
    [JsonPropertyName("device_id")]
    public string DeviceId { get; set; } = string.Empty;

    /// <summary>
    /// <para>权限组id列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("rule_ids")]
    public string[] RuleIds { get; set; } = Array.Empty<string>();
}
