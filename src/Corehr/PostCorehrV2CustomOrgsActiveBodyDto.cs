// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostCorehrV2CustomOrgsActiveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>启用/停用自定义组织 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 启用/停用自定义组织 请求体
/// <para>对自定义组织进行启用或停用操作</para>
/// <para>接口ID：7358017162446471172</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/active</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2factive</para>
/// </summary>
public record PostCorehrV2CustomOrgsActiveBodyDto
{
    /// <summary>
    /// <para>自定义组织 ID</para>
    /// <para>- 可从 [批量查询自定义组织](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/custom_org/query)的 org_id 字段中获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：6862995757234914823</para>
    /// </summary>
    [JsonPropertyName("org_id")]
    public string OrgId { get; set; } = string.Empty;

    /// <summary>
    /// <para>组织类型编码，可在「飞书人事-设置-组织配置」中相应的自定义组织目录下查看</para>
    /// <para>必填：是</para>
    /// <para>示例值：custom_org_01</para>
    /// </summary>
    [JsonPropertyName("object_api_name")]
    public string ObjectApiName { get; set; } = string.Empty;

    /// <summary>
    /// <para>启用/停用状态。</para>
    /// <para>- active 传 true 代表启用</para>
    /// <para>- active 传 false 代表停用</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// <para>自定义组织生效时间</para>
    /// <para>- 填写格式： YYYY-MM-DD</para>
    /// <para>- 系统默认为填写日期当天的 00:00:00 生效</para>
    /// <para>- 该接口只支持到最小单位为日</para>
    /// <para>- 日期范围要求:1900-01-01 ～ 9999-12-31</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-01-01</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;
}
