// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-06
//
// Last Modified By : yxr
// Last Modified On : 2026-03-06
// ************************************************************************
// <copyright file="PostSparkV1DirectoryUserIdConvertBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>妙搭和飞书用户 ID 转换 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 妙搭和飞书用户 ID 转换 请求体
/// <para>转换飞书妙搭和飞书开放平台之间的用户 ID</para>
/// <para>#### 使用场景</para>
/// <para>适用于需要在飞书妙搭和飞书开放平台之间转换用户身份的场景</para>
/// <para>#### 实现方式</para>
/// <para>通过指定转换类型（id_convert_type）和待转换的 ID 列表（ids）实现指定 ID 转换</para>
/// <para>接口ID：7613807342706871517</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/directory-user/id_convert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fdirectory-user%2fid_convert</para>
/// </summary>
public record PostSparkV1DirectoryUserIdConvertBodyDto
{
    /// <summary>
    /// <para>ID 转换类型，枚举</para>
    /// <para>设置为10、11时，ids需要传入妙搭用户 ID</para>
    /// <para>设置为20时，需要传入飞书开平 OpenID</para>
    /// <para>设置为21时，需要传入飞书开平 UnionID</para>
    /// <para>必填：是</para>
    /// <para>示例值：10</para>
    /// <para>可选值：<list type="bullet">
    /// <item>10：妙搭用户 ID 转飞书开放平台 Open ID</item>
    /// <item>11：妙搭用户 ID 转飞书开放平台 Union ID</item>
    /// <item>20：飞书开放平台 Open ID 转妙搭用户 ID</item>
    /// <item>21：飞书开放平台 Union ID 转妙搭用户 ID</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("id_convert_type")]
    public int IdConvertType { get; set; }

    /// <summary>
    /// <para>默认为空，为空时不返回</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("ids")]
    public string[]? Ids { get; set; }
}
