// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-23
//
// Last Modified By : yxr
// Last Modified On : 2025-12-23
// ************************************************************************
// <copyright file="EntityCardDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>卡片实体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 卡片实体
    /// </summary>
    public record EntityCardDto : MessageCard
    {
        /// <summary>
        /// 卡片类型，固定值为：card
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; init; } = "card";

        /// <summary>
        /// 卡片内容
        /// </summary>
        [JsonPropertyName("data")]
        public EntityCardData Data { get; set; } = new();

        /// <summary>
        /// 卡片内容
        /// </summary>
        public record EntityCardData
        {
            /// <summary>
            /// 模板ID
            /// </summary>
            [JsonPropertyName("card_id")]
            public string CardId { get; set; } = string.Empty;
        }

        /// <summary>
        /// 输出格式化字符串
        /// </summary>
        public override string ToString() => System.Text.Json.JsonSerializer.Serialize(this);
    }
}
