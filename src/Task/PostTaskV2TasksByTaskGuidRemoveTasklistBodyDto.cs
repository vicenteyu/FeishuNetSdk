using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 任务移出清单 请求体
/// <para>将任务从一个清单中移出。返回任务详情。</para>
/// <para>如果任务不在清单中，接口将返回成功。</para>
/// <para>接口ID：7255580838154780700</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_tasklist</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fremove_tasklist</para>
/// </summary>
public record PostTaskV2TasksByTaskGuidRemoveTasklistBodyDto
{
    /// <summary>
    /// <para>要移除的清单的全局唯一ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("tasklist_guid")]
    public string TasklistGuid { get; set; } = string.Empty;
}
