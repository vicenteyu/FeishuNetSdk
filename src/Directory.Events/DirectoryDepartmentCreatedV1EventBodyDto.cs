// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="DirectoryDepartmentCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>部门新建 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory.Events;
/// <summary>
/// 部门新建 事件体
/// <para>在创建新部门时接收事件通知。</para>
/// <para>接口ID：7419214646853238788</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fevents%2fcreated</para>
/// </summary>
public record DirectoryDepartmentCreatedV1EventBodyDto() : EventBodyDto("directory.department.created_v1")
{
    /// <summary>
    /// <para>部门信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department")]
    public DepartmentSuffix? Department { get; set; }

    /// <summary>
    /// 部门信息
    /// </summary>
    public record DepartmentSuffix
    {
        /// <summary>
        /// <para>部门ID,部门ID类型为 open_department_id，了解部门 ID 可参见[部门资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)。</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 最大长度：`64` 字符</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- directory:department.base:read : 查看部门基础信息</para>
        /// <para>- directory:department.external_id:read : 查看部门自定义 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>部门负责人</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`0` ～ `100`</para>
        /// <para>**字段权限要求**：</para>
        /// <para>- directory:department.leader:read : 查看部门负责人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leaders")]
        public DepartmentLeader[]? Leaders { get; set; }

        /// <summary>
        /// 部门负责人
        /// </summary>
        public record DepartmentLeader
        {
            /// <summary>
            /// <para>部门负责人类型</para>
            /// <para>**可选值有**：</para>
            /// <para>1:主,2:副</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：主</item>
            /// <item>2：副</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("leader_type")]
            public int? LeaderType { get; set; }

            /// <summary>
            /// <para>部门负责人ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("leader_id")]
            public string? LeaderId { get; set; }
        }

        /// <summary>
        /// <para>父部门ID</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 最大长度：`64` 字符</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- directory:department.organization:read : 查看部门组织架构信息</para>
        /// <para>- directory:department.parent_id:read : 查看部门的父部门 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("parent_department_id")]
        public string? ParentDepartmentId { get; set; }

        /// <summary>
        /// <para>部门名称</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- directory:department.base:read : 查看部门基础信息</para>
        /// <para>- directory:department.name:read : 查看部门的名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18nText? Name { get; set; }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>**字段权限要求**：</para>
        /// <para>- directory:department.status:read : 查看部门的停启用状态</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("enabled_status")]
        public bool? EnabledStatus { get; set; }

        /// <summary>
        /// <para>部门排序权重</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- directory:department.order_weight:read : 查看部门排序权重</para>
        /// <para>- directory:department.organization:read : 查看部门组织架构信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("order_weight")]
        public int? OrderWeight { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`0` ～ `100`</para>
        /// <para>**字段权限要求**：</para>
        /// <para>- directory:department.custom_field:read : 查看部门自定义字段信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_field_values")]
        public CustomFieldValue[]? CustomFieldValues { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        public record CustomFieldValue
        {
            /// <summary>
            /// <para>自定义字段key</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("field_key")]
            public string? FieldKey { get; set; }

            /// <summary>
            /// <para>自定义字段类型</para>
            /// <para>**可选值有**：</para>
            /// <para>1:多行文本,2:网页链接,3:枚举选项,4:人员,10:多选枚举类型(目前仅支持文本类型),11:人员列表</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：多行文本</item>
            /// <item>2：网页链接</item>
            /// <item>3：枚举选项</item>
            /// <item>4：人员</item>
            /// <item>10：多选枚举类型(目前仅支持文本类型)</item>
            /// <item>11：人员列表</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("field_type")]
            public string? FieldType { get; set; }

            /// <summary>
            /// <para>i18n文本</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("text_value")]
            public I18nText? TextValue { get; set; }

            /// <summary>
            /// <para>网页链接字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("url_value")]
            public UrlValueSuffix? UrlValue { get; set; }

            /// <summary>
            /// 网页链接字段值
            /// </summary>
            public record UrlValueSuffix
            {
                /// <summary>
                /// <para>i18n文本</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("link_text")]
                public I18nText? LinkText { get; set; }

                /// <summary>
                /// <para>移动端网页链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// <para>桌面端网页链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("pcurl")]
                public string? Pcurl { get; set; }
            }

            /// <summary>
            /// <para>枚举</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("enum_value")]
            public EnumValueSuffix? EnumValue { get; set; }

            /// <summary>
            /// 枚举
            /// </summary>
            public record EnumValueSuffix
            {
                /// <summary>
                /// <para>选项结果ID</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 长度范围：`0` ～ `100`</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("enum_ids")]
                public string[]? EnumIds { get; set; }

                /// <summary>
                /// <para>选项类型</para>
                /// <para>**可选值有**：</para>
                /// <para>1:文本,2:图片</para>
                /// <para>必填：否</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：文本</item>
                /// <item>2：图片</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("enum_type")]
                public string? EnumType { get; set; }
            }

            /// <summary>
            /// <para>人员字段值</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 长度范围：`0` ～ `100`</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("user_values")]
            public UserValue[]? UserValues { get; set; }

            /// <summary>
            /// 人员字段值
            /// </summary>
            public record UserValue
            {
                /// <summary>
                /// <para>人员ID列表，了解用户 ID 可参见[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 长度范围：`0` ～ `100`</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("ids")]
                public string[]? Ids { get; set; }

                /// <summary>
                /// <para>人员类型</para>
                /// <para>**可选值有**：</para>
                /// <para>1:员工</para>
                /// <para>必填：否</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：员工</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("user_type")]
                public string? UserType { get; set; }
            }
        }

        /// <summary>
        /// i18n文本
        /// </summary>
        public record I18nText
        {
            /// <summary>
            /// <para>默认值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("default_value")]
            public string? DefaultValue { get; set; }

            /// <summary>
            /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("i18n_value")]
            public I18nLanguage<string>? I18nValue { get; set; }
        }
    }

    /// <summary>
    /// <para>字段异常信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("abnormal")]
    public AbnormalRecord? Abnormal { get; set; }

    /// <summary>
    /// 字段异常信息
    /// </summary>
    public record AbnormalRecord
    {
        /// <summary>
        /// <para>异常ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>行级异常</para>
        /// <para>**可选值有**：</para>
        /// <para>0:成功,1000:没权限</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 取值范围：`0` ～ `100`</para>
        /// <para>必填：否</para>
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
        /// </summary>
        [JsonPropertyName("field_errors")]
        public Dictionary<string, int>? FieldErrors { get; set; }
    }
}
