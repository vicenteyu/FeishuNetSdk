// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-07-12
// ************************************************************************
// <copyright file="PostHireV1NotesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建备注 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建备注 响应体
/// <para>为人才创建备注信息，支持在备注中@其他用户。</para>
/// <para>## 注意事项</para>
/// <para>在备注中@其他用户时，会同时赋予该用户查看该人才的权限，即该用户有权限在「飞书招聘」产品中查看该人才。</para>
/// <para>接口ID：6950213983267274756</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/note/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fnote%2fcreate</para>
/// </summary>
public record PostHireV1NotesResponseDto
{
    /// <summary>
    /// <para>备注信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("note")]
    public PostHireV1NotesResponseDtoNote? Note { get; set; }

    /// <summary>
    /// <para>备注信息</para>
    /// </summary>
    public record PostHireV1NotesResponseDtoNote
    {
        /// <summary>
        /// <para>备注ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>人才ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6916472453069883661</para>
        /// </summary>
        [JsonPropertyName("talent_id")]
        public string TalentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>投递ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891565253964859661</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>是否私密</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_private")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618209327096</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618209327096</para>
        /// </summary>
        [JsonPropertyName("modify_time")]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>创建人ID，与入参中`user_id_type`类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_f476cb099ac9227c9bae09ce46112579</para>
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// <para>备注内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：测试</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
    }
}
