// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchCorehrV2CostCentersByCostCenterIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>启用 / 停用成本中心 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 启用 / 停用成本中心 响应体
/// <para>该接口支持对单个成本中心进行启用和停用操作。</para>
/// <para>接口ID：7225452763517206531</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fpatch</para>
/// </summary>
public record PatchCorehrV2CostCentersByCostCenterIdResponseDto
{
    /// <summary>
    /// <para>成本中心结果；操作成本中心的详情信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("cost_center")]
    public PatchCorehrV2CostCentersByCostCenterIdResponseDtoCostCenter? CostCenter { get; set; }

    /// <summary>
    /// <para>成本中心结果；操作成本中心的详情信息</para>
    /// </summary>
    public record PatchCorehrV2CostCentersByCostCenterIdResponseDtoCostCenter
    {
        /// <summary>
        /// <para>成本中心ID</para>
        /// <para>- 详细信息可通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969828847121885087</para>
        /// </summary>
        [JsonPropertyName("cost_center_id")]
        public string? CostCenterId { get; set; }

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
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：MDPD00000023</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>上级成本中心ID，详细信息可通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995757234914824</para>
        /// </summary>
        [JsonPropertyName("parent_cost_center_id")]
        public string? ParentCostCenterId { get; set; }

        /// <summary>
        /// <para>成本中心负责人ID 列表</para>
        /// <para>- 详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search) 或 [【批量查询员工】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get) 接口获取</para>
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
        /// <para>版本生效日期</para>
        /// <para>- 返回格式：YYYY-MM-DD（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01～9999-12-31</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>版本失效日期</para>
        /// <para>- 返回格式：YYYY-MM-DD（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01～9999-12-31</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>成本中心启用状态，true为启用，false为停用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }
    }
}
