using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 列取任务所在清单 响应体
/// <para>列取一个任务所在的所有清单的信息，包括清单的GUID和所在自定义分组的GUID。</para>
/// <para>只有调用身份有权限访问的清单信息会被返回。</para>
/// <para>接口ID：7255580838154453020</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/tasklists</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2ftasklists</para>
/// </summary>
public record GetTaskV2TasksByTaskGuidTasklistsResponseDto
{
    /// <summary>
    /// <para>任务所在清单的摘要信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("tasklists")]
    public TaskInTasklistInfo[]? Tasklists { get; set; }

    /// <summary>
    /// <para>任务所在清单的摘要信息</para>
    /// </summary>
    public record TaskInTasklistInfo
    {
        /// <summary>
        /// <para>任务所在清单的guid</para>
        /// <para>必填：否</para>
        /// <para>示例值：cc371766-6584-cf50-a222-c22cd9055004</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonProperty("tasklist_guid")]
        public string? TasklistGuid { get; set; }

        /// <summary>
        /// <para>任务所在清单的自定义分组guid</para>
        /// <para>必填：否</para>
        /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
        /// </summary>
        [JsonProperty("section_guid")]
        public string? SectionGuid { get; set; }
    }
}
