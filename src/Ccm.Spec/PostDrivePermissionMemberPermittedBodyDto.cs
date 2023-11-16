namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 判断协作者是否有某权限 请求体
/// <para>该接口用于根据 filetoken 判断当前登录用户是否具有某权限。</para>
/// <para>接口ID：6907569524101087233</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/permission/querying-if-a-collaborator-has-a-specific-permission</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYzN3UjL2czN14iN3cTN</para>
/// </summary>
public record PostDrivePermissionMemberPermittedBodyDto
{
    /// <summary>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// <para>文档类型，可选 **doc、docx、sheet、bitable、file**</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// <para>权限，"view" or "edit" or "share"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("perm")]
    public string Perm { get; set; } = string.Empty;
}
