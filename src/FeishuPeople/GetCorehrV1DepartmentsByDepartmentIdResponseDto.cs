namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询单个部门 响应体
/// <para>根据 ID 查询单个部门。</para>
/// <para>接口ID：7017707615190974467</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fdepartment%2fget</para>
/// </summary>
public record GetCorehrV1DepartmentsByDepartmentIdResponseDto
{
    /// <summary>
    /// <para>部门信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department")]
    public GetCorehrV1DepartmentsByDepartmentIdResponseDtoDepartment? Department { get; set; }

    /// <summary>
    /// <para>部门信息</para>
    /// </summary>
    public record GetCorehrV1DepartmentsByDepartmentIdResponseDtoDepartment
    {
        /// <summary>
        /// <para>部门 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969828847121885087</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>部门子类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)部门子类型（department_sub_type）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sub_type")]
        public Enum? SubType { get; set; }

        /// <summary>
        /// <para>部门子类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)部门子类型（department_sub_type）枚举定义部分获得</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：type_1</para>
            /// </summary>
            [JsonPropertyName("enum_name")]
            public string EnumName { get; set; } = string.Empty;

            /// <summary>
            /// <para>枚举多语展示</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("display")]
            public I18n[]? Displies { get; set; }

            /// <summary>
            /// <para>枚举多语展示</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>名称信息的语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>名称信息的内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>部门负责人 ID，枚举值及详细信息可通过【批量查询雇佣信息】接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893013238632416776</para>
        /// </summary>
        [JsonPropertyName("manager")]
        public string? Manager { get; set; }

        /// <summary>
        /// <para>是否保密</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_confidential")]
        public bool IsConfidential { get; set; }

        /// <summary>
        /// <para>层级关系，内层字段见实体</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("hiberarchy_common")]
        public GetCorehrV1DepartmentsByDepartmentIdResponseDtoDepartmentHiberarchyCommon HiberarchyCommon { get; set; } = new();

        /// <summary>
        /// <para>层级关系，内层字段见实体</para>
        /// </summary>
        public record GetCorehrV1DepartmentsByDepartmentIdResponseDtoDepartmentHiberarchyCommon
        {
            /// <summary>
            /// <para>上级组织 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719168654814483759</para>
            /// </summary>
            [JsonPropertyName("parent_id")]
            public string? ParentId { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n[] Names { get; set; } = Array.Empty<I18n>();

            /// <summary>
            /// <para>名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>名称信息的语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>名称信息的内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>组织类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)组织类型（organization_type）枚举定义部分获得</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("type")]
            public Enum Type { get; set; } = new();

            /// <summary>
            /// <para>组织类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)组织类型（organization_type）枚举定义部分获得</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>枚举值</para>
                /// <para>必填：是</para>
                /// <para>示例值：type_1</para>
                /// </summary>
                [JsonPropertyName("enum_name")]
                public string EnumName { get; set; } = string.Empty;

                /// <summary>
                /// <para>枚举多语展示</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("display")]
                public I18n[]? Displies { get; set; }

                /// <summary>
                /// <para>枚举多语展示</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>名称信息的语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>名称信息的内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>是否启用</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("active")]
            public bool Active { get; set; }

            /// <summary>
            /// <para>生效时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-0100:00:00</para>
            /// </summary>
            [JsonPropertyName("effective_time")]
            public string? EffectiveTime { get; set; }

            /// <summary>
            /// <para>失效时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-0200:00:00</para>
            /// </summary>
            [JsonPropertyName("expiration_time")]
            public string? ExpirationTime { get; set; }

            /// <summary>
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：12456</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public I18n[]? Descriptions { get; set; }

            /// <summary>
            /// <para>树形排序，代表同层级的部门排序序号。新建的部门，该字段默认为空，有两种情况会自动写入值：</para>
            /// <para>- 管理员在部门管理页面上拖动排序；</para>
            /// <para>- 定时任务更新该字段为空的数据，3分钟/次</para>
            /// <para>必填：否</para>
            /// <para>示例值：001000</para>
            /// </summary>
            [JsonPropertyName("tree_order")]
            public string? TreeOrder { get; set; }

            /// <summary>
            /// <para>列表排序，代表所有部门的混排序号。新建的部门，该字段默认为空，有两种情况会自动写入值：</para>
            /// <para>- 管理员在部门管理页面上拖动排序；</para>
            /// <para>- 定时任务更新该字段为空的数据，3分钟/次</para>
            /// <para>必填：否</para>
            /// <para>示例值：001000-001000</para>
            /// </summary>
            [JsonPropertyName("list_order")]
            public string? ListOrder { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ObjectFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ObjectFieldData
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
                /// <para>必填：是</para>
                /// <para>示例值：\"Sandy\"</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>生效时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-05-0100:00:00</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>失效时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-0200:00:00</para>
        /// </summary>
        [JsonPropertyName("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record ObjectFieldData
        {
            /// <summary>
            /// <para>字段名</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("field_name")]
            public string FieldName { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"Sandy\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>成本中心id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7142384817131652652</para>
        /// </summary>
        [JsonPropertyName("cost_center_id")]
        public string? CostCenterId { get; set; }
    }
}
