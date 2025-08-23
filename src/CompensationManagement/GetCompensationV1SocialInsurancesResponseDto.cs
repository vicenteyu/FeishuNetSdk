// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="GetCompensationV1SocialInsurancesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取险种配置列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 获取险种配置列表 响应体
/// <para>获取飞书人事系统中社保公积金设置下的险种配置详细列表，包括险种名称、类型等信息。</para>
/// <para>接口ID：7420038908975415298</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_insurance/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_insurance%2flist</para>
/// </summary>
public record GetCompensationV1SocialInsurancesResponseDto
{
    /// <summary>
    /// <para>险种列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public SocialInsurance[]? Items { get; set; }

    /// <summary>
    /// <para>险种列表</para>
    /// </summary>
    public record SocialInsurance
    {
        /// <summary>
        /// <para>险种唯一ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7207415762276992556</para>
        /// <para>最大长度：256</para>
        /// <para>最小长度：8</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>险种名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n Name { get; set; } = new();

        /// <summary>
        /// <para>险种名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：生育保险</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：maternity insurance</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>险种类型. social_insurance: 社保; provident_fund: 公积金</para>
        /// <para>必填：是</para>
        /// <para>示例值：social_insurance</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：8</para>
        /// <para>可选值：<list type="bullet">
        /// <item>social_insurance：社保</item>
        /// <item>provident_fund：公积金</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("insurance_type")]
        public string InsuranceType { get; set; } = string.Empty;

        /// <summary>
        /// <para>启用状态，true：启用，false：停用；</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>是否为系统预置险种，true：预置险种，false：自定义险种</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_system")]
        public bool IsSystem { get; set; }
    }
}
