// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="FormInputElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>输入框组件</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 输入框组件
    /// <para>扩展方法：
    /// <list type="bullet">
    /// <item>SetElements</item>
    /// </list>
    /// </para>
    /// </summary>
    /// <param name="Name">组件的唯一标识。</param>
    /// <param name="Required">是否必填
    /// <para>true：必填。当用户点击表单容器的“提交”时，未填写该组件，则前端提示“有必填项未填写”，不会向开发者的服务端发起回传请求。</para>
    /// <para>false：选填。当用户点击表单容器的“提交”时，未填写该组件，仍提交表单容器中的数据。</para>
    /// </param>
    public record FormInputElement(string Name = "", [property: JsonPropertyName("required")] bool? Required = null)
        : FormBaseElement("input", Name);
}
