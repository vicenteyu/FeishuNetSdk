// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="AttachmentFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>附件</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 附件
    /// </summary>
    /// <param name="Value">控件值</param>
    public record AttachmentFormControl([property: JsonPropertyName("value")] string[] Value) : FormControlBase("attachmentV2");

}
