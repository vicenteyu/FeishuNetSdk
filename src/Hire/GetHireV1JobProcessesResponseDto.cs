namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取招聘流程信息 响应体
/// <para>获取全部招聘流程信息。</para>
/// <para>接口ID：6964286393804947484</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_process/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_process%2flist</para>
/// </summary>
public record GetHireV1JobProcessesResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public JobProcesses[]? Items { get; set; }

    /// <summary>
    /// <para>列表</para>
    /// </summary>
    public record JobProcesses
    {
        /// <summary>
        /// <para>ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：123123123123</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>中文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：中文</para>
        /// </summary>
        [JsonPropertyName("zh_name")]
        public string? ZhName { get; set; }

        /// <summary>
        /// <para>英文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("en_name")]
        public string? EnName { get; set; }

        /// <summary>
        /// <para>类型 1=社招流程, 2=校招流程,</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：社招流程</item>
        /// <item>2：校招流程</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// <para>阶段列表, 内部按用户设置顺序排列</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("stage_list")]
        public JobProcessesStage[]? StageLists { get; set; }

        /// <summary>
        /// <para>阶段列表, 内部按用户设置顺序排列</para>
        /// </summary>
        public record JobProcessesStage
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：123123123123123</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：名字</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

            /// <summary>
            /// <para>1=筛选型, 2=评估型, 3=笔试型, 4=面试型, 5=Offer型, 6=待入职, 7=已入职, 8=其它类型, 255=系统默认，后端模型中并没有该字段，仅用于前端显示,</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：筛选型</item>
            /// <item>2：评估型</item>
            /// <item>3：笔试型</item>
            /// <item>4：面试型</item>
            /// <item>5：Offer型</item>
            /// <item>6：待入职</item>
            /// <item>7：已入职</item>
            /// <item>8：其它类型</item>
            /// <item>255：系统默认</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }
        }
    }
}
