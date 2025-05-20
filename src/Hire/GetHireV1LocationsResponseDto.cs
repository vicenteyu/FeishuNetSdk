// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-12
//
// Last Modified By : yxr
// Last Modified On : 2024-07-12
// ************************************************************************
// <copyright file="GetHireV1LocationsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取地址列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取地址列表 响应体
/// <para>获取地址列表，可查询到的信息包括地址与地点信息，可应用在职位地点、面试地点、人才意向工作城市等场景。</para>
/// <para>## 名词解释</para>
/// <para>地点和地址的描述如下：</para>
/// <para>- 地点：行政区域划分，如 「中国大陆」、「四川省」、「成都市」、「高新区」</para>
/// <para>- 地址：具体地理位置，包括职位地址、面试地址、门店地址，如：「中国四川省成都市成华区熊猫大道 1375 号」</para>
/// <para>接口ID：6990661791098683395</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/location/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2flocation%2flist</para>
/// </summary>
public record GetHireV1LocationsResponseDto : IPageableResponse<GetHireV1LocationsResponseDto.Location>
{
    /// <summary>
    /// <para>地址和地点信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Location[]? Items { get; set; }

    /// <summary>
    /// <para>地址和地点信息列表</para>
    /// </summary>
    public record Location
    {
        /// <summary>
        /// <para>地址 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1213213123123</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>地址名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>地址名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>地址中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：中国四川省成都市成华区熊猫大道 1375 号</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>地址英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：No. 1375, Panda Avenue, Chenghua District, Chengdu, Sichuan, China</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>区信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("district")]
        public CodeNameObject? District { get; set; }

        /// <summary>
        /// <para>区信息</para>
        /// </summary>
        public record CodeNameObject
        {
            /// <summary>
            /// <para>区编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：MDCA00009061</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>区名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>区名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>区中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：高新区</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>区英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Gaoxin</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>市信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("city")]
        public CodeNameObject? City { get; set; }

        /// <summary>
        /// <para>省份/州信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("state")]
        public CodeNameObject? State { get; set; }

        /// <summary>
        /// <para>国家信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("country")]
        public CodeNameObject? Country { get; set; }

        /// <summary>
        /// <para>地址启用状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：已启用</item>
        /// <item>2：已禁用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("active_status")]
        public int? ActiveStatus { get; set; }
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
    /// <para>示例值：eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
