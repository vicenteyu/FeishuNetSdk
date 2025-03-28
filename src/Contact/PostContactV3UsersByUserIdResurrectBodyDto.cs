// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3UsersByUserIdResurrectBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>恢复已删除用户 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 恢复已删除用户 请求体
/// <para>该接口用于恢复已删除用户（已离职的成员）。</para>
/// <para>## 使用限制</para>
/// <para>- 该接口仅适用于飞书商业专业版、商业旗舰版、企业标准版、企业专业版、企业旗舰版。版本信息参见[版本对比](https://www.feishu.cn/service)。</para>
/// <para>- 该接口仅适用于企业自建应用，商店应用无权限调用此接口。应用类型介绍参见[应用类型简介](https://open.feishu.cn/document/home/app-types-introduction/overview)。</para>
/// <para>## 注意事项</para>
/// <para>- 调用该接口仅支持恢复离职 30 天内的成员。恢复后，部分用户数据仍不可恢复，请谨慎调用。</para>
/// <para>- 可恢复的数据：单聊记录、外部联系人、群聊、企业邮箱地址和邮件；未转移的文档、妙记、问卷。</para>
/// <para>- 不可恢复的数据：已转移的资源、成员所属部门、管理员角色等数据。</para>
/// <para>- 待恢复成员的用户 ID 不能被企业内其他成员使用。如有重复，请先离职重复 ID 的成员，否则接口会报错。</para>
/// <para>- 待恢复成员的手机号和邮箱不能被企业内其他成员使用。如有重复，请先修改重复成员的手机号或邮箱信息，否则接口会报错。</para>
/// <para>接口ID：7122710137048399875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/resurrect</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fresurrect</para>
/// </summary>
public record PostContactV3UsersByUserIdResurrectBodyDto
{
    /// <summary>
    /// <para>用户排序信息。用户可能存在多个部门中，且有不同的排序，该参数用于设置用户部门排序。</para>
    /// <para>**说明**：如果请求时不传入 departments 参数，则用户将恢复至根部门。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("departments")]
    public UserDepartmentInfo[]? Departments { get; set; }

    /// <summary>
    /// <para>用户排序信息。用户可能存在多个部门中，且有不同的排序，该参数用于设置用户部门排序。</para>
    /// <para>**说明**：如果请求时不传入 departments 参数，则用户将恢复至根部门。</para>
    /// </summary>
    public record UserDepartmentInfo
    {
        /// <summary>
        /// <para>排序信息对应的部门 ID。表示用户所在的、且需要排序的部门。部门 ID 类型与查询参数 `department_id_type` 保持一致。</para>
        /// <para>了解不同类型的部门 ID 以及获取部门 ID 的方式，可参见 [部门 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)。</para>
        /// <para>必填：是</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string DepartmentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户在其直属部门内的排序。数值越大，排序越靠前。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("user_order")]
        public int? UserOrder { get; set; }

        /// <summary>
        /// <para>用户所属的多个部门之间的排序。数值越大，排序越靠前。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("department_order")]
        public int? DepartmentOrder { get; set; }
    }

    /// <summary>
    /// <para>如果用户正常状态时分配了席位，则可以通过该参数指定恢复后分配的席位 ID。</para>
    /// <para>**注意**：</para>
    /// <para>- 该字段需开通 **分配用户席位** 权限。</para>
    /// <para>必填：否</para>
    /// <para>示例值：["7179609168571645971"]</para>
    /// </summary>
    [JsonPropertyName("subscription_ids")]
    public string[]? SubscriptionIds { get; set; }
}
