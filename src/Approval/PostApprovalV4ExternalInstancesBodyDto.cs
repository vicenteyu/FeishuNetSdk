// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="PostApprovalV4ExternalInstancesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>同步三方审批实例 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 同步三方审批实例 请求体
/// <para>审批中心不负责审批的流转，审批的流转在三方系统，三方系统在审批流转后生成的审批实例、审批任务、审批抄送数据同步到审批中心。</para>
/// <para>用户可以在审批中心中浏览三方系统同步过来的实例、任务、抄送信息，并且可以跳转回三方系统进行更详细的查看和操作，其中实例信息在【已发起】列表，任务信息在【待审批】和【已审批】列表，抄送信息在【抄送我】列表。</para>
/// <para>对于审批任务，三方系统也可以配置审批任务的回调接口，这样审批人可以在审批中心中直接进行审批操作，审批中心会回调三方系统，三方系统收到回调后更新任务信息，并将新的任务信息同步回审批中心，形成闭环。</para>
/// <para>接口ID：7114621541589811203</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_instance/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_instance%2fcreate</para>
/// </summary>
public record PostApprovalV4ExternalInstancesBodyDto
{
    /// <summary>
    /// <para>审批定义 code， 创建审批定义返回的值，表示该实例属于哪个流程；该字段会影响到列表中该实例的标题，标题取自对应定义的 name 字段</para>
    /// <para>必填：是</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：PENDING</para>
    /// <para>可选值：<list type="bullet">
    /// <item>PENDING：审批中</item>
    /// <item>APPROVED：审批流程结束，结果为同意</item>
    /// <item>REJECTED：审批流程结束，结果为拒绝</item>
    /// <item>CANCELED：审批发起人撤回</item>
    /// <item>DELETED：审批被删除</item>
    /// <item>HIDDEN：状态隐藏(不显示状态)</item>
    /// <item>TERMINATED：审批终止</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例扩展 JSON。单据编号通过传business_key字段来实现。以下示例值未转义，使用时请注意转义。你可查看请求体示例中转义后的 extra 示例值</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"xxx\":\"xxx\",\"business_key\":\"xxx\"}</para>
    /// </summary>
    [JsonPropertyName("extra")]
    public string? Extra { get; set; }

    /// <summary>
    /// <para>审批实例唯一标识，用户自定义，需确保证租户和应用下都唯一</para>
    /// <para>必填：是</para>
    /// <para>示例值：24492654</para>
    /// </summary>
    [JsonPropertyName("instance_id")]
    public string InstanceId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例链接集合 ，用于【已发起】列表的跳转，跳转回三方系统； pc_link 和 mobile_link 必须填一个，填写的是哪一端的链接，即会跳转到该链接，不受平台影响</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("links")]
    public ExternalInstanceLink Links { get; set; } = new();

    /// <summary>
    /// <para>审批实例链接集合 ，用于【已发起】列表的跳转，跳转回三方系统； pc_link 和 mobile_link 必须填一个，填写的是哪一端的链接，即会跳转到该链接，不受平台影响</para>
    /// </summary>
    public record ExternalInstanceLink
    {
        /// <summary>
        /// <para>pc 端的跳转链接，当用户使用飞书 pc 端时，使用该字段进行跳转，托管的链接保持不变。</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?mode=appCenter&amp;appId=cli_9c90fc38e07a9101&amp;path=pc/pages/detail?id=1234</para>
        /// </summary>
        [JsonPropertyName("pc_link")]
        public string PcLink { get; set; } = string.Empty;

        /// <summary>
        /// <para>移动端 跳转链接，当用户使用飞书 移动端时，使用该字段进行跳转，托管的链接保持不变</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&amp;path=pages/detail?id=1234</para>
        /// </summary>
        [JsonPropertyName("mobile_link")]
        public string? MobileLink { get; set; }
    }

    /// <summary>
    /// <para>审批展示名称，如果填写了该字段，则审批列表中的审批名称使用该字段，如果不填该字段，则审批名称使用审批定义的名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@1</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// <para>用户提交审批时填写的表单数据，用于所有审批列表中展示。可传多个值，但审批中心仅展示前 3 个，长度不超过 2048 字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：[{ "name": "@i18n@2", "value": "@i18n@3" }]</para>
    /// </summary>
    [JsonPropertyName("form")]
    public ExternalInstanceForm[]? Forms { get; set; }

    /// <summary>
    /// <para>用户提交审批时填写的表单数据，用于所有审批列表中展示。可传多个值，但审批中心仅展示前 3 个，长度不超过 2048 字符。</para>
    /// </summary>
    public record ExternalInstanceForm
    {
        /// <summary>
        /// <para>表单字段名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：@i18n@2</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>表单值</para>
        /// <para>必填：否</para>
        /// <para>示例值：@i18n@3</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    /// <summary>
    /// <para>审批发起人 user_id，发起人可在【已发起】列表中看到所有已发起的审批; 在【待审批】，【已审批】【抄送我】列表中，该字段展示审批是谁发起的。</para>
    /// <para>必填：否</para>
    /// <para>示例值：a987sf9s</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>审批发起人 用户名，如果发起人不是真实的用户（例如是某个部门），没有 user_id，则可以使用该字段传名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@9</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// <para>审批发起人 open id</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_be73cbc0ee35eb6ca54e9e7cc14998c1</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>发起人部门，用于列表中展示发起人所属部门。不传则不展示。如果用户没加入任何部门，传 ""，将展示租户名称传 department_name 展示部门名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：od-8ec33278bc2</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>审批发起人 部门，如果发起人不是真实的用户（例如是某个部门），没有 department_id，则可以使用该字段传名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@10</para>
    /// </summary>
    [JsonPropertyName("department_name")]
    public string? DepartmentName { get; set; }

    /// <summary>
    /// <para>审批发起时间，Unix毫秒时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1556468012678</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string StartTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例结束时间：未结束的审批为 0，Unix毫秒时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1556468012678</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string EndTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例最近更新时间；用于推送数据版本控制如果 update_mode 值为 UPDATE，则只有传过来的 update_time 有变化时（变大），才会更新审批中心中的审批实例信息。使用该字段主要用来避免并发时老的数据更新了新的数据</para>
    /// <para>必填：是</para>
    /// <para>示例值：1556468012678</para>
    /// </summary>
    [JsonPropertyName("update_time")]
    public string UpdateTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>列表页打开审批实例的方式</para>
    /// <para>必填：否</para>
    /// <para>示例值：BROWSER</para>
    /// <para>可选值：<list type="bullet">
    /// <item>BROWSER：跳转系统默认浏览器打开</item>
    /// <item>SIDEBAR：飞书中侧边抽屉打开</item>
    /// <item>NORMAL：飞书内嵌页面打开</item>
    /// <item>TRUSTEESHIP：以托管打开</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("display_method")]
    public string? DisplayMethod { get; set; }

    /// <summary>
    /// <para>更新方式， 当 update_mode=REPLACE时，每次都以当前推送的数据为最终数据，会删掉审批中心中多余的任务、抄送数据（不在这次推送的数据中）; 当 update_mode=UPDATE时，则不会删除审批中心的数据，而只是进行新增和更新实例、任务数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：UPDATE</para>
    /// <para>可选值：<list type="bullet">
    /// <item>REPLACE：全量替换，默认值</item>
    /// <item>UPDATE：增量更新</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("update_mode")]
    public string? UpdateMode { get; set; }

    /// <summary>
    /// <para>任务列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：300</para>
    /// </summary>
    [JsonPropertyName("task_list")]
    public ExternalInstanceTaskNode[]? TaskLists { get; set; }

    /// <summary>
    /// <para>任务列表</para>
    /// </summary>
    public record ExternalInstanceTaskNode
    {
        /// <summary>
        /// <para>审批实例内的唯一标识，用于更新审批任务时定位数据</para>
        /// <para>必填：是</para>
        /// <para>示例值：112534</para>
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批人 user_id，和 open_id 二者至少填一个。该任务会出现在审批人的【待审批】或【已审批】列表中</para>
        /// <para>必填：否</para>
        /// <para>示例值：a987sf9s</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>审批人 open_id，和 user_id 二者至少填一个</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_be73cbc0ee35eb6ca54e9e7cc14998c1</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>审批任务名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：i18n1</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>【待审批】或【已审批】中使用的跳转链接，用于跳转回三方系统pc_link 和 mobile_link 必须填一个，填写的是哪一端的链接，即会跳转到该链接，不受平台影响</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("links")]
        public ExternalInstanceLink Links { get; set; } = new();

        /// <summary>
        /// <para>【待审批】或【已审批】中使用的跳转链接，用于跳转回三方系统pc_link 和 mobile_link 必须填一个，填写的是哪一端的链接，即会跳转到该链接，不受平台影响</para>
        /// </summary>
        public record ExternalInstanceLink
        {
            /// <summary>
            /// <para>pc 端的跳转链接，当用户使用飞书 pc 端时，使用该字段进行跳转</para>
            /// <para>必填：是</para>
            /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?mode=appCenter&amp;appId=cli_9c90fc38e07a9101&amp;path=pc/pages/detail?id=1234</para>
            /// </summary>
            [JsonPropertyName("pc_link")]
            public string PcLink { get; set; } = string.Empty;

            /// <summary>
            /// <para>移动端 跳转链接，当用户使用飞书 移动端时，使用该字段进行跳转</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&amp;path=pages/detail?id=1234</para>
            /// </summary>
            [JsonPropertyName("mobile_link")]
            public string? MobileLink { get; set; }
        }

        /// <summary>
        /// <para>任务状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：PENDING</para>
        /// <para>可选值：<list type="bullet">
        /// <item>PENDING：待审批</item>
        /// <item>APPROVED：任务同意</item>
        /// <item>REJECTED：任务拒绝</item>
        /// <item>TRANSFERRED：任务转交</item>
        /// <item>DONE：任务通过但审批人未操作；审批人看不到这个任务, 若想要看到, 可以通过抄送该人.</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// <para>扩展 json，任务结束原因需传complete_reason字段。枚举值与对应说明：</para>
        /// <para>- approved：同意</para>
        /// <para>- rejected：拒绝</para>
        /// <para>- node_auto_reject：（因逻辑判断产生的）自动拒绝</para>
        /// <para>- specific_rollback：退回（包括退回到发起人、退回到中间任一审批人）</para>
        /// <para>- add：并加签（添加新审批人，和我一起审批）</para>
        /// <para>- add_pre：前加签（添加新审批人，在我之前审批）</para>
        /// <para>- add_post：后加签（添加新审批人，在我之后审批）</para>
        /// <para>- delete_assignee：减签</para>
        /// <para>- forward: 手动转交</para>
        /// <para>- forward_resign：离职自动转交</para>
        /// <para>- recall：撤销（撤回单据，单据失效）</para>
        /// <para>- delete ：删除审批单</para>
        /// <para>- admin_forward：管理员在后台操作转交</para>
        /// <para>- system_forward：系统自动转交</para>
        /// <para>- auto_skip：自动通过</para>
        /// <para>- manual_skip：手动跳过</para>
        /// <para>- submit_again：重新提交任务</para>
        /// <para>- restart：重新启动流程</para>
        /// <para>- others：其他（作为兜底）</para>
        /// <para>必填：否</para>
        /// <para>示例值：{\"xxx\":\"xxx\",\"complete_reason\":\"approved\"}</para>
        /// </summary>
        [JsonPropertyName("extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// <para>任务创建时间，Unix 毫秒时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1556468012678</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>任务完成时间：未结束的审批为 0，Unix 毫秒时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1556468012678</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>task最近更新时间，用于推送数据版本控制； 更新策略同 instance 中的 update_time</para>
        /// <para>必填：否</para>
        /// <para>示例值：1556468012678</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>操作上下文，当用户操作时，回调请求中带上该参数，用于传递该任务的上下文数据</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonPropertyName("action_context")]
        public string? ActionContext { get; set; }

        /// <summary>
        /// <para>任务级别操作配置,快捷审批目前支持移动端操作</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("action_configs")]
        public ActionConfig[]? ActionConfigs { get; set; }

        /// <summary>
        /// <para>任务级别操作配置,快捷审批目前支持移动端操作</para>
        /// </summary>
        public record ActionConfig
        {
            /// <summary>
            /// <para>操作类型，每个任务都可以配置2个操作，会展示审批列表中，当用户操作时，回调请求会带上该字段，表示用户进行了同意操作还是拒绝操作</para>
            /// <para>必填：是</para>
            /// <para>示例值：APPROVE</para>
            /// <para>可选值：<list type="bullet">
            /// <item>APPROVE：同意</item>
            /// <item>REJECT：拒绝</item>
            /// <item>{KEY}：任意字符串，如果使用任意字符串，则需要提供 action_name</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("action_type")]
            public string ActionType { get; set; } = string.Empty;

            /// <summary>
            /// <para>操作名称，i18n key 用于前台展示，如果 action_type 不是 APPROVAL和REJECT，则必须提供该字段，用于展示特定的操作名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：@i18n@5</para>
            /// </summary>
            [JsonPropertyName("action_name")]
            public string? ActionName { get; set; }

            /// <summary>
            /// <para>是否需要意见, 如果为true,则用户操作时，会跳转到 意见填写页面</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_need_reason")]
            public bool? IsNeedReason { get; set; }

            /// <summary>
            /// <para>审批意见是否必填</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_reason_required")]
            public bool? IsReasonRequired { get; set; }

            /// <summary>
            /// <para>意见是否支持上传附件</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_need_attachment")]
            public bool? IsNeedAttachment { get; set; }
        }

        /// <summary>
        /// <para>列表页打开审批任务的方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：BROWSER</para>
        /// <para>可选值：<list type="bullet">
        /// <item>BROWSER：跳转系统默认浏览器打开</item>
        /// <item>SIDEBAR：飞书中侧边抽屉打开</item>
        /// <item>NORMAL：飞书内嵌页面打开</item>
        /// <item>TRUSTEESHIP：以托管模式打开</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("display_method")]
        public string? DisplayMethod { get; set; }

        /// <summary>
        /// <para>三方任务支持不纳入效率统计。</para>
        /// <para>false：纳入效率统计。</para>
        /// <para>true：不纳入效率统计</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("exclude_statistics")]
        public bool? ExcludeStatistics { get; set; }

        /// <summary>
        /// <para>节点id：必须同时满足</para>
        /// <para>- 一个流程内，每个节点id唯一。如一个流程下「直属上级」、「隔级上级」等每个节点的Node_id均不一样</para>
        /// <para>- 同一个流程定义内，不同审批实例中的相同节点，Node_id要保持不变。例如张三和李四分别发起了请假申请，这2个审批实例中的「直属上级」节点的node_id应该保持一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：node</para>
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// <para>节点名称，如「财务审批」「法务审批」，支持中英日三种语言。示例：i18n@name。需要在i18n_resources中传该名称对应的国际化文案</para>
        /// <para>必填：否</para>
        /// <para>示例值：i18n@name</para>
        /// </summary>
        [JsonPropertyName("node_name")]
        public string? NodeName { get; set; }
    }

    /// <summary>
    /// <para>抄送列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("cc_list")]
    public CcNode[]? CcLists { get; set; }

    /// <summary>
    /// <para>抄送列表</para>
    /// </summary>
    public record CcNode
    {
        /// <summary>
        /// <para>审批实例内唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonPropertyName("cc_id")]
        public string CcId { get; set; } = string.Empty;

        /// <summary>
        /// <para>抄送人 employee id</para>
        /// <para>必填：否</para>
        /// <para>示例值：12345</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>抄送人 open id，和user id 二者至少填一个</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_be73cbc0ee35eb6ca54e9e7cc14998c1</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>跳转链接，用于【抄送我的】列表中的跳转pc_link 和 mobile_link 必须填一个，填写的是哪一端的链接，即会跳转到该链接，不受平台影响</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("links")]
        public ExternalInstanceLink Links { get; set; } = new();

        /// <summary>
        /// <para>跳转链接，用于【抄送我的】列表中的跳转pc_link 和 mobile_link 必须填一个，填写的是哪一端的链接，即会跳转到该链接，不受平台影响</para>
        /// </summary>
        public record ExternalInstanceLink
        {
            /// <summary>
            /// <para>pc 端的跳转链接，当用户使用飞书 pc 端时，使用该字段进行跳转</para>
            /// <para>必填：是</para>
            /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?mode=appCenter&amp;appId=cli_9c90fc38e07a9101&amp;path=pc/pages/detail?id=1234</para>
            /// </summary>
            [JsonPropertyName("pc_link")]
            public string PcLink { get; set; } = string.Empty;

            /// <summary>
            /// <para>移动端 跳转链接，当用户使用飞书 移动端时，使用该字段进行跳转</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&amp;path=pages/detail?id=1234</para>
            /// </summary>
            [JsonPropertyName("mobile_link")]
            public string? MobileLink { get; set; }
        }

        /// <summary>
        /// <para>阅读状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：READ</para>
        /// <para>可选值：<list type="bullet">
        /// <item>READ：已读</item>
        /// <item>UNREAD：未读</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("read_status")]
        public string ReadStatus { get; set; } = string.Empty;

        /// <summary>
        /// <para>扩展 json</para>
        /// <para>必填：否</para>
        /// <para>示例值：{\"xxx\":\"xxx\"}</para>
        /// </summary>
        [JsonPropertyName("extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// <para>抄送任务名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxx</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>抄送发起时间，Unix 毫秒时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1556468012678</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>抄送最近更新时间，用于推送数据版本控制更新策略同 instance 的update_time</para>
        /// <para>必填：是</para>
        /// <para>示例值：1556468012678</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>列表页打开审批任务的方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：BROWSER</para>
        /// <para>可选值：<list type="bullet">
        /// <item>BROWSER：跳转系统默认浏览器打开</item>
        /// <item>SIDEBAR：飞书中侧边抽屉打开</item>
        /// <item>NORMAL：飞书内嵌页面打开</item>
        /// <item>TRUSTEESHIP：以托管模式打开</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("display_method")]
        public string? DisplayMethod { get; set; }
    }

    /// <summary>
    /// <para>国际化文案</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("i18n_resources")]
    public I18nResource[] I18nResources { get; set; } = Array.Empty<I18nResource>();

    /// <summary>
    /// <para>国际化文案</para>
    /// </summary>
    public record I18nResource
    {
        /// <summary>
        /// <para>语言可选值有： zh-CN：中文 en-US：英文 ja-JP：日文</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// <para>可选值：<list type="bullet">
        /// <item>zh-CN：中文</item>
        /// <item>en-US：英文</item>
        /// <item>ja-JP：日文</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; } = string.Empty;

        /// <summary>
        /// <para>文案 key, value, i18n key 以 @i18n@ 开头； 该字段主要用于做国际化，允许用户同时传多个语言的文案，审批中心会根据用户当前的语音环境使用对应的文案，如果没有传用户当前的语音环境文案，则会使用默认的语言文案。</para>
        /// <para>必填：是</para>
        /// <para>示例值：{ "@i18n@1": "权限申请", "@i18n@2": "OA审批", "@i18n@3": "Permission" }</para>
        /// </summary>
        [JsonPropertyName("texts")]
        public I18nResourceText[] Texts { get; set; } = Array.Empty<I18nResourceText>();

        /// <summary>
        /// <para>文案 key, value, i18n key 以 @i18n@ 开头； 该字段主要用于做国际化，允许用户同时传多个语言的文案，审批中心会根据用户当前的语音环境使用对应的文案，如果没有传用户当前的语音环境文案，则会使用默认的语言文案。</para>
        /// </summary>
        public record I18nResourceText
        {
            /// <summary>
            /// <para>文案 key</para>
            /// <para>必填：是</para>
            /// <para>示例值：@i18n@1</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>文案</para>
            /// <para>必填：是</para>
            /// <para>示例值：people</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否默认语言，默认语言需要包含所有key，非默认语言如果key不存在会使用默认语言代替</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }
    }

    /// <summary>
    /// <para>单据托管认证token，托管回调会附带此token，帮助业务方认证</para>
    /// <para>必填：否</para>
    /// <para>示例值：788981c886b1c28ac29d1e68efd60683d6d90dfce80938ee9453e2a5f3e9e306</para>
    /// </summary>
    [JsonPropertyName("trusteeship_url_token")]
    public string? TrusteeshipUrlToken { get; set; }

    /// <summary>
    /// <para>用户的类型，会影响请求参数用户标识域的选择，包括加签操作回传的目标用户， 目前仅支持 "user_id"</para>
    /// <para>必填：否</para>
    /// <para>示例值：user_id</para>
    /// </summary>
    [JsonPropertyName("trusteeship_user_id_type")]
    public string? TrusteeshipUserIdType { get; set; }

    /// <summary>
    /// <para>单据托管回调接入方的接口的URL地址</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("trusteeship_urls")]
    public PostApprovalV4ExternalInstancesBodyDtoTrusteeshipUrls? TrusteeshipUrls { get; set; }

    /// <summary>
    /// <para>单据托管回调接入方的接口的URL地址</para>
    /// </summary>
    public record PostApprovalV4ExternalInstancesBodyDtoTrusteeshipUrls
    {
        /// <summary>
        /// <para>获取表单schema相关数据的url地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://#{your_domain}/api/form_detail</para>
        /// </summary>
        [JsonPropertyName("form_detail_url")]
        public string? FormDetailUrl { get; set; }

        /// <summary>
        /// <para>表示获取审批操作区数据的url地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://#{your_domain}/api/action_definition</para>
        /// </summary>
        [JsonPropertyName("action_definition_url")]
        public string? ActionDefinitionUrl { get; set; }

        /// <summary>
        /// <para>获取审批记录相关数据的url地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://#{your_domain}/api/approval_node</para>
        /// </summary>
        [JsonPropertyName("approval_node_url")]
        public string? ApprovalNodeUrl { get; set; }

        /// <summary>
        /// <para>进行审批操作时回调的url地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://#{your_domain}/api/action_callback</para>
        /// </summary>
        [JsonPropertyName("action_callback_url")]
        public string? ActionCallbackUrl { get; set; }

        /// <summary>
        /// <para>获取托管动态数据url 地址，使用该接口时必须要保证历史托管单据的数据中都同步了该接口地址，如果历史单据中没有该接口需要重新同步历史托管单据的数据来更新该URL。该接口用于飞书审批前端和业务线进行交互使用,只有使用审批前端的特定组件(由飞书审批前端提供的组件，并且需要和业务线进行接口交互的组件)才会需要</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://#{your_domain}/api/pull_business_data</para>
        /// </summary>
        [JsonPropertyName("pull_business_data_url")]
        public string? PullBusinessDataUrl { get; set; }
    }

    /// <summary>
    /// <para>托管预缓存策略</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("trusteeship_cache_config")]
    public TrusteeshipInstanceCacheConfig? TrusteeshipCacheConfig { get; set; }

    /// <summary>
    /// <para>托管预缓存策略</para>
    /// </summary>
    public record TrusteeshipInstanceCacheConfig
    {
        /// <summary>
        /// <para>托管预缓存策略</para>
        /// <para>必填：否</para>
        /// <para>示例值：DISABLE</para>
        /// <para>可选值：<list type="bullet">
        /// <item>DISABLE：不启用，默认</item>
        /// <item>IMMUTABLE：表单不会随流程进行改变</item>
        /// <item>BY_NODE：跟随流程节点变更更新缓存</item>
        /// <item>BY_USER：对于每个待办任务存储一份</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("form_policy")]
        public string? FormPolicy { get; set; }

        /// <summary>
        /// <para>表单是否随国际化改变</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("form_vary_with_locale")]
        public bool? FormVaryWithLocale { get; set; }

        /// <summary>
        /// <para>当前使用的表单版本号，保证表单改变后，版本号增加，实际值为int64整数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("form_version")]
        public string? FormVersion { get; set; }
    }
}
