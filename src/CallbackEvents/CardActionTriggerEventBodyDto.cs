// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2024-09-07
// ************************************************************************
// <copyright file="CardActionTriggerEventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>卡片回传交互 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.CallbackEvents
{
    /// <summary>
    /// 卡片回传交互 事件体
    /// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-callback-communication</para>
    /// </summary>
    public record CardActionTriggerEventBodyDto() : EventBodyDto("card.action.trigger")
    {
        /// <summary>
        /// 回调触发者信息。
        /// </summary>
        [JsonPropertyName("operator")]
        public OperatorSuffix? Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 交互信息。
        /// </summary>
        [JsonPropertyName("action")]
        public ActionSuffix? Action { get; set; }

        /// <summary>
        /// 卡片展示场景。
        /// </summary>
        [JsonPropertyName("host")]
        public string? Host { get; set; }

        /// <summary>
        /// 卡片分发类型，固定取值为 url_preview，表示链接预览卡片仅链接预览卡片有此字段
        /// </summary>
        [JsonPropertyName("delivery_type")]
        public string? DeliveryType { get; set; }

        /// <summary>
        /// 展示场景上下文。
        /// </summary>
        [JsonPropertyName("context")]
        public ContextSuffix? Context { get; set; }

        /// <summary>
        /// 回调触发者信息。
        /// </summary>
        public record OperatorSuffix
        {
            /// <summary>
            /// 回调触发者的 tenant key，即租户唯一标识。
            /// </summary>
            [JsonPropertyName("tenant_key")]
            public string? TenantKey { get; set; }

            /// <summary>
            /// 回调触发者的 user_id。
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// 回调触发者的 open_id。
            /// </summary>
            [JsonPropertyName("open_id")]
            public string? OpenId { get; set; }

            /// <summary>
            /// 回调触发者的 union_id。
            /// </summary>
            [JsonPropertyName("union_id")]
            public string? UnionId { get; set; }
        }

        /// <summary>
        /// 交互信息。
        /// </summary>
        public record ActionSuffix
        {
            /// <summary>
            /// 交互组件绑定的开发者自定义回传数据，对应组件中的 value 属性。类型为 string 或 object，可由开发者指定。
            /// </summary>
            [JsonPropertyName("value")]
            public Dictionary<string, object>? Value { get; set; }

            /// <summary>
            /// 交互组件的标签。
            /// </summary>
            [JsonPropertyName("tag")]
            public string? Tag { get; set; }

            /// <summary>
            /// 用户当前所在地区的时区。当用户操作日期选择器、时间选择器、或日期时间选择器时返回。
            /// </summary>
            [JsonPropertyName("timezone")]
            public string? Timezone { get; set; }

            /// <summary>
            /// 表单容器内用户提交的数据
            /// </summary>
            [JsonPropertyName("form_value")]
            public Dictionary<string, object>? FormValue { get; set; }

            /// <summary>
            /// 组件的自定义唯一标识，用于识别内嵌在表单容器中的某个组件。
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// 当输入框组件未内嵌在表单容器中时，用户在输入框中提交的数据。
            /// </summary>
            [JsonPropertyName("input_value")]
            public string? InputValue { get; set; }

            /// <summary>
            /// 当折叠按钮组、下拉选择-单选、人员选择-单选、日期选择器、时间选择器、日期时间选择器组件未内嵌在表单容器中时，用户选择该类组件某个选项时，组件返回的选项回调值。
            /// </summary>
            [JsonPropertyName("option")]
            public string? Option { get; set; }

            /// <summary>
            /// 当下拉选择-多选组件和人员选择-多选组件未内嵌在表单容器中时，用户选择该类组件某个选项时，组件返回的选项回调值。
            /// </summary>
            [JsonPropertyName("options")]
            public string[]? Options { get; set; }

            /// <summary>
            /// 当勾选器组件未内嵌在表单容器中时，勾选器组件的回调数据。
            /// </summary>
            [JsonPropertyName("checked")]
            public bool? Checked { get; set; }
        }

        /// <summary>
        /// 展示场景上下文。
        /// </summary>
        public record ContextSuffix
        {
            /// <summary>
            /// 链接地址（适用于链接预览场景）
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }

            /// <summary>
            /// 链接预览的 token（适用于链接预览场景）
            /// </summary>
            [JsonPropertyName("preview_token")]
            public string? PreviewToken { get; set; }

            /// <summary>
            /// 卡片所在的消息 ID
            /// </summary>
            [JsonPropertyName("open_message_id")]
            public string? OpenMessageId { get; set; }

            /// <summary>
            /// 卡片所在的会话 ID
            /// </summary>
            [JsonPropertyName("open_chat_id")]
            public string? OpenChatId { get; set; }
        }
    }

    /// <summary>
    /// 卡片回传交互 响应体
    /// </summary>
    public record CardActionTriggerResponseDto : CallbackResponseDto
    {
        /// <summary>
        /// 客户端的 Toast 弹窗提示。
        /// </summary>
        [JsonPropertyName("toast"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ToastSuffix? Toast { get; set; }

        /// <summary>
        /// 卡片数据。
        /// </summary>
        [JsonPropertyName("card"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CardSuffix? Card { get; set; }

        /// <summary>
        /// 客户端的 Toast 弹窗提示。
        /// </summary>
        public record ToastSuffix
        {
            /// <summary>
            /// 弹窗提示的类型。可选值有：info、success、error、和 warning。
            /// </summary>
            [JsonPropertyName("type")]
            public ToastType? Type { get; set; }

            /// <summary>
            /// 单语言提示文案。要配置多语言提示文案，请使用 i18n 字段。
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// 多语言提示文案。
            /// </summary>
            [JsonPropertyName("i18n")]
            public I18nLanguage<string>? I18n { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonConverter(typeof(SnakeCaseLowerConverter<ToastType>))]
            public enum ToastType
            {
                /// <summary>
                /// 
                /// </summary>
                Info,

                /// <summary>
                /// 
                /// </summary>
                Success,

                /// <summary>
                /// 
                /// </summary>
                Error,

                /// <summary>
                /// 
                /// </summary>
                Warning
            }
        }

        /// <summary>
        /// 卡片数据。
        /// </summary>
        public record CardSuffix
        {
            /// <summary>
            /// 卡片类型。
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// 卡片的数据。不同的卡片类型所需填写的字段不同。
            /// </summary>
            [JsonPropertyName("data")]
            public object? Data { get; set; }

            /// <summary>
            /// 卡片类型。
            /// </summary>
            public enum CardType
            {
                /// <summary>
                /// 由 JSON 构建的卡片
                /// </summary>
                Raw,

                /// <summary>
                /// 搭建工具构建的卡片模板
                /// </summary>
                Template
            }
        }
    }
}
