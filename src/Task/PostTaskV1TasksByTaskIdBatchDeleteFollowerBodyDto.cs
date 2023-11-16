namespace FeishuNetSdk.Task;
/// <summary>
/// 批量删除关注人 请求体
/// <para>该接口用于批量删除关注人。</para>
/// <para>接口ID：7118952533649227779</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-follower/batch_delete_follower</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fbatch_delete_follower</para>
/// </summary>
public record PostTaskV1TasksByTaskIdBatchDeleteFollowerBodyDto
{
    /// <summary>
    /// <para>要删除的关注人ID列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：[ "ou_550cc75233d8b7b9fcbdad65f34433f4", "ou_d1e9d27cf3235b40ca9a67c67ef088b0" ]</para>
    /// </summary>
    [JsonPropertyName("id_list")]
    public string[]? IdList { get; set; }
}
