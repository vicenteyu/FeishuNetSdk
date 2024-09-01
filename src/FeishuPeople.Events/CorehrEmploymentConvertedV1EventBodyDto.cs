// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrEmploymentConvertedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>员工完成转正 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 员工完成转正 事件体
/// <para>当员工转正生效时触发该事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=employment&amp;event=converted)</para>
/// <para>接口ID：7085202007996514308</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/probation/converted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployment%2fevents%2fconverted</para>
/// </summary>
public record CorehrEmploymentConvertedV1EventBodyDto() : EventBodyDto("corehr.employment.converted_v1")
{
    /// <summary>
    /// <para>雇佣ID，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }
}
