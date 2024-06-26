// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3DepartmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取部门信息列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact.Spec;
/// <summary>
/// 获取部门信息列表 响应体
/// <para>该接口用于获取当前部门子部门列表。[常见问题答疑](https://open.feishu.cn/document/ugTN1YjL4UTN24CO1UjN/uQzN1YjL0cTN24CN3UjN)。</para>
/// <para>接口ID：6943913881476972571</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//department/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2flist</para>
/// </summary>
public record GetContactV3DepartmentsResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Department[]? Items { get; set; }

    /// <summary></summary>
    public record Department
    {
        /// <summary>
        /// <para>部门名称</para>
        /// <para>注意：不可包含斜杠</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>&lt;md-perm name="contact:contact:readonly_as_app" desc="以应用身份读取通讯录" support_app_types="custom,isv" tags=""&gt;以应用身份读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:department.base:readonly" desc="获取部门基础信息" support_app_types="custom,isv" tags=""&gt;获取部门基础信息&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:readonly" desc="读取通讯录" support_app_types="custom,isv" tags="history,offline"&gt;读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:access_as_app" desc="以应用身份访问通讯录" support_app_types="custom,isv" tags="history,offline"&gt;以应用身份访问通讯录&lt;/md-perm&gt;</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>国际化的部门名称</para>
        /// <para>注意：不可包含斜杠</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>&lt;md-perm name="contact:contact:readonly_as_app" desc="以应用身份读取通讯录" support_app_types="custom,isv" tags=""&gt;以应用身份读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:department.base:readonly" desc="获取部门基础信息" support_app_types="custom,isv" tags=""&gt;获取部门基础信息&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:readonly" desc="读取通讯录" support_app_types="custom,isv" tags="history,offline"&gt;读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:access_as_app" desc="以应用身份访问通讯录" support_app_types="custom,isv" tags="history,offline"&gt;以应用身份访问通讯录&lt;/md-perm&gt;</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public DepartmentI18nName? I18nName { get; set; }

        /// <summary></summary>
        public record DepartmentI18nName
        {
            /// <summary>
            /// <para>部门的中文名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>部门的日文名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("ja_jp")]
            public string? JaJp { get; set; }

            /// <summary>
            /// <para>部门的英文名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>父部门的ID</para>
        /// <para>* 在根部门下创建新部门，该参数值为 “0”</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>&lt;md-perm name="contact:contact:readonly_as_app" desc="以应用身份读取通讯录" support_app_types="custom,isv" tags=""&gt;以应用身份读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:department.organize:readonly" desc="获取部门组织架构信息" support_app_types="custom,isv" tags=""&gt;获取部门组织架构信息&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:readonly" desc="读取通讯录" support_app_types="custom,isv" tags="history,offline"&gt;读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:access_as_app" desc="以应用身份访问通讯录" support_app_types="custom,isv" tags="history,offline"&gt;以应用身份访问通讯录&lt;/md-perm&gt;</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("parent_department_id")]
        public string? ParentDepartmentId { get; set; }

        /// <summary>
        /// <para>本部门的自定义部门ID</para>
        /// <para>注意：除需要满足正则规则外，同时不能以`od-`开头</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>&lt;md-perm name="contact:contact:readonly_as_app" desc="以应用身份读取通讯录" support_app_types="custom,isv" tags=""&gt;以应用身份读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:department.base:readonly" desc="获取部门基础信息" support_app_types="custom,isv" tags=""&gt;获取部门基础信息&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:readonly" desc="读取通讯录" support_app_types="custom,isv" tags="history,offline"&gt;读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:access_as_app" desc="以应用身份访问通讯录" support_app_types="custom,isv" tags="history,offline"&gt;以应用身份访问通讯录&lt;/md-perm&gt;</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>部门的open_id，类型与通过请求的查询参数传入的department_id_type相同</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_department_id")]
        public string? OpenDepartmentId { get; set; }

        /// <summary>
        /// <para>部门主管用户ID</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>&lt;md-perm name="contact:contact:readonly_as_app" desc="以应用身份读取通讯录" support_app_types="custom,isv" tags=""&gt;以应用身份读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:department.organize:readonly" desc="获取部门组织架构信息" support_app_types="custom,isv" tags=""&gt;获取部门组织架构信息&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:readonly" desc="读取通讯录" support_app_types="custom,isv" tags="history,offline"&gt;读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:access_as_app" desc="以应用身份访问通讯录" support_app_types="custom,isv" tags="history,offline"&gt;以应用身份访问通讯录&lt;/md-perm&gt;</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leader_user_id")]
        public string? LeaderUserId { get; set; }

        /// <summary>
        /// <para>部门群ID</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>&lt;md-perm name="contact:contact:readonly_as_app" desc="以应用身份读取通讯录" support_app_types="custom,isv" tags=""&gt;以应用身份读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:department.base:readonly" desc="获取部门基础信息" support_app_types="custom,isv" tags=""&gt;获取部门基础信息&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:readonly" desc="读取通讯录" support_app_types="custom,isv" tags="history,offline"&gt;读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:access_as_app" desc="以应用身份访问通讯录" support_app_types="custom,isv" tags="history,offline"&gt;以应用身份访问通讯录&lt;/md-perm&gt;</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>部门的排序，即部门在其同级部门的展示顺序</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>&lt;md-perm name="contact:contact:readonly_as_app" desc="以应用身份读取通讯录" support_app_types="custom,isv" tags=""&gt;以应用身份读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:department.organize:readonly" desc="获取部门组织架构信息" support_app_types="custom,isv" tags=""&gt;获取部门组织架构信息&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:readonly" desc="读取通讯录" support_app_types="custom,isv" tags="history,offline"&gt;读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:access_as_app" desc="以应用身份访问通讯录" support_app_types="custom,isv" tags="history,offline"&gt;以应用身份访问通讯录&lt;/md-perm&gt;</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("order")]
        public string? Order { get; set; }

        /// <summary>
        /// <para>部门单位自定义ID列表，当前只支持一个</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>&lt;md-perm name="contact:contact:readonly_as_app" desc="以应用身份读取通讯录" support_app_types="custom,isv" tags=""&gt;以应用身份读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:department.organize:readonly" desc="获取部门组织架构信息" support_app_types="custom,isv" tags=""&gt;获取部门组织架构信息&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:readonly" desc="读取通讯录" support_app_types="custom,isv" tags="history,offline"&gt;读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:access_as_app" desc="以应用身份访问通讯录" support_app_types="custom,isv" tags="history,offline"&gt;以应用身份访问通讯录&lt;/md-perm&gt;</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("unit_ids")]
        public string[]? UnitIds { get; set; }

        /// <summary>
        /// <para>部门下用户的个数</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>&lt;md-perm name="contact:contact:readonly_as_app" desc="以应用身份读取通讯录" support_app_types="custom,isv" tags=""&gt;以应用身份读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:department.organize:readonly" desc="获取部门组织架构信息" support_app_types="custom,isv" tags=""&gt;获取部门组织架构信息&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:readonly" desc="读取通讯录" support_app_types="custom,isv" tags="history,offline"&gt;读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:access_as_app" desc="以应用身份访问通讯录" support_app_types="custom,isv" tags="history,offline"&gt;以应用身份访问通讯录&lt;/md-perm&gt;</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("member_count")]
        public int? MemberCount { get; set; }

        /// <summary>
        /// <para>部门状态</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>&lt;md-perm name="contact:contact:readonly_as_app" desc="以应用身份读取通讯录" support_app_types="custom,isv" tags=""&gt;以应用身份读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:department.base:readonly" desc="获取部门基础信息" support_app_types="custom,isv" tags=""&gt;获取部门基础信息&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:readonly" desc="读取通讯录" support_app_types="custom,isv" tags="history,offline"&gt;读取通讯录&lt;/md-perm&gt;</para>
        /// <para>&lt;md-perm name="contact:contact:access_as_app" desc="以应用身份访问通讯录" support_app_types="custom,isv" tags="history,offline"&gt;以应用身份访问通讯录&lt;/md-perm&gt;</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("status")]
        public DepartmentStatus? Status { get; set; }

        /// <summary></summary>
        public record DepartmentStatus
        {
            /// <summary>
            /// <para>是否被删除</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("is_deleted")]
            public bool? IsDeleted { get; set; }
        }

    }
}
