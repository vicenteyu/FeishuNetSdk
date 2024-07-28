// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1FilesUploadResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传用户人脸识别照片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 上传用户人脸识别照片 响应体
/// <para>上传用户人脸照片并获取文件 ID，对应小程序端的人脸录入功能</para>
/// <para>接口ID：7044467124773765121</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_setting/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2ffile%2fupload</para>
/// </summary>
public record PostAttendanceV1FilesUploadResponseDto
{
    /// <summary>
    /// <para>文件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file")]
    public PostAttendanceV1FilesUploadResponseDtoFile? File { get; set; }

    /// <summary>
    /// <para>文件</para>
    /// </summary>
    public record PostAttendanceV1FilesUploadResponseDtoFile
    {
        /// <summary>
        /// <para>文件 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6b30e7636a38861bbe02869c726a4612</para>
        /// </summary>
        [JsonPropertyName("file_id")]
        public string FileId { get; set; } = string.Empty;
    }
}
