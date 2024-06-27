// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="FormElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>表单内部控件基类</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 表单内部控件基类
    /// </summary>
    /// <param name="Tag">控件标签</param>
    public abstract record FormElement(string Tag) : Element(Tag);
}
