// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-11
// ************************************************************************
// <copyright file="GetHireV1RolesByRoleIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取角色详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取角色详情 响应体
/// <para>可通过此接口获取角色详情信息，包括名称、描述、权限列表等</para>
/// <para>接口ID：7351241605105090564</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/role/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2frole%2fget</para>
/// </summary>
public record GetHireV1RolesByRoleIdResponseDto
{
    /// <summary>
    /// <para>角色详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("role")]
    public RoleDetail? Role { get; set; }

    /// <summary>
    /// <para>角色详情</para>
    /// </summary>
    public record RoleDetail
    {
        /// <summary>
        /// <para>角色 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114324</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>角色名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>角色名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>角色中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：招聘 HRBP</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>角色英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Recruitment HRBP</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>角色描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n? Description { get; set; }

        /// <summary>
        /// <para>更新时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1716535727510</para>
        /// </summary>
        [JsonPropertyName("modify_time")]
        public string? ModifyTime { get; set; }

        /// <summary>
        /// <para>角色启用状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：启用</item>
        /// <item>2：停用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("role_status")]
        public int? RoleStatus { get; set; }

        /// <summary>
        /// <para>角色类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：系统内置角色</item>
        /// <item>2：普通用户</item>
        /// <item>5：自定义角色</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("role_type")]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>角色适用范围</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：社招</item>
        /// <item>2：校招</item>
        /// <item>3：都包含</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("scope_of_application")]
        public int? ScopeOfApplication { get; set; }

        /// <summary>
        /// <para>是否在角色上配置业务管理范围</para>
        /// <para>- `true`：配置了业务管理范围</para>
        /// <para>- `false`：未配置业务管理范围</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("has_business_management_scope")]
        public bool? HasBusinessManagementScope { get; set; }

        /// <summary>
        /// <para>社招权限配置，仅当`scope_of_application`为“社招”或“都包含”时有值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("socail_permission_collection")]
        public PermissionCollection? SocailPermissionCollection { get; set; }

        /// <summary>
        /// <para>社招权限配置，仅当`scope_of_application`为“社招”或“都包含”时有值</para>
        /// </summary>
        public record PermissionCollection
        {
            /// <summary>
            /// <para>功能权限</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("feature_permissions")]
            public IdNameObject[]? FeaturePermissions { get; set; }

            /// <summary>
            /// <para>功能权限</para>
            /// </summary>
            public record IdNameObject
            {
                /// <summary>
                /// <para>权限点 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：10101000</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>权限点名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>权限点名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>权限点中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：查看人才</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>权限点英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：View talent</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>管理权限</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("management_permissions")]
            public IdNameObject[]? ManagementPermissions { get; set; }

            /// <summary>
            /// <para>数据权限</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("data_permissions")]
            public DataPermission[]? DataPermissions { get; set; }

            /// <summary>
            /// <para>数据权限</para>
            /// </summary>
            public record DataPermission
            {
                /// <summary>
                /// <para>权限点 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：30203005</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>权限点名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>权限点名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>权限点中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：私密备注</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>权限点英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Private notes</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>数据权限状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：0</para>
                /// <para>可选值：<list type="bullet">
                /// <item>0：不可见</item>
                /// <item>1：可见</item>
                /// <item>2：可编辑</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("select_status")]
                public int? SelectStatus { get; set; }
            }

            /// <summary>
            /// <para>业务管理范围</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("business_management_scopes")]
            public BusinessManagementScope[]? BusinessManagementScopes { get; set; }

            /// <summary>
            /// <para>业务管理范围</para>
            /// </summary>
            public record BusinessManagementScope
            {
                /// <summary>
                /// <para>实体</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("entity")]
                public EntityInfo? Entity { get; set; }

                /// <summary>
                /// <para>实体</para>
                /// </summary>
                public record EntityInfo
                {
                    /// <summary>
                    /// <para>实体code，枚举如下</para>
                    /// <para>- `talent`：人才</para>
                    /// <para>- `application`：投递</para>
                    /// <para>- `interview`：面试</para>
                    /// <para>- `interview_appointment_project`：预约面试</para>
                    /// <para>- `jobfair`：集中面试</para>
                    /// <para>- `exam_session`：集中笔试</para>
                    /// <para>- `offer`：Offer</para>
                    /// <para>- `job`：职位</para>
                    /// <para>- `job_recruitment`：招聘需求</para>
                    /// <para>- `reward`：内推奖励</para>
                    /// <para>- `info_session`：宣讲会</para>
                    /// <para>- `bi`：BI</para>
                    /// <para>- `subject`：对应项目</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：application</para>
                    /// </summary>
                    [JsonPropertyName("code")]
                    public string? Code { get; set; }

                    /// <summary>
                    /// <para>实体名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>实体名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>实体中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：投递</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>实体英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Application</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }

                /// <summary>
                /// <para>权限分组</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("permission_groups")]
                public PermissionGroupInfo[]? PermissionGroups { get; set; }

                /// <summary>
                /// <para>权限分组</para>
                /// </summary>
                public record PermissionGroupInfo
                {
                    /// <summary>
                    /// <para>权限点 ID列表</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("permission_ids")]
                    public string[]? PermissionIds { get; set; }

                    /// <summary>
                    /// <para>管理范围规则</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("scope_rule")]
                    public PermissionScopeRule? ScopeRule { get; set; }

                    /// <summary>
                    /// <para>管理范围规则</para>
                    /// </summary>
                    public record PermissionScopeRule
                    {
                        /// <summary>
                        /// <para>规则类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>0：无数据权限</item>
                        /// <item>1：全部数据权限</item>
                        /// <item>2：按规则指定范围，当前系统暂不支持返回详细规则</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("rule_type")]
                        public int? RuleType { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>校招权限配置，仅当`scope_of_application`为“校招”或“都包含”时有值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("campus_permission_collection")]
        public PermissionCollection? CampusPermissionCollection { get; set; }
    }
}
