namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取单个流程详情 响应体
/// <para>根据流程实例 id 获取单个流程详情。</para>
/// <para>接口ID：7296819819722588188</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess%2fget</para>
/// </summary>
public record GetCorehrV2ProcessesByProcessIdResponseDto
{
    /// <summary>
    /// <para>流程实例ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7278949005675988535</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>流程状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：进行中</item>
    /// <item>2：拒绝</item>
    /// <item>4：撤回</item>
    /// <item>8：撤销</item>
    /// <item>9：已完成</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// <para>业务类型ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：leave</para>
    /// </summary>
    [JsonPropertyName("flow_template_id")]
    public string? FlowTemplateId { get; set; }

    /// <summary>
    /// <para>业务类型名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("flow_template_name")]
    public DataengineI18n? FlowTemplateName { get; set; }

    /// <summary>
    /// <para>业务类型名称</para>
    /// </summary>
    public record DataengineI18n
    {
        /// <summary>
        /// <para>中文值</para>
        /// <para>必填：否</para>
        /// <para>示例值：中文</para>
        /// </summary>
        [JsonPropertyName("zh_cn")]
        public string? ZhCn { get; set; }

        /// <summary>
        /// <para>英文值</para>
        /// <para>必填：否</para>
        /// <para>示例值：English</para>
        /// </summary>
        [JsonPropertyName("en_us")]
        public string? EnUs { get; set; }
    }

    /// <summary>
    /// <para>流程定义ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：people_6961286846093788680_7081951411982077732</para>
    /// </summary>
    [JsonPropertyName("flow_definition_id")]
    public string? FlowDefinitionId { get; set; }

    /// <summary>
    /// <para>流程定义名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("flow_definition_name")]
    public DataengineI18n? FlowDefinitionName { get; set; }

    /// <summary>
    /// <para>流程发起人ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7124991993901827628</para>
    /// </summary>
    [JsonPropertyName("initiator_id")]
    public string? InitiatorId { get; set; }

    /// <summary>
    /// <para>流程发起人姓名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("initiator_name")]
    public DataengineI18n? InitiatorName { get; set; }

    /// <summary>
    /// <para>流程发起时间，Unix毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1694769814036</para>
    /// </summary>
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// <para>流程结束时间，Unix毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1694769814036</para>
    /// </summary>
    [JsonPropertyName("complete_time")]
    public string? CompleteTime { get; set; }

    /// <summary>
    /// <para>发起单据地址</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("start_links")]
    public ProcessLink? StartLinks { get; set; }

    /// <summary>
    /// <para>发起单据地址</para>
    /// </summary>
    public record ProcessLink
    {
        /// <summary>
        /// <para>web端单据详情页地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：http://xxxx.com/xxx/xxx?a=b</para>
        /// </summary>
        [JsonPropertyName("web_link")]
        public string? WebLink { get; set; }

        /// <summary>
        /// <para>飞书pc端单据详情页地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=xxx</para>
        /// </summary>
        [JsonPropertyName("pc_link")]
        public string? PcLink { get; set; }

        /// <summary>
        /// <para>飞书移动端单据详情页地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=xxx</para>
        /// </summary>
        [JsonPropertyName("mobile_link")]
        public string? MobileLink { get; set; }
    }

    /// <summary>
    /// <para>流程摘要，会随着流程流转发生变化</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("abstracts")]
    public ProcessAbstractItem[]? Abstracts { get; set; }

    /// <summary>
    /// <para>流程摘要，会随着流程流转发生变化</para>
    /// </summary>
    public record ProcessAbstractItem
    {
        /// <summary>
        /// <para>摘要标题</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public DataengineI18n? Name { get; set; }

        /// <summary>
        /// <para>摘要标题</para>
        /// </summary>
        public record DataengineI18n
        {
            /// <summary>
            /// <para>中文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：中文</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：English</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>摘要值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("value")]
        public DataengineI18n? Value { get; set; }
    }

    /// <summary>
    /// <para>待办列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("todos")]
    public ProcessTodoItem[]? Todos { get; set; }

    /// <summary>
    /// <para>待办列表</para>
    /// </summary>
    public record ProcessTodoItem
    {
        /// <summary>
        /// <para>单据ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7278949005675988535</para>
        /// </summary>
        [JsonPropertyName("approver_id")]
        public string? ApproverId { get; set; }

        /// <summary>
        /// <para>单据类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：审批单</item>
        /// <item>5：表单</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// <para>单据地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("links")]
        public ProcessLink? Links { get; set; }

        /// <summary>
        /// <para>单据地址</para>
        /// </summary>
        public record ProcessLink
        {
            /// <summary>
            /// <para>web端单据详情页地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://xxxx.com/xxx/xxx?a=b</para>
            /// </summary>
            [JsonPropertyName("web_link")]
            public string? WebLink { get; set; }

            /// <summary>
            /// <para>飞书pc端单据详情页地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=xxx</para>
            /// </summary>
            [JsonPropertyName("pc_link")]
            public string? PcLink { get; set; }

            /// <summary>
            /// <para>飞书移动端单据详情页地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=xxx</para>
            /// </summary>
            [JsonPropertyName("mobile_link")]
            public string? MobileLink { get; set; }
        }

        /// <summary>
        /// <para>操作人ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7124991993901827628</para>
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string? OperatorId { get; set; }

        /// <summary>
        /// <para>操作人姓名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("operator_name")]
        public DataengineI18n? OperatorName { get; set; }

        /// <summary>
        /// <para>操作人姓名</para>
        /// </summary>
        public record DataengineI18n
        {
            /// <summary>
            /// <para>中文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：中文</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：English</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>节点名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("node_name")]
        public DataengineI18n? NodeName { get; set; }

        /// <summary>
        /// <para>创建时间，Unix毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1694769814036</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }
    }

    /// <summary>
    /// <para>抄送列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("cc_list")]
    public ProcessCcItem[]? CcLists { get; set; }

    /// <summary>
    /// <para>抄送列表</para>
    /// </summary>
    public record ProcessCcItem
    {
        /// <summary>
        /// <para>单据ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7278949005675988535</para>
        /// </summary>
        [JsonPropertyName("approver_id")]
        public string? ApproverId { get; set; }

        /// <summary>
        /// <para>单据地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("links")]
        public ProcessLink? Links { get; set; }

        /// <summary>
        /// <para>单据地址</para>
        /// </summary>
        public record ProcessLink
        {
            /// <summary>
            /// <para>web端单据详情页地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://xxxx.com/xxx/xxx?a=b</para>
            /// </summary>
            [JsonPropertyName("web_link")]
            public string? WebLink { get; set; }

            /// <summary>
            /// <para>飞书pc端单据详情页地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=xxx</para>
            /// </summary>
            [JsonPropertyName("pc_link")]
            public string? PcLink { get; set; }

            /// <summary>
            /// <para>飞书移动端单据详情页地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=xxx</para>
            /// </summary>
            [JsonPropertyName("mobile_link")]
            public string? MobileLink { get; set; }
        }

        /// <summary>
        /// <para>抄送人ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7124991993901827628</para>
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string? OperatorId { get; set; }

        /// <summary>
        /// <para>抄送人姓名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("operator_name")]
        public DataengineI18n? OperatorName { get; set; }

        /// <summary>
        /// <para>抄送人姓名</para>
        /// </summary>
        public record DataengineI18n
        {
            /// <summary>
            /// <para>中文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：中文</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：English</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>节点名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("node_name")]
        public DataengineI18n? NodeName { get; set; }

        /// <summary>
        /// <para>抄送时间，Unix毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1694769814036</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }
    }

    /// <summary>
    /// <para>已办列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("done_list")]
    public ProcessDoneItem[]? DoneLists { get; set; }

    /// <summary>
    /// <para>已办列表</para>
    /// </summary>
    public record ProcessDoneItem
    {
        /// <summary>
        /// <para>单据ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7278949005675988535</para>
        /// </summary>
        [JsonPropertyName("approver_id")]
        public string? ApproverId { get; set; }

        /// <summary>
        /// <para>单据类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：审批单</item>
        /// <item>5：表单</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// <para>单据状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// <para>可选值：<list type="bullet">
        /// <item>3：已完成</item>
        /// <item>2：拒绝</item>
        /// <item>4：取消</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>单据地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("links")]
        public ProcessLink? Links { get; set; }

        /// <summary>
        /// <para>单据地址</para>
        /// </summary>
        public record ProcessLink
        {
            /// <summary>
            /// <para>web端单据详情页地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://xxxx.com/xxx/xxx?a=b</para>
            /// </summary>
            [JsonPropertyName("web_link")]
            public string? WebLink { get; set; }

            /// <summary>
            /// <para>飞书pc端单据详情页地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=xxx</para>
            /// </summary>
            [JsonPropertyName("pc_link")]
            public string? PcLink { get; set; }

            /// <summary>
            /// <para>飞书移动端单据详情页地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=xxx</para>
            /// </summary>
            [JsonPropertyName("mobile_link")]
            public string? MobileLink { get; set; }
        }

        /// <summary>
        /// <para>操作人ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7124991993901827628</para>
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string? OperatorId { get; set; }

        /// <summary>
        /// <para>操作人姓名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("operator_name")]
        public DataengineI18n? OperatorName { get; set; }

        /// <summary>
        /// <para>操作人姓名</para>
        /// </summary>
        public record DataengineI18n
        {
            /// <summary>
            /// <para>中文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：中文</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：English</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>节点名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("node_name")]
        public DataengineI18n? NodeName { get; set; }

        /// <summary>
        /// <para>创建时间，Unix毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1694769814036</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>完成时间，Unix毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1694769814036</para>
        /// </summary>
        [JsonPropertyName("complete_time")]
        public string? CompleteTime { get; set; }
    }
}
