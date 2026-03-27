// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="GetVcV1NotesByNoteIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取纪要详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 获取纪要详情 响应体
/// <para>获取一篇纪要的详细数据。</para>
/// <para>接口ID：7621600266278522080</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/note/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fnote%2fget</para>
/// </summary>
public record GetVcV1NotesByNoteIdResponseDto
{
    /// <summary>
    /// <para>纪要信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("note")]
    public NoteSuffix? Note { get; set; }

    /// <summary>
    /// <para>纪要信息</para>
    /// </summary>
    public record NoteSuffix
    {
        /// <summary>
        /// <para>纪要创建者 User ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// <para>纪要创建时间（unix时间，单位sec）</para>
        /// <para>必填：是</para>
        /// <para>示例值：1773922587</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>纪要产物</para>
        /// <para>必填：是</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("artifacts")]
        public NoteArtifactInfo[] Artifacts { get; set; } = [];

        /// <summary>
        /// <para>纪要产物</para>
        /// </summary>
        public record NoteArtifactInfo
        {
            /// <summary>
            /// <para>纪要产物类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：保留值（正常业务流程中服务端不会返回）</item>
            /// <item>1：纪要文档</item>
            /// <item>2：逐字稿文档</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("artifact_type")]
            public int ArtifactType { get; set; }

            /// <summary>
            /// <para>产物创建时间（unix时间，单位sec）</para>
            /// <para>必填：是</para>
            /// <para>示例值：1773922587</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string CreateTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>产物的doc token</para>
            /// <para>必填：是</para>
            /// <para>示例值：BkX1wpU0gi6WP4klwRGchoqZntv</para>
            /// </summary>
            [JsonPropertyName("doc_token")]
            public string DocToken { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>关联引用</para>
        /// <para>必填：是</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("references")]
        public NoteReferenceInfo[] References { get; set; } = [];

        /// <summary>
        /// <para>关联引用</para>
        /// </summary>
        public record NoteReferenceInfo
        {
            /// <summary>
            /// <para>关联引用类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：保留值（正常业务流程中服务端不会返回）</item>
            /// <item>1：会中共享文档</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("reference_type")]
            public int ReferenceType { get; set; }

            /// <summary>
            /// <para>关联引用的doc token</para>
            /// <para>必填：是</para>
            /// <para>示例值：fqF1wpU0gi6WP4klwRGchoqqweA</para>
            /// </summary>
            [JsonPropertyName("doc_token")]
            public string DocToken { get; set; } = string.Empty;
        }
    }
}
