// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-11
//
// Last Modified By : yxr
// Last Modified On : 2024-07-11
// ************************************************************************
// <copyright file="PostImV1MessagesByMessageIdPushFollowUpBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加跟随气泡 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 添加跟随气泡 请求体
/// <para>调用该接口在最新一条消息下方添加气泡样式的内容，当消息接收者点击气泡或者新消息到达后，气泡消失。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 跟随气泡的效果在飞书客户端 v7.20 及以上版本生效。</para>
/// <para>- 仅支持在当前机器人与用户单聊的消息上添加跟随气泡，且消息需要符合：</para>
/// <para>- 消息是机器人发送的。</para>
/// <para>- 消息是会话内最新的消息。</para>
/// <para>- 消息发送后未超过 600 秒。</para>
/// <para>## 注意事项</para>
/// <para>添加跟随气泡后，会话内的用户点击气泡会自动转换为该用户发送的一条消息，你可以为应用订阅[接收消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/events/receive)事件，接收用户发送的消息并判断是否为跟随气泡的内容。</para>
/// <para>接口ID：7377650885165268995</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/push_follow_up</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fpush_follow_up</para>
/// </summary>
public record PostImV1MessagesByMessageIdPushFollowUpBodyDto
{
    /// <summary>
    /// <para>跟随气泡列表。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：3</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("follow_ups")]
    public FollowUp[] FollowUps { get; set; } = Array.Empty<FollowUp>();

    /// <summary>
    /// <para>跟随气泡列表。</para>
    /// </summary>
    public record FollowUp
    {
        /// <summary>
        /// <para>气泡的内容。</para>
        /// <para>必填：是</para>
        /// <para>示例值：你好</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// <para>气泡的多语言内容。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("i18n_contents")]
        public I18nContent[]? I18nContents { get; set; }

        /// <summary>
        /// <para>气泡的多语言内容。</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>`language` 参数对应的内容。</para>
            /// <para>必填：是</para>
            /// <para>示例值：hello</para>
            /// <para>最大长度：200</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string Content { get; set; } = string.Empty;

            /// <summary>
            /// <para>语言类型。</para>
            /// <para>必填：是</para>
            /// <para>示例值：en_us</para>
            /// <para>可选值：<list type="bullet">
            /// <item>en_us：英文</item>
            /// <item>zh_cn：简体中文</item>
            /// <item>zh_hk：繁体中文-香港</item>
            /// <item>zh_tw：繁体中文-台湾</item>
            /// <item>ja_jp：日语</item>
            /// <item>id_id：印尼语</item>
            /// <item>vi_vn：越南语</item>
            /// <item>th_th：泰语</item>
            /// <item>pt_br：葡萄牙语</item>
            /// <item>es_es：西班牙语</item>
            /// <item>ko_kr：韩语</item>
            /// <item>de_de：德语</item>
            /// <item>fr_fr：法语</item>
            /// <item>it_it：意大利语</item>
            /// <item>ru_ru：俄语</item>
            /// <item>ms_my：马来语</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("language")]
            public string Language { get; set; } = string.Empty;
        }
    }
}
