// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2CostCentersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建成本中心 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建成本中心 请求体
/// <para>单个创建成本中心；可定义成本中心的名称，父级成本中心，成本中心负责人，生效时间等</para>
/// <para>接口ID：7225452763517140995</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fcreate</para>
/// </summary>
public record PostCorehrV2CostCentersBodyDto
{
    /// <summary>
    /// <para>- 名称不能包含「/」「；」「;」字符</para>
    /// <para>- 成本中心中英文名称会有全局唯一校验</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("name")]
    public I18n[] Names { get; set; } = Array.Empty<I18n>();

    /// <summary>
    /// <para>- 名称不能包含「/」「；」「;」字符</para>
    /// <para>- 成本中心中英文名称会有全局唯一校验</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>名称信息的语言，支持中文和英文。中文用zh-CN；英文用en-US</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：基础架构相关</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>- 编码 (不能与其他记录的编码重复)；当开启自动编码时，该字段将无效</para>
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
    /// <para>成本中心负责人ID 列表；</para>
    /// <para>详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
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
    /// <para>生效时间；该接口最知好吃到最小单位为日</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;
}
