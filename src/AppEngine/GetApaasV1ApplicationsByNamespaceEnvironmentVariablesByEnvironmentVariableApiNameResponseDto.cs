// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-29
//
// Last Modified By : yxr
// Last Modified On : 2024-06-29
// ************************************************************************
// <copyright file="GetApaasV1ApplicationsByNamespaceEnvironmentVariablesByEnvironmentVariableApiNameResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询环境变量详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 查询环境变量详情 响应体
/// <para>查询基于飞书应用引擎开发的应用的环境变量详情，包括名称、描述、变量值等</para>
/// <para>接口ID：7385474062586314754</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/application-environment_variable/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-environment_variable%2fget</para>
/// </summary>
public record GetApaasV1ApplicationsByNamespaceEnvironmentVariablesByEnvironmentVariableApiNameResponseDto
{
    /// <summary>
    /// <para>环境变量详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("item")]
    public EnvironmentVariable? Item { get; set; }

    /// <summary>
    /// <para>环境变量详情</para>
    /// </summary>
    public record EnvironmentVariable
    {
        /// <summary>
        /// <para>环境变量 API 名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：globalParam_0b410b17704</para>
        /// </summary>
        [JsonPropertyName("api_name")]
        public string ApiName { get; set; } = string.Empty;

        /// <summary>
        /// <para>环境变量的名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("label")]
        public EnvironmentVariableLabel Label { get; set; } = new();

        /// <summary>
        /// <para>环境变量的名称</para>
        /// </summary>
        public record EnvironmentVariableLabel
        {
            /// <summary>
            /// <para>中文内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：示例文本</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string ZhCn { get; set; } = string.Empty;

            /// <summary>
            /// <para>英文内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：Sample text</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string EnUs { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：是</para>
        /// <para>示例值：Sample text</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// <para>返回 json marshal 后的字符串。 is_encrypted 为 「true」时，依然可以获取返回值</para>
        /// <para>必填：是</para>
        /// <para>示例值：[1757083131077684,1757085362739239,1757083720703032]</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否加密，「type」取值为 text, float 时才有效</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_encrypted")]
        public bool? IsEncrypted { get; set; }

        /// <summary>
        /// <para>对象的 API 名称，「type」取值为 lookup, lookup_multi 时才有效</para>
        /// <para>必填：否</para>
        /// <para>示例值：_user</para>
        /// </summary>
        [JsonPropertyName("object_api_name")]
        public string? ObjectApiName { get; set; }

        /// <summary>
        /// <para>对象的名称，「type」取值为 lookup, lookup_multi 时才有效</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("object_label")]
        public LabelSuffix? ObjectLabel { get; set; }

        /// <summary>
        /// <para>对象的名称，「type」取值为 lookup, lookup_multi 时才有效</para>
        /// </summary>
        public record LabelSuffix
        {
            /// <summary>
            /// <para>中文内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：示例文本</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string ZhCn { get; set; } = string.Empty;

            /// <summary>
            /// <para>英文内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：Sample text</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string EnUs { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>「创建时间」，日期时间字段。 使用 Unix 时间戳，单位为毫秒</para>
        /// <para>必填：否</para>
        /// <para>示例值：1718350902019</para>
        /// <para>最大值：9223372036854775807</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>「更新时间」，日期时间字段。 使用 Unix 时间戳，单位为毫秒</para>
        /// <para>必填：是</para>
        /// <para>示例值：1718350902019</para>
        /// <para>最大值：9223372036854775807</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public long UpdatedAt { get; set; }

        /// <summary>
        /// <para>环境变量的类型，可取值范围有：lookup, lookup_multi, text, float 等</para>
        /// <para>必填：否</para>
        /// <para>示例值：lookup</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
