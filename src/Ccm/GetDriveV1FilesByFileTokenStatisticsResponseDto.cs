// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDriveV1FilesByFileTokenStatisticsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取文件统计信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取文件统计信息 响应体
/// <para>此接口用于获取各类文件的流量统计信息和互动信息，包括阅读人数、阅读次数和点赞数。</para>
/// <para>接口ID：6989584844481544196</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-statistics%2fget</para>
/// </summary>
public record GetDriveV1FilesByFileTokenStatisticsResponseDto
{
    /// <summary>
    /// <para>文档 token</para>
    /// <para>必填：否</para>
    /// <para>示例值：doccnfYZzTlvXqZIGTdAHKabcef</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string? FileToken { get; set; }

    /// <summary>
    /// <para>文档类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：doc</para>
    /// </summary>
    [JsonPropertyName("file_type")]
    public string? FileType { get; set; }

    /// <summary>
    /// <para>文档统计信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("statistics")]
    public FileStatistics? Statistics { get; set; }

    /// <summary>
    /// <para>文档统计信息</para>
    /// </summary>
    public record FileStatistics
    {
        /// <summary>
        /// <para>文档历史访问人数，同一用户（user_id）多次访问按一次计算。</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("uv")]
        public int? Uv { get; set; }

        /// <summary>
        /// <para>文档历史访问次数，同一用户（user_id）多次访问按多次计算，但同一用户在间隔在半小时内访问两次视为一次访问</para>
        /// <para>必填：否</para>
        /// <para>示例值：15</para>
        /// </summary>
        [JsonPropertyName("pv")]
        public int? Pv { get; set; }

        /// <summary>
        /// <para>文档历史点赞总数。`-1` 表示对应的文档类型不支持点赞</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("like_count")]
        public int? LikeCount { get; set; }

        /// <summary>
        /// <para>时间戳（单位：秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1627367349</para>
        /// </summary>
        [JsonPropertyName("timestamp")]
        public int? Timestamp { get; set; }

        /// <summary>
        /// <para>今日新增文档访问人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("uv_today")]
        public int? UvToday { get; set; }

        /// <summary>
        /// <para>今日新增文档访问次数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("pv_today")]
        public int? PvToday { get; set; }

        /// <summary>
        /// <para>今日新增文档点赞数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("like_count_today")]
        public int? LikeCountToday { get; set; }
    }
}
