// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-09
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="PostPerformanceV2AdditionalInformationsImportBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量导入补充信息 请求体</summary>
namespace FeishuNetSdk.Performance;
/// <summary>
/// 批量导入补充信息 请求体
/// <para>批量导入被评估人的补充信息作为绩效评估的参考，如补充信息的事项、时间以及具体描述等。该接口支持创建和更新补充信息。</para>
/// <para>## 注意事项</para>
/// <para>该接口执行创建或者更新的判断逻辑如下（按顺序判断）：</para>
/// <para>1. 若请求参数 `additional_informations` 中 `item_ids` 传入系统中已有的补充信息 ID 时，将更新对应的补充消息数据。</para>
/// <para>2. 若请求参数 `additional_informations` 中 `external_ids` 传入系统中已有的外部系统补充信息 ID 时，将更新对应的补充消息数据。</para>
/// <para>3. 若请求参数 `additional_informations` 中 `reviewee_user_id`、`item `、`time `、`detailed_description` 的参数组合在系统中已存在内容一致的补充消息时，将更新对应的补充消息数据。</para>
/// <para>4. 以上情况都不符合时，创建新的补充消息数据。</para>
/// <para>接口ID：7371009404255633412</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/additional_information/import</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fadditional_information%2fimport</para>
/// </summary>
public record PostPerformanceV2AdditionalInformationsImportBodyDto
{
    /// <summary>
    /// <para>评估周期 ID，可通过[获取周期列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7348736302176534547</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string SemesterId { get; set; } = string.Empty;

    /// <summary>
    /// <para>补充信息列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("additional_informations")]
    public AdditionalInformation[]? AdditionalInformations { get; set; }

    /// <summary>
    /// <para>补充信息列表</para>
    /// </summary>
    public record AdditionalInformation
    {
        /// <summary>
        /// <para>补充信息 ID</para>
        /// <para>**注意**：若传入系统中已有的补充信息 ID 时，将更新对应的补充消息数据</para>
        /// <para>必填：否</para>
        /// <para>示例值：7350194523185610771</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// <para>外部系统补充信息 ID，用于系统间的数据映射。</para>
        /// <para>**注意**：若传入系统中已有的外部系统补充信息 ID 时，将更新对应的补充消息数据</para>
        /// <para>必填：否</para>
        /// <para>示例值：6789523104723558912</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// <para>被评估人 ID 列表，与入参 `user_id_type` 类型一致，可通过[获取被评估人信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/reviewee/query)接口获取</para>
        /// <para>**注意**：若 `reviewee_user_id`、`item `、`time `、`detailed_description` 的参数组合在系统中已存在内容一致的补充消息时，将更新对应的补充消息数据</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_3245842393d09e9428ad4655da6e30b3</para>
        /// <para>最大长度：9999</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("reviewee_user_id")]
        public string RevieweeUserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>事项</para>
        /// <para>**注意**：若 `reviewee_user_id`、`item `、`time `、`detailed_description` 的参数组合在系统中已存在内容一致的补充消息时，将更新对应的补充消息数据</para>
        /// <para>必填：是</para>
        /// <para>示例值：业绩补充说明</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("item")]
        public string Item { get; set; } = string.Empty;

        /// <summary>
        /// <para>时间</para>
        /// <para>**说明**：文本内容，无格式校验</para>
        /// <para>**注意**：若 `reviewee_user_id`、`item `、`time `、`detailed_description` 的参数组合在系统中已存在内容一致的补充消息时，将更新对应的补充消息数据</para>
        /// <para>必填：是</para>
        /// <para>示例值：2024-03-12</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; } = string.Empty;

        /// <summary>
        /// <para>具体描述</para>
        /// <para>**注意**：若 `reviewee_user_id`、`item `、`time `、`detailed_description` 的参数组合在系统中已存在内容一致的补充消息时，将更新对应的补充消息数据</para>
        /// <para>必填：是</para>
        /// <para>示例值：销售额增长目标超额完成</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("detailed_description")]
        public string DetailedDescription { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>补充信息导入记录名称，管理员可在补充信息管理的导入记录中查看。</para>
    /// <para>**默认值**："API导入"</para>
    /// <para>必填：否</para>
    /// <para>示例值：人工导入</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("import_record_name")]
    public string? ImportRecordName { get; set; }
}
