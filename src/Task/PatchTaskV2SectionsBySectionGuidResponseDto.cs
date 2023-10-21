using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 更新自定义分组 响应体
/// <para>更新自定义分组，可以更新自定义分组的名称和位置。</para>
/// <para>更新时，将`update_fields`字段中填写所有要修改的字段名，同时在`section`字段中填写要修改的字段的新值即可。调用约定详情见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 关于资源的更新”章节。</para>
/// <para>目前支持更新的字段包括：</para>
/// <para>* `name` - 自定义字段名字;</para>
/// <para>* `insert_before` - 要让当前自定义分组放到某个自定义分组前面的secion_guid，用于改变当前自定义分组的位置;</para>
/// <para>* `insert_after` - 要让当前自定义分组放到某个自定义分组后面的secion_guid，用于改变当前自定义分组的位置。</para>
/// <para>`insert_before`和`insert_after`如果填写，必须是同一个资源的合法section_guid。注意不能同时设置`insert_before`和`insert_after`。</para>
/// <para>接口ID：7259330038033842204</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/section/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fsection%2fpatch</para>
/// </summary>
public record PatchTaskV2SectionsBySectionGuidResponseDto
{
    /// <summary>
    /// <para>更新后的自定义分组</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("section")]
    public PatchTaskV2SectionsBySectionGuidResponseDtoSection? Section { get; set; }

    /// <summary>
    /// <para>更新后的自定义分组</para>
    /// </summary>
    public record PatchTaskV2SectionsBySectionGuidResponseDtoSection
    {
        /// <summary>
        /// <para>自定义分组的guid</para>
        /// <para>必填：否</para>
        /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
        /// </summary>
        [JsonProperty("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>自定义分组的名字</para>
        /// <para>必填：否</para>
        /// <para>示例值：已经评审过的任务</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>资源类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：tasklist</para>
        /// </summary>
        [JsonProperty("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// <para>分组是否为默认自定义分组</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>自定义分组的创建者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("creator")]
        public Member? Creator { get; set; }

        /// <summary>
        /// <para>自定义分组的创建者</para>
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
            /// <para>成员角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：editor</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonProperty("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>如果该分组归属于清单，展示清单的简要信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("tasklist")]
        public TasklistSummary? Tasklist { get; set; }

        /// <summary>
        /// <para>如果该分组归属于清单，展示清单的简要信息</para>
        /// </summary>
        public record TasklistSummary
        {
            /// <summary>
            /// <para>清单的全局唯一ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：cc371766-6584-cf50-a222-c22cd9055004</para>
            /// </summary>
            [JsonProperty("guid")]
            public string? Guid { get; set; }

            /// <summary>
            /// <para>清单名字</para>
            /// <para>必填：否</para>
            /// <para>示例值：活动分工任务列表</para>
            /// </summary>
            [JsonProperty("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>自定义分组创建时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>自定义分组最近一次更新时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }
    }
}
