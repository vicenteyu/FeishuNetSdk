// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-03
//
// Last Modified By : yxr
// Last Modified On : 2024-11-03
// ************************************************************************
// <copyright file="PostCorehrV2LocationsActiveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>启用/停用地点 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 启用/停用地点 请求体
/// <para>启用/停用地点</para>
/// <para>接口ID：7420421437192945667</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/location/active</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation%2factive</para>
/// </summary>
public record PostCorehrV2LocationsActiveBodyDto
{
    /// <summary>
    /// <para>地点 ID。ID 获取方式：</para>
    /// <para>- 调用[【创建地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/create)[【批量分页查询地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)等接口可以返回地点ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：1616161616</para>
    /// </summary>
    [JsonPropertyName("location_id")]
    public string LocationId { get; set; } = string.Empty;

    /// <summary>
    /// <para>地点启用/停用生效日期</para>
    /// <para>- 填写格式：YYYY-MM-DD</para>
    /// <para>- 系统默认为填写日期当天的 00:00:00 生效</para>
    /// <para>- 该接口只支持到最小单位为日</para>
    /// <para>- 日期范围要求:1900-01-01～9999-12-31</para>
    /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>地点启用/停用状态</para>
    /// <para>- true 为启用</para>
    /// <para>- false 为停用</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// <para>操作原因</para>
    /// <para>必填：是</para>
    /// <para>示例值：业务操作</para>
    /// </summary>
    [JsonPropertyName("operation_reason")]
    public string OperationReason { get; set; } = string.Empty;
}
