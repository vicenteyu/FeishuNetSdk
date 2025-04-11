// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-12-27
// ************************************************************************
// <copyright file="PostCorehrV2DepartmentsQueryMultiTimelineResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询部门版本信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询部门版本信息 响应体
/// <para>根据部门ID列表，批量查询开始结束时间内的所有部门版本信息，含部门名称、部门类型、上级、编码、负责人、是否启用、描述等信息</para>
/// <para>接口ID：7372158581884911618</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fquery_multi_timeline</para>
/// </summary>
public record PostCorehrV2DepartmentsQueryMultiTimelineResponseDto
{
    /// <summary>
    /// <para>部门信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public DepartmentTimeline[]? Items { get; set; }

    /// <summary>
    /// <para>部门信息</para>
    /// </summary>
    public record DepartmentTimeline
    {
        /// <summary>
        /// <para>部门 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719456877659520852</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>部门版本 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7238516215202170412</para>
        /// </summary>
        [JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// <para>部门名称</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("names")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>部门名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言，中文用zh-CN，英文用en-US</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>文本内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：中文示例</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>部门类型</para>
        /// <para>- 通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。请求参数：object_api_name=department；custom_api_name=subtype。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sub_type")]
        public Enum? SubType { get; set; }

        /// <summary>
        /// <para>部门类型</para>
        /// <para>- 通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。请求参数：object_api_name=department；custom_api_name=subtype。</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：phone_type</para>
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
                /// <para>语言编码（IETF BCP 47）</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>文本内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：中文示例</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>上级部门 ID ，详细信息可通过[【查询单个部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719456877659520111</para>
        /// </summary>
        [JsonPropertyName("parent_department_id")]
        public string? ParentDepartmentId { get; set; }

        /// <summary>
        /// <para>部门负责人雇佣 ID，枚举值及详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893013238632416777</para>
        /// </summary>
        [JsonPropertyName("manager")]
        public string? Manager { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：D00000456</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>生效日期</para>
        /// <para>- 返回格式：YYYY-MM-DD（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01～9999-12-31</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-01</para>
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string? EffectiveDate { get; set; }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("descriptions")]
        public I18n[]? Descriptions { get; set; }

        /// <summary>
        /// <para>自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public CustomFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
        /// </summary>
        public record CustomFieldData
        {
            /// <summary>
            /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("custom_api_name")]
            public string CustomApiName { get; set; } = string.Empty;

            /// <summary>
            /// <para>自定义字段名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public CustomName? Name { get; set; }

            /// <summary>
            /// <para>自定义字段名称</para>
            /// </summary>
            public record CustomName
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：自定义姓名</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Custom Name</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            /// <summary>
            /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"231\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
