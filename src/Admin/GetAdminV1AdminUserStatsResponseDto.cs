namespace FeishuNetSdk.Admin;
/// <summary>
/// 获取用户维度的用户活跃和功能使用数据 响应体
/// <para>用于获取用户维度的用户活跃和功能使用数据，即IM（即时通讯）、日历、云文档、音视频会议、邮箱功能的使用数据。</para>
/// <para>接口ID：6954303251601276955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/data-report-management/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fadmin_user_stat%2flist</para>
/// </summary>
public record GetAdminV1AdminUserStatsResponseDto
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
    /// <para>示例值：3</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>数据报表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AdminUserStat[]? Items { get; set; }

    /// <summary>
    /// <para>数据报表</para>
    /// </summary>
    public record AdminUserStat
    {
        /// <summary>
        /// <para>日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-02-15</para>
        /// </summary>
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>用户名</para>
        /// <para>必填：否</para>
        /// <para>示例值：Zhang San</para>
        /// </summary>
        [JsonPropertyName("user_name")]
        public string? UserName { get; set; }

        /// <summary>
        /// <para>部门名</para>
        /// <para>必填：否</para>
        /// <para>示例值：testcqlbfaaasdasdasd</para>
        /// </summary>
        [JsonPropertyName("department_name")]
        public string? DepartmentName { get; set; }

        /// <summary>
        /// <para>部门路径</para>
        /// <para>必填：否</para>
        /// <para>示例值：testkkk/testcqlbfaaasdasdasd</para>
        /// </summary>
        [JsonPropertyName("department_path")]
        public string? DepartmentPath { get; set; }

        /// <summary>
        /// <para>账号创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-09-04 11:17:55</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>用户激活状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未激活</item>
        /// <item>1：已激活</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("user_active_flag")]
        public int? UserActiveFlag { get; set; }

        /// <summary>
        /// <para>激活时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-09-04 11:18:32</para>
        /// </summary>
        [JsonPropertyName("register_time")]
        public string? RegisterTime { get; set; }

        /// <summary>
        /// <para>用户活跃状态，用户在飞书套件任意应用登陆，即为活跃。包括飞书即时消息，文档，日历，会议，开放平台等</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：无活跃</item>
        /// <item>1：活跃</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("suite_active_flag")]
        public int? SuiteActiveFlag { get; set; }

        /// <summary>
        /// <para>最近活跃时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-12-21 22:21:28</para>
        /// </summary>
        [JsonPropertyName("last_active_time")]
        public string? LastActiveTime { get; set; }

        /// <summary>
        /// <para>用户消息活跃状态，发生过如下事件，则认为该用户消息活跃：</para>
        /// <para>发送消息、回复消息、reaction、转发消息、阅读消息、查看会话、发送表情消息等</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：无活跃</item>
        /// <item>1：活跃</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("im_active_flag")]
        public int? ImActiveFlag { get; set; }

        /// <summary>
        /// <para>发送消息数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("send_messenger_num")]
        public int? SendMessengerNum { get; set; }

        /// <summary>
        /// <para>用户云文档活跃状态，"发生过如下事件，则认为该用户云文档活跃：</para>
        /// <para>事件1：文档/文件打开</para>
        /// <para>事件2：进入docs相关页面：如文档详情页，space的各个页面"</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：无活跃</item>
        /// <item>1：活跃</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("docs_active_flag")]
        public int? DocsActiveFlag { get; set; }

        /// <summary>
        /// <para>创建文件数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("create_docs_num")]
        public int? CreateDocsNum { get; set; }

        /// <summary>
        /// <para>用户日历活跃状态，发生过如下事件，则认为用户日历活跃，包含进入日历、创建日程、收到日程邀请等</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：无活跃</item>
        /// <item>1：活跃</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("cal_active_flag")]
        public int? CalActiveFlag { get; set; }

        /// <summary>
        /// <para>创建日程数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("create_cal_num")]
        public int? CreateCalNum { get; set; }

        /// <summary>
        /// <para>用户音视频会议活跃状态，用户进入会中状态（不包含妙记和直播）即为活跃</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：无活跃</item>
        /// <item>1：活跃</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("vc_active_flag")]
        public int? VcActiveFlag { get; set; }

        /// <summary>
        /// <para>会议时长（分钟，不包含会议室的时长）</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("vc_duration")]
        public int? VcDuration { get; set; }

        /// <summary>
        /// <para>活跃设备</para>
        /// <para>必填：否</para>
        /// <para>示例值：'ios 14.2,-','ios 14.2,feishu 3.40.0-alpha'</para>
        /// </summary>
        [JsonPropertyName("active_os")]
        public string? ActiveOs { get; set; }

        /// <summary>
        /// <para>创建任务数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("create_task_num")]
        public int? CreateTaskNum { get; set; }

        /// <summary>
        /// <para>会议数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("vc_num")]
        public int? VcNum { get; set; }

        /// <summary>
        /// <para>飞书的应用类型名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：Feishu，Lark</para>
        /// </summary>
        [JsonPropertyName("app_package_type")]
        public string? AppPackageType { get; set; }

        /// <summary>
        /// <para>操作系统名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：iOS,Andorid,Windows</para>
        /// </summary>
        [JsonPropertyName("os_name")]
        public string? OsName { get; set; }

        /// <summary>
        /// <para>邮件总发件量</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("email_send_count")]
        public string? EmailSendCount { get; set; }

        /// <summary>
        /// <para>邮件总收件量</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("email_receive_count")]
        public string? EmailReceiveCount { get; set; }

        /// <summary>
        /// <para>对外发件数</para>
        /// <para>必填：否</para>
        /// <para>示例值：4</para>
        /// </summary>
        [JsonPropertyName("email_send_ext_count")]
        public string? EmailSendExtCount { get; set; }

        /// <summary>
        /// <para>来自外部收件数</para>
        /// <para>必填：否</para>
        /// <para>示例值：5</para>
        /// </summary>
        [JsonPropertyName("email_receive_ext_count")]
        public string? EmailReceiveExtCount { get; set; }

        /// <summary>
        /// <para>对内发件数</para>
        /// <para>必填：否</para>
        /// <para>示例值：6</para>
        /// </summary>
        [JsonPropertyName("email_send_in_count")]
        public string? EmailSendInCount { get; set; }

        /// <summary>
        /// <para>来自内部收件数</para>
        /// <para>必填：否</para>
        /// <para>示例值：7</para>
        /// </summary>
        [JsonPropertyName("email_receive_in_count")]
        public string? EmailReceiveInCount { get; set; }

        /// <summary>
        /// <para>是否使用了大搜（0：未使用，1：有使用）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("search_active_flag")]
        public int? SearchActiveFlag { get; set; }

        /// <summary>
        /// <para>总搜索次数（在飞书主端搜索框发起过搜索请求的会话数）</para>
        /// <para>必填：否</para>
        /// <para>示例值：7</para>
        /// </summary>
        [JsonPropertyName("total_search_count")]
        public string? TotalSearchCount { get; set; }

        /// <summary>
        /// <para>综搜次数（在飞书主端搜索框的综合搜索发起过搜索请求的会话数）</para>
        /// <para>必填：否</para>
        /// <para>示例值：7</para>
        /// </summary>
        [JsonPropertyName("quick_search_count")]
        public string? QuickSearchCount { get; set; }

        /// <summary>
        /// <para>垂搜次数（在飞书主端搜索框的垂类搜索tab（例如消息tab、云文档tab）发起过搜索请求的会话数）</para>
        /// <para>必填：否</para>
        /// <para>示例值：7</para>
        /// </summary>
        [JsonPropertyName("tab_search_count")]
        public string? TabSearchCount { get; set; }
    }
}
