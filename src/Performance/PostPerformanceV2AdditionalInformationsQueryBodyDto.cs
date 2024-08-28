// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-09
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="PostPerformanceV2AdditionalInformationsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询补充信息 请求体/summary>
namespace FeishuNetSdk.Performance;
/// <summary>
/// 批量查询补充信息 请求体
/// <para>批量查询被评估人的补充信息，如补充信息的事项、时间以及具体描述等。</para>
/// <para>接口ID：7371009404255617028</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/additional_information/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fadditional_information%2fquery</para>
/// </summary>
public record PostPerformanceV2AdditionalInformationsQueryBodyDto
{
    /// <summary>
    /// <para>评估周期 ID，可通过[获取周期列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)接口获取</para>
    /// <para>**注意**：若请求参数 `item_ids`、`external_ids`、`reviewee_user_ids` 均为空，返回 `semester_id` 参数指定周期的所有补充信息</para>
    /// <para>必填：是</para>
    /// <para>示例值：7348736302176534547</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string SemesterId { get; set; } = string.Empty;

    /// <summary>
    /// <para>补充信息 ID 列表，可通过[批量导入补充信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/additional_information/import)接口获取</para>
    /// <para>**说明**：若提供多个筛选参数，按照 `item_ids` &gt; `external_ids` &gt; `reviewee_user_ids` 的优先级顺序，以第一个有值的筛选参数进行筛选</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("item_ids")]
    public string[]? ItemIds { get; set; }

    /// <summary>
    /// <para>外部系统补充信息 ID 列表，该 ID 在通过[批量导入补充信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/additional_information/import)接口导入时写入</para>
    /// <para>**说明**：若提供多个筛选参数，按照 `item_ids` &gt; `external_ids` &gt; `reviewee_user_ids` 的优先级顺序，以第一个有值的筛选参数进行筛选</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("external_ids")]
    public string[]? ExternalIds { get; set; }

    /// <summary>
    /// <para>被评估人 ID 列表，与入参 `user_id_type` 类型一致，可通过[获取被评估人信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/reviewee/query)接口获取</para>
    /// <para>**说明**：若提供多个筛选参数，按照 `item_ids` &gt; `external_ids` &gt; `reviewee_user_ids` 的优先级顺序，以第一个有值的筛选参数进行筛选</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("reviewee_user_ids")]
    public string[]? RevieweeUserIds { get; set; }
}
