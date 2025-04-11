// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ElearningCourseRegistrationUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>课程学习进度更新事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Elearning.Events;
/// <summary>
/// 课程学习进度更新事件 事件体
/// <para>课程学习进度更新时触发{使用示例}(url=/api/tools/api_explore/api_explore_config?project=elearning&amp;version=v2&amp;resource=course_registration&amp;event=updated)</para>
/// <para>接口ID：7345679561005416451</para>
/// <para>文档地址：https://open.feishu.cn/document/elearning-v2/course_registration/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2felearning-v2%2fcourse_registration%2fevents%2fupdated</para>
/// </summary>
public record ElearningCourseRegistrationUpdatedV2EventBodyDto() : EventBodyDto("elearning.course_registration.updated_v2")
{
    /// <summary>
    /// <para>课程ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("course_id")]
    public string? CourseId { get; set; }

    /// <summary>
    /// <para>课程学员信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("learner")]
    public EventUser? Learner { get; set; }


    /// <summary>
    /// 
    /// </summary>
    public record EventUser
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public UserIdSuffix? UserId { get; set; }

        /// <summary>
        /// <para>用户的 email</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>用户的手机号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }
    }

    /// <summary>
    /// <para>加入学习时间戳（秒）</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 取值范围：`0` ～ `4294967295`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("enroll_at")]
    public int? EnrollAt { get; set; }

    /// <summary>
    /// <para>注册类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1:被管理员指派,2:学员自主加入,3:按照规则自动加入,4:学员申请被批准加入</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：被管理员指派</item>
    /// <item>2：学员自主加入</item>
    /// <item>3：按照规则自动加入</item>
    /// <item>4：学员申请被批准加入</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("enroll_type")]
    public int? EnrollType { get; set; }

    /// <summary>
    /// <para>学习时长，单位：秒</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 取值范围：`0` ～ `4294967295`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("learning_duration")]
    public int? LearningDuration { get; set; }

    /// <summary>
    /// <para>完成时间戳（秒）</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 取值范围：`0` ～ `4294967295`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("finished_at")]
    public int? FinishedAt { get; set; }

    /// <summary>
    /// <para>完成状态</para>
    /// <para>**可选值有**：</para>
    /// <para>0:课程未开始,1:课程学习中,2:课程已通过,3:课程不合格</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：课程未开始</item>
    /// <item>1：课程学习中</item>
    /// <item>2：课程已通过</item>
    /// <item>3：课程不合格</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("learning_state")]
    public int? LearningState { get; set; }

    /// <summary>
    /// <para>必修章节id列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `65535`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("compulsory_lesson_ids")]
    public string[]? CompulsoryLessonIds { get; set; }

    /// <summary>
    /// <para>已完成的必修章节id列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `65535`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("learned_compulsory_lesson_ids")]
    public string[]? LearnedCompulsoryLessonIds { get; set; }

    /// <summary>
    /// <para>选修章节id列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `65535`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("optional_lesson_ids")]
    public string[]? OptionalLessonIds { get; set; }

    /// <summary>
    /// <para>已完成的选修章节id列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `65535`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("learned_optional_lesson_ids")]
    public string[]? LearnedOptionalLessonIds { get; set; }
}
