namespace FeishuNetSdk.Contact;
/// <summary>
/// 批量添加角色成员 响应体
/// <para>通过”批量添加角色成员“接口可批量添加成员，成员信息同步展示至租户的管理后台-角色管理模块。</para>
/// <para>接口ID：7200215886841053212</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/functional_role-member/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2ffunctional_role-member%2fbatch_create</para>
/// </summary>
public record PostContactV3FunctionalRolesByRoleIdMembersBatchCreateResponseDto
{
    /// <summary>
    /// <para>批量新增角色成员结果集</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("results")]
    public FunctionalRoleMemberResult[]? Results { get; set; }

    /// <summary>
    /// <para>批量新增角色成员结果集</para>
    /// </summary>
    public record FunctionalRoleMemberResult
    {
        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>成员处理结果</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：处理成功</item>
        /// <item>2：用户ID无效</item>
        /// <item>3：用户ID无权限</item>
        /// <item>4：用户已存在在该角色中</item>
        /// <item>5：用户不存在在该角色中</item>
        /// <item>6：对该角色内该用户旧的管理范围无权限</item>
        /// </list></para>
        /// <para>默认值：1</para>
        /// </summary>
        [JsonPropertyName("reason")]
        public int Reason { get; set; }
    }
}
