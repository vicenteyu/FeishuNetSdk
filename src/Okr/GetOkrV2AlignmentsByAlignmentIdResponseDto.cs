// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="GetOkrV2AlignmentsByAlignmentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 OKR 对齐 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 获取 OKR 对齐 响应体
/// <para>获取特定 OKR 对齐的详细信息，包括对齐关系中涉及的两个实体、它们的所有者以及创建/更新时间戳。</para>
/// <para>接口ID：7644764969658305484</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-alignment/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-alignment%2fget</para>
/// </summary>
public record GetOkrV2AlignmentsByAlignmentIdResponseDto
{
    /// <summary>
    /// <para>对齐</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("alignment")]
    public AlignmentSuffix? Alignment { get; set; }

    /// <summary>
    /// <para>对齐</para>
    /// </summary>
    public record AlignmentSuffix
    {
        /// <summary>
        /// <para>对齐的 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398473</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>对齐的创建时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>对齐的更新时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>发起对齐的所有者</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("from_owner")]
        public Owner FromOwner { get; set; } = new();

        /// <summary>
        /// <para>发起对齐的所有者</para>
        /// </summary>
        public record Owner
        {
            /// <summary>
            /// <para>所有者类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：user</para>
            /// <para>可选值：<list type="bullet">
            /// <item>user：员工</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("owner_type")]
            public string OwnerType { get; set; } = string.Empty;

            /// <summary>
            /// <para>员工 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }
        }

        /// <summary>
        /// <para>被对齐的所有者</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("to_owner")]
        public Owner ToOwner { get; set; } = new();

        /// <summary>
        /// <para>发起对齐的实体类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>2：目标</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("from_entity_type")]
        public int FromEntityType { get; set; }

        /// <summary>
        /// <para>发起对齐的实体 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398473</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("from_entity_id")]
        public string FromEntityId { get; set; } = string.Empty;

        /// <summary>
        /// <para>被对齐的实体类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>2：目标</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("to_entity_type")]
        public int ToEntityType { get; set; }

        /// <summary>
        /// <para>被对齐的实体 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398473</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("to_entity_id")]
        public string ToEntityId { get; set; } = string.Empty;
    }
}
