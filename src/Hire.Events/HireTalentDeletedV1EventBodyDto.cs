// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="HireTalentDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除人才 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire.Events;
/// <summary>
/// 删除人才 事件体
/// <para>当人才被删除时，触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=hire&amp;version=v1&amp;resource=talent&amp;event=deleted)</para>
/// <para>接口ID：7062539156064370689</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fevents%2fdeleted</para>
/// </summary>
public record HireTalentDeletedV1EventBodyDto() : EventBodyDto("hire.talent.deleted_v1")
{
    /// <summary>
    /// <para>人才 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string? TalentId { get; set; }
}
