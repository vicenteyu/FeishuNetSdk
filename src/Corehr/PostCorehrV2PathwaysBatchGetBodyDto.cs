// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="PostCorehrV2PathwaysBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取通道信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取通道信息 请求体
/// <para>根据通道的ID批量获取通道的名称、编码、描述信息</para>
/// <para>接口ID：7508634905586991107</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpathway%2fbatch_get</para>
/// </summary>
public record PostCorehrV2PathwaysBatchGetBodyDto
{
    /// <summary>
    /// <para>通道 ID 列表。ID获取方式</para>
    /// <para>- 调用[创建通道接口](/document-mod/index?fullPath=%2FuAjLw4CM%2FukTMukTMukTM%2Fcorehr-v2%2Fpathway%2Fcreate)后，从响应结果的`pathway_id`获取。</para>
    /// <para>- 监听[通道创建事件](/document-mod/index?fullPath=/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/events/created)，当触发该事件后可从事件体内获取`pathway_id`</para>
    /// <para>- 监听[通道更新事件](/document-mod/index?fullPath=/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/events/updated)，当触发该事件后可从事件体内获取`pathway_id`</para>
    /// <para>- 监听[通道删除事件](/document-mod/index?fullPath=%2FuAjLw4CM%2FukTMukTMukTM%2Fcorehr-v2%2Fpathway%2Fevents%2Fdeleted)，当触发该事件后可从事件体内获取`pathway_id`</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("pathway_ids")]
    public string[] PathwayIds { get; set; } = Array.Empty<string>();
}
