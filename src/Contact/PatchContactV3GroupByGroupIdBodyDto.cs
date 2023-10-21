using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 更新用户组 请求体
/// <para>使用该接口更新用户组信息，请注意更新用户组时应用的通讯录权限范围需为“全部员工”，否则会更新失败。[点击了解通讯录权限范围](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7008085931593007107</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fpatch</para>
/// </summary>
public record PatchContactV3GroupByGroupIdBodyDto
{
    /// <summary>
    /// <para>用户组的名字，企业内唯一，最大长度：100 字符</para>
    /// <para>必填：否</para>
    /// <para>示例值：外包IT用户组</para>
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>用户组描述信息</para>
    /// <para>最大长度：500 字</para>
    /// <para>必填：否</para>
    /// <para>示例值：IT外包用户组，需要进行细粒度权限管控</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }
}
