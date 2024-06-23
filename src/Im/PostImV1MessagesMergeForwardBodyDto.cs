// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1MessagesMergeForwardBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>合并转发消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 合并转发消息 请求体
/// <para>将来自同一个群聊中的多条消息合并转发给指定用户、群聊或话题。</para>
/// <para>接口ID：7210967154035638275</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/merge_forward</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fmerge_forward</para>
/// </summary>
public record PostImV1MessagesMergeForwardBodyDto
{
    /// <summary>
    /// <para>依据`receive_id_type`的值，填写对应的合并转发目标的ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </summary>
    [JsonPropertyName("receive_id")]
    public string ReceiveId { get; set; } = string.Empty;

    /// <summary>
    /// <para>要转发的消息ID列表，详情参见[消息ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro#ac79c1c2)</para>
    /// <para>必填：是</para>
    /// <para>示例值：["om_d862083dd13b61cc009e66c40a0f0a56", "om_61244dab1ef11257621dcd7g0e256651"]</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("message_id_list")]
    public string[] MessageIdList { get; set; } = Array.Empty<string>();
}
