// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="PostCorehrV2PathwaysActiveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>启停用通道 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 启停用通道 请求体
/// <para>对通道进行 启用 或 停用 操作</para>
/// <para>接口ID：7508634905587040259</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/active</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpathway%2factive</para>
/// </summary>
public record PostCorehrV2PathwaysActiveBodyDto
{
    /// <summary>
    /// <para>通道ID。ID获取方式</para>
    /// <para>- 调用[创建通道接口](/document-mod/index?fullPath=%2FuAjLw4CM%2FukTMukTMukTM%2Fcorehr-v2%2Fpathway%2Fcreate)后，从响应结果的`pathway_id`获取。</para>
    /// <para>- 监听[通道创建事件](/document-mod/index?fullPath=/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/events/created)，当触发该事件后可从事件体内获取`pathway_id`</para>
    /// <para>- 监听[通道更新事件](/document-mod/index?fullPath=/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/events/updated)，当触发该事件后可从事件体内获取`pathway_id`</para>
    /// <para>- 监听[通道删除事件](/document-mod/index?fullPath=%2FuAjLw4CM%2FukTMukTMukTM%2Fcorehr-v2%2Fpathway%2Fevents%2Fdeleted)，当触发该事件后可从事件体内获取`pathway_id`</para>
    /// <para>必填：是</para>
    /// <para>示例值：6862995757234914823</para>
    /// </summary>
    [JsonPropertyName("pathway_id")]
    public string PathwayId { get; set; } = string.Empty;

    /// <summary>
    /// <para>停启用状态；true：启用，false：停用</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; set; }
}
