// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PostOkrV2ObjectivesByObjectiveIdAlignmentsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建目标对齐关系 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 创建目标对齐关系 请求体
/// <para>为指定目标与另一个目标创建对齐关系，在 OKR 结构中建立层级对齐。</para>
/// <para>接口ID：7644764969658289100</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-objective-alignment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-objective-alignment%2fcreate</para>
/// </summary>
public record PostOkrV2ObjectivesByObjectiveIdAlignmentsBodyDto
{
    /// <summary>
    /// <para>被对齐实体类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>2：目标</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("to_entity_type")]
    public int ToEntityType { get; set; }

    /// <summary>
    /// <para>被对齐实体(目标) ID，可通过“获取用户 OKR 周期内的目标”接口获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7342342398472398473</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("to_entity_id")]
    public string ToEntityId { get; set; } = string.Empty;
}
