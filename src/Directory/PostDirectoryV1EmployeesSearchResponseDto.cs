// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-07-11
// ************************************************************************
// <copyright file="PostDirectoryV1EmployeesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索员工 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 搜索员工信息 响应体
/// <para>本接口用于搜索员工信息，如通过关键词搜索员工的名称、手机号、邮箱等信息。</para>
/// <para>员工指飞书企业内身份为「Employee」的成员，等同于通讯录OpenAPI中的「User」。</para>
/// <para>接口ID：7359428154233618436</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fsearch</para>
/// </summary>
public record PostDirectoryV1EmployeesSearchResponseDto
{
    /// <summary>
    /// <para>员工信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employees")]
    public EmployeeEntity[]? Employees { get; set; }

    /// <summary>
    /// <para>员工信息</para>
    /// </summary>
    public record EmployeeEntity
    {
        /// <summary>
        /// <para>员工基础信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("base_info")]
        public EmployeeBaseEntity? BaseInfo { get; set; }

        /// <summary>
        /// <para>员工基础信息</para>
        /// </summary>
        public record EmployeeBaseEntity
        {
            /// <summary>
            /// <para>企业内在职员工的唯一标识，与employee_id_type类型保持一致。</para>
            /// <para>注：如果要获取employee_id的话，必须要在required_fields中加上对应的字段，否则获取到的id无意义。</para>
            /// <para>`employee_id_type`为`open_id`或者`union_id`时无需权限，使用`employee_id`类型时，权限要求如下</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- directory:employee.base.external_id:read : 查看员工自定义 ID</para>
            /// <para>&lt;/md-dt-td&gt;</para>
            /// <para>&lt;/md-dt-tr&gt;</para>
            /// <para>必填：是</para>
            /// <para>示例值：sddasdeqwe</para>
            /// </summary>
            [JsonPropertyName("employee_id")]
            public string EmployeeId { get; set; } = string.Empty;

            /// <summary>
            /// <para>姓名</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public EmployeeBaseEntityName Name { get; set; } = new();

            /// <summary>
            /// <para>姓名</para>
            /// </summary>
            public record EmployeeBaseEntityName
            {
                /// <summary>
                /// <para>员工的姓名</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18nText? Name { get; set; }

                /// <summary>
                /// <para>别名</para>
                /// <para>必填：否</para>
                /// <para>示例值：张小明</para>
                /// </summary>
                [JsonPropertyName("another_name")]
                public string? AnotherName { get; set; }
            }

            /// <summary>
            /// <para>员工的手机号</para>
            /// <para>必填：否</para>
            /// <para>示例值：13011111111 或 +8613011111111</para>
            /// <para>最大长度：255</para>
            /// </summary>
            [JsonPropertyName("mobile")]
            public string? Mobile { get; set; }

            /// <summary>
            /// <para>员工在工作中的工作邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：zhangsan@gmail.com</para>
            /// <para>最大长度：255</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>员工的企业邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：zhangsan@gmail.com</para>
            /// <para>最大长度：255</para>
            /// </summary>
            [JsonPropertyName("enterprise_email")]
            public string? EnterpriseEmail { get; set; }

            /// <summary>
            /// <para>性别</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：未知</item>
            /// <item>1：男</item>
            /// <item>2：女</item>
            /// <item>3：其他</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("gender")]
            public int? Gender { get; set; }

            /// <summary>
            /// <para>员工所属的部门信息。一个员工可属于多个部门，排在第一个的为主部门</para>
            /// <para>必填：否</para>
            /// <para>最大长度：20</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("departments")]
            public Department[]? Departments { get; set; }

            /// <summary>
            /// <para>员工所属的部门信息。一个员工可属于多个部门，排在第一个的为主部门</para>
            /// </summary>
            public record Department
            {
                /// <summary>
                /// <para>部门ID，与department_id_type类型保持一致</para>
                /// <para>必填：是</para>
                /// <para>示例值：h12921</para>
                /// <para>最大长度：64</para>
                /// </summary>
                [JsonPropertyName("department_id")]
                public string DepartmentId { get; set; } = string.Empty;

                /// <summary>
                /// <para>部门成员与子部门计数</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("department_count")]
                public DepartmentDepartmentCount? DepartmentCount { get; set; }

                /// <summary>
                /// <para>部门成员与子部门计数</para>
                /// </summary>
                public record DepartmentDepartmentCount
                {
                    /// <summary>
                    /// <para>递归成员数量</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：100</para>
                    /// </summary>
                    [JsonPropertyName("recursive_members_count")]
                    public string? RecursiveMembersCount { get; set; }

                    /// <summary>
                    /// <para>直属成员数量</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：100</para>
                    /// </summary>
                    [JsonPropertyName("direct_members_count")]
                    public string? DirectMembersCount { get; set; }

                    /// <summary>
                    /// <para>递归成员数量(不含leader)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：100</para>
                    /// </summary>
                    [JsonPropertyName("recursive_members_count_exclude_leaders")]
                    public string? RecursiveMembersCountExcludeLeaders { get; set; }

                    /// <summary>
                    /// <para>递归子部门数量</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：100</para>
                    /// </summary>
                    [JsonPropertyName("recursive_departments_count")]
                    public string? RecursiveDepartmentsCount { get; set; }

                    /// <summary>
                    /// <para>直属子部门数量</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：100</para>
                    /// </summary>
                    [JsonPropertyName("direct_departments_count")]
                    public string? DirectDepartmentsCount { get; set; }
                }

                /// <summary>
                /// <para>是否有子部门</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("has_child")]
                public bool? HasChild { get; set; }

                /// <summary>
                /// <para>部门负责人</para>
                /// <para>必填：否</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("leaders")]
                public DepartmentLeader[]? Leaders { get; set; }

                /// <summary>
                /// <para>部门负责人</para>
                /// </summary>
                public record DepartmentLeader
                {
                    /// <summary>
                    /// <para>部门负责人类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：主</item>
                    /// <item>2：副</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("leader_type")]
                    public int LeaderType { get; set; }

                    /// <summary>
                    /// <para>部门负责人ID，与employee_id_type类型保持一致</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：u273y71</para>
                    /// </summary>
                    [JsonPropertyName("leader_id")]
                    public string LeaderId { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>父部门ID，与department_id_type类型保持一致</para>
                /// <para>必填：否</para>
                /// <para>示例值：h12921</para>
                /// <para>最大长度：64</para>
                /// </summary>
                [JsonPropertyName("parent_department_id")]
                public string? ParentDepartmentId { get; set; }

                /// <summary>
                /// <para>部门名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18nText? Name { get; set; }

                /// <summary>
                /// <para>是否启用</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("enabled_status")]
                public bool? EnabledStatus { get; set; }

                /// <summary>
                /// <para>部门排序权重</para>
                /// <para>必填：否</para>
                /// <para>示例值：无</para>
                /// </summary>
                [JsonPropertyName("order_weight")]
                public string? OrderWeight { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("custom_field_values")]
                public CustomFieldValue[]? CustomFieldValues { get; set; }

                /// <summary>
                /// <para>部门路径信息。排列顺序为根部门到末级部门</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>最大长度：35565</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("department_path_infos")]
                public DepartmentBaseInfo[]? DepartmentPathInfos { get; set; }

                /// <summary>
                /// <para>部门路径信息。排列顺序为根部门到末级部门</para>
                /// </summary>
                public record DepartmentBaseInfo
                {
                    /// <summary>
                    /// <para>部门ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("department_id")]
                    public string? DepartmentId { get; set; }

                    /// <summary>
                    /// <para>部门名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("department_name")]
                    public I18nText? DepartmentName { get; set; }
                }

                /// <summary>
                /// <para>数据来源</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>最大值：100</para>
                /// <para>最小值：0</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：管理后台</item>
                /// <item>2：人事企业版</item>
                /// <item>3：SCIM</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("data_source")]
                public int? DataSource { get; set; }
            }

            /// <summary>
            /// <para>用户在部门内的排序信息， 第一个部门为主部门</para>
            /// <para>必填：否</para>
            /// <para>最大长度：20</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("employee_order_in_departments")]
            public UserDepartmentSortInfo[]? EmployeeOrderInDepartments { get; set; }

            /// <summary>
            /// <para>用户在部门内的排序信息， 第一个部门为主部门</para>
            /// </summary>
            public record UserDepartmentSortInfo
            {
                /// <summary>
                /// <para>部门id</para>
                /// <para>必填：否</para>
                /// <para>示例值：h12921</para>
                /// </summary>
                [JsonPropertyName("department_id")]
                public string? DepartmentId { get; set; }

                /// <summary>
                /// <para>用户在部门内的排序权重</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonPropertyName("order_weight_in_deparment")]
                public string? OrderWeightInDeparment { get; set; }

                /// <summary>
                /// <para>用户多个部门间的排序权重</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonPropertyName("order_weight_among_deparments")]
                public string? OrderWeightAmongDeparments { get; set; }
            }

            /// <summary>
            /// <para>个人签名</para>
            /// <para>必填：否</para>
            /// <para>示例值：新成员请多关照</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>用户活跃状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：未激活</item>
            /// <item>2：激活</item>
            /// <item>3：冻结</item>
            /// <item>4：主动退出</item>
            /// <item>5：未加入</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("active_status")]
            public int? ActiveStatus { get; set; }

            /// <summary>
            /// <para>是否离职</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_resigned")]
            public bool? IsResigned { get; set; }

            /// <summary>
            /// <para>直属上级ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：uyg77nx</para>
            /// </summary>
            [JsonPropertyName("leader_id")]
            public string? LeaderId { get; set; }

            /// <summary>
            /// <para>虚线上级ID</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("dotted_line_leader_ids")]
            public string[]? DottedLineLeaderIds { get; set; }

            /// <summary>
            /// <para>是否租户超级管理员</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_primary_admin")]
            public bool? IsPrimaryAdmin { get; set; }

            /// <summary>
            /// <para>企业邮箱别名</para>
            /// <para>必填：否</para>
            /// <para>最大长度：20</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("enterprise_email_aliases")]
            public string[]? EnterpriseEmailAliases { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("custom_field_values")]
            public CustomFieldValue[]? CustomFieldValues { get; set; }

            /// <summary>
            /// <para>全部直属部门对应的全路径。排列顺序为根部门到末级部门</para>
            /// <para>对应结构</para>
            /// <para>``` json</para>
            /// <para>[</para>
            /// <para>/*所属部门A相关部门路径*/</para>
            /// <para>[</para>
            /// <para>{/*根部门*/},</para>
            /// <para>{/*A的父部门*/},</para>
            /// <para>{</para>
            /// <para>"department_id": "abcdefg",</para>
            /// <para>"i18n_text": {</para>
            /// <para>"default_value": "A",</para>
            /// <para>"i18n_value": {</para>
            /// <para>"zh_cn": "A cn name",</para>
            /// <para>"en_us": "A en name"</para>
            /// <para>}</para>
            /// <para>}</para>
            /// <para>}</para>
            /// <para>]]</para>
            /// <para>```</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("department_path_infos")]
            public DepartmentBaseInfo[][]? DepartmentPathInfos { get; set; }

            /// <summary>
            /// <para>全部直属部门对应的全路径。排列顺序为根部门到末级部门</para>
            /// <para>对应结构</para>
            /// <para>``` json</para>
            /// <para>[</para>
            /// <para>/*所属部门A相关部门路径*/</para>
            /// <para>[</para>
            /// <para>{/*根部门*/},</para>
            /// <para>{/*A的父部门*/},</para>
            /// <para>{</para>
            /// <para>"department_id": "abcdefg",</para>
            /// <para>"i18n_text": {</para>
            /// <para>"default_value": "A",</para>
            /// <para>"i18n_value": {</para>
            /// <para>"zh_cn": "A cn name",</para>
            /// <para>"en_us": "A en name"</para>
            /// <para>}</para>
            /// <para>}</para>
            /// <para>}</para>
            /// <para>]]</para>
            /// <para>```</para>
            /// </summary>
            public record DepartmentBaseInfo
            {
                /// <summary>
                /// <para>部门ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("department_id")]
                public string? DepartmentId { get; set; }

                /// <summary>
                /// <para>部门名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("department_name")]
                public I18nText? DepartmentName { get; set; }
            }

            /// <summary>
            /// <para>离职时间。离职操作的时间，系统自动生成，无法写入。格式为YYYY-MM-DD</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("resign_time")]
            public string? ResignTime { get; set; }

            /// <summary>
            /// <para>头像url</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("avatar")]
            public ImageLink? Avatar { get; set; }

            /// <summary>
            /// <para>头像url</para>
            /// </summary>
            public record ImageLink
            {
                /// <summary>
                /// <para>72*72像素头像链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：http://qwed.com</para>
                /// </summary>
                [JsonPropertyName("avatar_72")]
                public string? Avatar72 { get; set; }

                /// <summary>
                /// <para>240*240像素头像链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：http://wssd.com</para>
                /// </summary>
                [JsonPropertyName("avatar_240")]
                public string? Avatar240 { get; set; }

                /// <summary>
                /// <para>640*640像素头像链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：http://wssd.com</para>
                /// </summary>
                [JsonPropertyName("avatar_640")]
                public string? Avatar640 { get; set; }

                /// <summary>
                /// <para>原始头像链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https:inernal-api/image</para>
                /// </summary>
                [JsonPropertyName("avatar_origin")]
                public string? AvatarOrigin { get; set; }
            }

            /// <summary>
            /// <para>自定义背景图 url</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://sadui.com</para>
            /// </summary>
            [JsonPropertyName("background_image")]
            public string? BackgroundImage { get; set; }

            /// <summary>
            /// <para>是否租户普通管理员</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_admin")]
            public bool? IsAdmin { get; set; }

            /// <summary>
            /// <para>数据来源</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：100</para>
            /// <para>最小值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：管理后台</item>
            /// <item>2：人事企业版</item>
            /// <item>3：SCIM</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("data_source")]
            public int? DataSource { get; set; }

            /// <summary>
            /// <para>员工数据驻留地</para>
            /// <para>必填：否</para>
            /// <para>示例值：boe</para>
            /// </summary>
            [JsonPropertyName("geo_name")]
            public string? GeoName { get; set; }

            /// <summary>
            /// <para>分配给员工的席位ID列表。</para>
            /// <para>必填：否</para>
            /// <para>最大长度：20</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("subscription_ids")]
            public string[]? SubscriptionIds { get; set; }
        }

        /// <summary>
        /// <para>员工工作信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_info")]
        public EmployeeWorkEntity? WorkInfo { get; set; }

        /// <summary>
        /// <para>员工工作信息</para>
        /// </summary>
        public record EmployeeWorkEntity
        {
            /// <summary>
            /// <para>工作地国家/地区 [如何查询国家/地区的编码含义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/mdm-v3/batch_country_region/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：MDCT00000012</para>
            /// </summary>
            [JsonPropertyName("work_country_or_region")]
            public string? WorkCountryOrRegion { get; set; }

            /// <summary>
            /// <para>工作地点</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("work_place")]
            public Place? WorkPlace { get; set; }

            /// <summary>
            /// <para>工作地点</para>
            /// </summary>
            public record Place
            {
                /// <summary>
                /// <para>ID，不存在时默认返回"0"</para>
                /// <para>必填：是</para>
                /// <para>示例值：place100</para>
                /// </summary>
                [JsonPropertyName("place_id")]
                public string PlaceId { get; set; } = string.Empty;

                /// <summary>
                /// <para>工作地点名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("place_name")]
                public I18nText? PlaceName { get; set; }

                /// <summary>
                /// <para>是否启用</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_enabled")]
                public bool? IsEnabled { get; set; }

                /// <summary>
                /// <para>描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("description")]
                public I18nText? Description { get; set; }
            }

            /// <summary>
            /// <para>工位</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("work_station")]
            public I18nText? WorkStation { get; set; }

            /// <summary>
            /// <para>工号</para>
            /// <para>必填：否</para>
            /// <para>示例值：2845435</para>
            /// <para>最大长度：255</para>
            /// </summary>
            [JsonPropertyName("job_number")]
            public string? JobNumber { get; set; }

            /// <summary>
            /// <para>分机号</para>
            /// <para>必填：否</para>
            /// <para>示例值：2845435</para>
            /// <para>最大长度：99</para>
            /// </summary>
            [JsonPropertyName("extension_number")]
            public string? ExtensionNumber { get; set; }

            /// <summary>
            /// <para>入职日期。如“2007-03-20”</para>
            /// <para>必填：否</para>
            /// <para>示例值：2007-03-20</para>
            /// </summary>
            [JsonPropertyName("join_date")]
            public string? JoinDate { get; set; }

            /// <summary>
            /// <para>员工类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("employment_type")]
            public int? EmploymentType { get; set; }

            /// <summary>
            /// <para>员工人事状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：在职</item>
            /// <item>2：离职</item>
            /// <item>3：待入职</item>
            /// <item>4：取消入职</item>
            /// <item>5：待离职</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("staff_status")]
            public int? StaffStatus { get; set; }

            /// <summary>
            /// <para>职务</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_title")]
            public EmployeeWorkEntityJobTitle? JobTitle { get; set; }

            /// <summary>
            /// <para>职务</para>
            /// </summary>
            public record EmployeeWorkEntityJobTitle
            {
                /// <summary>
                /// <para>ID，不存在时默认返回"0"</para>
                /// <para>必填：是</para>
                /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
                /// <para>最大长度：64</para>
                /// </summary>
                [JsonPropertyName("job_title_id")]
                public string JobTitleId { get; set; } = string.Empty;

                /// <summary>
                /// <para>职务名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("job_title_name")]
                public I18nText? JobTitleName { get; set; }

                /// <summary>
                /// <para>是否启用</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_enabled")]
                public bool? IsEnabled { get; set; }

                /// <summary>
                /// <para>描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("description")]
                public I18nText? Description { get; set; }
            }

            /// <summary>
            /// <para>职级</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_level")]
            public EmployeeWorkEntityJobLevel? JobLevel { get; set; }

            /// <summary>
            /// <para>职级</para>
            /// </summary>
            public record EmployeeWorkEntityJobLevel
            {
                /// <summary>
                /// <para>ID</para>
                /// <para>必填：是</para>
                /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
                /// <para>最大长度：64</para>
                /// </summary>
                [JsonPropertyName("job_level_id")]
                public string JobLevelId { get; set; } = string.Empty;

                /// <summary>
                /// <para>i18n文本</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("job_level_name")]
                public I18nText? JobLevelName { get; set; }

                /// <summary>
                /// <para>是否启用</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_enabled")]
                public bool? IsEnabled { get; set; }

                /// <summary>
                /// <para>是否删除</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_deleted")]
                public bool? IsDeleted { get; set; }

                /// <summary>
                /// <para>排序, 小的在前面</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("order")]
                public string? Order { get; set; }

                /// <summary>
                /// <para>i18n文本</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("description")]
                public I18nText? Description { get; set; }
            }

            /// <summary>
            /// <para>序列</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("job_family")]
            public EmployeeWorkEntityJobFamily? JobFamily { get; set; }

            /// <summary>
            /// <para>序列</para>
            /// </summary>
            public record EmployeeWorkEntityJobFamily
            {
                /// <summary>
                /// <para>序列ID</para>
                /// <para>必填：是</para>
                /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
                /// <para>最大长度：64</para>
                /// </summary>
                [JsonPropertyName("job_family_id")]
                public string JobFamilyId { get; set; } = string.Empty;

                /// <summary>
                /// <para>i18n文本</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("job_family_name")]
                public I18nText? JobFamilyName { get; set; }

                /// <summary>
                /// <para>是否启用</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_enabled")]
                public bool? IsEnabled { get; set; }

                /// <summary>
                /// <para>上级序列</para>
                /// <para>必填：否</para>
                /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
                /// </summary>
                [JsonPropertyName("parent_job_family_id")]
                public string? ParentJobFamilyId { get; set; }

                /// <summary>
                /// <para>i18n文本</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("description")]
                public I18nText? Description { get; set; }
            }

            /// <summary>
            /// <para>离职日期 2007-03-20</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("resign_date")]
            public string? ResignDate { get; set; }

            /// <summary>
            /// <para>离职原因</para>
            /// <para>**示例值**："1"</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：薪酬不符合预期</item>
            /// <item>2：工作时间过长</item>
            /// <item>3：不满意工作内容</item>
            /// <item>4：不认可上级或管理层</item>
            /// <item>5：职业发展机会有限</item>
            /// <item>6：对公司文化缺乏认同</item>
            /// <item>7：组织架构调整（主动离职）</item>
            /// <item>8：合同到期</item>
            /// <item>9：跳槽</item>
            /// <item>10：转行</item>
            /// <item>11：家庭原因</item>
            /// <item>12：健康状况不佳</item>
            /// <item>13：工作地点原因</item>
            /// <item>14：其他(主动离职)</item>
            /// <item>15：意外</item>
            /// <item>16：身故</item>
            /// <item>17：解雇</item>
            /// <item>18：试用期不通过</item>
            /// <item>19：工作表现不佳</item>
            /// <item>20：工作产出低</item>
            /// <item>21：组织架构调整（被动离职）</item>
            /// <item>22：违纪</item>
            /// <item>23：违法</item>
            /// <item>24：其他（被动离职）</item>
            /// <item>25：其他（其他）</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("resign_reason")]
            public string? ResignReason { get; set; }

            /// <summary>
            /// <para>离职备注</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大长度：5000</para>
            /// </summary>
            [JsonPropertyName("resign_remark")]
            public string? ResignRemark { get; set; }

            /// <summary>
            /// <para>离职类型</para>
            /// <para>**示例值**："1"</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：主动</item>
            /// <item>2：被动</item>
            /// <item>3：其他</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("resign_type")]
            public string? ResignType { get; set; }
        }
    }

    /// <summary>
    /// <para>国际化文本</para>
    /// </summary>
    public record I18nText
    {
        /// <summary>
        /// <para>默认本地值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("default_locale")]
        public string? DefaultLocale { get; set; }

        /// <summary>
        /// <para>默认值</para>
        /// <para>必填：是</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("default_value")]
        public string DefaultValue { get; set; } = string.Empty;

        /// <summary>
        /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"zh_cn":"张三"}</para>
        /// </summary>
        [JsonPropertyName("i18n_value")]
        public I18nLanguage<string>? I18nValue { get; set; }
    }

    /// <summary>
    /// <para>自定义字段</para>
    /// </summary>
    public record CustomFieldValue
    {
        /// <summary>
        /// <para>自定义字段类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：多行文本</item>
        /// <item>2：网页链接</item>
        /// <item>3：枚举选项</item>
        /// <item>4：人员</item>
        /// <item>9：电话</item>
        /// <item>10：多选枚举类型(目前仅支持文本类型)</item>
        /// <item>11：人员列表</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("field_type")]
        public int? FieldType { get; set; }

        /// <summary>
        /// <para>文本字段值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("text_value")]
        public I18nText? TextValue { get; set; }

        /// <summary>
        /// <para>网页链接字段值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("url_value")]
        public CustomFieldValueUrlValue? UrlValue { get; set; }

        /// <summary>
        /// <para>网页链接字段值</para>
        /// </summary>
        public record CustomFieldValueUrlValue
        {
            /// <summary>
            /// <para>网页标题</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("link_text")]
            public I18nText LinkText { get; set; } = new();

            /// <summary>
            /// <para>移动端网页链接</para>
            /// <para>必填：是</para>
            /// <para>示例值：https://m.bytedance.com/afnasjfna</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string Url { get; set; } = string.Empty;

            /// <summary>
            /// <para>桌面端网页链接</para>
            /// <para>必填：是</para>
            /// <para>示例值：http://www.fs.cn</para>
            /// </summary>
            [JsonPropertyName("pcurl")]
            public string Pcurl { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>枚举</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("enum_value")]
        public CustomFieldValueEnumValue? EnumValue { get; set; }

        /// <summary>
        /// <para>枚举</para>
        /// </summary>
        public record CustomFieldValueEnumValue
        {
            /// <summary>
            /// <para>选项结果ID</para>
            /// <para>必填：是</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("enum_ids")]
            public string[] EnumIds { get; set; } = [];

            /// <summary>
            /// <para>选项类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：文本</item>
            /// <item>2：图片</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("enum_type")]
            public int? EnumType { get; set; }

            /// <summary>
            /// <para>选项名称</para>
            /// </summary>
            [JsonPropertyName("enum_name")]
            public string EnumName { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>人员字段值</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("user_values")]
        public UserValue[]? UserValues { get; set; }

        /// <summary>
        /// <para>人员字段值</para>
        /// </summary>
        public record UserValue
        {
            /// <summary>
            /// <para>人员ID</para>
            /// <para>必填：是</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("ids")]
            public string[] Ids { get; set; } = [];
        }

        /// <summary>
        /// <para>电话字段值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("phone_value")]
        public CustomFieldValuePhoneValue? PhoneValue { get; set; }

        /// <summary>
        /// <para>电话字段值</para>
        /// </summary>
        public record CustomFieldValuePhoneValue
        {
            /// <summary>
            /// <para>电话号</para>
            /// <para>必填：是</para>
            /// <para>示例值：18812345678</para>
            /// </summary>
            [JsonPropertyName("phone_number")]
            public string PhoneNumber { get; set; } = string.Empty;

            /// <summary>
            /// <para>分机号</para>
            /// <para>必填：否</para>
            /// <para>示例值：234234234</para>
            /// </summary>
            [JsonPropertyName("extension_number")]
            public string? ExtensionNumber { get; set; }
        }

        /// <summary>
        /// <para>自定义字段key</para>
        /// <para>必填：否</para>
        /// <para>示例值：C-1000001</para>
        /// </summary>
        [JsonPropertyName("field_key")]
        public string? FieldKey { get; set; }
    }

    /// <summary>
    /// <para>分页结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_response")]
    public PostDirectoryV1EmployeesSearchResponseDtoPageResponse? PageResponse { get; set; }

    /// <summary>
    /// <para>分页结果</para>
    /// </summary>
    public record PostDirectoryV1EmployeesSearchResponseDtoPageResponse
    {
        /// <summary>
        /// <para>是否还有后续结果，如果has_more为true，代表还有数据没有完全返回，需要使用响应结果中的page_token，并再次请求才能取得剩下的数据。</para>
        /// <para>必填：否</para>
        /// <para>示例值：cursor</para>
        /// </summary>
        [JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
        /// <para>必填：否</para>
        /// <para>示例值：cursor</para>
        /// </summary>
        [JsonPropertyName("page_token")]
        public string? PageToken { get; set; }
    }

    /// <summary>
    /// <para>字段异常信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("abnormals")]
    public AbnormalRecord[]? Abnormals { get; set; }

    /// <summary>
    /// <para>字段异常信息</para>
    /// </summary>
    public record AbnormalRecord
    {
        /// <summary>
        /// <para>异常ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：eedasfwe</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>行级异常</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>最大值：100</para>
        /// <para>最小值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：成功</item>
        /// <item>1000：没权限</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("row_error")]
        public int? RowError { get; set; }

        /// <summary>
        /// <para>列级异常，key为字段名,value为下列枚举</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"base_info.mobile":1000}</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1000：无权限</item>
        /// <item>2000：服务异常</item>
        /// <item>2002：用户不存在</item>
        /// <item>2003：字段不存在</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("field_errors")]
        public object? FieldErrors { get; set; }
    }
}
