// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="PostCorehrV2SignatureFilesQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询电子签文件详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询电子签文件详情 请求体
/// <para>该接口可用于批量查询电子签文件列表，并且支持根据文件ID、更新时间范围、文件状态、模板ID等条件检索</para>
/// <para>接口ID：7408897731056500740</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_file%2fquery</para>
/// </summary>
public record PostCorehrV2SignatureFilesQueryBodyDto
{
    /// <summary>
    /// <para>电子签文件状态状态列表，多个状态之间为「或」的关系；枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签文件状态（signature_file_state）枚举定义部分获得</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("states")]
    public string[]? States { get; set; }

    /// <summary>
    /// <para>电子签模板ID列表，返回的电子签文件使用的模板在该数组中；</para>
    /// <para>可以通过[【获取电子签模板内容】](ssl:/uAjLw4CM/ukTMukTMukTM/corehr-v2/signature_template/search)接口获取模板ID</para>
    /// <para>注意：多个模板ID之间是或的关系</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("template_ids")]
    public string[]? TemplateIds { get; set; }
}
