// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-12
//
// Last Modified By : yxr
// Last Modified On : 2024-07-12
// ************************************************************************
// <copyright file="PostCorehrV1AuthorizationsUpdateRoleAssignBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新用户被授权的数据范围 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 更新用户被授权的数据范围 请求体
/// <para>更新角色被授权的管理范围</para>
/// <para>更新后的数据范围，以本次提交的数据范围为准，本次未提交的部分将被移除。</para>
/// <para>接口ID：7361618338575810588</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/authorization/update_role_assign</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fauthorization%2fupdate_role_assign</para>
/// </summary>
public record PostCorehrV1AuthorizationsUpdateRoleAssignBodyDto
{
    /// <summary>
    /// <para>被授权角色的授权范围。你需要按照请求体示例构造结构体。</para>
    /// <para>它是一个二维数组，你可以使用它来授权具有多个管理维度的角色，例如属地 HRBP。</para>
    /// <para>- ==org_key==：管理维度。可选项有</para>
    /// <para>- 部门：==department==</para>
    /// <para>- 工作地点：==work_location==</para>
    /// <para>- 公司：==company==</para>
    /// <para>- 成本中心：==organization_id_strand==</para>
    /// <para>- 社保城市：==social_security_location==</para>
    /// <para>- 入职地点：==onboarding_location==</para>
    /// <para>- 薪资组：==pay_group==</para>
    /// <para>- 人才池：==talent_pool==</para>
    /// <para>- 自定义组织：可在「[飞书人事](https://people.feishu.cn/people/)-设置-组织设置」中相应的自定义组织目录下查看对应的组织类型编码，例如==custom_org_01==、==custom_org_02==、==custom_org_03==、==custom_org_04==、==custom_org_05==</para>
    /// <para>- ==org_ids==：组织 ID。组织 ID 和组织编码只需要填写一个</para>
    /// <para>- ==org_codes==：组织编码。组织 ID 和组织编码只需要填写一个</para>
    /// <para>必填：是</para>
    /// <para>示例值：67489937334909845</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("assigned_organization_items")]
    public AssignedOrganizationWithCode[][] AssignedOrganizationItems { get; set; } = Array.Empty<AssignedOrganizationWithCode[]>();

    /// <summary>
    /// <para>被授权角色的授权范围。你需要按照请求体示例构造结构体。</para>
    /// <para>它是一个二维数组，你可以使用它来授权具有多个管理维度的角色，例如属地 HRBP。</para>
    /// <para>- ==org_key==：管理维度。可选项有</para>
    /// <para>- 部门：==department==</para>
    /// <para>- 工作地点：==work_location==</para>
    /// <para>- 公司：==company==</para>
    /// <para>- 成本中心：==organization_id_strand==</para>
    /// <para>- 社保城市：==social_security_location==</para>
    /// <para>- 入职地点：==onboarding_location==</para>
    /// <para>- 薪资组：==pay_group==</para>
    /// <para>- 人才池：==talent_pool==</para>
    /// <para>- 自定义组织：可在「[飞书人事](https://people.feishu.cn/people/)-设置-组织设置」中相应的自定义组织目录下查看对应的组织类型编码，例如==custom_org_01==、==custom_org_02==、==custom_org_03==、==custom_org_04==、==custom_org_05==</para>
    /// <para>- ==org_ids==：组织 ID。组织 ID 和组织编码只需要填写一个</para>
    /// <para>- ==org_codes==：组织编码。组织 ID 和组织编码只需要填写一个</para>
    /// </summary>
    public record AssignedOrganizationWithCode
    {
        /// <summary>
        /// <para>管理对象key</para>
        /// <para>必填：是</para>
        /// <para>示例值：department</para>
        /// </summary>
        [JsonPropertyName("org_key")]
        public string OrgKey { get; set; } = string.Empty;

        /// <summary>
        /// <para>管理对象id列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("org_ids")]
        public string[]? OrgIds { get; set; }

        /// <summary>
        /// <para>管理对象code列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("org_codes")]
        public string[]? OrgCodes { get; set; }
    }
}
