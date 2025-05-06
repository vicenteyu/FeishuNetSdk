// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-06
//
// Last Modified By : yxr
// Last Modified On : 2025-05-06
// ************************************************************************
// <copyright file="GetTrustPartyV1CollaborationTenantsByTargetTenantKeyCollaborationDepartmentsByTargetDepartmentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取关联组织部门详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.TrustParty;
/// <summary>
/// 获取关联组织部门详情 响应体
/// <para>获取对方的关联组织部门详情，需要对部门有可见性权限才可以获取。</para>
/// <para>## 提示</para>
/// <para>使用 user_access_token 时，按照 admin 管理后台关联组织列表中针对用户设置的可见性规则进行校验，使用 tenant_access_token 时，按照应用互通界面中针对应用设置的可见性规则进行校验。</para>
/// <para>接口ID：7442539768884674588</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/-collaboraiton-organization/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftrust_party-v1%2fcollaboration_tenant-collaboration_department%2fget</para>
/// </summary>
public record GetTrustPartyV1CollaborationTenantsByTargetTenantKeyCollaborationDepartmentsByTargetDepartmentIdResponseDto
{
    /// <summary>
    /// <para>对方关联组织的部门</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("target_department")]
    public CollaborationDepartment TargetDepartment { get; set; } = new();

    /// <summary>
    /// <para>对方关联组织的部门</para>
    /// </summary>
    public record CollaborationDepartment
    {
        /// <summary>
        /// <para>关联组织的部门open id</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("open_department_id")]
        public string? OpenDepartmentId { get; set; }

        /// <summary>
        /// <para>关联组织的部门id</para>
        /// <para>必填：否</para>
        /// <para>示例值：902c7141</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>关联组织的部门名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试部门</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>关联组织的的国际化部门名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public CollaborationDepartmentI18nName? I18nName { get; set; }

        /// <summary>
        /// <para>关联组织的的国际化部门名称</para>
        /// </summary>
        public record CollaborationDepartmentI18nName
        {
            /// <summary>
            /// <para>中文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn_name</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>日文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：ja_jp_name</para>
            /// </summary>
            [JsonPropertyName("ja_jp")]
            public string? JaJp { get; set; }

            /// <summary>
            /// <para>英文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：en_name</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>关联组织的部门排序</para>
        /// <para>必填：否</para>
        /// <para>示例值：2000</para>
        /// </summary>
        [JsonPropertyName("order")]
        public string? Order { get; set; }

        /// <summary>
        /// <para>部门负责人，必须对负责人有可见性权限才会返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leaders")]
        public CollaborationDepartmentLeader[]? Leaders { get; set; }

        /// <summary>
        /// <para>部门负责人，必须对负责人有可见性权限才会返回</para>
        /// </summary>
        public record CollaborationDepartmentLeader
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
            [JsonPropertyName("leader_type")]
            public int LeaderType { get; set; }

            /// <summary>
            /// <para>负责人ID</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("id")]
            public CollaborationUserId Id { get; set; } = new();

            /// <summary>
            /// <para>负责人ID</para>
            /// </summary>
            public record CollaborationUserId
            {
                /// <summary>
                /// <para>用户ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：1dfsads</para>
                /// </summary>
                [JsonPropertyName("user_id")]
                public string? UserId { get; set; }

                /// <summary>
                /// <para>用户open ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou_8b8d8b4e310575fd7e4947cf6f1402ac</para>
                /// </summary>
                [JsonPropertyName("open_id")]
                public string? OpenId { get; set; }

                /// <summary>
                /// <para>用户union ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：on_cad4860e7af114fb4ff6c5d496d1dd76</para>
                /// </summary>
                [JsonPropertyName("union_id")]
                public string? UnionId { get; set; }
            }
        }

        /// <summary>
        /// <para>父部门ID，必须对父部门有可见性权限才会返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("parent_department_id")]
        public CollaborationDepartmentId? ParentDepartmentId { get; set; }

        /// <summary>
        /// <para>父部门ID，必须对父部门有可见性权限才会返回</para>
        /// </summary>
        public record CollaborationDepartmentId
        {
            /// <summary>
            /// <para>部门ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：902c7141</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>部门open ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
            /// </summary>
            [JsonPropertyName("open_department_id")]
            public string? OpenDepartmentId { get; set; }
        }
    }
}
