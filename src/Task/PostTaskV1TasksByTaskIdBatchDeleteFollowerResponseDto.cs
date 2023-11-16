namespace FeishuNetSdk.Task;
/// <summary>
/// 批量删除关注人 响应体
/// <para>该接口用于批量删除关注人。</para>
/// <para>接口ID：7118952533649227779</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-follower/batch_delete_follower</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fbatch_delete_follower</para>
/// </summary>
public record PostTaskV1TasksByTaskIdBatchDeleteFollowerResponseDto
{
    /// <summary>
    /// <para>实际删除的关注人用户ID列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("followers")]
    public string[]? Followers { get; set; }
}
