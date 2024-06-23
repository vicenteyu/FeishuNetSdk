// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1FilesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传文件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 上传文件 请求体
/// <para>上传文件，可以上传视频，音频和常见的文件类型。</para>
/// <para>接口ID：6946222931479461889</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/file/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2ffile%2fcreate</para>
/// </summary>
public record PostImV1FilesBodyDto
{
    /// <summary>
    /// <para>文件类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：mp4</para>
    /// <para>可选值：<list type="bullet">
    /// <item>opus：上传opus音频文件； 其他格式的音频文件，请转为opus格式后上传，转换方式可参考：`ffmpeg -i SourceFile.mp3 -acodec libopus -ac 1 -ar 16000 TargetFile.opus`</item>
    /// <item>mp4：上传mp4视频文件</item>
    /// <item>pdf：上传pdf格式文件</item>
    /// <item>doc：上传doc格式文件</item>
    /// <item>xls：上传xls格式文件</item>
    /// <item>ppt：上传ppt格式文件</item>
    /// <item>stream：上传stream格式文件。若上传文件不属于以上类型，可以使用stream格式</item>
    /// </list></para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("file_type")]
    public string FileType { get; set; } = string.Empty;

    /// <summary>
    /// <para>带后缀的文件名</para>
    /// <para>必填：是</para>
    /// <para>示例值：测试视频.mp4</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("file_name")]
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件的时长（视频、音频），单位:毫秒。不填充时无法显示具体时长。</para>
    /// <para>必填：否</para>
    /// <para>示例值：3000</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("duration")]
    public int? Duration { get; set; }
}
