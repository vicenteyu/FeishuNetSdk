// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-01-05
//
// Last Modified By : yxr
// Last Modified On : 2025-01-05
// ************************************************************************
// <copyright file="PostCardkitV1CardsIdConvertResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转换 ID 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Cardkit;
/// <summary>
/// 转换 ID 响应体
/// <para>将[消息 ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro#44c58e1c)（ `message_id` ）转换为卡片实体 ID（`card_id`）。</para>
/// <para>## 提示</para>
/// <para>- 卡片实体 ID 是卡片实体的唯一标识，由[创建卡片实体](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/cardkit-v1/card/create)接口返回。</para>
/// <para>- 该接口可用于将由[发送消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/create)等接口返回的消息 ID 转换为卡片实体 ID，以进一步对卡片进行全量更新、局部更新、或文本流式更新操作。</para>
/// <para>接口ID：7397265677100957699</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/cardkit-v1/card/id_convert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard%2fid_convert</para>
/// </summary>
public record PostCardkitV1CardsIdConvertResponseDto
{
    /// <summary>
    /// <para>消息 ID 对应的卡片 ID。可用于对该卡片进行全量更新、局部更新、或文本流式更新操作</para>
    /// <para>必填：否</para>
    /// <para>示例值：7355403067414003715</para>
    /// </summary>
    [JsonPropertyName("card_id")]
    public string? CardId { get; set; }
}
