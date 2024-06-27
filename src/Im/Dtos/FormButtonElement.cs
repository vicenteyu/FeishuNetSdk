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
    public record FormButtonElement(string Name = "",
        [property: JsonPropertyName("text")] LarkMdElement Text = default!,
        [property: JsonPropertyName("type")] string? Type = null,
        [property: JsonPropertyName("action_type")] string ActionType = "",
        [property: JsonPropertyName("confirm")] FormButtonElement.ConfirmSuffix? Confirm = null) : FormBaseElement("button", Name)
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
