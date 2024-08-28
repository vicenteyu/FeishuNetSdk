// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1JobTypesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取职位类别列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取职位类别列表 响应体
/// <para>获取招聘系统预置的职位类别列表，可用于操作职位（如[新建职位](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/combined_create)），操作招聘需求（如[创建招聘需求](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement/create)）时回填职位类别字段。返回列表默认按创建时间升序排序，且包含节点的层级关系（节点的父节点 ID），可在获取全量数据后自行构建职位类别树。</para>
/// <para>接口ID：7287407243900895234</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_type/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_type%2flist</para>
/// </summary>
public record GetHireV1JobTypesResponseDto
{
    /// <summary>
    /// <para>职位类别列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("items")]
    public JobTypeInfo[]? Items { get; set; }

    /// <summary>
    /// <para>职位类别列表</para>
    /// </summary>
    public record JobTypeInfo
    {
        /// <summary>
        /// <para>职位类别 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6930815272790114324</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>职位类别名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n Name { get; set; } = new();

        /// <summary>
        /// <para>职位类别名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>职位类别中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：金融</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>职位类别英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：finance</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>父级职位类别 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114323</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
