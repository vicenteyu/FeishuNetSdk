// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="PostCorehrV2PathwaysBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取通道信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取通道信息 响应体
/// <para>根据通道的ID批量获取通道的名称、编码、描述信息</para>
/// <para>接口ID：7508634905586991107</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpathway%2fbatch_get</para>
/// </summary>
public record PostCorehrV2PathwaysBatchGetResponseDto
{
    /// <summary>
    /// <para>查询的通道信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Pathway[]? Items { get; set; }

    /// <summary>
    /// <para>查询的通道信息</para>
    /// </summary>
    public record Pathway
    {
        /// <summary>
        /// <para>通道 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4692446793125560154</para>
        /// </summary>
        [JsonPropertyName("pathway_id")]
        public string? PathwayId { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：A01234</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("names")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文用zh-CN，英文用en-US</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>文本内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：中文示例</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("descriptions")]
        public I18n[]? Descriptions { get; set; }

        /// <summary>
        /// <para>停启用状态；true：启用，false：停用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }
    }
}
