// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-28
//
// Last Modified By : yxr
// Last Modified On : 2024-08-28
// ************************************************************************
// <copyright file="GetHireV1UserRolesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取用户角色列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取用户角色列表 响应体
/// <para>通过用户ID、角色ID等筛选条件获取用户角色列表，可获取的信息包括用户ID、角色ID、角色姓名、业务管理范围等</para>
/// <para>接口ID：7044464966434390044</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/auth/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fuser_role%2flist</para>
/// </summary>
public record GetHireV1UserRolesResponseDto : IPageableResponse<GetHireV1UserRolesResponseDto.UserRole>
{
    /// <summary>
    /// <para>用户角色列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public UserRole[]? Items { get; set; }

    /// <summary>
    /// <para>用户角色列表</para>
    /// </summary>
    public record UserRole
    {
        /// <summary>
        /// <para>用户 ID，与入参 `user_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：7326856229396906012</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>角色 ID，可通过接口 [获取角色列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/role/list) 获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：101</para>
        /// </summary>
        [JsonPropertyName("role_id")]
        public string? RoleId { get; set; }

        /// <summary>
        /// <para>修改时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618500278663</para>
        /// </summary>
        [JsonPropertyName("modify_time")]
        public string? ModifyTime { get; set; }

        /// <summary>
        /// <para>角色名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("role_name")]
        public I18n? RoleName { get; set; }

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
        [JsonPropertyName("role_description")]
        public I18n? RoleDescription { get; set; }

        /// <summary>
        /// <para>业务管理范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("business_management_scopes")]
        public UserBusinessManagementScope[]? BusinessManagementScopes { get; set; }

        /// <summary>
        /// <para>业务管理范围</para>
        /// </summary>
        public record UserBusinessManagementScope
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
                    /// <para>示例值：测试</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>实体英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：test</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

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
                /// <item>2：按规则制定范围</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("rule_type")]
                public int? RuleType { get; set; }
            }
        }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
