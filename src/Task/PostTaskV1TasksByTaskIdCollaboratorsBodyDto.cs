using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 新增执行者 请求体
/// <para>该接口用于新增任务执行者，一次性可以添加多个执行者。</para>
/// <para>只有任务的创建者和执行者才能添加执行者，关注人无权限添加。</para>
/// <para>接口ID：6985127383322198018</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-collaborator/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-collaborator%2fcreate</para>
/// </summary>
public record PostTaskV1TasksByTaskIdCollaboratorsBodyDto
{
    /// <summary>
    /// <para>任务执行者的 ID。</para>
    /// <para>传入的值为 user_id 或 open_id，由user_id_type 决定。user_id和open_id的获取可见文档[如何获取相关id](https://open.feishu.cn/document/home/user-identity-introduction/how-to-get)。</para>
    /// <para>已经废弃，为了向前兼容早期只支持单次添加一个人的情况而保留，但不再推荐使用，建议使用id_list字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_99e1a581b36ecc4862cbfbce473f1234</para>
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>执行者的用户ID列表。</para>
    /// <para>传入的值为 user_id 或 open_id，由user_id_type 决定。user_id和open_id的获取可见文档[如何获取相关id](https://open.feishu.cn/document/home/user-identity-introduction/how-to-get)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_550cc75233d8b7b9fcbdad65f34433f4","ou_d1e9d27cf3235b40ca9a67c67ef088b0"]</para>
    /// </summary>
    [JsonProperty("id_list")]
    public string[]? IdList { get; set; }
}
