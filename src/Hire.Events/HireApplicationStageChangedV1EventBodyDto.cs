// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="HireApplicationStageChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>投递阶段变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire.Events;
/// <summary>
/// 投递阶段变更 事件体
/// <para>当投递阶段发生变更时，会触发此事件。了解事件订阅的使用场景和配置流程，请点击查看 [事件订阅概述](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM)。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=hire&amp;version=v1&amp;resource=application&amp;event=stage_changed)</para>
/// <para>接口ID：7385118058418896900</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/events/stage_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fevents%2fstage_changed</para>
/// </summary>
public record HireApplicationStageChangedV1EventBodyDto() : EventBodyDto("hire.application.stage_changed_v1")
{
    /// <summary>
    /// <para>投递 ID，详情请参考[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// <para>投递阶段转移前的阶段 ID，详情请参考[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("origin_stage_id")]
    public string? OriginStageId { get; set; }

    /// <summary>
    /// <para>投递阶段转移后的阶段 ID，详情请参考[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("target_stage_id")]
    public string? TargetStageId { get; set; }

    /// <summary>
    /// <para>投递阶段变更时间戳（单位：毫秒）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("update_time")]
    public int? UpdateTime { get; set; }
}
