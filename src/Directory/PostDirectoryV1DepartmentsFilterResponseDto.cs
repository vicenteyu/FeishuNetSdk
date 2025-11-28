// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-07-11
// ************************************************************************
// <copyright file="PostDirectoryV1DepartmentsFilterResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取部门列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 获取部门列表 响应体
/// <para>本接口用于依据指定条件，批量获取符合条件的部门详情列表。</para>
/// <para>接口ID：7359428154233700356</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/filter</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2ffilter</para>
/// </summary>
public record PostDirectoryV1DepartmentsFilterResponseDto
{
    /// <summary>
    /// <para>部门信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("departments")]
    public Department[]? Departments { get; set; }

    /// <summary>
    /// <para>部门信息</para>
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
        /// <para>部门成员计数与子部门计数。计算结果可能会有延迟</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_count")]
        public DepartmentDepartmentCount? DepartmentCount { get; set; }

        /// <summary>
        /// <para>部门成员计数与子部门计数。计算结果可能会有延迟</para>
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
        /// <para>部门名称</para>
        /// </summary>
        public record I18nText
        {
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
            /// <para>示例值：{ "zh_cn": "中文","ja_jp": "ja_jp_name","en_us": "en_us_name"}</para>
            /// </summary>
            [JsonPropertyName("i18n_value")]
            public object? I18nValue { get; set; }
        }

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
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("order_weight")]
        public string? OrderWeight { get; set; }

        /// <summary>
        /// <para>部门自定义字段值</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("custom_field_values")]
        public CustomFieldValue[]? CustomFieldValues { get; set; }

        /// <summary>
        /// <para>部门自定义字段值</para>
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
            public string? FieldType { get; set; }

            /// <summary>
            /// <para>文本字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("text_value")]
            public I18nText? TextValue { get; set; }

            /// <summary>
            /// <para>文本字段值</para>
            /// </summary>
            public record I18nText
            {
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
                /// <para>示例值：{ "zh_cn": "中文","ja_jp": "ja_jp_name","en_us": "en_us_name"}</para>
                /// </summary>
                [JsonPropertyName("i18n_value")]
                public object? I18nValue { get; set; }
            }

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
                /// <para>网页标题</para>
                /// </summary>
                public record I18nText
                {
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
                    /// <para>示例值：{ "zh_cn": "中文","ja_jp": "ja_jp_name","en_us": "en_us_name"}</para>
                    /// </summary>
                    [JsonPropertyName("i18n_value")]
                    public object? I18nValue { get; set; }
                }

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
            /// <para>枚举字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("enum_value")]
            public CustomFieldValueEnumValue? EnumValue { get; set; }

            /// <summary>
            /// <para>枚举字段值</para>
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
                public string EnumType { get; set; } = string.Empty;
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
                /// <para>人员ID，与employee_id_type类型保持一致</para>
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
        /// <para>部门路径信息。排列顺序为根级到末级，不包含根部门</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>最大长度：35565</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("department_path_infos")]
        public DepartmentBaseInfo[]? DepartmentPathInfos { get; set; }

        /// <summary>
        /// <para>部门路径信息。排列顺序为根级到末级，不包含根部门</para>
        /// </summary>
        public record DepartmentBaseInfo
        {
            /// <summary>
            /// <para>部门ID，与department_id_type类型保持一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>i18n文本</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_name")]
            public I18nText? DepartmentName { get; set; }

            /// <summary>
            /// <para>i18n文本</para>
            /// </summary>
            public record I18nText
            {
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
                /// <para>示例值：{ "zh_cn": "中文","ja_jp":"ja_jp_name","en_us":"en_us_name"}</para>
                /// </summary>
                [JsonPropertyName("i18n_value")]
                public object? I18nValue { get; set; }
            }
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
    /// <para>分页结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_response")]
    public PostDirectoryV1DepartmentsFilterResponseDtoPageResponse? PageResponse { get; set; }

    /// <summary>
    /// <para>分页结果</para>
    /// </summary>
    public record PostDirectoryV1DepartmentsFilterResponseDtoPageResponse
    {
        /// <summary>
        /// <para>是否还有后续结果，如果has_more为true，代表还有数据没有完全返回，需要使用响应结果中的page_token，并再次请求才能取得剩下的数据。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
        /// <para>必填：否</para>
        /// <para>示例值：hiofbsabui214iokncaub</para>
        /// </summary>
        [JsonPropertyName("page_token")]
        public string? PageToken { get; set; }
    }

    /// <summary>
    /// <para>异常信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("abnormals")]
    public AbnormalRecord[]? Abnormals { get; set; }

    /// <summary>
    /// <para>异常信息</para>
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
        /// <para>示例值：0</para>
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
        /// <para>示例值：{"name":1000}</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1000：无权限</item>
        /// <item>2000：服务异常</item>
        /// <item>2003：字段不存在</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("field_errors")]
        public object? FieldErrors { get; set; }
    }
}
