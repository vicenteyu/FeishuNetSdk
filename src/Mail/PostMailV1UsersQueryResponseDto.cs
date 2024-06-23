// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMailV1UsersQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询邮箱地址状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 查询邮箱地址状态 响应体
/// <para>使用邮箱状态查询接口，可以输入邮箱地址，查询出该邮箱地址对应的类型以及状态。</para>
/// <para>接口ID：7055500003323379713</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/user/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser%2fquery</para>
/// </summary>
public record PostMailV1UsersQueryResponseDto
{
    /// <summary>
    /// <para>邮箱地址以及其对应的类型类型和状态</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_list")]
    public User[]? UserLists { get; set; }

    /// <summary>
    /// <para>邮箱地址以及其对应的类型类型和状态</para>
    /// </summary>
    public record User
    {
        /// <summary>
        /// <para>邮箱地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：aaa@lark.com</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>邮箱地址状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：4</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：邮箱地址格式错误</item>
        /// <item>2：邮箱地址域名不存在</item>
        /// <item>3：邮箱地址不存在</item>
        /// <item>4：启用</item>
        /// <item>5：已删除（邮箱回收站中）</item>
        /// <item>6：禁用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>邮箱地址类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：成员邮箱</item>
        /// <item>2：成员邮箱别名</item>
        /// <item>3：公共邮箱</item>
        /// <item>4：公共邮箱别名</item>
        /// <item>5：邮件组</item>
        /// <item>6：邮件组别名</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }
    }
}
