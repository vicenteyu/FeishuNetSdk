// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="PostMailV1MultiEntitySearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>多实体搜索 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 多实体搜索 请求体
/// <para>多实体搜索，适用于写信联系人搜索</para>
/// <para>接口ID：7648865505080413417</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/multi_entity/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmulti_entity%2fsearch</para>
/// </summary>
public record PostMailV1MultiEntitySearchBodyDto
{
    /// <summary>
    /// <para>搜索关键词</para>
    /// <para>**数据校验规则：** 长度范围：1 字符 ～ 50 字符</para>
    /// <para>必填：是</para>
    /// <para>示例值：周会</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;

    /// <summary>
    /// <para>获取的数据条数，**默认20，支持1-20**</para>
    /// <para>必填：否</para>
    /// <para>示例值：20</para>
    /// <para>最大值：20</para>
    /// <para>最小值：1</para>
    /// <para>默认值：20</para>
    /// </summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }
}
