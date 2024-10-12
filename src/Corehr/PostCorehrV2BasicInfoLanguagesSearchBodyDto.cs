// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoLanguagesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询语言信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询语言信息 请求体
/// <para>根据语言 ID、状态，批量查询语言信息</para>
/// <para>接口ID：7424038983966425089</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-language/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-language%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoLanguagesSearchBodyDto
{
    /// <summary>
    /// <para>语言 ID 列表，如果为空，返回所有数据</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("language_id_list")]
    public string[]? LanguageIdList { get; set; }

    /// <summary>
    /// <para>状态列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2</para>
    /// <para>最小长度：0</para>
    /// <para>默认值：[1]</para>
    /// </summary>
    [JsonPropertyName("status_list")]
    public int[]? StatusList { get; set; }
}
