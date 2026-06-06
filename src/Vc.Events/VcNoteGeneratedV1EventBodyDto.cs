// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="VcNoteGeneratedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>纪要生成 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc.Events;
/// <summary>
/// 纪要生成 事件体
/// <para>当与用户有关联的纪要生成后，将会触发该事件。</para>
/// <para>用户关联的纪要包括：</para>
/// <para>- 参与的会议所生成的纪要</para>
/// <para>- 录音或者上传音视频文件所生成的纪要{使用示例}(url=/api/tools/api_explore/api_explore_config?project=vc&amp;version=v1&amp;resource=note&amp;event=generated)</para>
/// <para>接口ID：7646314141168323795</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/note/events/generated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fnote%2fevents%2fgenerated</para>
/// </summary>
public record VcNoteGeneratedV1EventBodyDto() : EventBodyDto("vc.note.generated_v1")
{
    /// <summary>
    /// <para>纪要ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("note_id")]
    public string? NoteId { get; set; }

    /// <summary>
    /// <para>需要推送事件的用户列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `500`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("subscriber_ids")]
    public UserIdSuffix[]? SubscriberIds { get; set; }
}
