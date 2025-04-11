// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ElearningCourseRegistrationDeletedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>课程学习进度删除事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Elearning.Events;
/// <summary>
/// 课程学习进度删除事件 事件体
/// <para>课程学习进度删除时触发{使用示例}(url=/api/tools/api_explore/api_explore_config?project=elearning&amp;version=v2&amp;resource=course_registration&amp;event=deleted)</para>
/// <para>接口ID：7345679561005432835</para>
/// <para>文档地址：https://open.feishu.cn/document/elearning-v2/course_registration/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2felearning-v2%2fcourse_registration%2fevents%2fdeleted</para>
/// </summary>
public record ElearningCourseRegistrationDeletedV2EventBodyDto() : EventBodyDto("elearning.course_registration.deleted_v2")
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
}
