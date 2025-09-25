// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-25
//
// Last Modified By : yxr
// Last Modified On : 2025-09-25
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresTransformOnboardingTaskBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>流转入职任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 流转入职任务 请求体
/// <para>处于进行中的入职流程，可通过本接口实现手动开启、提交或审批入职任务</para>
/// <para>- 当任务处于「手动开启」时，可通过本接口手动开启任务，将任务状态流转到「进行中」</para>
/// <para>- 当任务处于「进行中」时，可通过本接口提交任务，将任务流转到「审批中」或「已完成」</para>
/// <para>- 当任务处于「审批中」时，可通过本接口审批任务，将任务流转到「已完成」或「已拒绝」</para>
/// <para>- 当任务处于「已拒绝」时，可通过本接口提交任务，将任务流转到「审批中」</para>
/// <para>接口ID：7525488347772682242</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/transform_onboarding_task</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2ftransform_onboarding_task</para>
/// </summary>
public record PostCorehrV2PreHiresTransformOnboardingTaskBodyDto
{
    /// <summary>
    /// <para>待入职ID，可以通过[搜索待入职人员信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/search)接口获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：7345005664477775407</para>
    /// </summary>
    [JsonPropertyName("pre_hire_id")]
    public string PreHireId { get; set; } = string.Empty;

    /// <summary>
    /// <para>任务标识码。</para>
    /// <para>- 对于系统内置的任务，标识码与任务名称的对应关系如下所示：</para>
    /// <para>&gt; 其中 **创建账户SSO** 为隐藏的任务节点，在 **个人信息** 前自动执行。</para>
    /// <para>- 1：职位信息</para>
    /// <para>- 2：个人信息</para>
    /// <para>- 3：创建账户SSO</para>
    /// <para>- 4：签到</para>
    /// <para>- 9：签署入职文件</para>
    /// <para>- 对于自定义的任务节点（如：3095697a-065f-4627-a47c-46fe958a6754），名称的获取方式如下所示：</para>
    /// <para>1. 通过 `pre_hire_id` 调用[搜索待入职人员信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/search)接口或[查询待入职](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/query)</para>
    /// <para>2. 查询字段 `fields` 中添加 `onboarding_info.onboarding_task_list`</para>
    /// <para>查询后返回的 onboarding_task_list 结构体中包含标识码和任务名字的对应关系，示例如下所示：</para>
    /// <para>```json</para>
    /// <para>{</para>
    /// <para>"onboarding_task_list": [</para>
    /// <para>{</para>
    /// <para>"task_code": "3095697a-065f-4627-a47c-46fe958a6754",</para>
    /// <para>"task_name": "修改入职日期",</para>
    /// <para>"task_status": "uninitialized"</para>
    /// <para>},</para>
    /// <para>{</para>
    /// <para>"task_code": "d37b9d7c-232d-4a55-98fa-541318234ede",</para>
    /// <para>"task_name": "工签补充任务",</para>
    /// <para>"task_status": "uninitialized"</para>
    /// <para>}</para>
    /// <para>]</para>
    /// <para>}</para>
    /// <para>```</para>
    /// <para>必填：是</para>
    /// <para>示例值：27691344-699b-47fb-a352-7b41e992a536</para>
    /// </summary>
    [JsonPropertyName("task_code")]
    public string TaskCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>流转类型，当任务处于不同的状态时，通过该字段指定任务做何种类型的流转。</para>
    /// <para>入职任务状态：</para>
    /// <para>- uninitialized：任务未初始化</para>
    /// <para>- not_started：任务未开始</para>
    /// <para>- in_progress：任务进行中</para>
    /// <para>- in_review：任务审批中</para>
    /// <para>- rejected：任务已拒绝</para>
    /// <para>- failed：任务失败</para>
    /// <para>- skipped：任务自动跳过</para>
    /// <para>- completed：任务完成</para>
    /// <para>- exception：任务异常</para>
    /// <para>- terminated：任务终止</para>
    /// <para>- initiating：任务发起中</para>
    /// <para>- manual_skipped：任务手动跳过</para>
    /// <para>任务流转类型：</para>
    /// <para>- manual_start_task：手动开启任务</para>
    /// <para>&gt; 当任务处于未开始状态时，可通过指定该类型手动开启任务</para>
    /// <para>- submit_task：提交任务</para>
    /// <para>&gt; 当任务处于进行中和已拒绝时，可以通过指定该类型提交任务。创建账户(`task_code：3`)、签到（`task_code：4`）和电子签（`task_code：9`）任务不支持提交</para>
    /// <para>- review_task：审批任务</para>
    /// <para>&gt; 当任务处于审批中时，可以通过指定该类型审批任务。通过本接口审批任务时，会忽略多个审批人审批的场景。</para>
    /// <para>必填：是</para>
    /// <para>示例值：review_task</para>
    /// </summary>
    [JsonPropertyName("transform_type")]
    public string TransformType { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批结果，当`transform_type`为`review_task`时，该字段需要传值，否则报错。</para>
    /// <para>审批结果：</para>
    /// <para>- approve：通过</para>
    /// <para>- reject：拒绝</para>
    /// <para>必填：否</para>
    /// <para>示例值：approve</para>
    /// </summary>
    [JsonPropertyName("review_decision")]
    public string? ReviewDecision { get; set; }

    /// <summary>
    /// <para>审批原因，审批任务时，如果`review_decision`传参为`approve`时，审批原因可以不填；如果`review_decision`传参为`reject`时，审批原因必填。</para>
    /// <para>&gt; 审批原因长度需小于3000字节</para>
    /// <para>必填：否</para>
    /// <para>示例值：信息填写完整，允许通过</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}
