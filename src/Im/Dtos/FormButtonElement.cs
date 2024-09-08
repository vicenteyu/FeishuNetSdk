// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="FormButtonElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>按钮组件</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 按钮组件
    /// </summary>
    /// <param name="Name">用于提交表单的按钮组件的唯一标识，用于识别用户在交互后，点击的是哪个按钮。在表单容器中所有的交互组件中，该字段必填，否则数据会发送失败。</param>
    /// <param name="Text">用于提交表单的按钮上的文本。</param>
    /// <param name="Type">按钮的类型。可选值：
    /// <list type="bullet">
    /// <item>default：黑色字体按钮，有边框</item>
    /// <item>primary：蓝色字体按钮，有边框</item>
    /// <item>danger：红色字体按钮，有边框</item>
    /// <item>text：黑色字体按钮，无边框</item>
    /// <item>primary_text：蓝色字体按钮，无边框</item>
    /// <item>danger_text：红色字体按钮，无边框</item>
    /// <item>primary_filled：蓝底白字按钮</item>
    /// <item>danger_filled：红底白字按钮</item>
    /// <item>laser：镭射按钮</item>
    /// </list></param>
    /// <param name="ActionType">内嵌在表单容器中的按钮的交互类型。
    /// <list type="bullet">
    /// <item>link：当前按钮仅支持链接跳转</item>
    /// <item>request：当前按钮仅支持回传交互</item>
    /// <item>multi：当前按钮同时支持链接跳转和回传交互</item>
    /// <item>form_submit：将当前按钮与提交事件绑定。用户点击后，将触发表单容器的提交事件，异步提交所有已填写的表单项内容</item>
    /// <item>form_reset：将当前按钮与取消提交事件绑定。用户点击后，将触发表单容器的取消提交事件，重置所有表单组件的输入值为初始值</item>
    /// </list>
    /// </param>
    /// <param name="Confirm">二次确认弹窗配置。指在用户提交时弹出二次确认弹窗提示；只有用户点击确认后，才提交输入的内容。该字段默认提供了确认和取消按钮，你只需要配置弹窗的标题与内容即可。
    /// <para>confirm 字段仅在用户点击包含提交属性的按钮时才会触发二次确认弹窗。</para>
    /// </param>
    /// <param name="Required">组件的内容是否必填。当组件内嵌在表单容器中时，该属性生效。
    /// <list type="bullet">
    /// <item>true：必填。当用户点击表单容器的“提交”时，未填写该组件，则前端提示“有必填项未填写”，不会向开发者的服务端发起回传请求。</item>
    /// <item>false：选填。当用户点击表单容器的“提交”时，未填写该组件，仍提交表单容器中的数据。</item>
    /// </list>
    /// </param>
    /// <param name="Size">按钮的尺寸。可选值：
    /// <list type="bullet">
    /// <item>tiny：超小尺寸，PC 端为 24 px；移动端为 28 px</item>
    /// <item>small：小尺寸，PC 端为 28 px；移动端为 28 px</item>
    /// <item>medium：中尺寸，PC 端为 32 px；移动端为 36 px</item>
    /// <item>large：大尺寸，PC 端为 40 px；移动端为 48 px</item>
    /// </list>
    /// </param>
    /// <param name="Width">
    /// <list type="bullet">按钮的宽度。支持以下枚举值：
    /// <item>default：默认宽度</item>
    /// <item>fill：卡片最大支持宽度</item>
    /// <item>[100,∞)px：自定义宽度，如 120px。超出卡片宽度时将按最大支持宽度展示</item>
    /// </list>
    /// </param>
    /// <param name="Icon">添加图标作为文本前缀图标。支持自定义或使用图标库中的图标。
    /// <list type="bullet">按钮的宽度。支持以下枚举值：
    /// <item>CustomIconElement</item>
    /// <item>StandardIconElement</item>
    /// </list>
    /// </param>
    /// <param name="HoverTips">用户在 PC 端将光标悬浮在交互容器上方时的文案提醒。默认为空。</param>
    /// <param name="Disabled">是否禁按钮。可选值：
    /// <list type="bullet">
    /// <item>true：禁用按钮</item>
    /// <item>false：按钮组件保持可用状态</item>
    /// </list>
    /// </param>
    /// <param name="DisabledTips">禁用按钮后，用户触发交互时的弹窗文案提醒。默认为空，即不弹窗。</param>
    /// <param name="Behaviors">配置交互类型和具体交互行为。支持同时生效跳转链接和回传交互。
    /// <list type="bullet">
    /// <item>OpenUrlBehaviors</item>
    /// <item>CallbackBehaviors</item>
    /// <item>FormActionBehaviors</item>
    /// </list>
    /// </param>
    public record FormButtonElement(string Name = "",
        [property: JsonPropertyName("text")] PlainTextElement Text = default!,
        [property: JsonPropertyName("type")] string? Type = null,
        [property: JsonPropertyName("action_type")] string ActionType = "",
        [property: JsonPropertyName("confirm")] FormButtonElement.ConfirmSuffix? Confirm = null,
        [property: JsonPropertyName("required")] bool? Required = null,
        [property: JsonPropertyName("size")] string? Size = null,
        [property: JsonPropertyName("width")] string? Width = null,
        [property: JsonPropertyName("icon")] IAmDivIconElement? Icon = null,
        [property: JsonPropertyName("hover_tips")] PlainTextElement? HoverTips = null,
        [property: JsonPropertyName("disabled")] bool? Disabled = null,
        [property: JsonPropertyName("disabled_tips")] PlainTextElement? DisabledTips = null,
        [property: JsonPropertyName("behaviors")] Behaviors[]? Behaviors = null) : FormBaseElement("button", Name)
    {
        ///// <summary>
        ///// 用于提交表单的按钮组件的交互类型。固定取值 form_submit，表示提交表单。
        ///// </summary>
        //[JsonPropertyName("action_type")]
        //public string ActionType { get; } = "form_submit";

        /// <summary>
        /// 二次确认弹窗配置。指在用户提交时弹出二次确认弹窗提示；只有用户点击确认后，才提交输入的内容。该字段默认提供了确认和取消按钮，你只需要配置弹窗的标题与内容即可。
        /// <para>confirm 字段仅在用户点击包含提交属性的按钮时才会触发二次确认弹窗。</para>
        /// </summary>
        /// <param name="Title">二次确认弹窗标题。</param>
        /// <param name="Text">二次确认弹窗的文本内容。</param>
        public record ConfirmSuffix([property: JsonPropertyName("title")] PlainTextElement Title = default!,
            [property: JsonPropertyName("text")] PlainTextElement Text = default!);
    }
}
