namespace FeishuNetSdk.Ccm;
/// <summary>
/// 新建文件夹 响应体
/// <para>该接口用于在用户云空间指定文件夹中创建一个空文件夹。</para>
/// <para>接口ID：7086652480830914563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/create_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcreate_folder</para>
/// </summary>
public record PostDriveV1FilesCreateFolderResponseDto
{
    /// <summary>
    /// <para>新建的文件夹的 token</para>
    /// <para>必填：否</para>
    /// <para>示例值：fldbcddUuPz8VwnpPx5oc2abcef</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>
    /// <para>新建的文件夹的 URL 链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://feishu.cn/drive/folder/fldbcddUuPz8VwnpPx5oc2abcef</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
