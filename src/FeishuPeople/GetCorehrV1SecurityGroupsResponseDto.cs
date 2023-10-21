using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 批量获取角色列表 响应体
/// <para>批量查询「飞书人事」-「权限设置」-「角色设置」中的角色列表。</para>
/// <para>接口ID：7088513302561128449</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fsecurity_group%2flist</para>
/// </summary>
public record GetCorehrV1SecurityGroupsResponseDto
{
    /// <summary>
    /// <para>查询的用户角色信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public SecurityGroup[]? Items { get; set; }

    /// <summary>
    /// <para>查询的用户角色信息</para>
    /// </summary>
    public record SecurityGroup
    {
        /// <summary>
        /// <para>角色ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7034393015968122400</para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>角色code，通常用于与其他系统进行交互</para>
        /// <para>必填：是</para>
        /// <para>示例值：department_manager</para>
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// <para>角色名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public SecurityGroupName? Name { get; set; }

        /// <summary>
        /// <para>角色名称</para>
        /// </summary>
        public record SecurityGroupName
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：cn</para>
            /// </summary>
            [JsonProperty("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：en</para>
            /// </summary>
            [JsonProperty("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>状态，1 = Inactive / 停用，</para>
        /// <para>2 = Active / 启用，3 = TobeActivated / 待启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("active_status")]
        public int ActiveStatus { get; set; }

        /// <summary>
        /// <para>角色描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("description")]
        public NameSuffix? Description { get; set; }

        /// <summary>
        /// <para>角色描述</para>
        /// </summary>
        public record NameSuffix
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：cn</para>
            /// </summary>
            [JsonProperty("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：en</para>
            /// </summary>
            [JsonProperty("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("update_time")]
        public string UpdateTime { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234452132</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }
}
