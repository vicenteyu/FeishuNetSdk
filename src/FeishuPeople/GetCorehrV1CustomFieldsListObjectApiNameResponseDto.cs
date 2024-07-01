// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCorehrV1CustomFieldsListObjectApiNameResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取飞书人事对象列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取飞书人事对象列表 响应体
/// <para>获取「飞书人事」中的对象列表，含系统预置对象与自定义对象。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
/// <para>接口ID：7112009113388105756</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/list_object_api_name</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcustom_field%2flist_object_api_name</para>
/// </summary>
public record GetCorehrV1CustomFieldsListObjectApiNameResponseDto
{
    /// <summary>
    /// <para>对象列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Object[]? Items { get; set; }

    /// <summary>
    /// <para>对象列表</para>
    /// </summary>
    public record Object
    {
        /// <summary>
        /// <para>对象的唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：offboarding_info</para>
        /// </summary>
        [JsonPropertyName("object_api_name")]
        public string? ObjectApiName { get; set; }

        /// <summary>
        /// <para>对象名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public ObjectName? Name { get; set; }

        /// <summary>
        /// <para>对象名称</para>
        /// </summary>
        public record ObjectName
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：cn</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：en</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_open")]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// <para>创建时间，秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1644992809</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间，秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1644992809</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：3</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
