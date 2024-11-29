// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrEmployeeDomainEventV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>人员信息变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 人员信息变更 事件体
/// <para>人员领域事件变更，通过业务界面、开放平台接口对个人信息、工作信息（雇佣信息）、任职信息、兼职信息等进行操作时会触发相应事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=employee&amp;event=domain_event)</para>
/// <para>接口ID：7350263010596438044</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/events/domain_event</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fevents%2fdomain_event</para>
/// </summary>
public record CorehrEmployeeDomainEventV2EventBodyDto() : EventBodyDto("corehr.employee.domain_event_v2")
{
    /// <summary>
    /// <para>事件类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1:员工入职,2:更新人员信息,4:员工兼职变动,5:员工主任职变动,7:员工离职,8:自定义组织记录变动</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：员工入职</item>
    /// <item>2：更新人员信息</item>
    /// <item>4：员工兼职变动</item>
    /// <item>5：员工主任职变动</item>
    /// <item>7：员工离职</item>
    /// <item>8：自定义组织记录变动</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("event_type")]
    public int? EventType { get; set; }

    /// <summary>
    /// <para>子事件类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1001:新入职,2001:更新人员信息,4001:创建兼职,4002:编缉兼职（更新兼职的任一字段就会触发该事件，包括更新【结束日期】）,4003:撤销兼职（弃用）,4004:结束兼职（目前含义为数据变更，即首次设置【结束日期】时会触发）,4005:删除兼职,5001:添加异动,5002:编辑异动信息,5003:撤销异动,7001:离职通过,7002:撤销离职,8001:新增第一条记录,8002:新增第一条之后的自定义组织记录,8003:编辑自定义组织记录</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1001：新入职</item>
    /// <item>2001：更新人员信息</item>
    /// <item>4001：创建兼职</item>
    /// <item>4002：编缉兼职（更新兼职的任一字段就会触发该事件，包括更新【结束日期】）</item>
    /// <item>4003：撤销兼职（弃用）</item>
    /// <item>4004：结束兼职（目前含义为数据变更，即首次设置【结束日期】时会触发）</item>
    /// <item>4005：删除兼职</item>
    /// <item>5001：添加异动</item>
    /// <item>5002：编辑异动信息</item>
    /// <item>5003：撤销异动</item>
    /// <item>7001：离职通过</item>
    /// <item>7002：撤销离职</item>
    /// <item>8001：新增第一条记录</item>
    /// <item>8002：新增第一条之后的自定义组织记录</item>
    /// <item>8003：编辑自定义组织记录</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("sub_event_type")]
    public int? SubEventType { get; set; }

    /// <summary>
    /// <para>操作用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_user_id")]
    public string? OperatorUserId { get; set; }

    /// <summary>
    /// <para>业务场景</para>
    /// <para>- 标识触发此事件操作场景：系统页面操作、开发平台接口操作等</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("opt_scene")]
    public string? OptScene { get; set; }

    /// <summary>
    /// <para>操作描述</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("opt_desc")]
    public string? OptDesc { get; set; }

    /// <summary>
    /// <para>操作时间戳，单位：秒</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("opt_time")]
    public string? OptTime { get; set; }

    /// <summary>
    /// <para>操作 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("opt_id")]
    public string? OptId { get; set; }

    /// <summary>
    /// <para>被操作人的雇佣 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>变更数据</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `1000`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("data")]
    public EmployeeDomainEventData[]? Data { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record EmployeeDomainEventData
    {
        /// <summary>
        /// <para>变更实体的 ID</para>
        /// <para>- 雇佣ID，个人信息ID</para>
        /// <para>- 特殊：</para>
        /// <para>- 任职记录版本ID：请使用[批量查询员工任职](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employees-job_data/batch_get)获取任职记录，对照 version_id 字段查找对象</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>变更实体标识，如：</para>
        /// <para>- job_data: 任职信息</para>
        /// <para>- person：个人信息</para>
        /// <para>- employment：雇佣信息</para>
        /// <para>- email: 邮箱</para>
        /// <para>- person_name：姓名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("entity")]
        public string? Entity { get; set; }

        /// <summary>
        /// <para>聚合实体标识，如：</para>
        /// <para>- job_data: 任职信息</para>
        /// <para>- person：个人信息</para>
        /// <para>- employment：雇佣信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agg_entity")]
        public string? AggEntity { get; set; }

        /// <summary>
        /// <para>聚合实体 ID，父对象 ID，如：</para>
        /// <para>- person：个人信息 ID</para>
        /// <para>- employment：雇佣 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agg_entity_id")]
        public string? AggEntityId { get; set; }

        /// <summary>
        /// <para>操作类型</para>
        /// <para>**可选值有**：</para>
        /// <para>1:新增,2:修改,3:删除</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：新增</item>
        /// <item>2：修改</item>
        /// <item>3：删除</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("opt_type")]
        public int? OptType { get; set; }

        /// <summary>
        /// <para>字段标识，ApiName</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`0` ～ `1000`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("fields")]
        public string[]? Fields { get; set; }
    }
}
