// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-07-12
// ************************************************************************
// <copyright file="GetHireV1NotesByNoteIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取备注 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取备注 响应体
/// <para>根据备注 ID 查询人才备注信息，包括备注内容、人才 ID、投递 ID 等。可用于人才备注信息展示等场景。</para>
/// <para>接口ID：6950644745484386331</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/note/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fnote%2fget</para>
/// </summary>
public record GetHireV1NotesByNoteIdResponseDto
{
    /// <summary>
    /// <para>人才备注信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("note")]
    public GetHireV1NotesByNoteIdResponseDtoNote? Note { get; set; }

    /// <summary>
    /// <para>人才备注信息</para>
    /// </summary>
    public record GetHireV1NotesByNoteIdResponseDtoNote
    {
        /// <summary>
        /// <para>备注 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>人才 ID，详情请参考：[获取人才信息 ](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/get)</para>
        /// <para>必填：是</para>
        /// <para>示例值：6916472453069883661</para>
        /// </summary>
        [JsonPropertyName("talent_id")]
        public string TalentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>投递 ID，详情请参考：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891565253964859661</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>是否私密备注</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_private")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// <para>创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618209327096</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618209327096</para>
        /// </summary>
        [JsonPropertyName("modify_time")]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>创建人 ID，与入参中 `user_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_f476cb099ac9227c9bae09ce46112579</para>
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// <para>备注内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：这是一个备注</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
    }
}
