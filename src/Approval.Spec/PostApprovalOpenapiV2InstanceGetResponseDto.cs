using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 获取单个审批实例详情 响应体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本>>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/get)通过审批实例 Instance Code  获取审批实例详情。Instance Code 由 [批量获取审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/list) 接口获取。</para>
/// <para>接口ID：6907569524100497409</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/obtain-single-approval-instance-details</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEDNyUjLxQjM14SM0ITN</para>
/// </summary>
public record PostApprovalOpenapiV2InstanceGetResponseDto
{
    /// <summary>
    /// <para>审批定义 Code</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批名称</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("approval_name")]
    public string ApprovalName { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批创建时间</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("start_time")]
    public int StartTime { get; set; }

    /// <summary>
    /// <para>审批完成时间，未完成为 0</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("end_time")]
    public int EndTime { get; set; }

    /// <summary>
    /// <para>发起审批用户</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起审批用户 open id</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("open_id")]
    public string OpenId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批单编号</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("serial_number")]
    public string SerialNumber { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起审批用户所在部门</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("department_id")]
    public string DepartmentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例状态</para>
    /// <para>PENDING    - 审批中</para>
    /// <para>APPROVED - 通过</para>
    /// <para>REJECTED  - 拒绝</para>
    /// <para>CANCELED -  撤回</para>
    /// <para>DELETED    -  删除</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("status")]
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// <para>用户的唯一标识id</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("uuid")]
    public string Uuid { get; set; } = string.Empty;

    /// <summary>
    /// <para>json字符串，**控件值**</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("form")]
    public string Form { get; set; } = string.Empty;

    public record FormSuffix
    {
        /// <summary>
        /// <para>控件 id</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>控件自定义 id，如果没有设置自定义 id，则不返回该字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// <para>控件名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>控件类型</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>控件值，不同类型格式不一样</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// <para>控件的扩展字段，满足一些特殊控件值的扩展值设置 例：图片控件的ext是文件名</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("ext")]
        public object Ext { get; set; } = new();
    }

    /// <summary>
    /// <para>审批任务列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("task_list")]
    public Task[] TaskList { get; set; } = Array.Empty<Task>();

    public record Task
    {
        /// <summary>
        /// <para>task id</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批人</para>
        /// <para>自动通过、自动拒绝 task user_id 为空</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>审批人 open id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>任务状态</para>
        /// <para>PENDING - 审批中</para>
        /// <para>APPROVED - 同意</para>
        /// <para>REJECTED  - 拒绝</para>
        /// <para>TRANSFERRED - 已转交</para>
        /// <para>DONE -  完成</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// <para>task 所属节点 id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// <para>task 所属节点名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("node_name")]
        public string? NodeName { get; set; }

        /// <summary>
        /// <para>task 所属节点自定义 id, 如果没设置自定义 id, 则不返回该字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("custom_node_id")]
        public string? CustomNodeId { get; set; }

        /// <summary>
        /// <para>审批方式</para>
        /// <para>AND -会签</para>
        /// <para>OR - 或签</para>
        /// <para>AUTO_PASS -自动通过</para>
        /// <para>AUTO_REJECT - 自动拒绝</para>
        /// <para>SEQUENTIAL - 按顺序</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>task 开始时间</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// <para>task 完成时间, 未完成为 0</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("end_time")]
        public long EndTime { get; set; }
    }

    /// <summary>
    /// <para>评论列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("comment_list")]
    public CommentSuffix[] CommentList { get; set; } = Array.Empty<CommentSuffix>();

    public record CommentSuffix
    {
        /// <summary>
        /// <para>comment id</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>发表评论用户</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>发表评论用户 open id</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// <para>评论内容</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// <para>评论时间</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("create_time")]
        public long CreateTime { get; set; }
    }

    /// <summary>
    /// <para>审批动态</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("timeline")]
    public TimelineSuffix[] Timeline { get; set; } = Array.Empty<TimelineSuffix>();

    public record TimelineSuffix
    {
        /// <summary>
        /// <para>动态类型，不同类型 ext 内的 user_id_list 含义不一样</para>
        /// <para>START - 审批开始</para>
        /// <para>PASS - 通过</para>
        /// <para>REJECT  - 拒绝</para>
        /// <para>AUTO_PASS -  自动通过</para>
        /// <para>AUTO_REJECT - 自动拒绝</para>
        /// <para>REMOVE_REPEAT - 去重</para>
        /// <para>TRANSFER - 转交</para>
        /// <para>ADD_APPROVER_BEFORE  - 前加签</para>
        /// <para>ADD_APPROVER -  并加签</para>
        /// <para>ADD_APPROVER_AFTER -  后加签</para>
        /// <para>DELETE_APPROVER  - 减签</para>
        /// <para>ROLLBACK_SELECTED -  指定回退</para>
        /// <para>ROLLBACK - 全部回退</para>
        /// <para>CANCEL -  撤回</para>
        /// <para>DELETE - 删除</para>
        /// <para>CC - 抄送</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>发生时间</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// <para>动态产生用户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>动态产生用户 open id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>被抄送人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("user_id_list")]
        public string[]? UserIdList { get; set; }

        /// <summary>
        /// <para>被抄送人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("open_id_list")]
        public string[]? OpenIdList { get; set; }

        /// <summary>
        /// <para>产生动态关联的task_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// <para>理由</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// <para>抄送人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("cc_user_list")]
        public CcUser[]? CcUserList { get; set; }

        public record CcUser
        {
            /// <summary>
            /// <para>抄送人 user id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>审批实例内抄送唯一标识</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("cc_id")]
            public string? CcId { get; set; }

            /// <summary>
            /// <para>抄送人 open id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("open_id")]
            public string? OpenId { get; set; }
        }

        /// <summary>
        /// <para>动态其他信息，目前包括 user_id_list, user_id</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("ext")]
        public string Ext { get; set; } = string.Empty;

        public record ExtSuffix
        {
            /// <summary>
            /// <para>**type类型** - **user_id_list 含义**</para>
            /// <para>TRANSFER - 被转交人</para>
            /// <para>ADD_APPROVER_BEFORE  -  被加签人</para>
            /// <para>ADD_APPROVER -   被加签人</para>
            /// <para>ADD_APPROVER_AFTER -   被加签人</para>
            /// <para>DELETE_APPROVER  - 被减签人</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("user_id_list")]
            public string[]? UserIdList { get; set; }

            /// <summary>
            /// <para>user_id_list 对应的 open id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("open_id_list")]
            public string[]? OpenIdList { get; set; }

            /// <summary>
            /// <para>**type类型** - **user_id 含义**</para>
            /// <para>CC - 抄送人</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>user_id 对应的 open_id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("open_id")]
            public string? OpenId { get; set; }
        }

        /// <summary>
        /// <para>产生task的节点key</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("node_key")]
        public string? NodeKey { get; set; }
    }

    /// <summary>
    /// <para>修改的原实例 code,仅在查询修改实例时显示该字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("modified_instance_code")]
    public string? ModifiedInstanceCode { get; set; }

    /// <summary>
    /// <para>撤销的原实例 code,仅在查询撤销实例时显示该字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("reverted_instance_code")]
    public string? RevertedInstanceCode { get; set; }
}
