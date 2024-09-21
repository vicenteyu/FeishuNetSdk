// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-20
// ************************************************************************
// <copyright file="GetContactV3DepartmentsBatchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取部门信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 批量获取部门信息 响应体
/// <para>调用该接口获取一个或多个部门的信息，包括部门名称、ID、父部门、负责人、状态以及成员个数等。</para>
/// <para>## 注意事项</para>
/// <para>使用不同身份调用本接口时，需要注意不同身份所需的不同权限范围。具体说明如下：</para>
/// <para>- 当你使用应用身份（tenant_access_token）调用本接口时，应用的通讯录权限范围内需要包含当前被查询的部门。如果需要查询根部门信息，则应用的通讯录权限范围需设置为 **全部成员**。了解权限范围参见[权限范围资源介绍](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>- 当你使用用户身份（user_access_token）调用本接口时，需要确保该用户身份拥有待查询部门的可见性。如果需要查询根部门信息，则用户需要可见所有人。用户的组织架构可见范围需要由企业管理员在[管理后台](https://feishu.cn/admin/index) &gt; **安全** &gt; **成员权限** &gt; **组织架构可见范围** 内调整。</para>
/// <para>接口ID：7243624444425519132</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fbatch</para>
/// </summary>
public record GetContactV3DepartmentsBatchResponseDto
{
    /// <summary>
    /// <para>查询到的部门信息。</para>
    /// <para>**说明**：多个部门 ID 中的异常部门 ID 不会返回结果。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Department[]? Items { get; set; }

    /// <summary>
    /// <para>查询到的部门信息。</para>
    /// <para>**说明**：多个部门 ID 中的异常部门 ID 不会返回结果。</para>
    /// </summary>
    public record Department
    {
        /// <summary>
        /// <para>部门名称。</para>
        /// <para>必填：是</para>
        /// <para>示例值：DemoName</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>部门名称的国际化配置。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public DepartmentI18nName? I18nName { get; set; }

        /// <summary>
        /// <para>部门名称的国际化配置。</para>
        /// </summary>
        public record DepartmentI18nName
        {
            /// <summary>
            /// <para>部门的中文名。</para>
            /// <para>必填：否</para>
            /// <para>示例值：Demo名称</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>部门的日文名。</para>
            /// <para>必填：否</para>
            /// <para>示例值：デモ名</para>
            /// </summary>
            [JsonPropertyName("ja_jp")]
            public string? JaJp { get; set; }

            /// <summary>
            /// <para>部门的英文名。</para>
            /// <para>必填：否</para>
            /// <para>示例值：Demo Name</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>父部门的部门 ID。</para>
        /// <para>- ID 类型与查询参数的 department_id_type 取值保持一致。</para>
        /// <para>- 当父部门为根部门时，该参数值为 `0`。</para>
        /// <para>必填：是</para>
        /// <para>示例值：D067</para>
        /// </summary>
        [JsonPropertyName("parent_department_id")]
        public string ParentDepartmentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义部门 ID。后续可以使用该 ID 删除、修改、查询部门信息。</para>
        /// <para>必填：否</para>
        /// <para>示例值：D096</para>
        /// <para>最大长度：64</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>部门的 open_department_id，由系统自动生成。后续可以使用该 ID 删除、修改、查询部门信息。</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("open_department_id")]
        public string? OpenDepartmentId { get; set; }

        /// <summary>
        /// <para>部门主管的用户 ID，ID 类型与查询参数的 user_id_type 取值保持一致。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonPropertyName("leader_user_id")]
        public string? LeaderUserId { get; set; }

        /// <summary>
        /// <para>部门群的群 ID。后续可以使用[获取群信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/get)，获取群的详细信息。</para>
        /// <para>必填：否</para>
        /// <para>示例值：oc_5ad11d72b830411d72b836c20</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>部门的排序，即部门在其同级部门的展示顺序。取值越小排序越靠前。</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("order")]
        public string? Order { get; set; }

        /// <summary>
        /// <para>部门绑定的单位自定义 ID 列表，当前只支持一个。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("unit_ids")]
        public string[]? UnitIds { get; set; }

        /// <summary>
        /// <para>当前部门及其下属部门的用户（包含部门负责人）个数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("member_count")]
        public int? MemberCount { get; set; }

        /// <summary>
        /// <para>部门状态。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("status")]
        public DepartmentStatus? Status { get; set; }

        /// <summary>
        /// <para>部门状态。</para>
        /// </summary>
        public record DepartmentStatus
        {
            /// <summary>
            /// <para>是否被删除。</para>
            /// <para>**可能值有：**</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_deleted")]
            public bool? IsDeleted { get; set; }
        }

        /// <summary>
        /// <para>部门负责人信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leaders")]
        public DepartmentLeader[]? Leaders { get; set; }

        /// <summary>
        /// <para>部门负责人信息。</para>
        /// </summary>
        public record DepartmentLeader
        {
            /// <summary>
            /// <para>负责人类型。</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：主负责人</item>
            /// <item>2：副负责人</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("leaderType")]
            public int LeaderType { get; set; }

            /// <summary>
            /// <para>负责人的用户 ID，ID 类型与查询参数的 user_id_type 取值保持一致。</para>
            /// <para>必填：是</para>
            /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
            /// </summary>
            [JsonPropertyName("leaderID")]
            public string LeaderID { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>部门群的人员类型限制。人员类型的可能值如下：</para>
        /// <para>- 1：正式员工</para>
        /// <para>- 2：实习生</para>
        /// <para>- 3：外包</para>
        /// <para>- 4：劳务</para>
        /// <para>- 5：顾问</para>
        /// <para>如果是自定义人员类型，则会返回对应的编号。你可以调用[查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/employee_type_enum/list)接口，获取相应编号（enum_value）对应的自定义人员类型信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("group_chat_employee_types")]
        public int[]? GroupChatEmployeeTypes { get; set; }

        /// <summary>
        /// <para>部门 HRBP 的用户 ID 列表。 ID 类型与查询参数 user_id_type 的取值保持一致。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：500</para>
        /// </summary>
        [JsonPropertyName("department_hrbps")]
        public string[]? DepartmentHrbps { get; set; }

        /// <summary>
        /// <para>当前部门及其下属部门的主属成员（即成员的主部门为当前部门）的数量。</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("primary_member_count")]
        public int? PrimaryMemberCount { get; set; }
    }
}
