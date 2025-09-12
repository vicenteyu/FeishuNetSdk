// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-10
//
// Last Modified By : yxr
// Last Modified On : 2025-09-10
// ************************************************************************
// <copyright file="CompensationArchiveChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>薪资档案变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement.Events;
/// <summary>
/// 薪资档案变更 事件体
/// <para>当应用订阅该事件后，如果员工薪资档案发生变更（例如，通过管理后台对员工定薪、调薪、更正或删除），则会触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=compensation&amp;version=v1&amp;resource=archive&amp;event=changed)</para>
/// <para>接口ID：7455211774629396508</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/archive/events/changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2farchive%2fevents%2fchanged</para>
/// </summary>
public record CompensationArchiveChangedV1EventBodyDto() : EventBodyDto("compensation.archive.changed_v1")
{
    /// <summary>
    /// <para>档案变更类型。add新增、modify更正、delete删除</para>
    /// <para>**可选值有**：</para>
    /// <para>add:新增薪酬档案,modify:更正薪酬档案,delete:删除薪酬档案</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `255` 字符</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>add：新增薪酬档案</item>
    /// <item>modify：更正薪酬档案</item>
    /// <item>delete：删除薪酬档案</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("operate_type")]
    public string? OperateType { get; set; }

    /// <summary>
    /// <para>员工 ID。</para>
    /// <para>- 调用[【批量查询员工薪资档案】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/archive/query)接口返回员工薪资档案，需指定user_id_type为people_corehr_id来识别用户</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `255` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>生效时间</para>
    /// <para>- 示例值："2022-05-10"</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `255` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("effective_date")]
    public string? EffectiveDate { get; set; }

    /// <summary>
    /// <para>调前档案时间轴版本Tid。更正、删除场景下有值</para>
    /// <para>- 调用[【批量查询员工薪资档案】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/archive/query)接口返回员工薪资档案</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `255` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("before_tid")]
    public string? BeforeTid { get; set; }

    /// <summary>
    /// <para>调后档案时间轴版本Tid。新增、更正场景下有值</para>
    /// <para>- 调用[【批量查询员工薪资档案】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/archive/query)接口返回员工薪资档案</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `255` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("after_tid")]
    public string? AfterTid { get; set; }
}
