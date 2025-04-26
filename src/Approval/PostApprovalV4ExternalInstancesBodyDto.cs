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
/// <para>审批中心不负责审批的流转，审批的流转在三方系统。本接口用于把三方系统在审批流转后生成的审批实例、审批任务、审批抄送数据同步到审批中心。</para>
/// <para>## 实现效果</para>
/// <para>调用本接口同步三方审批实例后，企业员工可以在审批中心浏览同步过来的审批实例、任务、抄送信息，并可以跳转回三方系统查看和操作审批，其中，实例信息在审批中心的 **已发起** 列表、任务信息在 **待办** 和 **已办** 列表、抄送信息在 **抄送我** 列表。</para>
/// <para>[创建三方审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/external_approval/create)时如果设置了三方审批回调 URL，对于审批任务，可以配置[三方快捷审批回调](https://open.feishu.cn/document/ukTMukTMukTM/ukjNyYjL5YjM24SO2IjN/quick-approval-callback)，这样审批人可以在审批中心直接进行审批操作，审批中心会将审批结果回调至三方系统，三方系统收到回调后更新任务信息，并将新的任务信息同步回审批中心，形成闭环。</para>
/// <para>## 注意事项</para>
/// <para>需确保审批实例内各类实体（实例、任务、抄送） ID 在审批实例内的唯一性，不属于同一实体之间的 ID 也要确保唯一性。如果实例 ID、任务 ID、抄送 ID 重复，则会导致在审批中心任务看不到对应的审批数据。</para>
/// <para>接口ID：7114621541589811203</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_instance/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_instance%2fcreate</para>
/// </summary>
public record PostApprovalV4ExternalInstancesBodyDto
{
    /// <summary>
    /// <para>审批定义 Code。[创建三方审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/external_approval/create)的返回值，用来指定当前实例属于的审批定义。</para>
    /// <para>**说明**：如果在当前接口设置了 title 参数，则审批实例名称按照 title 展示。如果未设置 title，审批实例的标题取自对应审批定义（approval_code）的 name 参数。</para>
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
    /// <item>HIDDEN：状态隐藏（不显示状态）</item>
    /// <item>TERMINATED：审批终止</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例扩展参数，JSON 格式，传值时需要压缩转义为字符串。单据编号通过传 business_key 参数来实现。</para>
    /// <para>**注意**：以下示例值未转义，使用时请注意转义。你可查看请求体示例中转义后的 extra 示例值。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"xxx\":\"xxx\",\"business_key\":\"xxx\"}</para>
    /// </summary>
    [JsonPropertyName("extra")]
    public string? Extra { get; set; }

    /// <summary>
    /// <para>审批实例唯一标识，自定义设置。需确保证在当前企业和应用内唯一。</para>
    /// <para>必填：是</para>
    /// <para>示例值：24492654</para>
    /// </summary>
    [JsonPropertyName("instance_id")]
    public string InstanceId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例链接信息。设置的链接用于在审批中心 **已发起** 列表内点击跳转，跳回三方审批系统查看审批详情。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("links")]
    public ExternalInstanceLink Links { get; set; } = new();

    /// <summary>
    /// <para>审批实例链接信息。设置的链接用于在审批中心 **已发起** 列表内点击跳转，跳回三方审批系统查看审批详情。</para>
    /// </summary>
    public record ExternalInstanceLink
    {
        /// <summary>
        /// <para>PC 端的三方审批实例跳转链接。</para>
        /// <para>**说明**：</para>
        /// <para>- 当用户使用飞书 PC 端查看实例详情时，通过该链接进行跳转。</para>
        /// <para>- pc_link 和 mobile_link 至少填一个。</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?mode=appCenter&amp;appId=cli_9c90fc38e07a9101&amp;path=pc/pages/detail?id=1234</para>
        /// </summary>
        [JsonPropertyName("pc_link")]
        public string PcLink { get; set; } = string.Empty;

        /// <summary>
        /// <para>移动端的三方审批实例跳转链接。</para>
        /// <para>**说明**：</para>
        /// <para>- 当用户使用飞书移动端查看实例详情时，通过该链接进行跳转。</para>
        /// <para>- pc_link 和 mobile_link 至少填一个。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&amp;path=pages/detail?id=1234</para>
        /// </summary>
        [JsonPropertyName("mobile_link")]
        public string? MobileLink { get; set; }
    }

    /// <summary>
    /// <para>审批展示名称。</para>
    /// <para>**说明**：</para>
    /// <para>- 如果填写了该参数，则审批列表中的审批名称使用该参数。如果不填该参数，则审批名称使用审批定义的名称。</para>
    /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key:Value 格式进行赋值。</para>
    /// <para>- Key 需要以 @i18n@ 开头。</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@1</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// <para>用户提交审批时填写的表单数据，用于所有审批列表中展示。可传多个值，最多展示前 3 个，长度不超过 2048 字符。</para>
    /// <para>![image.png](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/69fd0009295b654b28ba2fb46727b4aa_KWIEEvsNPu.png?height=294&amp;maxWidth=200&amp;width=626)</para>
    /// <para>必填：否</para>
    /// <para>示例值：[{ "name": "@i18n@2", "value": "@i18n@3" }]</para>
    /// </summary>
    [JsonPropertyName("form")]
    public ExternalInstanceForm[]? Forms { get; set; }

    /// <summary>
    /// <para>用户提交审批时填写的表单数据，用于所有审批列表中展示。可传多个值，最多展示前 3 个，长度不超过 2048 字符。</para>
    /// <para>![image.png](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/69fd0009295b654b28ba2fb46727b4aa_KWIEEvsNPu.png?height=294&amp;maxWidth=200&amp;width=626)</para>
    /// </summary>
    public record ExternalInstanceForm
    {
        /// <summary>
        /// <para>表单字段名称。</para>
        /// <para>**说明**：</para>
        /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key:Value 格式进行赋值。</para>
        /// <para>- Key 需要以 @i18n@ 开头。</para>
        /// <para>必填：否</para>
        /// <para>示例值：@i18n@2</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>表单值。</para>
        /// <para>**说明**：</para>
        /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key:Value 格式进行赋值。</para>
        /// <para>- Key 需要以 @i18n@ 开头。</para>
        /// <para>必填：否</para>
        /// <para>示例值：@i18n@3</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    /// <summary>
    /// <para>审批发起人 user_id。发起人可在审批中心的 **已发起** 列表中看到所有已发起的审批。在 **待办**、**已办**、**抄送我** 列表中，该字段用来展示审批的发起人。获取方式参见[如何获取用户的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
    /// <para>**注意**：审批发起人的 open_id 和 user_id 需至少传入一个。</para>
    /// <para>必填：否</para>
    /// <para>示例值：a987sf9s</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>审批发起人的用户名。如果发起人不是真实的用户（例如是某个部门），没有 user_id，则可以使用该参数传入一个名称。</para>
    /// <para>**说明**：</para>
    /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key:Value 格式进行赋值。</para>
    /// <para>- Key 需要以 @i18n@ 开头。</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@9</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// <para>审批发起人 open_id。发起人可在审批中心的 **已发起** 列表中看到所有已发起的审批。在 **待办**、**已办**、**抄送我** 列表中，该字段用来展示审批的发起人。获取方式参见[如何获取用户的 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>**注意**：审批发起人的 open_id 和 user_id 需至少传入一个。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_be73cbc0ee35eb6ca54e9e7cc14998c1</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>发起人的部门 ID，用于在审批中心列表中展示发起人的所属部门，不传值则不展示。获取方式参见[部门 ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#9c02ed7a)。</para>
    /// <para>**说明**：如果用户没加入任何部门，传 `""`，默认展示企业名称。如果传入 department_name 参数，则展示对应的部门名称。</para>
    /// <para>必填：否</para>
    /// <para>示例值：od-8ec33278bc2</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>审批发起人的部门名称。如果发起人不是真实的用户或没有部门，则可以使用该参数传入部门名称。</para>
    /// <para>**说明**：</para>
    /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key:Value 格式进行赋值。</para>
    /// <para>- Key 需要以 @i18n@ 开头。</para>
    /// <para>必填：否</para>
    /// <para>示例值：@i18n@10</para>
    /// </summary>
    [JsonPropertyName("department_name")]
    public string? DepartmentName { get; set; }

    /// <summary>
    /// <para>审批发起时间，Unix 毫秒时间戳。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1556468012678</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string StartTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例结束时间。未结束的审批为 0，Unix 毫秒时间戳。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1556468012678</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string EndTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例最近更新时间，用于推送数据版本控制。如果 update_mode 值为 UPDATE，则仅当传过来的 update_time 有变化时（变大），才会更新审批中心中的审批实例信息。</para>
    /// <para>**说明**：使用该参数主要用来避免并发时，旧数据更新了新数据。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1556468012678</para>
    /// </summary>
    [JsonPropertyName("update_time")]
    public string UpdateTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>列表页打开审批实例的方式。</para>
    /// <para>必填：否</para>
    /// <para>示例值：BROWSER</para>
    /// <para>可选值：<list type="bullet">
    /// <item>BROWSER：跳转系统默认浏览器打开</item>
    /// <item>SIDEBAR：飞书中侧边抽屉打开</item>
    /// <item>NORMAL：飞书内嵌页面打开</item>
    /// <item>TRUSTEESHIP：以托管打开（即托管在飞书审批中心打开）</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("display_method")]
    public string? DisplayMethod { get; set; }

    /// <summary>
    /// <para>更新方式。</para>
    /// <para>- 当 update_mode 取值为 REPLACE 时，每次都以当前推送的数据为最终数据，会删掉审批中心中，不在本次推送数据中的多余的任务、抄送数据。</para>
    /// <para>- 当 update_mode 取值为 UPDATE 时，不会删除审批中心的数据，而只进行新增、更新实例与任务数据。</para>
    /// <para>**默认值**：REPLACE</para>
    /// <para>必填：否</para>
    /// <para>示例值：UPDATE</para>
    /// <para>可选值：<list type="bullet">
    /// <item>REPLACE：全量替换</item>
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
        /// <para>审批实例内，审批任务的唯一标识，用于更新审批任务时定位数据。</para>
        /// <para>必填：是</para>
        /// <para>示例值：112534</para>
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批人 user_id，获取方式参见[如何获取用户的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
        /// <para>**说明**：</para>
        /// <para>- 该任务会出现在审批人的飞书审批中心 **待办** 或 **已办** 的列表中。</para>
        /// <para>- user_id 与 open_id 需至少传入一个。</para>
        /// <para>必填：否</para>
        /// <para>示例值：a987sf9s</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>审批人 open_id，获取方式参见[如何获取用户的 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
        /// <para>**说明**：</para>
        /// <para>- 该任务会出现在审批人的飞书审批中心 **待办** 或 **已办** 的列表中。</para>
        /// <para>- user_id 与 open_id 需至少传入一个。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_be73cbc0ee35eb6ca54e9e7cc14998c1</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>审批任务名称。</para>
        /// <para>**说明**：</para>
        /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key:Value 格式进行赋值。</para>
        /// <para>- Key 需要以 @i18n@ 开头。</para>
        /// <para>必填：否</para>
        /// <para>示例值：@i18n@4</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>在审批中心 **待办**、**已办** 中使用的三方审批跳转链接，用于跳转回三方审批系统查看任务详情。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("links")]
        public ExternalInstanceLink Links { get; set; } = new();

        /// <summary>
        /// <para>在审批中心 **待办**、**已办** 中使用的三方审批跳转链接，用于跳转回三方审批系统查看任务详情。</para>
        /// </summary>
        public record ExternalInstanceLink
        {
            /// <summary>
            /// <para>PC 端的跳转链接。</para>
            /// <para>**说明**：</para>
            /// <para>- 当用户使用飞书 PC 端查看任务详情时，通过该链接进行跳转。</para>
            /// <para>- pc_link 和 mobile_link 至少填一个。</para>
            /// <para>必填：是</para>
            /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?mode=appCenter&amp;appId=cli_9c90fc38e07a9101&amp;path=pc/pages/detail?id=1234</para>
            /// </summary>
            [JsonPropertyName("pc_link")]
            public string PcLink { get; set; } = string.Empty;

            /// <summary>
            /// <para>移动端的跳转链接。</para>
            /// <para>**说明**：</para>
            /// <para>- 当用户使用飞书移动端查看任务详情时，通过该链接进行跳转。</para>
            /// <para>- pc_link 和 mobile_link 至少填一个。</para>
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
        /// <item>DONE：任务通过但审批人未操作。审批人看不到该任务时，如需查看可抄送至该审批人。</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// <para>扩展字段。JSON 格式，传值时需要压缩转义为字符串。</para>
        /// <para>任务结束原因需传 complete_reason 参数，枚举值说明：</para>
        /// <para>- approved：同意</para>
        /// <para>- rejected：拒绝</para>
        /// <para>- node_auto_reject：因逻辑判断产生的自动拒绝</para>
        /// <para>- specific_rollback：退回（包括退回到发起人、退回到中间任一审批人）</para>
        /// <para>- add：并加签（添加新审批人，与我一起审批）</para>
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
        /// <para>- others：其他</para>
        /// <para>必填：否</para>
        /// <para>示例值：{\"xxx\":\"xxx\",\"complete_reason\":\"approved\"}</para>
        /// </summary>
        [JsonPropertyName("extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// <para>任务创建时间，Unix 毫秒时间戳。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1556468012678</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>任务完成时间。未结束的审批为 0，Unix 毫秒时间戳。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1556468012678</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>任务最近更新时间，用于推送数据版本控制。如果 update_mode 值为 UPDATE，则仅当传过来的 update_time 有变化时（变大），才会更新审批中心中的审批任务信息。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1556468012678</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>操作上下文。当用户操作审批时，回调请求中会包含该参数，用于传递该任务的上下文数据。</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonPropertyName("action_context")]
        public string? ActionContext { get; set; }

        /// <summary>
        /// <para>任务级别的快捷审批操作配置。</para>
        /// <para>**注意**：快捷审批目前仅支持在飞书移动端操作。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("action_configs")]
        public ActionConfig[]? ActionConfigs { get; set; }

        /// <summary>
        /// <para>任务级别的快捷审批操作配置。</para>
        /// <para>**注意**：快捷审批目前仅支持在飞书移动端操作。</para>
        /// </summary>
        public record ActionConfig
        {
            /// <summary>
            /// <para>操作类型。每个任务都可以配置两个操作（同意、拒绝或任意中的两个），操作会展示审批列表中。当用户操作时，回调请求会包含该字段，三方审批可接受到审批人的操作数据。</para>
            /// <para>必填：是</para>
            /// <para>示例值：APPROVE</para>
            /// <para>可选值：<list type="bullet">
            /// <item>APPROVE：同意</item>
            /// <item>REJECT：拒绝</item>
            /// <item>{KEY}：任意字符串。如果使用任意字符串，则需要提供 action_name</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("action_type")]
            public string ActionType { get; set; } = string.Empty;

            /// <summary>
            /// <para>操作名称。如果 action_type 不等于 APPROVAL 或 REJECT，则必须提供该字段，用于展示特定的操作名称。</para>
            /// <para>**说明**：</para>
            /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key:Value 格式进行赋值。</para>
            /// <para>- Key 需要以 @i18n@ 开头。</para>
            /// <para>必填：否</para>
            /// <para>示例值：@i18n@5</para>
            /// </summary>
            [JsonPropertyName("action_name")]
            public string? ActionName { get; set; }

            /// <summary>
            /// <para>是否需要审批意见。取值为 true 时，审批人在审批中心操作任务后，还需要跳转填写审批意见。</para>
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
            /// <para>审批意见是否支持上传附件</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_need_attachment")]
            public bool? IsNeedAttachment { get; set; }
        }

        /// <summary>
        /// <para>审批中心列表页打开审批任务的方式。</para>
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
        /// <para>三方审批任务是否不纳入效率统计。可选值有：</para>
        /// <para>- true：不纳入效率统计</para>
        /// <para>- false：纳入效率统计</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("exclude_statistics")]
        public bool? ExcludeStatistics { get; set; }

        /// <summary>
        /// <para>审批节点 ID。必须同时满足：</para>
        /// <para>- 一个审批流程内，每个节点 ID 唯一。例如，一个流程下直属上级、隔级上级等节点的 node_id 均不一样。</para>
        /// <para>- 同一个三方审批定义内，不同审批实例中的相同节点，node_id 要保持不变。例如，用户 A 和用户 B 分别发起了请假申请，这两个审批实例中的直属上级节点的 node_id 应该保持一致。</para>
        /// <para>必填：否</para>
        /// <para>示例值：node</para>
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// <para>节点名称。</para>
        /// <para>**说明**：</para>
        /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key:Value 格式进行赋值。</para>
        /// <para>- Key 需要以 @i18n@ 开头。</para>
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
        /// <para>审批实例内抄送唯一标识。</para>
        /// <para>必填：是</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonPropertyName("cc_id")]
        public string CcId { get; set; } = string.Empty;

        /// <summary>
        /// <para>抄送人的 user_id。获取方式参见[如何获取用户的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
        /// <para>**注意**：抄送人的 open_id 和 user_id 需至少传入一个。</para>
        /// <para>必填：否</para>
        /// <para>示例值：12345</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>抄送人的 open_id。获取方式参见[如何获取用户的 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
        /// <para>**注意**：抄送人的 open_id 和 user_id 需至少传入一个。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_be73cbc0ee35eb6ca54e9e7cc14998c1</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>审批抄送跳转链接。设置的链接用于在审批中心 **抄送我** 列表内点击跳转，跳回三方审批系统查看审批抄送详情。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("links")]
        public ExternalInstanceLink Links { get; set; } = new();

        /// <summary>
        /// <para>审批抄送跳转链接。设置的链接用于在审批中心 **抄送我** 列表内点击跳转，跳回三方审批系统查看审批抄送详情。</para>
        /// </summary>
        public record ExternalInstanceLink
        {
            /// <summary>
            /// <para>PC 端的三方审批实例跳转链接。</para>
            /// <para>**说明**：</para>
            /// <para>- 当用户使用飞书 PC 端查看审批抄送时，通过该字段进行跳转。</para>
            /// <para>- pc_link 和 mobile_link 至少填一个。</para>
            /// <para>必填：是</para>
            /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?mode=appCenter&amp;appId=cli_9c90fc38e07a9101&amp;path=pc/pages/detail?id=1234</para>
            /// </summary>
            [JsonPropertyName("pc_link")]
            public string PcLink { get; set; } = string.Empty;

            /// <summary>
            /// <para>移动端的三方审批实例跳转链接。</para>
            /// <para>**说明**：</para>
            /// <para>- 当用户使用飞书移动端查看审批抄送时，通过该字段进行跳转。</para>
            /// <para>- pc_link 和 mobile_link 至少填一个。</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&amp;path=pages/detail?id=1234</para>
            /// </summary>
            [JsonPropertyName("mobile_link")]
            public string? MobileLink { get; set; }
        }

        /// <summary>
        /// <para>抄送人的阅读状态，空值表示不支持已读未读。</para>
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
        /// <para>扩展字段。JSON 格式，传值时需要压缩转义为字符串。</para>
        /// <para>必填：否</para>
        /// <para>示例值：{\"xxx\":\"xxx\"}</para>
        /// </summary>
        [JsonPropertyName("extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// <para>抄送任务名称。</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxx</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>抄送发起时间，Unix 毫秒时间戳。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1556468012678</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>抄送最近更新时间，用于推送数据版本。如果 update_mode 值为 UPDATE，则仅当传过来的 update_time 有变化时（变大），才会更新审批中心中的审批实例信息。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1556468012678</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>列表页打开审批任务的方式。</para>
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
        /// <para>语言</para>
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
        /// <para>文案的 Key:Value。Key 需要以 @i18n@ 开头，并按照各个参数的要求传入 Value。该字段主要用于做国际化，允许用户同时传多个语言的文案，审批中心会根据用户当前的语音环境使用对应的文案，如果没有传用户当前的语音环境文案，则会使用默认的语言文案。</para>
        /// <para>必填：是</para>
        /// <para>示例值：{ "@i18n@1": "权限申请", "@i18n@2": "OA审批", "@i18n@3": "Permission" }</para>
        /// </summary>
        [JsonPropertyName("texts")]
        public I18nResourceText[] Texts { get; set; } = Array.Empty<I18nResourceText>();

        /// <summary>
        /// <para>文案的 Key:Value。Key 需要以 @i18n@ 开头，并按照各个参数的要求传入 Value。该字段主要用于做国际化，允许用户同时传多个语言的文案，审批中心会根据用户当前的语音环境使用对应的文案，如果没有传用户当前的语音环境文案，则会使用默认的语言文案。</para>
        /// </summary>
        public record I18nResourceText
        {
            /// <summary>
            /// <para>文案 Key，需要和各个参数 Key 相匹配。</para>
            /// <para>必填：是</para>
            /// <para>示例值：@i18n@1</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>文案 Value，即文案 Key 对应的参数值。</para>
            /// <para>必填：是</para>
            /// <para>示例值：people</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否为默认语言。默认语言需要包含所有所需的文案 Key，非默认语言如果 Key 不存在，则会使用默认语言代替。</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }
    }

    /// <summary>
    /// <para>单据托管认证 token，托管回调会附带此 token，帮助业务认证。</para>
    /// <para>必填：否</para>
    /// <para>示例值：788981c886b1c28ac29d1e68efd60683d6d90dfce80938ee9453e2a5f3e9e306</para>
    /// </summary>
    [JsonPropertyName("trusteeship_url_token")]
    public string? TrusteeshipUrlToken { get; set; }

    /// <summary>
    /// <para>用户的类型，会影响请求参数用户标识域的选择，包括加签操作回传的目标用户， 目前仅支持 user_id。</para>
    /// <para>必填：否</para>
    /// <para>示例值：user_id</para>
    /// </summary>
    [JsonPropertyName("trusteeship_user_id_type")]
    public string? TrusteeshipUserIdType { get; set; }

    /// <summary>
    /// <para>单据托管回调接入方的接口 URL 地址。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("trusteeship_urls")]
    public PostApprovalV4ExternalInstancesBodyDtoTrusteeshipUrls? TrusteeshipUrls { get; set; }

    /// <summary>
    /// <para>单据托管回调接入方的接口 URL 地址。</para>
    /// </summary>
    public record PostApprovalV4ExternalInstancesBodyDtoTrusteeshipUrls
    {
        /// <summary>
        /// <para>获取表单 schema 相关数据的 URL 地址。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://#{your_domain}/api/form_detail</para>
        /// </summary>
        [JsonPropertyName("form_detail_url")]
        public string? FormDetailUrl { get; set; }

        /// <summary>
        /// <para>表示获取审批操作区数据的 URL 地址。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://#{your_domain}/api/action_definition</para>
        /// </summary>
        [JsonPropertyName("action_definition_url")]
        public string? ActionDefinitionUrl { get; set; }

        /// <summary>
        /// <para>获取审批记录相关数据的 URL 地址。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://#{your_domain}/api/approval_node</para>
        /// </summary>
        [JsonPropertyName("approval_node_url")]
        public string? ApprovalNodeUrl { get; set; }

        /// <summary>
        /// <para>进行审批操作时回调的 URL 地址。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://#{your_domain}/api/action_callback</para>
        /// </summary>
        [JsonPropertyName("action_callback_url")]
        public string? ActionCallbackUrl { get; set; }

        /// <summary>
        /// <para>获取托管动态数据 URL 地址。使用该接口时，必须要保证历史托管单据的数据中都同步了该接口地址。如果历史单据中没有该接口，需要重新同步历史托管单据的数据来更新该 URL。该接口用于飞书审批前端和业务进行交互使用，只有使用审批前端的特定组件（由飞书审批前端提供的组件，并且需要和业务进行接口交互的组件）才会需要。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://#{your_domain}/api/pull_business_data</para>
        /// </summary>
        [JsonPropertyName("pull_business_data_url")]
        public string? PullBusinessDataUrl { get; set; }
    }

    /// <summary>
    /// <para>托管预缓存策略。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("trusteeship_cache_config")]
    public TrusteeshipInstanceCacheConfig? TrusteeshipCacheConfig { get; set; }

    /// <summary>
    /// <para>托管预缓存策略。</para>
    /// </summary>
    public record TrusteeshipInstanceCacheConfig
    {
        /// <summary>
        /// <para>托管预缓存策略。</para>
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
        /// <para>表单是否随国际化改变。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("form_vary_with_locale")]
        public bool? FormVaryWithLocale { get; set; }

        /// <summary>
        /// <para>当前使用的表单版本号，保证表单改变后，版本号增加，实际值为 int64 整数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("form_version")]
        public string? FormVersion { get; set; }
    }
}
