// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2ReviewTemplatesQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取评估模板配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取绩效模板配置 请求体
/// <para>获取绩效模板信息，包括模版名称、执行角色、填写项类型等</para>
/// <para>接口ID：7351374599659782148</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/review_template/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freview_template%2fquery</para>
/// </summary>
public record PostPerformanceV2ReviewTemplatesQueryBodyDto
{
    /// <summary>
    /// <para>绩效模板 ID 列表，获取指定绩效模板的配置数据。如果不传则返回所有</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("review_template_ids")]
    public string[]? ReviewTemplateIds { get; set; }
}
