// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutImV2BizEntityTagRelationBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>解绑标签与群 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 解绑标签与群 请求体
/// <para>从业务实体上解绑标签。</para>
/// <para>接口ID：7315032956271263748</para>
/// <para>文档地址：https://open.feishu.cn/document/tenant-tag/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fbiz_entity_tag_relation%2fupdate</para>
/// </summary>
public record PutImV2BizEntityTagRelationBodyDto
{
    /// <summary>
    /// <para>业务类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：chat</para>
    /// <para>可选值：<list type="bullet">
    /// <item>chat：chat类型</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("tag_biz_type")]
    public string TagBizType { get; set; } = string.Empty;

    /// <summary>
    /// <para>业务实体id</para>
    /// <para>必填：是</para>
    /// <para>示例值：oc_xxxxx</para>
    /// </summary>
    [JsonPropertyName("biz_entity_id")]
    public string BizEntityId { get; set; } = string.Empty;

    /// <summary>
    /// <para>标签id</para>
    /// <para>必填：否</para>
    /// <para>最大长度：40</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("tag_ids")]
    public string[]? TagIds { get; set; }
}
