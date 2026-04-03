// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="GetCorehrV2CustomOrgQuerybyidResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询单个人员自定义组织变更记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询单个人员自定义组织变更记录 响应体
/// <para>根据自定义组织 id 查询自定义组织变更记录</para>
/// <para>接口ID：7425878850969419780</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/employee-custom_org/querybyid</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee-custom_org%2fquerybyid</para>
/// </summary>
public record GetCorehrV2CustomOrgQuerybyidResponseDto
{
    /// <summary>
    /// <para>详情</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("custom_org")]
    public EmpCustomOrgList[] CustomOrgs { get; set; } = [];

    /// <summary>
    /// <para>详情</para>
    /// </summary>
    public record EmpCustomOrgList
    {
        /// <summary>
        /// <para>自定义组织列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_org_list")]
        public CustomOrgList[]? CustomOrgLists { get; set; }

        /// <summary>
        /// <para>自定义组织列表</para>
        /// </summary>
        public record CustomOrgList
        {
            /// <summary>
            /// <para>自定义组织名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：编制单元</para>
            /// </summary>
            [JsonPropertyName("custom_org_name")]
            public I18nV2? CustomOrgName { get; set; }

            /// <summary>
            /// <para>自定义组织名称</para>
            /// </summary>
            public record I18nV2
            {
                /// <summary>
                /// <para>zh-CN</para>
                /// <para>必填：否</para>
                /// <para>示例值：王冰</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>en-US</para>
                /// <para>必填：否</para>
                /// <para>示例值：Bob</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>自定义组织ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7293641346149138452</para>
            /// </summary>
            [JsonPropertyName("custom_org_id")]
            public string? CustomOrgId { get; set; }

            /// <summary>
            /// <para>比例</para>
            /// <para>必填：否</para>
            /// <para>示例值：42.98</para>
            /// </summary>
            [JsonPropertyName("rate")]
            public string? Rate { get; set; }
        }

        /// <summary>
        /// <para>生效时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-06-13 00:00:00</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string? EffectiveTime { get; set; }

        /// <summary>
        /// <para>变动原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：自动打标</para>
        /// </summary>
        [JsonPropertyName("start_reason")]
        public string? StartReason { get; set; }

        /// <summary>
        /// <para>ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7260357352426782739</para>
        /// </summary>
        [JsonPropertyName("job_data_custom_org_id")]
        public string? JobDataCustomOrgId { get; set; }

        /// <summary>
        /// <para>版本号</para>
        /// <para>必填：否</para>
        /// <para>示例值：7260357352426782749</para>
        /// </summary>
        [JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// <para>自定义组织类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：custom_org_03</para>
        /// </summary>
        [JsonPropertyName("object_api_name")]
        public string? ObjectApiName { get; set; }

        /// <summary>
        /// <para>用户id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7352797725202581036</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
    }

    /// <summary>
    /// <para>用户编码</para>
    /// <para>必填：否</para>
    /// <para>示例值：006</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
}
