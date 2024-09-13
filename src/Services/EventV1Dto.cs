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
    /// 事件头 V1.0
    /// </summary>
    public record EventV1Dto<T> : EventDto<T> where T : EventBodyDto
    {
        /// <summary>
        /// 事件唯一Id
        /// </summary>
        [JsonPropertyName("event_id")]
        public override string EventId => Uuid;

        /// <summary>
        /// <para>事件发送的时间，一般近似于事件发生的时间。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ts")]
        public string? Ts { get; set; }

        /// <summary>
        /// <para>事件的唯一标识。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; } = string.Empty;

        /// <summary>
        /// <para>此事件此处始终为event_callback。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
