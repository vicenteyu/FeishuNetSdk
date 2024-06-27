// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="DepartmentFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>部门</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 部门
    /// </summary>
    /// <param name="Value">控件值</param>
    public record DepartmentFormControl([property: JsonPropertyName("value")] DepartmentFormControl.ValueDto[] Value) : FormControlBase("department")
    {
        /// <summary>
        /// 控件值类型
        /// </summary>
        /// <param name="OpenId">控件ID</param>
        public record ValueDto([property: JsonPropertyName("open_id")] string OpenId);
    }

}
