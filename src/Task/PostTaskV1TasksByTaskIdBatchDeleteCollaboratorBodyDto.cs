namespace FeishuNetSdk.Task;
/// <summary>
/// 批量删除执行者 请求体
/// <para>该接口用于批量删除执行者。</para>
/// <para>接口ID：7118952533649244163</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-collaborator/batch_delete_collaborator</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fbatch_delete_collaborator</para>
/// </summary>
public record PostTaskV1TasksByTaskIdBatchDeleteCollaboratorBodyDto
{
    /// <summary>
    /// <para>执行者的用户ID列表。</para>
    /// <para>传入的值为 user_id 或 open_id，由user_id_type 决定。user_id和open_id的获取可见文档[如何获取相关id](https://open.feishu.cn/document/home/user-identity-introduction/how-to-get)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_550cc75233d8b7b9fcbdad65f34433f4","ou_d1e9d27cf3235b40ca9a67c67ef088b0"]</para>
    /// </summary>
    [JsonPropertyName("id_list")]
    public string[]? IdList { get; set; }
}
