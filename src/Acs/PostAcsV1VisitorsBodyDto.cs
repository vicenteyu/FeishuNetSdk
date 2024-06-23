// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAcsV1VisitorsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加访客 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Acs;
/// <summary>
/// 添加访客 请求体
/// <para>添加访客</para>
/// <para>接口ID：7321978105899057180</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/acs-v1/visitor/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fvisitor%2fcreate</para>
/// </summary>
public record PostAcsV1VisitorsBodyDto
{
    /// <summary>
    /// <para>访客信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("user")]
    public UserExternal User { get; set; } = new();

    /// <summary>
    /// <para>访客信息</para>
    /// </summary>
    public record UserExternal
    {
        /// <summary>
        /// <para>用户类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：11</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：员工</item>
        /// <item>2：部门</item>
        /// <item>10：全体员工</item>
        /// <item>11：访客</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("user_type")]
        public int UserType { get; set; }

        /// <summary>
        /// <para>用户id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>用户名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("user_name")]
        public string? UserName { get; set; }

        /// <summary>
        /// <para>电话号码</para>
        /// <para>必填：否</para>
        /// <para>示例值：1357890001</para>
        /// </summary>
        [JsonPropertyName("phone_num")]
        public string? PhoneNum { get; set; }

        /// <summary>
        /// <para>部门id</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-f7d44ab733f7602f5cc5194735fd9aaf</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }
    }
}
