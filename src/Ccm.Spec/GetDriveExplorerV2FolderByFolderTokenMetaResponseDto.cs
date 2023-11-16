namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取文件夹元信息 响应体
/// <para>该接口用于根据 folderToken 获取该文件夹的元信息。</para>
/// <para>接口ID：6907569524099989505</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/get-folder-meta</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAjNzUjLwYzM14CM2MTN</para>
/// </summary>
public record GetDriveExplorerV2FolderByFolderTokenMetaResponseDto
{
    /// <summary>
    /// <para>文件夹的 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>文件夹的标题</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>文件夹的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>
    /// <para>文件夹的创建者 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("createUid")]
    public string? CreateUid { get; set; }

    /// <summary>
    /// <para>文件夹的最后编辑者 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("editUid")]
    public string? EditUid { get; set; }

    /// <summary>
    /// <para>文件夹的上级目录 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    /// <summary>
    /// <para>文件夹为个人文件夹时，为文件夹的所有者 id；文件夹为共享文件夹时，为文件夹树id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("ownUid")]
    public string? OwnUid { get; set; }
}
