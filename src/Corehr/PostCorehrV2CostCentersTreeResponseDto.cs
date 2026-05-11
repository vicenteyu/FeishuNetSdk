// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-11
//
// Last Modified By : yxr
// Last Modified On : 2026-05-11
// ************************************************************************
// <copyright file="PostCorehrV2CostCentersTreeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定生效日期的成本中心架构树 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询指定生效日期的成本中心架构树 响应体
/// <para>支持传入成本中心ID，任意日期（不传默认当前日期）</para>
/// <para>接口ID：7637139455451139033</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/tree</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2ftree</para>
/// </summary>
public record PostCorehrV2CostCentersTreeResponseDto : IPageableResponse<PostCorehrV2CostCentersTreeResponseDto.CostCenterTree>
{
    /// <summary>
    /// <para>成本中心树节点</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CostCenterTree[]? Items { get; set; }

    /// <summary>
    /// <para>成本中心树节点</para>
    /// </summary>
    public record CostCenterTree
    {
        /// <summary>
        /// <para>成本中心 ID</para>
        /// <para>- 可通过[搜索成本中心信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search) 获取详情</para>
        /// <para>必填：否</para>
        /// <para>示例值：7140964208476371111</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>成本中心层级</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>最大值：99</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("level")]
        public int? Level { get; set; }

        /// <summary>
        /// <para>下级成本中心 ID 列表</para>
        /// <para>- 可通过[搜索成本中心信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)获取详情</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("children")]
        public string[]? Children { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：7140964208476371111</para>
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
