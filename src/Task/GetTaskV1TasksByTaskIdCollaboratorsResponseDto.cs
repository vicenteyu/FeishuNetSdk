using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 获取执行者列表 响应体
/// <para>该接口用于查询任务执行者列表，支持分页，最大值为50。</para>
/// <para>接口ID：6985127383322230786</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-collaborator/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-collaborator%2flist</para>
/// </summary>
public record GetTaskV1TasksByTaskIdCollaboratorsResponseDto
{
    /// <summary>
    /// <para>返回的执行者ID列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public Collaborator[]? Items { get; set; }

    /// <summary>
    /// <para>返回的执行者ID列表</para>
    /// </summary>
    public record Collaborator
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
        /// </summary>
        [JsonProperty("id_list")]
        public string[]? IdList { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：「上次返回的page_token」</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
