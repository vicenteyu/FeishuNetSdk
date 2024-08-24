// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="GetHireV1TalentPoolsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取人才库列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取人才库列表 响应体
/// <para>获取人才库列表，可获取的信息包括人才库ID、人才库名称等。</para>
/// <para>接口ID：7218853190452428804</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent_pool/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_pool%2fsearch</para>
/// </summary>
public record GetHireV1TalentPoolsResponseDto
{
    /// <summary>
    /// <para>人才库列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public TalentPool[]? Items { get; set; }

    /// <summary>
    /// <para>人才库列表</para>
    /// </summary>
    public record TalentPool
    {
        /// <summary>
        /// <para>人才库 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114324</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>人才库名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public I18n? I18nName { get; set; }

        /// <summary>
        /// <para>人才库名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：公共人才库</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Common Talent Pool</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>人才库描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_description")]
        public I18n? I18nDescription { get; set; }

        /// <summary>
        /// <para>父级人才库 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114324</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>是否「部分用户可见」</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：代表部分用户可见。具体而言，只有满足授权条件的用户，才能查看人才库。授权条件的维度包括：角色、部门、用户</item>
        /// <item>2：代表全部用户可见。这里的全部用户指的是拥有「查看人才库」权限的用户</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("is_private")]
        public int? IsPrivate { get; set; }

        /// <summary>
        /// <para>人才库创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1679300424000</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>人才库修改时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1679300424000</para>
        /// </summary>
        [JsonPropertyName("modify_time")]
        public string? ModifyTime { get; set; }
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
