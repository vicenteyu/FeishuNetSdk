using Newtonsoft.Json;
namespace FeishuNetSdk.Application.Spec;
/// <summary>
/// 校验应用管理员 响应体
/// <para>该接口用于查询用户是否为应用管理员。</para>
/// <para>&gt; 此处应用管理员是指可以进入企业管理后台对应用进行审核和管理的企业管理员，并不是应用的开发者。</para>
/// <para>接口ID：6907569524100022273</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/verify-app-admin</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuITN1EjLyUTNx4iM1UTM</para>
/// </summary>
public record GetApplicationV3IsUserAdminResponseDto
{
    /// <summary>
    /// <para>用户是否为管理员，true 为是，false 为否</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("is_app_admin")]
    public bool? IsAppAdmin { get; set; }
}
