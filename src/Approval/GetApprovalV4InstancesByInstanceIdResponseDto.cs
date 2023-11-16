namespace FeishuNetSdk.Approval;
/// <summary>
/// 获取单个审批实例详情 响应体
/// <para>通过审批实例 Instance Code 获取审批实例详情。Instance Code 由 [批量获取审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/list) 接口获取。</para>
/// <para>接口ID：7114621541589729283</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fget</para>
/// </summary>
public record GetApprovalV4InstancesByInstanceIdResponseDto
{
    /// <summary>
    /// <para>审批名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：Payment</para>
    /// </summary>
    [JsonPropertyName("approval_name")]
    public string ApprovalName { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批创建时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1564590532967</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// <para>审批完成时间，未完成为 0</para>
    /// <para>必填：是</para>
    /// <para>示例值：1564590532967</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string EndTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起审批用户</para>
    /// <para>必填：是</para>
    /// <para>示例值：f3ta757q</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起审批用户 open id</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_3cda9c969f737aaa05e6915dce306cb9</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string OpenId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批单编号</para>
    /// <para>必填：是</para>
    /// <para>示例值：202102060002</para>
    /// </summary>
    [JsonPropertyName("serial_number")]
    public string SerialNumber { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起审批用户所在部门</para>
    /// <para>必填：是</para>
    /// <para>示例值：od-8ec33ffec336c3a39a278bc25e931676</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string DepartmentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：PENDING</para>
    /// <para>可选值：<list type="bullet">
    /// <item>PENDING：审批中</item>
    /// <item>APPROVED：通过</item>
    /// <item>REJECTED：拒绝</item>
    /// <item>CANCELED：撤回</item>
    /// <item>DELETED：删除</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// <para>用户的唯一标识 id</para>
    /// <para>必填：是</para>
    /// <para>示例值：1234567</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; } = string.Empty;

    /// <summary>
    /// <para>json 字符串，控件值详情见下方</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"id\":\"widget1\",\"custom_id\":\"user_info\",\"name\":\"Itemapplication\",\"type\":\"textarea\"}]</para>
    /// </summary>
    [JsonPropertyName("form")]
    public string Form { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批任务列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("task_list")]
    public InstanceTask[] TaskLists { get; set; } = Array.Empty<InstanceTask>();

    /// <summary>
    /// <para>审批任务列表</para>
    /// </summary>
    public record InstanceTask
    {
        /// <summary>
        /// <para>task id</para>
        /// <para>必填：是</para>
        /// <para>示例值：1234</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批人的用户 id，自动通过、自动拒绝 时为空</para>
        /// <para>必填：是</para>
        /// <para>示例值：f7cb567e</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批人 open id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_123457</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>任务状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：PENDING</para>
        /// <para>可选值：<list type="bullet">
        /// <item>PENDING：审批中</item>
        /// <item>APPROVED：通过</item>
        /// <item>REJECTED：拒绝</item>
        /// <item>TRANSFERRED：已转交</item>
        /// <item>DONE：完成</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// <para>task 所属节点 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：46e6d96cfa756980907209209ec03b64</para>
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// <para>task 所属节点名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：开始</para>
        /// </summary>
        [JsonPropertyName("node_name")]
        public string? NodeName { get; set; }

        /// <summary>
        /// <para>task 所属节点自定义 id, 如果没设置自定义 id, 则不返回该字段</para>
        /// <para>必填：否</para>
        /// <para>示例值：manager</para>
        /// </summary>
        [JsonPropertyName("custom_node_id")]
        public string? CustomNodeId { get; set; }

        /// <summary>
        /// <para>审批方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：AND</para>
        /// <para>可选值：<list type="bullet">
        /// <item>AND：会签</item>
        /// <item>OR：或签</item>
        /// <item>AUTO_PASS：自动通过</item>
        /// <item>AUTO_REJECT：自动拒绝</item>
        /// <item>SEQUENTIAL：按顺序</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>task 开始时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：1564590532967</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>task 完成时间, 未完成为 0</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }
    }

    /// <summary>
    /// <para>评论列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("comment_list")]
    public InstanceComment[] CommentLists { get; set; } = Array.Empty<InstanceComment>();

    /// <summary>
    /// <para>评论列表</para>
    /// </summary>
    public record InstanceComment
    {
        /// <summary>
        /// <para>评论 id</para>
        /// <para>必填：是</para>
        /// <para>示例值：1234</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>发表评论用户</para>
        /// <para>必填：是</para>
        /// <para>示例值：f7cb567e</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>发表评论用户 open id</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_123456</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// <para>评论内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：ok</para>
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// <para>1564590532967</para>
        /// <para>必填：是</para>
        /// <para>示例值：评论时间</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>评论附件</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("files")]
        public File[]? Files { get; set; }

        /// <summary>
        /// <para>评论附件</para>
        /// </summary>
        public record File
        {
            /// <summary>
            /// <para>附件路径</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://p3-approval-sign.byteimg.com/lark-approval-attachment/image/20220714/1/332f3596-0845-4746-a4bc-818d54ad435b.png~tplv-ottatrvjsm-image.image?x-expires=1659033558&amp;x-signature=6edF3k%2BaHeAuvfcBRGOkbckoUl4%3D#.png</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }

            /// <summary>
            /// <para>附件大小</para>
            /// <para>必填：否</para>
            /// <para>示例值：186823</para>
            /// </summary>
            [JsonPropertyName("file_size")]
            public int? FileSize { get; set; }

            /// <summary>
            /// <para>附件标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：e018906140ed9388234bd03b0.png</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>附件类别</para>
            /// <para>必填：否</para>
            /// <para>示例值：image</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }
        }
    }

    /// <summary>
    /// <para>审批动态</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("timeline")]
    public InstanceTimeline[] Timelines { get; set; } = Array.Empty<InstanceTimeline>();

    /// <summary>
    /// <para>审批动态</para>
    /// </summary>
    public record InstanceTimeline
    {
        /// <summary>
        /// <para>动态类型，不同类型 ext 内的 user_id_list 含义不一样</para>
        /// <para>必填：是</para>
        /// <para>示例值：PASS</para>
        /// <para>可选值：<list type="bullet">
        /// <item>START：审批开始</item>
        /// <item>PASS：通过</item>
        /// <item>REJECT：拒绝</item>
        /// <item>AUTO_PASS：自动通过</item>
        /// <item>AUTO_REJECT：自动拒绝</item>
        /// <item>REMOVE_REPEAT：去重</item>
        /// <item>TRANSFER：转交</item>
        /// <item>ADD_APPROVER_BEFORE：前加签</item>
        /// <item>ADD_APPROVER：并加签</item>
        /// <item>ADD_APPROVER_AFTER：后加签</item>
        /// <item>DELETE_APPROVER：减签</item>
        /// <item>ROLLBACK_SELECTED：指定回退</item>
        /// <item>ROLLBACK：全部回退</item>
        /// <item>CANCEL：撤回</item>
        /// <item>DELETE：删除</item>
        /// <item>CC：抄送</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>发生时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：1564590532967</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>动态产生用户</para>
        /// <para>必填：否</para>
        /// <para>示例值：f7cb567e</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>动态产生用户 open id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_123456</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>被抄送人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id_list")]
        public string[]? UserIdList { get; set; }

        /// <summary>
        /// <para>被抄送人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_id_list")]
        public string[]? OpenIdList { get; set; }

        /// <summary>
        /// <para>产生动态关联的task_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：1234</para>
        /// </summary>
        [JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// <para>理由</para>
        /// <para>必填：否</para>
        /// <para>示例值：ok</para>
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// <para>抄送人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cc_user_list")]
        public InstanceCcUser[]? CcUserLists { get; set; }

        /// <summary>
        /// <para>抄送人列表</para>
        /// </summary>
        public record InstanceCcUser
        {
            /// <summary>
            /// <para>抄送人 user id</para>
            /// <para>必填：否</para>
            /// <para>示例值：eea5gefe</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>审批实例内抄送唯一标识</para>
            /// <para>必填：否</para>
            /// <para>示例值：123445</para>
            /// </summary>
            [JsonPropertyName("cc_id")]
            public string? CcId { get; set; }

            /// <summary>
            /// <para>抄送人 open id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_12345</para>
            /// </summary>
            [JsonPropertyName("open_id")]
            public string? OpenId { get; set; }
        }

        /// <summary>
        /// <para>动态其他信息，json格式，目前包括 user_id_list, user_id，open_id_list，open_id</para>
        /// <para>必填：是</para>
        /// <para>示例值：{\"user_id\":\"62d4a44c\",\"open_id\":\"ou_123456\"}</para>
        /// </summary>
        [JsonPropertyName("ext")]
        public string Ext { get; set; } = string.Empty;

        /// <summary>
        /// <para>产生 task 的节点 key</para>
        /// <para>必填：否</para>
        /// <para>示例值：APPROVAL_240330_4058663</para>
        /// </summary>
        [JsonPropertyName("node_key")]
        public string? NodeKey { get; set; }

        /// <summary>
        /// <para>审批附件</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("files")]
        public File[]? Files { get; set; }

        /// <summary>
        /// <para>审批附件</para>
        /// </summary>
        public record File
        {
            /// <summary>
            /// <para>附件路径</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://p3-approval-sign.byteimg.com/lark-approval-attachment/image/20220714/1/332f3596-0845-4746-a4bc-818d54ad435b.png~tplv-ottatrvjsm-image.image?x-expires=1659033558&amp;x-signature=6edF3k%2BaHeAuvfcBRGOkbckoUl4%3D#.png</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }

            /// <summary>
            /// <para>附件大小</para>
            /// <para>必填：否</para>
            /// <para>示例值：186823</para>
            /// </summary>
            [JsonPropertyName("file_size")]
            public int? FileSize { get; set; }

            /// <summary>
            /// <para>附件标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：e018906140ed9388234bd03b0.png</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>附件类别</para>
            /// <para>必填：否</para>
            /// <para>示例值：image</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }
        }
    }

    /// <summary>
    /// <para>修改的原实例 code,仅在查询修改实例时显示该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("modified_instance_code")]
    public string? ModifiedInstanceCode { get; set; }

    /// <summary>
    /// <para>撤销的原实例 code,仅在查询撤销实例时显示该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("reverted_instance_code")]
    public string? RevertedInstanceCode { get; set; }

    /// <summary>
    /// <para>审批定义 Code</para>
    /// <para>必填：是</para>
    /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A85</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>单据是否被撤销</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("reverted")]
    public bool? Reverted { get; set; }

    /// <summary>
    /// <para>审批实例 Code</para>
    /// <para>必填：是</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;
}
