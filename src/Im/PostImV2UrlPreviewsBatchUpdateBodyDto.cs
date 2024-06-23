// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV2UrlPreviewsBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新 URL 预览 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 更新 URL 预览 请求体
/// <para>主动更新 URL 预览，调用后会重新触发一次客户端拉取，需要回调服务返回更新后的数据。</para>
/// <para>接口ID：7358413940747862020</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/url_preview/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2furl_preview%2fbatch_update</para>
/// </summary>
public record PostImV2UrlPreviewsBatchUpdateBodyDto
{
    /// <summary>
    /// <para>URL 预览的 token 列表。单个 token 限制更新频率为 1次/5秒</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("preview_tokens")]
    public string[] PreviewTokens { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>需要更新 URL 预览的用户 open_id。若不传，则默认更新 URL 预览所在会话的所有成员；若用户不在 URL 所在会话，则无法触发更新该用户对应的 URL 预览结果</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("open_ids")]
    public string[]? OpenIds { get; set; }
}
