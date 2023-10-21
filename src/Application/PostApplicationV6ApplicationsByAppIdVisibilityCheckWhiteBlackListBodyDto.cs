using Newtonsoft.Json;
namespace FeishuNetSdk.Application;
/// <summary>
/// 查询用户或部门是否在应用的可用或禁用名单 请求体
/// <para>该接口用于查询用户、部门、用户组是否在应用的可用或禁用名单中</para>
/// <para>接口ID：7218093640928149508</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/check_white_black_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-visibility%2fcheck_white_black_list</para>
/// </summary>
public record PostApplicationV6ApplicationsByAppIdVisibilityCheckWhiteBlackListBodyDto
{
    /// <summary>
    /// <para>想要查询的用户id列表，按照user_id_type录入，最多录入100个。</para>
    /// <para>可以调用[获取部门直属用户列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/find_by_department)接口获取。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_a2c7c74ff52b1644220e319aeabd9c63</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("user_ids")]
    public string[]? UserIds { get; set; }

    /// <summary>
    /// <para>想要查询的部门的 id 列表，最多录入100个。</para>
    /// <para>可以[调用获取子部门列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/children)接口获取。</para>
    /// <para>必填：否</para>
    /// <para>示例值：od-b329544b2737a0c42ea01fdde3546673</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("department_ids")]
    public string[]? DepartmentIds { get; set; }

    /// <summary>
    /// <para>想要查询的用户组id列表，最多录入100个。</para>
    /// <para>可以调用[查询用户组列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/group/simplelist)接口获取。</para>
    /// <para>必填：否</para>
    /// <para>示例值：e62d2977e8328eb4</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("group_ids")]
    public string[]? GroupIds { get; set; }
}
