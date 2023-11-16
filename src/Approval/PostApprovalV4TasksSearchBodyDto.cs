namespace FeishuNetSdk.Approval;
/// <summary>
/// 查询任务列表 请求体
/// <para>该接口通过不同条件查询审批系统中符合条件的审批任务列表。</para>
/// <para>接口ID：7117964632137138179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fsearch</para>
/// </summary>
public record PostApprovalV4TasksSearchBodyDto
{
    /// <summary>
    /// <para>根据x_user_type填写审批人id</para>
    /// <para>必填：否</para>
    /// <para>示例值：lwiu098wj</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>审批定义 code</para>
    /// <para>必填：否</para>
    /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED942</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批实例 code</para>
    /// <para>必填：否</para>
    /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED943</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string? InstanceCode { get; set; }

    /// <summary>
    /// <para>审批实例第三方 id 注：和 approval_code 取并集</para>
    /// <para>必填：否</para>
    /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED976</para>
    /// </summary>
    [JsonPropertyName("instance_external_id")]
    public string? InstanceExternalId { get; set; }

    /// <summary>
    /// <para>审批定义分组第三方 id 注：和 instance_code 取并集</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234567</para>
    /// </summary>
    [JsonPropertyName("group_external_id")]
    public string? GroupExternalId { get; set; }

    /// <summary>
    /// <para>审批任务标题（只有第三方审批有）</para>
    /// <para>必填：否</para>
    /// <para>示例值：test</para>
    /// </summary>
    [JsonPropertyName("task_title")]
    public string? TaskTitle { get; set; }

    /// <summary>
    /// <para>审批任务状态，注：若不设置，查询全部状态 若不在集合中，报错</para>
    /// <para>必填：否</para>
    /// <para>示例值：PENDING</para>
    /// <para>可选值：<list type="bullet">
    /// <item>PENDING：审批中</item>
    /// <item>REJECTED：拒绝</item>
    /// <item>APPROVED：通过</item>
    /// <item>TRANSFERRED：转交</item>
    /// <item>DONE：已完成</item>
    /// <item>RM_REPEAT：去重</item>
    /// <item>PROCESSED：已处理</item>
    /// <item>ALL：所有状态</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("task_status")]
    public string? TaskStatus { get; set; }

    /// <summary>
    /// <para>任务查询开始时间（unix毫秒时间戳）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1547654251506</para>
    /// </summary>
    [JsonPropertyName("task_start_time_from")]
    public string? TaskStartTimeFrom { get; set; }

    /// <summary>
    /// <para>任务查询结束时间 (unix毫秒时间戳)</para>
    /// <para>必填：否</para>
    /// <para>示例值：1547654251506</para>
    /// </summary>
    [JsonPropertyName("task_start_time_to")]
    public string? TaskStartTimeTo { get; set; }

    /// <summary>
    /// <para>地区</para>
    /// <para>必填：否</para>
    /// <para>示例值：zh-CN</para>
    /// <para>可选值：<list type="bullet">
    /// <item>zh-CN：中文</item>
    /// <item>en-US：英文</item>
    /// <item>ja-JP：日文</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>
    /// <para>可选择task_status中的多个状态，当填写此参数时，task_status失效</para>
    /// <para>必填：否</para>
    /// <para>示例值：PENDING</para>
    /// </summary>
    [JsonPropertyName("task_status_list")]
    public string[]? TaskStatusList { get; set; }

    /// <summary>
    /// <para>按任务时间排序</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：按update_time倒排</item>
    /// <item>1：按update_time正排</item>
    /// <item>2：按start_time倒排</item>
    /// <item>3：按start_time正排</item>
    /// </list></para>
    /// <para>默认值：2</para>
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }
}
