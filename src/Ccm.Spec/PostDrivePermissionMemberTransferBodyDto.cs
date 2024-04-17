namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 转移拥有者 请求体
/// <para>该接口用于根据文档信息和用户信息转移文档的所有者。</para>
/// <para>接口ID：6907569744329719809</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/permission/transfer-ownership</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQzNzUjL0czM14CN3MTN</para>
/// </summary>
public record PostDrivePermissionMemberTransferBodyDto
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
    /// <para>要转移到的新的文档所有者</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; } = string.Empty;

    /// <summary>
    /// <para>用户类型，可选 **email、openid、userid、unionid**</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("member_type")]
    public string MemberType { get; set; } = string.Empty;

    /// <summary>
    /// <para>用户类型下的值，获取方式见 [如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("member_id")]
    public string MemberId { get; set; } = string.Empty;

    /// <summary>
    /// <para>true 为转移后删除旧 owner 的权限，默认为false</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("remove_old_owner")]
    public bool? RemoveOldOwner { get; set; }

    /// <summary>
    /// <para>true为不通知新owner，默认为false</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("cancel_notify")]
    public bool? CancelNotify { get; set; }
}
