namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取协作者列表 请求体
/// <para>该接口用于根据文件的 token 查询协作者，目前包括人("user")和群("chat") 。</para>
/// <para>接口ID：6907569523177324545</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/obtain-a-collaborator-list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATN3UjLwUzN14CM1cTN</para>
/// </summary>
public record PostDrivePermissionMemberListBodyDto
{
    /// <summary>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// <para>文档类型，可选 **doc、docx、sheet、bitable、file、minutes**</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
}
