// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-29
//
// Last Modified By : yxr
// Last Modified On : 2024-11-29
// ************************************************************************
// <copyright file="GetPayrollV1PaygroupsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取薪资组基本信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 获取薪资组基本信息 响应体
/// <para>- 薪资组是按薪酬管理的纬度创建的组，组内的员工由相同的HR处理薪酬相关工作，通过薪资组可实现对薪资组人员的管理和在薪酬计算发放等环节的人员权限范围控制</para>
/// <para>- 本接口返回所有薪资组的基本信息，包括薪资组ID、薪资组名称、薪资组编码、薪资组状态等，不含薪资组下的员工信息</para>
/// <para>接口ID：7405412186246627329</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/paygroup/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpaygroup%2flist</para>
/// </summary>
public record GetPayrollV1PaygroupsResponseDto
{
    /// <summary>
    /// <para>薪资组列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Paygroup[]? Items { get; set; }

    /// <summary>
    /// <para>薪资组列表</para>
    /// </summary>
    public record Paygroup
    {
        /// <summary>
        /// <para>薪资组ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6823630319749580301</para>
        /// </summary>
        [JsonPropertyName("pay_group_id")]
        public string PayGroupId { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资组名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：CHN - 审核</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n Name { get; set; } = new();

        /// <summary>
        /// <para>薪资组名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：CHN-审核</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：english name</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>薪资组编码</para>
        /// <para>必填：是</para>
        /// <para>示例值：PAY_GROUP-3-8</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资组状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>最大值：1</para>
        /// <para>最小值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：启用</item>
        /// <item>0：禁用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：6862995757234914824</para>
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
