// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3UsersBatchGetIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过手机号或邮箱获取用户 ID 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 通过手机号或邮箱获取用户 ID 请求体
/// <para>调用该接口通过手机号或邮箱获取一个或多个用户的 ID （包括 user_id、open_id、union_id）与状态信息。</para>
/// <para>## 注意事项</para>
/// <para>请求后不返回用户 ID 的可能原因：</para>
/// <para>- 请求头 Authorization 传入的 tenant_access_token 有误。例如，tenant_access_token 对应的应用与实际所需应用不一致。</para>
/// <para>- 输入的手机号或者邮箱不存在。</para>
/// <para>- 应用未开通 **获取用户 user ID** API 权限。</para>
/// <para>- 应用无权限查看用户信息。你需要在应用详情页为应用配置数据权限，具体说明参见[配置应用数据权限](https://open.feishu.cn/document/home/introduction-to-scope-and-authorization/configure-app-data-permissions)。</para>
/// <para>- 使用企业邮箱查询将无法返回用户 ID，必须使用用户的邮箱地址。</para>
/// <para>- 所查询的用户已离职，如果请求参数 include_resigned 取值为 false，则不会返回离职用户 ID。</para>
/// <para>接口ID：7026591401610526724</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/batch_get_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fbatch_get_id</para>
/// </summary>
public record PostContactV3UsersBatchGetIdBodyDto
{
    /// <summary>
    /// <para>要查询的用户邮箱，最多可传入 50 条。</para>
    /// <para>**注意**：</para>
    /// <para>- 不支持企业邮箱。</para>
    /// <para>- emails 与 mobiles 两个参数相互独立，即每个用户邮箱会返回对应的用户信息，每个手机号也会返回对应的用户信息。</para>
    /// <para>- 本接口返回的用户 ID 数量为 emails 数量与 mobiles 数量之和。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：sync@a.com</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("emails")]
    public string[]? Emails { get; set; }

    /// <summary>
    /// <para>要查询的用户手机号，最多可传入 50 条。</para>
    /// <para>**注意**：</para>
    /// <para>- 非中国大陆地区的手机号需要添加以 “+” 开头的国家或地区代码。</para>
    /// <para>- emails 与 mobiles 两个参数相互独立，即每个用户邮箱会返回对应的用户信息，每个手机号也会返回对应的用户信息。</para>
    /// <para>- 本接口返回的用户 ID 数量为 emails 数量与 mobiles 数量之和。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：17839872039</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("mobiles")]
    public string[]? Mobiles { get; set; }

    /// <summary>
    /// <para>查询结果是否包含离职员工的用户信息。</para>
    /// <para>**可选值有**：</para>
    /// <para>- true：包含</para>
    /// <para>- false：不包含</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("include_resigned")]
    public bool? IncludeResigned { get; set; }
}
