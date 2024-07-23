// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-09
//
// Last Modified By : yxr
// Last Modified On : 2024-07-11
// ************************************************************************
// <copyright file="PostHireV1WebsitesByWebsiteIdJobPostsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索招聘官网下的职位列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 搜索招聘官网下的职位列表 请求体
/// <para>搜索招聘官网下的职位列表。</para>
/// <para>接口ID：7021042393814450179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-job_post%2fsearch</para>
/// </summary>
public record PostHireV1WebsitesByWebsiteIdJobPostsSearchBodyDto
{
    /// <summary>
    /// <para>职位类型列表，详情请参考：[获取职位类别列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_type/list)</para>
    /// <para>必填：否</para>
    /// <para>示例值：6916472453069883661</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("job_type_id_list")]
    public string[]? JobTypeIdList { get; set; }

    /// <summary>
    /// <para>职位城市列表，详情请参考：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
    /// <para>必填：否</para>
    /// <para>示例值：CT_1</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("city_code_list")]
    public string[]? CityCodeList { get; set; }

    /// <summary>
    /// <para>职能分类列表，详情请参考：[获取职能分类列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_function/list)</para>
    /// <para>必填：否</para>
    /// <para>示例值：6916472453069883661</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("job_function_id_list")]
    public string[]? JobFunctionIdList { get; set; }

    /// <summary>
    /// <para>职位项目列表，详情请参考：[获取项目列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/subject/list)</para>
    /// <para>必填：否</para>
    /// <para>示例值：6916472453069883661</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("subject_id_list")]
    public string[]? SubjectIdList { get; set; }

    /// <summary>
    /// <para>关键字</para>
    /// <para>必填：否</para>
    /// <para>示例值：HR</para>
    /// </summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    /// <summary>
    /// <para>最早更新时间，毫秒级时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1618500278663</para>
    /// </summary>
    [JsonPropertyName("update_start_time")]
    public string? UpdateStartTime { get; set; }

    /// <summary>
    /// <para>最晚更新时间，毫秒级时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1618500278663</para>
    /// </summary>
    [JsonPropertyName("update_end_time")]
    public string? UpdateEndTime { get; set; }

    /// <summary>
    /// <para>最早创建时间，毫秒级时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1618500278663</para>
    /// </summary>
    [JsonPropertyName("create_start_time")]
    public string? CreateStartTime { get; set; }

    /// <summary>
    /// <para>最晚创建时间，毫秒级时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1618500278663</para>
    /// </summary>
    [JsonPropertyName("create_end_time")]
    public string? CreateEndTime { get; set; }
}
