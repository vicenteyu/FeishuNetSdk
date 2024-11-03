// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ChatsByChatIdLinkBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取群分享链接 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 获取群分享链接 请求体
/// <para>获取指定群的分享链接，他人点击分享链接后可加入群组。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>- 调用该接口的用户或机器人必须在对应群组内。</para>
/// <para>- 单聊、密聊、团队群不支持生成分享链接。</para>
/// <para>- 当机器人被停用或者退出群组时，由该机器人获取的群分享链接也将失效。</para>
/// <para>- 当群组设置了 **仅群主和群管理员可添加群成员或分享群** 时，调用该接口的用户或机器人必须是群组的群主或管理员。</para>
/// <para>- 获取内部群分享链接时，调用该接口的用户或机器人必须和群组属于同一租户。</para>
/// <para>接口ID：7139929321426386972</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/link</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2flink</para>
/// </summary>
public record PostImV1ChatsByChatIdLinkBodyDto
{
    /// <summary>
    /// <para>群分享链接有效时长</para>
    /// <para>必填：否</para>
    /// <para>示例值：week</para>
    /// <para>可选值：<list type="bullet">
    /// <item>week：有效期 7 天</item>
    /// <item>year：有效期 1 年</item>
    /// <item>permanently：永久有效</item>
    /// </list></para>
    /// <para>默认值：week</para>
    /// </summary>
    [JsonPropertyName("validity_period")]
    public string? ValidityPeriod { get; set; }
}
