// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-22
//
// Last Modified By : yxr
// Last Modified On : 2024-11-22
// ************************************************************************
// <copyright file="GetAttendanceV1GroupsByGroupIdListUserResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询考勤组下所有成员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询考勤组下所有成员 响应体
/// <para>查询指定考勤组下的所有成员</para>
/// <para>接口ID：7439549206763372546</para>
/// <para>文档地址：https://open.feishu.cn/document/attendance-v1/group/list_user</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fgroup%2flist_user</para>
/// </summary>
public record GetAttendanceV1GroupsByGroupIdListUserResponseDto
{
    /// <summary>
    /// <para>考勤组成员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("users")]
    public UserBase[]? Users { get; set; }

    /// <summary>
    /// <para>考勤组成员列表</para>
    /// </summary>
    public record UserBase
    {
        /// <summary>
        /// <para>用户 ID，对应 employee_type</para>
        /// <para>必填：否</para>
        /// <para>示例值：5874663B</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>该用户所属部门 ID 列表，返回结果为该用户所属的部门树，从直属部门到根部门。对应 dept_type</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("department_ids")]
        public string[]? DepartmentIds { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：92xKiuWrBCSweSZJBSTpag%3D%3D</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
