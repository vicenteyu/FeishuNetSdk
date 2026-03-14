// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-14
//
// Last Modified By : yxr
// Last Modified On : 2026-03-14
// ************************************************************************
// <copyright file="GetApprovalV4DistrictsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询地理库信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 查询地理库信息 响应体
/// <para>获取审批的地理库数据，用于在发起审批时填写地址控件的区域信息</para>
/// <para>接口ID：7579169568158518477</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/district/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fdistrict%2flist</para>
/// </summary>
public record GetApprovalV4DistrictsResponseDto : IPageableResponse<GetApprovalV4DistrictsResponseDto.District>
{
    /// <summary>
    /// <para>地理库的版本，地理库更新时版本会同步更新，如果应用将地理数据存在本地，需要定时判断版本，在变化以及时更新本地数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：7569941109133377539</para>
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

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
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>区域列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public District[]? Items { get; set; }

    /// <summary>
    /// <para>区域列表</para>
    /// </summary>
    public record District
    {
        /// <summary>
        /// <para>区域的唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：2038349</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：Beijing</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>层级</para>
        /// <para>必填：否</para>
        /// <para>示例值：Province</para>
        /// </summary>
        [JsonPropertyName("level")]
        public string? Level { get; set; }

        /// <summary>
        /// <para>是否有子区域</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("has_sub_district")]
        public bool? HasSubDistrict { get; set; }

        /// <summary>
        /// <para>父区域列表，顺序由叶子节点到根节点，不包含叶子节点本身，仅遍历方式为leaf_level时返回</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("parent_districts")]
        public DistrictBaseInfo[]? ParentDistricts { get; set; }

        /// <summary>
        /// <para>父区域列表，顺序由叶子节点到根节点，不包含叶子节点本身，仅遍历方式为leaf_level时返回</para>
        /// </summary>
        public record DistrictBaseInfo
        {
            /// <summary>
            /// <para>区域的唯一标识</para>
            /// <para>必填：否</para>
            /// <para>示例值：1814991</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：China</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>层级</para>
            /// <para>必填：否</para>
            /// <para>示例值：Country</para>
            /// </summary>
            [JsonPropertyName("level")]
            public string? Level { get; set; }
        }
    }
}
