// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoBankBranchsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询支行信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询支行信息 响应体
/// <para>根据银行 ID、支行 ID 、支行名称、联行号，支行状态、更新时间 查询银行信息</para>
/// <para>接口ID：7301516605753212931</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-bank_branch/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-bank_branch%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoBankBranchsSearchResponseDto
{
    /// <summary>
    /// <para>查询到的支行列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public BankBranch[]? Items { get; set; }

    /// <summary>
    /// <para>查询到的支行列表</para>
    /// </summary>
    public record BankBranch
    {
        /// <summary>
        /// <para>支行 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：MDBK00061194</para>
        /// </summary>
        [JsonPropertyName("bank_branch_id")]
        public string? BankBranchId { get; set; }

        /// <summary>
        /// <para>支行名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("bank_branch_name")]
        public I18n[]? BankBranchNames { get; set; }

        /// <summary>
        /// <para>支行名称</para>
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
        /// <para>所属银行 ID，可通过[查询银行信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-bank/search)接口查询</para>
        /// <para>必填：否</para>
        /// <para>示例值：MDBH00000080</para>
        /// </summary>
        [JsonPropertyName("bank_id")]
        public string? BankId { get; set; }

        /// <summary>
        /// <para>金融分支机构编码（即银行联行号）</para>
        /// <para>必填：否</para>
        /// <para>示例值：308100005019</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>SWIFT 银行代码（ISO 9362）</para>
        /// <para>必填：否</para>
        /// <para>示例值：CMBCCNBS201</para>
        /// </summary>
        [JsonPropertyName("swift_code")]
        public string? SwiftCode { get; set; }

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

        /// <summary>
        /// <para>Bank Branch Code（特定国家地区使用）</para>
        /// <para>必填：否</para>
        /// <para>示例值：B04</para>
        /// </summary>
        [JsonPropertyName("bank_branch_code")]
        public string? BankBranchCode { get; set; }

        /// <summary>
        /// <para>注册地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：北京市朝阳区</para>
        /// </summary>
        [JsonPropertyName("register_place")]
        public string? RegisterPlace { get; set; }

        /// <summary>
        /// <para>银行地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：北京市朝阳区</para>
        /// </summary>
        [JsonPropertyName("bank_address")]
        public string? BankAddress { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-01-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：MDBK00000120</para>
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
