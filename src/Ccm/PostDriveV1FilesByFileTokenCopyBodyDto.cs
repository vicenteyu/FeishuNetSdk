namespace FeishuNetSdk.Ccm;
/// <summary>
/// 复制文件 请求体
/// <para>将文件复制到用户云空间的其他文件夹中。不支持复制文件夹。</para>
/// <para>如果目标文件夹是我的空间，则复制的文件会在「**我的空间**」的「**归我所有**」列表里。</para>
/// <para>接口ID：7087776630140157955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcopy</para>
/// </summary>
public record PostDriveV1FilesByFileTokenCopyBodyDto
{
    /// <summary>
    /// <para>被复制文件的新名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：test.txt</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>被复制文件的类型，如果该值为空或者与文件实际类型不匹配，接口会返回失败。</para>
    /// <para>必填：否</para>
    /// <para>示例值：doc</para>
    /// <para>可选值：<list type="bullet">
    /// <item>file：文件类型</item>
    /// <item>doc：文档类型</item>
    /// <item>sheet：电子表格类型</item>
    /// <item>bitable：多维表格类型</item>
    /// <item>docx：新版文档类型</item>
    /// <item>mindnote：思维笔记类型</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>文件被复制到的目标文件夹token</para>
    /// <para>必填：是</para>
    /// <para>示例值：fldbcO1UuPz8VwnpPx5a92abcef</para>
    /// </summary>
    [JsonPropertyName("folder_token")]
    public string FolderToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>用户自定义请求附加参数，用于实现特殊的复制语义</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("extra")]
    public Property[]? Extras { get; set; }

    /// <summary>
    /// <para>用户自定义请求附加参数，用于实现特殊的复制语义</para>
    /// </summary>
    public record Property
    {
        /// <summary>
        /// <para>自定义属性键对象</para>
        /// <para>必填：是</para>
        /// <para>示例值：target_type</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义属性值对象</para>
        /// <para>必填：是</para>
        /// <para>示例值：docx</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
