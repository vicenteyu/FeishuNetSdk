// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-12
//
// Last Modified By : yxr
// Last Modified On : 2024-07-12
// ************************************************************************
// <copyright file="PostHireV1LocationsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询地点列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询地点列表 请求体
/// <para>根据地点类型和地点码查询地点列表，获取地点名称信息。</para>
/// <para>## 名词解释</para>
/// <para>地点：行政区域划分，如 「中国大陆」、「四川省」、「成都市」、「高新区」</para>
/// <para>地址：分为职位地址与面试地址，如：「中国四川省成都市成华区熊猫大道1375号」</para>
/// <para>接口ID：7385067676815949828</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2flocation%2fquery</para>
/// </summary>
public record PostHireV1LocationsQueryBodyDto
{
    /// <summary>
    /// <para>地点码列表，最大长度不超过100，不传则根据地点类型分页查询全量列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：CN_1</para>
    /// </summary>
    [JsonPropertyName("code_list")]
    public string[]? CodeList { get; set; }

    /// <summary>
    /// <para>地点类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：国家类型</item>
    /// <item>2：省份/州类型</item>
    /// <item>3：市类型</item>
    /// <item>4：区类型</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("location_type")]
    public int LocationType { get; set; }
}
