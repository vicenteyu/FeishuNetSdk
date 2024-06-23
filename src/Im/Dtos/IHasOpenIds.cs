// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="IHasOpenIds.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 用户Id
    /// </summary>
    public interface IHasOpenIds
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        string[]? OpenIds { get; set; }
    }
}
