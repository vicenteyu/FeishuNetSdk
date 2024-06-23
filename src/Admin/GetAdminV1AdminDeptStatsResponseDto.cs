// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetAdminV1AdminDeptStatsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取部门维度的用户活跃和功能使用数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Admin;
/// <summary>
/// 获取部门维度的用户活跃和功能使用数据 响应体
/// <para>该接口用于获取部门维度的用户活跃和功能使用数据，即IM（即时通讯）、日历、云文档、音视频会议、邮箱功能的使用数据。</para>
/// <para>接口ID：6954303251601309723</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/data-report-management/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fadmin_dept_stat%2flist</para>
/// </summary>
public record GetAdminV1AdminDeptStatsResponseDto
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
    public AdminDeptStat[]? Items { get; set; }

    /// <summary>
    /// <para>数据报表</para>
    /// </summary>
    public record AdminDeptStat
    {
        /// <summary>
        /// <para>日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-02-15</para>
        /// </summary>
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// <para>部门的department_id 或者open_department_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-382e2793cfc9471f892e8a672987654c</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>部门名字</para>
        /// <para>必填：否</para>
        /// <para>示例值：subtestkkk</para>
        /// </summary>
        [JsonPropertyName("department_name")]
        public string? DepartmentName { get; set; }

        /// <summary>
        /// <para>部门路径</para>
        /// <para>必填：否</para>
        /// <para>示例值：testkkk/subtestkkk</para>
        /// </summary>
        [JsonPropertyName("department_path")]
        public string? DepartmentPath { get; set; }

        /// <summary>
        /// <para>部门总人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("total_user_num")]
        public int? TotalUserNum { get; set; }

        /// <summary>
        /// <para>激活人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("active_user_num")]
        public int? ActiveUserNum { get; set; }

        /// <summary>
        /// <para>激活率</para>
        /// <para>必填：否</para>
        /// <para>示例值：1.00</para>
        /// </summary>
        [JsonPropertyName("active_user_rate")]
        public string? ActiveUserRate { get; set; }

        /// <summary>
        /// <para>活跃人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("suite_dau")]
        public int? SuiteDau { get; set; }

        /// <summary>
        /// <para>活跃率</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.00</para>
        /// </summary>
        [JsonPropertyName("suite_active_rate")]
        public string? SuiteActiveRate { get; set; }

        /// <summary>
        /// <para>新用户数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("new_user_num")]
        public int? NewUserNum { get; set; }

        /// <summary>
        /// <para>新激活数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("new_active_num")]
        public int? NewActiveNum { get; set; }

        /// <summary>
        /// <para>离职人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("resign_user_num")]
        public int? ResignUserNum { get; set; }

        /// <summary>
        /// <para>消息活跃人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("im_dau")]
        public int? ImDau { get; set; }

        /// <summary>
        /// <para>发送消息人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("send_messenger_user_num")]
        public int? SendMessengerUserNum { get; set; }

        /// <summary>
        /// <para>发送消息数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("send_messenger_num")]
        public int? SendMessengerNum { get; set; }

        /// <summary>
        /// <para>人均发送消息数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.00</para>
        /// </summary>
        [JsonPropertyName("avg_send_messenger_num")]
        public string? AvgSendMessengerNum { get; set; }

        /// <summary>
        /// <para>云文档活跃人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("docs_dau")]
        public int? DocsDau { get; set; }

        /// <summary>
        /// <para>创建文件人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("create_docs_user_num")]
        public int? CreateDocsUserNum { get; set; }

        /// <summary>
        /// <para>创建文件数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("create_docs_num")]
        public int? CreateDocsNum { get; set; }

        /// <summary>
        /// <para>人均创建文件数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.00</para>
        /// </summary>
        [JsonPropertyName("avg_create_docs_num")]
        public string? AvgCreateDocsNum { get; set; }

        /// <summary>
        /// <para>日历活跃人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("cal_dau")]
        public int? CalDau { get; set; }

        /// <summary>
        /// <para>创建日程人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("create_cal_user_num")]
        public int? CreateCalUserNum { get; set; }

        /// <summary>
        /// <para>创建日程数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("create_cal_num")]
        public int? CreateCalNum { get; set; }

        /// <summary>
        /// <para>人均创建日程数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.00</para>
        /// </summary>
        [JsonPropertyName("avg_create_cal_num")]
        public string? AvgCreateCalNum { get; set; }

        /// <summary>
        /// <para>音视频会议活跃人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("vc_dau")]
        public int? VcDau { get; set; }

        /// <summary>
        /// <para>会议时长：企业内员工参与通话与会议的总时长（分钟,不包括会议室的时长）</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("vc_duration")]
        public int? VcDuration { get; set; }

        /// <summary>
        /// <para>人均会议时长（分钟，不包含会议室的时长）</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.00</para>
        /// </summary>
        [JsonPropertyName("avg_vc_duration")]
        public string? AvgVcDuration { get; set; }

        /// <summary>
        /// <para>人均飞书使用时长（分钟）</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.00</para>
        /// </summary>
        [JsonPropertyName("avg_duration")]
        public string? AvgDuration { get; set; }

        /// <summary>
        /// <para>任务活跃人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("task_dau")]
        public int? TaskDau { get; set; }

        /// <summary>
        /// <para>创建任务人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("create_task_user_num")]
        public int? CreateTaskUserNum { get; set; }

        /// <summary>
        /// <para>创建任务数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("create_task_num")]
        public int? CreateTaskNum { get; set; }

        /// <summary>
        /// <para>人均创建任务数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.00</para>
        /// </summary>
        [JsonPropertyName("avg_create_task_num")]
        public string? AvgCreateTaskNum { get; set; }

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
        /// <para>大搜搜索活跃人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：7</para>
        /// </summary>
        [JsonPropertyName("search_active_dau")]
        public string? SearchActiveDau { get; set; }

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
