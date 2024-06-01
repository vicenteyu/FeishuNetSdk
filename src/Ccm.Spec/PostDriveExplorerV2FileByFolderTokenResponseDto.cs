namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 新建文件 响应体
/// <para>该接口用于在云空间指定文件夹中创建电子表格或者多维表格。</para>
/// <para>接口ID：6907569743419932674</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/create-online-document</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQTNzUjL0UzM14CN1MTN</para>
/// </summary>
public record PostDriveExplorerV2FileByFolderTokenResponseDto
{
    /// <summary>
    /// <para>新创建文件的访问链接</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// <para>新创建文件的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>
    /// <para>新创建文件的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }
}
