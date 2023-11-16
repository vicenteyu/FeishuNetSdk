namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取我的空间（root folder）元信息 响应体
/// <para>该接口用于获取 "我的空间" 的元信息</para>
/// <para>接口ID：6979502797244170243</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/get-root-folder-meta</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugTNzUjL4UzM14CO1MTN%2fget-root-folder-meta</para>
/// </summary>
public record GetDriveExplorerV2RootFolderMetaResponseDto
{
    /// <summary>
    /// <para>文件夹的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>
    /// <para>文件夹的 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>文件夹的所有者 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
}
