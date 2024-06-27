// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="FormControlBase.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>审批实例控件抽象类</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 审批实例控件抽象类
    /// </summary>
    public abstract record FormControlBase(string Type)
    {
        /// <summary>
        /// 控件类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; } = Type;

        /// <summary>
        /// 控件ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
