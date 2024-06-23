// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV1LeaveGrantingRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建假期发放记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 创建假期发放记录 响应体
/// <para>向飞书人事休假系统写入假期发放记录。</para>
/// <para>接口ID：7127187941650612227</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/leave/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave_granting_record%2fcreate</para>
/// </summary>
public record PostCorehrV1LeaveGrantingRecordsResponseDto
{
    /// <summary>
    /// <para>假期发放记录</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("leave_granting_record")]
    public PostCorehrV1LeaveGrantingRecordsResponseDtoLeaveGrantingRecord? LeaveGrantingRecord { get; set; }

    /// <summary>
    /// <para>假期发放记录</para>
    /// </summary>
    public record PostCorehrV1LeaveGrantingRecordsResponseDtoLeaveGrantingRecord
    {
        /// <summary>
        /// <para>假期发放记录 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>员工 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string EmploymentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期类型 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("leave_type_id")]
        public string LeaveTypeId { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放数量</para>
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
        /// <para>失效时间（根据休假规则自动计算）</para>
        /// <para>必填：是</para>
        /// <para>示例值：2022-01-01</para>
        /// </summary>
        [JsonPropertyName("expiration_date")]
        public string ExpirationDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放来源</para>
        /// <para>可选值有：</para>
        /// <para>- 1: 系统发放</para>
        /// <para>- 2: 手动发放</para>
        /// <para>- 3: 外部系统发放</para>
        /// <para>必填：是</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("granted_by")]
        public int GrantedBy { get; set; }

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
        /// <para>发放记录的创建时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：1608725989000</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放记录的创建人，值为创建人的员工 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：646465654545</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public string CreatedBy { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放记录的更新时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：1608725989000</para>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; } = string.Empty;

        /// <summary>
        /// <para>发放记录的更新人，值为更新人的员工 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：646465654545</para>
        /// </summary>
        [JsonPropertyName("updated_by")]
        public string UpdatedBy { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否参与折算</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("section_type")]
        public int? SectionType { get; set; }
    }
}
