// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="FormBaseElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>表单容器交互控件</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 表单容器交互控件
    /// </summary>
    /// <param name="Tag">控件标签</param>
    /// <param name="Name">组件的唯一标识</param>
    public abstract record FormBaseElement(string Tag, string Name = "") : Element(Tag)
    {
        /// <summary>
        /// 组件的唯一标识。用于识别用户在交互后，提交的是哪个表单项的数据。在表单容器中所有的交互组件中，该字段必填，否则数据会发送失败。
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = Name;
    }
}
