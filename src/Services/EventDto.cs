// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Services
{
    /// <summary>
    /// 事件序列化基类
    /// </summary>
    /// <typeparam name="T">事件主体</typeparam>
    public record EventDto<T> : EventDto where T : EventBodyDto
    {
        /// <summary>
        /// 类型鉴别器
        /// </summary>
        [JsonIgnore]
        public override string? Discriminator => Event?.Discriminator;

        /// <summary>
        /// <para>事件体</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("event")]
        public T? Event { get; set; }
    }
}
