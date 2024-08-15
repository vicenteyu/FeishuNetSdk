// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-12
//
// Last Modified By : yxr
// Last Modified On : 2024-08-12
// ************************************************************************
// <copyright file="SystemDividerContent.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>系统消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 系统消息
    /// <para>仅支持使用 tenant_access_token 调用发送消息接口，发送特定模板的系统消息，除接口必须权限外，还需要拥有 发送特定模板系统消息 (im:message:send_sys_msg) 权限。</para>
    /// <para>飞书客户端版本需要在 V7.20 及以上，才能正常显示分割线系统消息，低于此版本将仅展示文本内容。</para>
    /// </summary>
    /// <param name="Params">系统消息参数。</param>
    /// <param name="Options">可选配置项。</param>
    public record SystemDividerContent(SystemDividerContent.ParamsSuffix? Params = null, SystemDividerContent.OptionsSuffix? Options = null)
        : MessageContent("system")
    {
        /// <summary>
        /// 系统消息类型。仅支持取值 divider，表示分割线。目前该类型仅支持在机器人与用户的单聊（p2p）中生效。
        /// </summary>
        [JsonPropertyName("type")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:将成员标记为 static", Justification = "<挂起>")]
        public string Type => "divider";

        /// <summary>
        /// 系统消息参数。
        /// </summary>
        [JsonPropertyName("params")]
        public ParamsSuffix Params { get; set; } = Params ?? new();

        /// <summary>
        /// 分割线系统消息的内容。当 type 为 divider 时该参数必填。
        /// </summary>
        /// <param name="DividerText"></param>
        public record ParamsSuffix([property: JsonPropertyName("divider_text")] ParamsSuffix.DividerTextSuffix? DividerText = null)
        {
            /// <summary>
            /// 分割线系统消息的内容。当 type 为 divider 时该参数必填。
            /// </summary>
            /// <param name="Text">默认文本。
            /// <para>该参数为必填参数，不能传空值。</para>
            /// <para>文本长度不能超过 20 个字符或 10 个汉字。</para>
            /// </param>
            /// <param name="I18nText">国际化文本，多语言环境下，优先使用该值。格式为 {key:value} 形式。
            /// <para></para>
            /// </param>
            public record DividerTextSuffix([property: JsonPropertyName("text")] string Text = "", [property: JsonPropertyName("i18n_text")] I18nLanguageUppercase<string>? I18nText = null);
        }

        /// <summary>
        /// 可选配置项，格式为 {key:value} 形式，key 为枚举值，value 为枚举值的取值。
        /// </summary>
        [JsonPropertyName("options")]
        public OptionsSuffix Options { get; set; } = Options ?? new();

        /// <summary>
        /// 可选配置项，格式为 {key:value} 形式，key 为枚举值，value 为枚举值的取值。
        /// </summary>
        /// <param name="NeedRollup">是否需要滚动清屏，boolean 类型参数，默认取值 false，表示不需要。</param>
        public record OptionsSuffix([property: JsonPropertyName("need_rollup")] bool NeedRollup = false);
    }
}
