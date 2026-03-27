// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="PatchApplicationV7ApplicationsByAppIdAbilityBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新应用能力配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 更新应用能力配置 请求体
/// <para>通过该接口可更新自建应用的应用能力（机器人、网页应用等）相关配置，不传入的参数则保持不变，仅针对传入的参数则进行更新。如果应用正在审核中，则无法更新配置</para>
/// <para>接口ID：7621030901518601175</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v7/application-v7/application-ability/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v7%2fapplication-v7%2fapplication-ability%2fpatch</para>
/// </summary>
public record PatchApplicationV7ApplicationsByAppIdAbilityBodyDto
{
    /// <summary>
    /// <para>网页应用</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("web_app")]
    public AppAbilityWeb? WebApp { get; set; }

    /// <summary>
    /// <para>网页应用</para>
    /// </summary>
    public record AppAbilityWeb
    {
        /// <summary>
        /// <para>是否开启网页应用能力</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// <para>PC端链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://open.feishu.cn/</para>
        /// <para>最大长度：512</para>
        /// </summary>
        [JsonPropertyName("pc_url")]
        public string? PcUrl { get; set; }

        /// <summary>
        /// <para>PC端新页面打开方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：new_tab</para>
        /// <para>可选值：<list type="bullet">
        /// <item>new_tab：PC新页面在飞书打开</item>
        /// <item>browser：PC新页面在浏览器打开</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("pc_new_page_open_mode")]
        public string? PcNewPageOpenMode { get; set; }

        /// <summary>
        /// <para>移动端链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://open.feishu.cn/</para>
        /// <para>最大长度：512</para>
        /// </summary>
        [JsonPropertyName("mobile_url")]
        public string? MobileUrl { get; set; }
    }

    /// <summary>
    /// <para>机器人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("bot")]
    public AppAbilityBot? Bot { get; set; }

    /// <summary>
    /// <para>机器人</para>
    /// </summary>
    public record AppAbilityBot
    {
        /// <summary>
        /// <para>是否开启</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// <para>消息卡片的回调地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://open.feishu.cn</para>
        /// </summary>
        [JsonPropertyName("message_card_callback_url")]
        public string? MessageCardCallbackUrl { get; set; }

        /// <summary>
        /// <para>国际化内容</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("i18ns")]
        public AppAbilityBotI18n[]? I18ns { get; set; }

        /// <summary>
        /// <para>国际化内容</para>
        /// </summary>
        public record AppAbilityBotI18n
        {
            /// <summary>
            /// <para>语种类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh_cn</para>
            /// <para>可选值：<list type="bullet">
            /// <item>zh_cn：中文</item>
            /// <item>en_us：英文</item>
            /// <item>ja_jp：日文</item>
            /// <item>zh_hk：繁体中文(中国香港)</item>
            /// <item>zh_tw：繁体中文(中国台湾)</item>
            /// <item>id_id：印度尼西亚语</item>
            /// <item>ms_my：马来语</item>
            /// <item>de_de：德语</item>
            /// <item>es_es：西班牙语</item>
            /// <item>fr_fr：法语</item>
            /// <item>it_it：意大利语</item>
            /// <item>pt_br：葡萄牙语(巴西)</item>
            /// <item>vi_vn：越南语</item>
            /// <item>ru_ru：俄语</item>
            /// <item>th_th：泰语</item>
            /// <item>ko_kr：韩语</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("i18n_key")]
            public string I18nKey { get; set; } = string.Empty;

            /// <summary>
            /// <para>如何开始使用描述文案</para>
            /// <para>必填：是</para>
            /// <para>示例值：如何使用机器人</para>
            /// <para>最大长度：64</para>
            /// </summary>
            [JsonPropertyName("get_started_desc")]
            public string GetStartedDesc { get; set; } = string.Empty;
        }
    }
}
