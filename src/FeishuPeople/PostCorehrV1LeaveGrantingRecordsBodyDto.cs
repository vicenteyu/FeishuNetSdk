// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV1LeaveGrantingRecordsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建假期发放记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 创建假期发放记录 请求体
/// <para>向飞书人事休假系统写入假期发放记录。</para>
/// <para>接口ID：7127187941650612227</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/leave/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave_granting_record%2fcreate</para>
/// </summary>
public record PostCorehrV1LeaveGrantingRecordsBodyDto
{
    /// <summary>
    /// <para>假期类型 ID，枚举值可通过[获取假期类型列表](https://open.larkoffice.com/document/server-docs/corehr-v1/leave/leave_types)接口获取（若假期类型下存在假期子类，此处仅支持传入假期子类的 ID）</para>
    /// <para>必填：是</para>
    /// <para>示例值：7111688079785723436</para>
    /// </summary>
    [JsonPropertyName("leave_type_id")]
    public string LeaveTypeId { get; set; } = string.Empty;

    /// <summary>
    /// <para>员工 ID，飞书人事的雇员id</para>
    /// <para>必填：是</para>
    /// <para>示例值：6982509313466189342</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string EmploymentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>发放数量（小数位数不能超过6位，授予数量范围为-9999~9999）</para>
    /// <para>必填：是</para>
    /// <para>示例值：0.5</para>
    /// </summary>
    [JsonPropertyName("granting_quantity")]
    public string GrantingQuantity { get; set; } = string.Empty;

    /// <summary>
    /// <para>发放时长单位</para>
    /// <para>可选值有：</para>
    /// <para>- 1: 天</para>
    /// <para>- 2: 小时</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("granting_unit")]
    public int GrantingUnit { get; set; }

    /// <summary>
    /// <para>生效时间</para>
    /// <para>必填：是</para>
    /// <para>示例值：2022-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_date")]
    public string EffectiveDate { get; set; } = string.Empty;

    /// <summary>
    /// <para>失效时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-01-01</para>
    /// </summary>
    [JsonPropertyName("expiration_date")]
    public string? ExpirationDate { get; set; }

    /// <summary>
    /// <para>是否参与折算（1不参与折算，2参与折算）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("section_type")]
    public int? SectionType { get; set; }

    /// <summary>
    /// <para>发放原因</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public I18n[] Reasons { get; set; } = Array.Empty<I18n>();

    /// <summary>
    /// <para>发放原因</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>名称信息的语言</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>名称信息的内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>自定义外部 ID，可用于避免数据重复写入（不能超过 64 字符）</para>
    /// <para>必填：否</para>
    /// <para>示例值：111</para>
    /// </summary>
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }
}
