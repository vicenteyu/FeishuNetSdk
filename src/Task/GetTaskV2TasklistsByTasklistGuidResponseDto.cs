using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 获取清单详情 响应体
/// <para>获取一个清单的详细信息，包括清单名，所有者，清单成员等。</para>
/// <para>接口ID：7255580838154666012</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2fget</para>
/// </summary>
public record GetTaskV2TasklistsByTasklistGuidResponseDto
{
    /// <summary>
    /// <para>清单详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("tasklist")]
    public GetTaskV2TasklistsByTasklistGuidResponseDtoTasklist? Tasklist { get; set; }

    /// <summary>
    /// <para>清单详情</para>
    /// </summary>
    public record GetTaskV2TasklistsByTasklistGuidResponseDtoTasklist
    {
        /// <summary>
        /// <para>清单的全局唯一ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：cc371766-6584-cf50-a222-c22cd9055004</para>
        /// </summary>
        [JsonProperty("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>清单名</para>
        /// <para>必填：否</para>
        /// <para>示例值：年会总结工作任务清单</para>
        /// <para>最大长度：300</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>清单创建者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("creator")]
        public Member? Creator { get; set; }

        /// <summary>
        /// <para>清单创建者</para>
        /// </summary>
        public record Member
        {
            /// <summary>
            /// <para>表示member的id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
            /// <para>最大长度：100</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>成员的类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>清单角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：creator</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonProperty("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>清单所有者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("owner")]
        public Member? Owner { get; set; }

        /// <summary>
        /// <para>清单协作成员</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("members")]
        public Member[]? Members { get; set; }

        /// <summary>
        /// <para>该清单分享的applink</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/todo/task_list?guid=b45b360f-1961-4058-b338-7f50c96e1b52</para>
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>清单创建时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>清单最后一次更新时间戳（ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }
    }
}
