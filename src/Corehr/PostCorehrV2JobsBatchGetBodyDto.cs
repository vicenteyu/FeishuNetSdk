// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostCorehrV2JobsBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>根据条件批量获取职务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 根据条件批量获取职务 请求体
/// <para>根据传入的职务ID或职务Code批量获取当前生效版本职务信息。</para>
/// <para>接口ID：7525709902931836932</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob%2fbatch_get</para>
/// </summary>
public record PostCorehrV2JobsBatchGetBodyDto
{
    /// <summary>
    /// <para>职务 ID 列表。职务ID列表和职务 Code 列表至少有一项有值，否则接口将调用失败。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_ids")]
    public string[]? JobIds { get; set; }

    /// <summary>
    /// <para>职务 Code 列表。职务ID列表和职务 Code 列表至少有一项有值，否则接口将调用失败。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_codes")]
    public string[]? JobCodes { get; set; }

    /// <summary>
    /// <para>需要查询的字段列表，默认返回id。可选以下预置字段及自定义字段：</para>
    /// <para>可选值有：</para>
    /// <para>- "job_name"：名称</para>
    /// <para>- "code"：编码</para>
    /// <para>- "active"：启用状态</para>
    /// <para>- "description"：描述</para>
    /// <para>- "job_title"：职务头衔</para>
    /// <para>- "pathway"：通道ID</para>
    /// <para>- "working_hours_type"：工时制度</para>
    /// <para>- "job_level"：关联的职级</para>
    /// <para>- "job_family"：关联的序列</para>
    /// <para>- "effective_date"：当前版本生效日期</para>
    /// <para>- "expiration_date"：当前版本失效日期</para>
    /// <para>- "created_time"：创建时间</para>
    /// <para>- "updated_time"：更新时间</para>
    /// <para>- "created_by"：创建人</para>
    /// <para>- "updated_by"：更新人</para>
    /// <para>- "custom_fields"：自定义字段(需传入具体的"custom_api_name")</para>
    /// <para>详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query) ,比如:"shifouleixing_7795__c"</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }
}
