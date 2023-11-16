namespace FeishuNetSdk.Contact;
/// <summary>
/// 更新部门所有信息 响应体
/// <para>该接口用于更新当前部门所有信息。</para>
/// <para>接口ID：6943913881477021723</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fupdate</para>
/// </summary>
public record PutContactV3DepartmentsByDepartmentIdResponseDto
{
    /// <summary>
    /// <para>部门信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department")]
    public PutContactV3DepartmentsByDepartmentIdResponseDtoDepartment? Department { get; set; }

    /// <summary>
    /// <para>部门信息</para>
    /// </summary>
    public record PutContactV3DepartmentsByDepartmentIdResponseDtoDepartment
    {
        /// <summary>
        /// <para>部门名称</para>
        /// <para>注意：不可包含斜杠</para>
        /// <para>必填：是</para>
        /// <para>示例值：DemoName</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>国际化的部门名称</para>
        /// <para>注意：不可包含斜杠</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public DepartmentI18nName? I18nName { get; set; }

        /// <summary>
        /// <para>国际化的部门名称</para>
        /// <para>注意：不可包含斜杠</para>
        /// </summary>
        public record DepartmentI18nName
        {
            /// <summary>
            /// <para>部门的中文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：Demo名称</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>部门的日文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：デモ名</para>
            /// </summary>
            [JsonPropertyName("ja_jp")]
            public string? JaJp { get; set; }

            /// <summary>
            /// <para>部门的英文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：DemoName</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>父部门的ID</para>
        /// <para>* 在根部门下创建新部门，该参数值为 “0”</para>
        /// <para>必填：是</para>
        /// <para>示例值：D067</para>
        /// </summary>
        [JsonPropertyName("parent_department_id")]
        public string ParentDepartmentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>本部门的自定义部门ID</para>
        /// <para>注意：除需要满足正则规则外，同时不能以`od-`开头</para>
        /// <para>必填：否</para>
        /// <para>示例值：g148e8fca291dc38</para>
        /// <para>最大长度：64</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>部门的open_id，类型与通过请求的查询参数传入的department_id_type相同</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-g148e8fca291dc38</para>
        /// </summary>
        [JsonPropertyName("open_department_id")]
        public string? OpenDepartmentId { get; set; }

        /// <summary>
        /// <para>部门主管用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonPropertyName("leader_user_id")]
        public string? LeaderUserId { get; set; }

        /// <summary>
        /// <para>部门群ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：oc_5ad11d72b830411d72b836c20</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>部门的排序，即部门在其同级部门的展示顺序</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("order")]
        public string? Order { get; set; }

        /// <summary>
        /// <para>部门单位自定义ID列表，当前只支持一个</para>
        /// <para>必填：否</para>
        /// <para>示例值：custom_unit_id</para>
        /// </summary>
        [JsonPropertyName("unit_ids")]
        public string[]? UnitIds { get; set; }

        /// <summary>
        /// <para>当前部门及其下属部门下用户（包含部门负责人）的个数</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("member_count")]
        public int? MemberCount { get; set; }

        /// <summary>
        /// <para>部门状态</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("status")]
        public DepartmentStatus? Status { get; set; }

        /// <summary>
        /// <para>部门状态</para>
        /// </summary>
        public record DepartmentStatus
        {
            /// <summary>
            /// <para>是否被删除</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_deleted")]
            public bool? IsDeleted { get; set; }
        }

        /// <summary>
        /// <para>部门负责人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leaders")]
        public DepartmentLeader[]? Leaders { get; set; }

        /// <summary>
        /// <para>部门负责人</para>
        /// </summary>
        public record DepartmentLeader
        {
            /// <summary>
            /// <para>负责人类型</para>
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
            /// <para>负责人ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
            /// </summary>
            [JsonPropertyName("leaderID")]
            public string LeaderID { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>部门群雇员类型限制。[]空列表时，表示为无任何雇员类型。类型字段可包含以下值，支持多个类型值；若有多个，用英文','分隔：</para>
        /// <para>1、正式员工</para>
        /// <para>2、实习生</para>
        /// <para>3、外包</para>
        /// <para>4、劳务</para>
        /// <para>5、顾问</para>
        /// <para>6、其他自定义类型字段，可通过下方接口获取到该租户的自定义员工类型的名称，参见[获取人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/employee_type_enum/list)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：[1,2,3]</para>
        /// </summary>
        [JsonPropertyName("group_chat_employee_types")]
        public int[]? GroupChatEmployeeTypes { get; set; }

        /// <summary>
        /// <para>当前部门及其下属的主属成员（即成员的主部门为当前部门）的数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("primary_member_count")]
        public int? PrimaryMemberCount { get; set; }
    }
}
