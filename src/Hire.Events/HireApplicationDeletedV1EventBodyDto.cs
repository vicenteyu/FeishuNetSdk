// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="HireApplicationDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除投递 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire.Events;
/// <summary>
/// 删除投递 事件体
/// <para>当投递被删除时，触发该事件的推送。</para>
/// <para>{使用示例}(url=/api/tools/api_explore/api_explore_config?project=hire&amp;version=v1&amp;resource=application&amp;event=deleted)</para>
/// <para>接口ID：7062313984436371457</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/event/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fevents%2fdeleted</para>
/// </summary>
public record HireApplicationDeletedV1EventBodyDto() : EventBodyDto("hire.application.deleted_v1")
{
    /// <summary>
    /// <para>投递 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("application_ids")]
    public string[]? ApplicationIds { get; set; }
}
