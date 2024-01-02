namespace FeishuNetSdk.Ccm;
/// <summary>
/// 复制文件 响应体
/// <para>将文件复制到用户云空间的其他文件夹中。不支持复制文件夹。</para>
/// <para>如果目标文件夹是我的空间，则复制的文件会在「**我的空间**」的「**归我所有**」列表里。</para>
/// <para>接口ID：7087776630140157955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcopy</para>
/// </summary>
public record PostDriveV1FilesByFileTokenCopyResponseDto
{
    /// <summary>
    /// <para>复制后的文件资源</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file")]
    public PostDriveV1FilesByFileTokenCopyResponseDtoFile? File { get; set; }

    /// <summary>
    /// <para>复制后的文件资源</para>
    /// </summary>
    public record PostDriveV1FilesByFileTokenCopyResponseDtoFile
    {
        /// <summary>
        /// <para>文件标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：doxcnUkUOWtOelpFcha2Zabcef</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件名</para>
        /// <para>必填：是</para>
        /// <para>示例值：title</para>
        /// <para>最大长度：250</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：docx</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>父文件夹标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：fldbcO1UuPz8VwnpPx5a92abcef</para>
        /// </summary>
        [JsonPropertyName("parent_token")]
        public string? ParentToken { get; set; }

        /// <summary>
        /// <para>在浏览器中查看的链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://feishu.cn/docx/doxcnUkUOWtOelpFcha2Zabcef</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>快捷方式文件信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("shortcut_info")]
        public PostDriveV1FilesByFileTokenCopyResponseDtoFileShortcutInfo? ShortcutInfo { get; set; }

        /// <summary>
        /// <para>快捷方式文件信息</para>
        /// </summary>
        public record PostDriveV1FilesByFileTokenCopyResponseDtoFileShortcutInfo
        {
            /// <summary>
            /// <para>快捷方式指向的原文件类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：docx</para>
            /// </summary>
            [JsonPropertyName("target_type")]
            public string TargetType { get; set; } = string.Empty;

            /// <summary>
            /// <para>快捷方式指向的原文件token</para>
            /// <para>必填：是</para>
            /// <para>示例值：doxcnUkUOWtOelpFcha2Zabcef</para>
            /// </summary>
            [JsonPropertyName("target_token")]
            public string TargetToken { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>文件创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686125119</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// <para>文件最近修改时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686125119</para>
        /// </summary>
        [JsonPropertyName("modified_time")]
        public string? ModifiedTime { get; set; }

        /// <summary>
        /// <para>文件所有者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_b13d41c02edc52ce66aaae67bf1abcef</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }
    }
}
