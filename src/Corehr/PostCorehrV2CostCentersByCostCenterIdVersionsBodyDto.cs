// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2CostCentersByCostCenterIdVersionsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建成本中心版本 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建成本中心版本 请求体
/// <para>创建成本中心版本；每次调用可创建一个成本中心版本，可定义成本中心的名称，描述，上级成本，成本中心负责人，版本生效时间等信息，接口内会做相关规则的校验</para>
/// <para>接口ID：7225452763517173763</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/cost_center-version/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center-version%2fcreate</para>
/// </summary>
public record PostCorehrV2CostCentersByCostCenterIdVersionsBodyDto
{
    /// <summary>
    /// <para>成本中心名称</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("name")]
    public I18n[] Names { get; set; } = Array.Empty<I18n>();

    /// <summary>
    /// <para>成本中心名称</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>信息的语言，支持中文和英文。中文用zh-CN；英文用en-US</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：基础架构</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>上级成本中心ID，可通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6862995757234914824</para>
    /// </summary>
    [JsonPropertyName("parent_cost_center_id")]
    public string? ParentCostCenterId { get; set; }

    /// <summary>
    /// <para>成本中心负责人ID 列表，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("managers")]
    public string[]? Managers { get; set; }

    /// <summary>
    /// <para>成本中心描述</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("description")]
    public I18n[]? Descriptions { get; set; }

    /// <summary>
    /// <para>版本生效时间</para>
    /// <para>- 填写格式：YYYY-MM-DD</para>
    /// <para>- 系统默认为填写日期当天的 00:00:00 生效</para>
    /// <para>- 该接口只支持到最小单位为日</para>
    /// <para>- 日期范围要求:1900-01-01～9999-12-31</para>
    /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>操作原因</para>
    /// <para>必填：是</para>
    /// <para>示例值：过期作废</para>
    /// </summary>
    [JsonPropertyName("operation_reason")]
    public string OperationReason { get; set; } = string.Empty;
}
