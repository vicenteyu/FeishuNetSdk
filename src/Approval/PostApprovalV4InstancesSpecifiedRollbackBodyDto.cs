using Newtonsoft.Json;
namespace FeishuNetSdk.Approval;
/// <summary>
/// 退回审批任务 请求体
/// <para>从当前审批任务，退回到已审批的一个或多个任务节点。退回后，已审批节点重新生成审批任务。</para>
/// <para>接口ID：7117964632137089027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/task/specified_rollback</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fspecified_rollback</para>
/// </summary>
public record PostApprovalV4InstancesSpecifiedRollbackBodyDto
{
    /// <summary>
    /// <para>当前审批任务的审批人的用户 ID，从实例详情中的 task_list 字段获取，且相应任务的状态必须为 PENDING</para>
    /// <para>必填：是</para>
    /// <para>示例值：893g4c45</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>当前需要回退的审批任务的任务 ID，从实例详情中的 task_list 字段获取，且相应任务的状态必须为 PENDING</para>
    /// <para>必填：是</para>
    /// <para>示例值：7026591166355210260</para>
    /// </summary>
    [JsonProperty("task_id")]
    public string TaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>退回原因</para>
    /// <para>必填：否</para>
    /// <para>示例值：申请事项填写不具体，请重新填写</para>
    /// </summary>
    [JsonProperty("reason")]
    public string? Reason { get; set; }

    /// <summary>
    /// <para>扩展字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：暂不填写</para>
    /// </summary>
    [JsonProperty("extra")]
    public string? Extra { get; set; }

    /// <summary>
    /// <para>需要退回到的任务 node_key。node_key 从实例详情中 timeline 字段获取，且相应任务的状态必须为 PASS</para>
    /// <para>必填：是</para>
    /// <para>示例值：["START","APPROVAL_27997_285502","APPROVAL_462205_2734554"]</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("task_def_key_list")]
    public string[] TaskDefKeyList { get; set; } = Array.Empty<string>();
}
