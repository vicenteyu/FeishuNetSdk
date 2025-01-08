// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-01-11
//
// Last Modified By : yxr
// Last Modified On : 2025-01-11
// ************************************************************************
// <copyright file="PostCorehrV2EnumsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询枚举信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询枚举信息 响应体
/// <para>根据枚举的APIName查询枚举详细信息，用于BPM等场景获取枚举选项。</para>
/// <para>接口ID：7457854043681603588</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/enum/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fenum%2fsearch</para>
/// </summary>
public record PostCorehrV2EnumsSearchResponseDto
{
    /// <summary>
    /// <para>查询的枚举信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("enums")]
    public EnumsSuffix[]? Enums { get; set; }

    /// <summary>
    /// <para>查询的枚举信息</para>
    /// </summary>
    public record EnumsSuffix
    {
        /// <summary>
        /// <para>枚举名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：overtime_date_type</para>
        /// </summary>
        [JsonPropertyName("enum_apiname")]
        public string? EnumApiname { get; set; }

        /// <summary>
        /// <para>枚举值</para>
        /// <para>必填：否</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("enum_items")]
        public EnumField[]? EnumItems { get; set; }

        /// <summary>
        /// <para>枚举值</para>
        /// </summary>
        public record EnumField
        {
            /// <summary>
            /// <para>ApiName</para>
            /// <para>必填：否</para>
            /// <para>示例值：special_day</para>
            /// </summary>
            [JsonPropertyName("api_name")]
            public string? ApiName { get; set; }

            /// <summary>
            /// <para>枚举值名</para>
            /// <para>必填：否</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n[]? Names { get; set; }

            /// <summary>
            /// <para>枚举值名</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言编码（IETF BCP 47）</para>
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
            /// <para>枚举值描述</para>
            /// <para>必填：否</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("description")]
            public I18n[]? Descriptions { get; set; }

            /// <summary>
            /// <para>所属枚举常量ApiName</para>
            /// <para>必填：否</para>
            /// <para>示例值：overtime_date_type</para>
            /// </summary>
            [JsonPropertyName("enum_api_name")]
            public string? EnumApiName { get; set; }

            /// <summary>
            /// <para>顺序</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：255</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("order")]
            public int? Order { get; set; }

            /// <summary>
            /// <para>状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：生效</item>
            /// <item>0：失效</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }
        }
    }
}
