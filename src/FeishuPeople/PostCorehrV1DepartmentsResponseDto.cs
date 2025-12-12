// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV1DepartmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建部门 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 创建部门 响应体
/// <para>支持在单个接口中进行部门信息添加，包括部门基本信息、部门负责人、部门自定义字段信息等</para>
/// <para>接口ID：7072646559953797122</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fdepartment%2fcreate</para>
/// </summary>
public record PostCorehrV1DepartmentsResponseDto
{
    /// <summary>
    /// <para>创建成功的部门信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department")]
    public DepartmentCreate? Department { get; set; }

    /// <summary>
    /// <para>创建成功的部门信息</para>
    /// </summary>
    public record DepartmentCreate
    {
        /// <summary>
        /// <para>部门ID(返回的是people_corehr_department_id)</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719456877659520852</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>部门类型，通过[请求接口](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=department；custom_api_name=subtype。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sub_type")]
        public Enum? SubType { get; set; }

        /// <summary>
        /// <para>部门类型，通过[请求接口](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=department；custom_api_name=subtype。</para>
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
                /// <para>枚举值信息的语言，支持中文和英文。中文用zh-CN；英文用en-US。</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>枚举值信息的内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>部门负责人，填写员工的雇佣ID</para>
        /// <para>详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893013238632416776</para>
        /// </summary>
        [JsonPropertyName("manager")]
        public string? Manager { get; set; }

        /// <summary>
        /// <para>是否保密</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_confidential")]
        public bool? IsConfidential { get; set; }

        /// <summary>
        /// <para>组织实体公共字段，包括名称、描述、上级、启停用状态、生效日期、编码等基础信息</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("hiberarchy_common")]
        public DepartmentCreateHiberarchyCommon HiberarchyCommon { get; set; } = new();

        /// <summary>
        /// <para>组织实体公共字段，包括名称、描述、上级、启停用状态、生效日期、编码等基础信息</para>
        /// </summary>
        public record DepartmentCreateHiberarchyCommon
        {
            /// <summary>
            /// <para>上级组织 ID，详细信息可通过[【查询单个部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)接口获得</para>
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
            public I18n[] Names { get; set; } = [];

            /// <summary>
            /// <para>名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>名称信息的语言，支持中文和英文。中文用zh-CN；英文用en-US。</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>名称信息的内容，支持中文和英文。填写规范</para>
                /// <para>- 名称不能包含「/」「；」「;」「\」「'」字符。</para>
                /// <para>- 同一个上级部门的启用的部门名称不允许重复</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>组织类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)组织类型（organization_type）枚举定义部分获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("type")]
            public Enum? Type { get; set; }

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
                    /// <para>枚举值信息的语言，支持中文和英文。中文用zh-CN；英文用en-US。</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>枚举值信息的内容</para>
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
            /// <para>版本生效时间</para>
            /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
            /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 23:59:59</para>
            /// <para>- 和data.effective_time值一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-01 00:00:00</para>
            /// </summary>
            [JsonPropertyName("effective_time")]
            public string? EffectiveTime { get; set; }

            /// <summary>
            /// <para>版本失效时间</para>
            /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
            /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 23:59:59</para>
            /// <para>- 和data. expiration_time值一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-02 00:00:00</para>
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
            /// <para>树形排序，代表同层级的部门排序序号</para>
            /// <para>- 创建部门场景tree_order不会实时生成，10分钟内更新完毕</para>
            /// <para>- 在页面拖动部门排序时tree_order可以实时生成</para>
            /// <para>- 变更部门上级时，会清空tree_order，并触发重算list_order和tree_order，10分钟内更新完毕</para>
            /// <para>必填：否</para>
            /// <para>示例值：001000</para>
            /// </summary>
            [JsonPropertyName("tree_order")]
            public string? TreeOrder { get; set; }

            /// <summary>
            /// <para>ListOrder</para>
            /// <para>列表排序，代表所有部门的混排序号，为该部门上级路径上所有tree_order用“-”拼接。</para>
            /// <para>- 该字段在新建/更新场景非立即更新，10分钟后会延迟更新</para>
            /// <para>- 由于list_order变更会导致[部门变更接口](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/updated)产生大量事件，因此事件接口不会针对该字段同步变更事件，如果有需求订阅请联系Oncall单独开启。</para>
            /// <para>必填：否</para>
            /// <para>示例值：001000-001000</para>
            /// </summary>
            [JsonPropertyName("list_order")]
            public string? ListOrder { get; set; }

            /// <summary>
            /// <para>自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ObjectFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
            /// </summary>
            public record ObjectFieldData
            {
                /// <summary>
                /// <para>自定义字段 API Name，即自定义字段的唯一标识</para>
                /// <para>必填：是</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同。如：```("\"123\"", "\"123.23\"", "\"true\"", [\"id1\",\"id2\"], \"2006-01-02 15:04:05\")```</para>
                /// <para>必填：是</para>
                /// <para>示例值：\"Sandy\"</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>生效时间</para>
        /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 23:59:59</para>
        /// <para>- 和data.hiberarchy_common.effective_time值一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-05-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>失效时间</para>
        /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 23:59:59</para>
        /// <para>- 和data.hiberarchy_common.expiration_time值一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-02 00:00:00</para>
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
        /// <para>成本中心id，详细信息可通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：7142384817131652652</para>
        /// </summary>
        [JsonPropertyName("cost_center_id")]
        public string? CostCenterId { get; set; }

        /// <summary>
        /// <para>岗职管理模式</para>
        /// <para>- 详细枚举类型请查看[枚举场景](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)中关于staffing_model定义</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("staffing_model")]
        public Enum? StaffingModel { get; set; }
    }
}
