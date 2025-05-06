// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-06
//
// Last Modified By : yxr
// Last Modified On : 2025-05-06
// ************************************************************************
// <copyright file="GetTrustPartyV1CollaborationTenantsByTargetTenantKeyCollaborationUsersByTargetUserIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取关联组织成员详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.TrustParty;
/// <summary>
/// 获取关联组织成员详情 响应体
/// <para>获取关联组织成员详情，需要对关联组织成员有权限才可以获取。</para>
/// <para>## 提示</para>
/// <para>使用 user_access_token 时，按照 admin 管理后台关联组织列表中针对用户设置的可见性规则进行校验，使用 tenant_access_token 时，按照应用互通界面中针对应用设置的可见性规则进行校验。</para>
/// <para>接口ID：7442539768884625436</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/-collaboraiton-organization/get-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftrust_party-v1%2fcollaboration_tenant-collaboration_user%2fget</para>
/// </summary>
public record GetTrustPartyV1CollaborationTenantsByTargetTenantKeyCollaborationUsersByTargetUserIdResponseDto
{
    /// <summary>
    /// <para>关联组织用户</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("target_user")]
    public CollaborationUser TargetUser { get; set; } = new();

    /// <summary>
    /// <para>关联组织用户</para>
    /// </summary>
    public record CollaborationUser
    {
        /// <summary>
        /// <para>对方关联组织用户的open_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>对方关联组织用户的id</para>
        /// <para>必填：否</para>
        /// <para>示例值：902c7141</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>对方关联组织用户的union id</para>
        /// <para>必填：否</para>
        /// <para>示例值：on_cad4860e7af114fb4ff6c5d496d1dd76</para>
        /// </summary>
        [JsonPropertyName("union_id")]
        public string? UnionId { get; set; }

        /// <summary>
        /// <para>用户的名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：test_name</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>关联组织的的国际化用户名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public CollaborationUserI18nName? I18nName { get; set; }

        /// <summary>
        /// <para>关联组织的的国际化用户名称</para>
        /// </summary>
        public record CollaborationUserI18nName
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
        /// <para>用户头像信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("avatar")]
        public AvatarInfo? Avatar { get; set; }

        /// <summary>
        /// <para>用户头像信息</para>
        /// </summary>
        public record AvatarInfo
        {
            /// <summary>
            /// <para>72*72像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_72")]
            public string? Avatar72 { get; set; }

            /// <summary>
            /// <para>240*240像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_240")]
            public string? Avatar240 { get; set; }

            /// <summary>
            /// <para>640*640像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_640")]
            public string? Avatar640 { get; set; }

            /// <summary>
            /// <para>原始头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_origin")]
            public string? AvatarOrigin { get; set; }
        }

        /// <summary>
        /// <para>手机号,需要对方租户授权展示.</para>
        /// <para>必填：否</para>
        /// <para>示例值：+41446681800</para>
        /// </summary>
        [JsonPropertyName("mobile")]
        public string? Mobile { get; set; }

        /// <summary>
        /// <para>用户状态</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("status")]
        public UserStatus? Status { get; set; }

        /// <summary>
        /// <para>用户状态</para>
        /// </summary>
        public record UserStatus
        {
            /// <summary>
            /// <para>是否冻结</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_frozen")]
            public bool? IsFrozen { get; set; }

            /// <summary>
            /// <para>是否离职</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_resigned")]
            public bool? IsResigned { get; set; }

            /// <summary>
            /// <para>是否激活</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_activated")]
            public bool? IsActivated { get; set; }

            /// <summary>
            /// <para>是否主动退出，主动退出一段时间后用户会自动转为已离职</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_exited")]
            public bool? IsExited { get; set; }

            /// <summary>
            /// <para>是否未加入，需要用户自主确认才能加入团队</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_unjoin")]
            public bool? IsUnjoin { get; set; }
        }

        /// <summary>
        /// <para>用户所属部门的ID列表,已废弃</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_ids")]
        public string[]? DepartmentIds { get; set; }

        /// <summary>
        /// <para>用户的直接主管的用户ID,已废弃</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonPropertyName("leader_user_id")]
        public string? LeaderUserId { get; set; }

        /// <summary>
        /// <para>职务,需要对方租户授权展示.</para>
        /// <para>必填：否</para>
        /// <para>示例值：顾问</para>
        /// </summary>
        [JsonPropertyName("job_title")]
        public string? JobTitle { get; set; }

        /// <summary>
        /// <para>自定义属性,需要对方租户授权展示.</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_attrs")]
        public UserCustomAttr[]? CustomAttrs { get; set; }

        /// <summary>
        /// <para>自定义属性,需要对方租户授权展示.</para>
        /// </summary>
        public record UserCustomAttr
        {
            /// <summary>
            /// <para>自定义属性类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：ENUMERATION</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>自定义属性ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：C-7245579267802529811</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>自定义属性取值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public UserCustomAttrValue? Value { get; set; }

            /// <summary>
            /// <para>自定义属性取值</para>
            /// </summary>
            public record UserCustomAttrValue
            {
                /// <summary>
                /// <para>属性文本</para>
                /// <para>必填：否</para>
                /// <para>示例值：文本1</para>
                /// </summary>
                [JsonPropertyName("text")]
                public string? Text { get; set; }

                /// <summary>
                /// <para>URL</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.feishu.cn</para>
                /// </summary>
                [JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// <para>PC上的URL</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.feishu.cn</para>
                /// </summary>
                [JsonPropertyName("pc_url")]
                public string? PcUrl { get; set; }

                /// <summary>
                /// <para>选项值</para>
                /// <para>必填：否</para>
                /// <para>示例值：v2_d9033c89-a483-4efa-8d17-d02340fb16dj</para>
                /// </summary>
                [JsonPropertyName("option_value")]
                public string? OptionValue { get; set; }

                /// <summary>
                /// <para>图片链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.xxxx.com/~?image_size=noop&amp;cut_type=&amp;quality=&amp;format=png&amp;sticker_format=.webp</para>
                /// </summary>
                [JsonPropertyName("picture_url")]
                public string? PictureUrl { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：名字</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>用户信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("generic_user")]
                public CustomAttrGenericUser? GenericUser { get; set; }

                /// <summary>
                /// <para>用户信息</para>
                /// </summary>
                public record CustomAttrGenericUser
                {
                    /// <summary>
                    /// <para>用户id</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：123456789</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string Id { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>用户类型，枚举值：</para>
                    /// <para>- 1: 用户</para>
                    /// <para>- 2: 机器人</para>
                    /// <para>- 11: Mail</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int Type { get; set; }
                }
            }
        }

        /// <summary>
        /// <para>工号,需要对方租户授权展示</para>
        /// <para>必填：否</para>
        /// <para>示例值：121212</para>
        /// </summary>
        [JsonPropertyName("employee_no")]
        public string? EmployeeNo { get; set; }

        /// <summary>
        /// <para>父部门ID，必须对父部门有权限才会返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("parent_department_ids")]
        public CollaborationDepartmentId[]? ParentDepartmentIds { get; set; }

        /// <summary>
        /// <para>父部门ID，必须对父部门有权限才会返回</para>
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

        /// <summary>
        /// <para>用户的leader，必须对leader有权限才会返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leader_id")]
        public CollaborationUserId? LeaderId { get; set; }

        /// <summary>
        /// <para>用户的leader，必须对leader有权限才会返回</para>
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
}
