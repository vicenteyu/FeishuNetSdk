namespace FeishuNetSdk.Task;
/// <summary>
/// 创建清单 请求体
/// <para>创建一个清单。清单可以用于组织和管理属于同一个项目的多个任务。</para>
/// <para>创建时，必须填写清单的名字。同时，可以设置通过`members`字段设置清单的协作成员。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
/// <para>创建清单后，创建人自动成为清单的所有者。如果请求同时将创建人设置为可编辑/可阅读角色，则最终该用户成为清单所有者，并自动从清单成员列表中消失。因为同一个用户在同一个清单只能拥有一个角色。</para>
/// <para>接口ID：7255580838154469404</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2fcreate</para>
/// </summary>
public record PostTaskV2TasklistsBodyDto
{
    /// <summary>
    /// <para>清单名称，必填。最多100个字符。</para>
    /// <para>必填：是</para>
    /// <para>示例值：年会工作任务清单</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>清单的成员列表。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// </summary>
    [JsonPropertyName("members")]
    public Member[]? Members { get; set; }

    /// <summary>
    /// <para>清单的成员列表。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
    /// </summary>
    public record Member
    {
        /// <summary>
        /// <para>表示member的id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>成员的类型，支持:</para>
        /// <para>&lt;md-enum&gt;</para>
        /// <para>&lt;md-enum-item key="user"&gt;普通用户，此时member的id是一个表示用户的ID，比如open_id。具体格式取决于user_id_type参数&lt;/md-enum-item&gt;</para>
        /// <para>&lt;md-enum-item key="chat"&gt;群组，此时member的id是一个Open Chat ID&lt;/md-enum-item&gt;</para>
        /// <para>&lt;md-enum-item key="app"&gt;应用，此时member的id是一个应用的ID&lt;/md-enum-item&gt;</para>
        /// <para>&lt;/md-enum&gt;</para>
        /// <para>必填：否</para>
        /// <para>示例值：user</para>
        /// <para>默认值：user</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>成员角色，可以是"editor"(可编辑）或者"viewer"（可阅读）。默认为"viewer"。</para>
        /// <para>必填：否</para>
        /// <para>示例值：editor</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonPropertyName("role")]
        public string? Role { get; set; }
    }
}
