// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="GetApaasV1ApplicationsByNamespaceRolesByRoleApiNameMemberResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询角色成员信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 查询角色成员信息 响应体
/// <para>获取角色成员详情</para>
/// <para>接口ID：7417675812785455107</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/permission/application-role-member/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-role-member%2fget</para>
/// </summary>
public record GetApaasV1ApplicationsByNamespaceRolesByRoleApiNameMemberResponseDto
{
    /// <summary>
    /// <para>角色成员</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("role_member")]
    public GetApaasV1ApplicationsByNamespaceRolesByRoleApiNameMemberResponseDtoRoleMember? RoleMember { get; set; }

    /// <summary>
    /// <para>角色成员</para>
    /// </summary>
    public record GetApaasV1ApplicationsByNamespaceRolesByRoleApiNameMemberResponseDtoRoleMember
    {
        /// <summary>
        /// <para>角色唯一 ID，系统自动生成</para>
        /// <para>必填：否</para>
        /// <para>示例值：role_api_id</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("role_api_id")]
        public string? RoleApiId { get; set; }

        /// <summary>
        /// <para>角色 API 名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：adminRole</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("role_api_name")]
        public string? RoleApiName { get; set; }

        /// <summary>
        /// <para>授权用户 ID 列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("users")]
        public string[]? Users { get; set; }

        /// <summary>
        /// <para>授权部门 ID 列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("departments")]
        public string[]? Departments { get; set; }

        /// <summary>
        /// <para>自定义授权用户规则</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_filter")]
        public Criterion? UserFilter { get; set; }

        /// <summary>
        /// <para>自定义授权用户规则</para>
        /// </summary>
        public record Criterion
        {
            /// <summary>
            /// <para>查询条件</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("conditions")]
            public Condition[]? Conditions { get; set; }

            /// <summary>
            /// <para>查询条件</para>
            /// </summary>
            public record Condition
            {
                /// <summary>
                /// <para>序号</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("index")]
                public string? Index { get; set; }

                /// <summary>
                /// <para>左值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("left")]
                public ConditionValue? Left { get; set; }

                /// <summary>
                /// <para>左值</para>
                /// </summary>
                public record ConditionValue
                {
                    /// <summary>
                    /// <para>类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：metadataVariable</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public string? Type { get; set; }

                    /// <summary>
                    /// <para>设置值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：{\"fieldPath\":[{\"fieldApiName\": \"_id\",\"objectApiName\": \"_user\"}]}</para>
                    /// </summary>
                    [JsonPropertyName("settings")]
                    public string? Settings { get; set; }

                    /// <summary>
                    /// <para>左值/右值的展示名称</para>
                    /// <para>必填：否</para>
                    /// <para>最大长度：255</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("display_names")]
                    public string[]? DisplayNames { get; set; }
                }

                /// <summary>
                /// <para>右值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("right")]
                public ConditionValue? Right { get; set; }

                /// <summary>
                /// <para>操作符</para>
                /// <para>必填：否</para>
                /// <para>示例值：equal</para>
                /// </summary>
                [JsonPropertyName("operator")]
                public string? Operator { get; set; }
            }

            /// <summary>
            /// <para>逻辑关系</para>
            /// <para>必填：否</para>
            /// <para>示例值：1 and 2</para>
            /// </summary>
            [JsonPropertyName("logic_expression")]
            public string? LogicExpression { get; set; }
        }

        /// <summary>
        /// <para>授权用户姓名列表，入参 need_display_name = true时返回</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("user_display_infos")]
        public PermissionNameInfo[]? UserDisplayInfos { get; set; }

        /// <summary>
        /// <para>授权用户姓名列表，入参 need_display_name = true时返回</para>
        /// </summary>
        public record PermissionNameInfo
        {
            /// <summary>
            /// <para>id</para>
            /// <para>必填：否</para>
            /// <para>示例值：1802412778084426</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>授权部门名称列表，入参 need_display_name = true时返回</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("department_display_infos")]
        public PermissionNameInfo[]? DepartmentDisplayInfos { get; set; }

        /// <summary>
        /// <para>角色成员模式</para>
        /// <para>必填：否</para>
        /// <para>示例值：custom</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>all：全部用户</item>
        /// <item>custom：自定义</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>更新人 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1802412778084426</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// <para>更新时间，单位：毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1702546522477</para>
        /// <para>最大值：9223372036854775807</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
