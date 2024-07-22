// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="GetHireV1AgenciesQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询猎头供应商信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询猎头供应商信息 响应体
/// <para>根据猎头供应商名称查询猎头供应商信息。</para>
/// <para>接口ID：6965472560995074050</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/agency/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fquery</para>
/// </summary>
public record GetHireV1AgenciesQueryResponseDto
{
    /// <summary>
    /// <para>数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Agency[]? Items { get; set; }

    /// <summary>
    /// <para>数据</para>
    /// </summary>
    public record Agency
    {
        /// <summary>
        /// <para>猎头供应商ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6898173495386147079</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>猎头供应商名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：超越猎头公司</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>供应商联系人唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_f476cb099ac9227c9bae09ce46112579</para>
        /// </summary>
        [JsonPropertyName("contactor_id")]
        public string? ContactorId { get; set; }

        /// <summary>
        /// <para>供应商联系人名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("contactor_name")]
        public I18n? ContactorName { get; set; }

        /// <summary>
        /// <para>供应商联系人名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：test</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }
    }
}
