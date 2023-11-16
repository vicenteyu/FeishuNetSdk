namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取父部门信息 响应体
/// <para>该接口用来递归获取部门的父部门信息，并按照由子到父的顺序返回有权限的父部门信息列表。</para>
/// <para>接口ID：7236202966714957826</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/parents</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fparents</para>
/// </summary>
public record PostCorehrV2DepartmentsParentsResponseDto
{
    /// <summary>
    /// <para>父部门查询结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public DepartmentParents[]? Items { get; set; }

    /// <summary>
    /// <para>父部门查询结果</para>
    /// </summary>
    public record DepartmentParents
    {
        /// <summary>
        /// <para>部门 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064111</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>父部门列表，部门按照至底向上的顺序返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("parent_department_list")]
        public DepartmentParentInfo[]? ParentDepartmentLists { get; set; }

        /// <summary>
        /// <para>父部门列表，部门按照至底向上的顺序返回</para>
        /// </summary>
        public record DepartmentParentInfo
        {
            /// <summary>
            /// <para>部门 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719456877659520852</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>部门名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_name")]
            public I18n[]? DepartmentNames { get; set; }

            /// <summary>
            /// <para>部门名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>上级部门 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719456877659520111</para>
            /// </summary>
            [JsonPropertyName("parent_department_id")]
            public string? ParentDepartmentId { get; set; }

            /// <summary>
            /// <para>是否启用</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("active")]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>是否根部门</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_root")]
            public bool? IsRoot { get; set; }
        }
    }
}
