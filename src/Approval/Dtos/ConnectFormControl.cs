// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="ConnectFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>关联审批</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 关联审批
    /// </summary>
    /// <param name="Value">控件值</param>
    public record ConnectFormControl([property: JsonPropertyName("value")] string[] Value) : FormControlBase("connect");

}
