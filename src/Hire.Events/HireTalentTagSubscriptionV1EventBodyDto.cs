// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-18
//
// Last Modified By : yxr
// Last Modified On : 2024-10-18
// ************************************************************************
// <copyright file="HireTalentTagSubscriptionV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>人才进展变更事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire.Events;
/// <summary>
/// 人才进展变更事件 事件体
/// <para>支持单独订阅有指定标签的人才进展，人才进展包括阶段变更、锁定、解锁，需要提前在「飞书招聘」-「设置」- 「候选人标签管理」里对指定标签勾选支持事件订阅{使用示例}(url=/api/tools/api_explore/api_explore_config?project=hire&amp;version=v1&amp;resource=talent&amp;event=tag_subscription)</para>
/// <para>接口ID：7404770953199697922</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/talent/events/tag_subscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fevents%2ftag_subscription</para>
/// </summary>
public record HireTalentTagSubscriptionV1EventBodyDto() : EventBodyDto("hire.talent.tag_subscription_v1")
{
    /// <summary>
    /// <para>人才 ID，详情可参考[获取人才详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/hire-v2/talent/get)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string? TalentId { get; set; }

    /// <summary>
    /// <para>投递 ID，详情可参考[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// <para>变更类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1:阶段变更,2:锁定,3:解锁</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：阶段变更</item>
    /// <item>2：锁定</item>
    /// <item>3：解锁</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }

    /// <summary>
    /// <para>人才标签</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tag")]
    public TalentTag? Tag { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record TalentTag
    {
        /// <summary>
        /// <para>标签 ID，可通过以下接口</para>
        /// <para>获取人才标签信息[</para>
        /// <para>获取人才标签信息列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_tag/list)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>标签名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18nLanguage<string>? Name { get; set; }

        /// <summary>
        /// <para>描述名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18nLanguage<string>? Description { get; set; }
    }

    /// <summary>
    /// <para>锁定状态</para>
    /// <para>**可选值有**：</para>
    /// <para>1:未锁定,2:锁定在其他职位,3:锁定在当前职位</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：未锁定</item>
    /// <item>2：锁定在其他职位</item>
    /// <item>3：锁定在当前职位</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("lock_status")]
    public int? LockStatus { get; set; }

    /// <summary>
    /// <para>投递阶段，如果变更类型为阶段变更，则为变更后的投递阶段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("application_stage")]
    public ApplicationStageInfo? ApplicationStage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record ApplicationStageInfo
    {
        /// <summary>
        /// <para>阶段 ID，可通过以下接口获取投递阶段信息[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>中文名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("zh_name")]
        public string? ZhName { get; set; }

        /// <summary>
        /// <para>英文名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("en_name")]
        public string? EnName { get; set; }

        /// <summary>
        /// <para>阶段类型</para>
        /// <para>**可选值有**：</para>
        /// <para>1:筛选型,2:评估型,3:笔试型,4:面试型,5:Offer型,6:待入职,7:已入职,8:其它类型,255:系统默认</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：筛选型</item>
        /// <item>2：评估型</item>
        /// <item>3：笔试型</item>
        /// <item>4：面试型</item>
        /// <item>5：Offer型</item>
        /// <item>6：待入职</item>
        /// <item>7：已入职</item>
        /// <item>8：其它类型</item>
        /// <item>255：系统默认</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }
    }
}
