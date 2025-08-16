// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-20
//
// Last Modified By : yxr
// Last Modified On : 2024-09-20
// ************************************************************************
// <copyright file="CorehrPreHireOnboardingTaskChangedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>入职流程状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 入职流程状态变更 事件体
/// <para>待入职员工的入职流程流转时，例如调用[流转入职任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/transit_task)接口会触发本事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=pre_hire&amp;event=onboarding_task_changed)</para>
/// <para>接口ID：7394722460207382556</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/pre-hire-events/onboarding_task_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fevents%2fonboarding_task_changed</para>
/// </summary>
public record CorehrPreHireOnboardingTaskChangedV2EventBodyDto() : EventBodyDto("corehr.pre_hire.onboarding_task_changed_v2")
{
    /// <summary>
    /// <para>飞书人事租户ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant_id")]
    public string? TenantId { get; set; }

    /// <summary>
    /// <para>待入职ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("pre_hire_id")]
    public string? PreHireId { get; set; }

    /// <summary>
    /// <para>入职任务状态变更</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `1000`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("onboarding_task_changes")]
    public OnboardingTaskChange[]? OnboardingTaskChanges { get; set; }

    /// <summary>
    /// 入职任务状态变更
    /// </summary>
    public record OnboardingTaskChange
    {
        /// <summary>
        /// <para>变更后任务状态</para>
        /// <para>**可选值有**：</para>
        /// <para>uninitialized:未初始化（内部状态无需关注）,not_started:未开始,in_progress:进行中,in_review:审核中/审批中,rejected:已拒绝,failed:失败,skipped:自动跳过,completed:已完成,terminated:已终止,initiating:初始化中,exception:异常,manual_skipped:手动跳过</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>uninitialized：未初始化（内部状态无需关注）</item>
        /// <item>not_started：未开始</item>
        /// <item>in_progress：进行中</item>
        /// <item>in_review：审核中/审批中</item>
        /// <item>rejected：已拒绝</item>
        /// <item>failed：失败</item>
        /// <item>skipped：自动跳过</item>
        /// <item>completed：已完成</item>
        /// <item>terminated：已终止</item>
        /// <item>initiating：初始化中</item>
        /// <item>exception：异常</item>
        /// <item>manual_skipped：手动跳过</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("after_status")]
        public string? AfterStatus { get; set; }

        /// <summary>
        /// <para>任务标识码</para>
        /// <para>如果是系统内置的任务，标识码与名称对应关系如下：</para>
        /// <para>其中『创建账户SSO』为隐藏的任务节点，在『个人信息』前自动执行</para>
        /// <para>| 名称 | task code |</para>
        /// <para>| ---- | --- |</para>
        /// <para>| 职位信息 | 1 |</para>
        /// <para>| 个人信息 | 2 |</para>
        /// <para>|创建账户SSO|3|</para>
        /// <para>|签到| 4|</para>
        /// <para>|签署入职文件|9|</para>
        /// <para>如果标识码不在上面，说明是自定义任务节点，如：3095697a-065f-4627-a47c-46fe958a6754，名称的获取方式如下：</para>
        /// <para>- 通过pre_hire_id调用[搜索待入职人员信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/search)接口或[查询待入职](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/query)</para>
        /// <para>- 查询字段fields中添加onboarding_info.onboarding_task_list</para>
        /// <para>- 查询后返回的onboarding_task_list结构体中则包含code和名字的对应关系。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("task_code")]
        public string? TaskCode { get; set; }
    }

    /// <summary>
    /// <para>入职流程状态变更</para>
    /// <para>- 当流程状态无变更，仅有任务状态变更时，此字段的会返回空</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("onboarding_flow_change")]
    public OnboardingFlowChangeSuffix? OnboardingFlowChange { get; set; }

    /// <summary>
    /// 入职流程状态变更
    /// </summary>
    public record OnboardingFlowChangeSuffix
    {
        /// <summary>
        /// <para>入职流程状态变更</para>
        /// <para>**可选值有**：</para>
        /// <para>not_started:未开始,in_progress:进行中,completed:已完成（完成入职）,withdrawn:已撤销（撤销待入职）,others:其他(异常情况),expired:已失效(回退至Offer沟通阶段)</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>not_started：未开始</item>
        /// <item>in_progress：进行中</item>
        /// <item>completed：已完成（完成入职）</item>
        /// <item>withdrawn：已撤销（撤销待入职）</item>
        /// <item>others：其他(异常情况)</item>
        /// <item>expired：已失效(回退至Offer沟通阶段)</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("after_status")]
        public string? AfterStatus { get; set; }
    }

    /// <summary>
    /// <para>待入职流程ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("onboarding_flow_id")]
    public string? OnboardingFlowId { get; set; }
}
