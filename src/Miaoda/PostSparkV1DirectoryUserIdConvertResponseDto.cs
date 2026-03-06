// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-06
//
// Last Modified By : yxr
// Last Modified On : 2026-03-06
// ************************************************************************
// <copyright file="PostSparkV1DirectoryUserIdConvertResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>妙搭和飞书用户 ID 转换 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 妙搭和飞书用户 ID 转换 响应体
/// <para>转换飞书妙搭和飞书开放平台之间的用户 ID</para>
/// <para>#### 使用场景</para>
/// <para>适用于需要在飞书妙搭和飞书开放平台之间转换用户身份的场景</para>
/// <para>#### 实现方式</para>
/// <para>通过指定转换类型（id_convert_type）和待转换的 ID 列表（ids）实现指定 ID 转换</para>
/// <para>接口ID：7613807342706871517</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/directory-user/id_convert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fdirectory-user%2fid_convert</para>
/// </summary>
public record PostSparkV1DirectoryUserIdConvertResponseDto
{
    /// <summary>
    /// <para>ID 映射，查询不到或者查询出错的不返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public IdMapItem[]? Items { get; set; }

    /// <summary>
    /// <para>ID 映射，查询不到或者查询出错的不返回</para>
    /// </summary>
    public record IdMapItem
    {
        /// <summary>
        /// <para>源 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：123445678933432</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; } = string.Empty;

        /// <summary>
        /// <para>目标 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_1234cdjhjfedgfhgdhy3884</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; } = string.Empty;
    }
}
