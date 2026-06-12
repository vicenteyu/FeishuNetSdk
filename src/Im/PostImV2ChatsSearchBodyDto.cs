// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="PostImV2ChatsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索群组 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 搜索群组 请求体
/// <para>用户可以通过关键字搜索可见群组，可见性和套件内搜索一致。</para>
/// <para>接口ID：7649732836954606572</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/chat/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fchat%2fsearch</para>
/// </summary>
public record PostImV2ChatsSearchBodyDto
{
    /// <summary>
    /// <para>query (长度范围：0 ～ 50 字符)</para>
    /// <para>必填：否</para>
    /// <para>示例值：部门群</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// <para>filter</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public ChatSearchFilter? Filter { get; set; }

    /// <summary>
    /// <para>filter</para>
    /// </summary>
    public record ChatSearchFilter
    {
        /// <summary>
        /// <para>群组类型</para>
        /// <para>必填：否</para>
        /// <para>最大长度：4</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>private：私有群</item>
        /// <item>external：外部群</item>
        /// <item>public_joined：已加入的公开群</item>
        /// <item>public_not_joined：未加入的公开群</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("search_types")]
        public string[]? SearchTypes { get; set; }

        /// <summary>
        /// <para>群成员ID</para>
        /// <para>成员ID即是User ID，获取方式：https://open.feishu.cn/document/server-docs/contact-v3/user/get?appId=cli_a9228da536381cc0</para>
        /// <para>必填：否</para>
        /// <para>最大长度：500</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("member_ids")]
        public string[]? MemberIds { get; set; }

        /// <summary>
        /// <para>是否自己创建或者管理的群组</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_manager")]
        public bool? IsManager { get; set; }

        /// <summary>
        /// <para>是否关闭以人搜群功能： 先通过群成员名搜索，再搜群组(默认开启)</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("disable_search_by_user")]
        public bool? DisableSearchByUser { get; set; }

        /// <summary>
        /// <para>群模式筛选器，支持按普通群/话题群过滤</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>default：普通群</item>
        /// <item>thread：话题群</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("chat_modes")]
        public string[]? ChatModes { get; set; }
    }

    /// <summary>
    /// <para>sorter</para>
    /// <para>必填：否</para>
    /// <para>示例值：create_time_desc</para>
    /// <para>可选值：<list type="bullet">
    /// <item>create_time_desc：按照群组创建时间降序排序</item>
    /// <item>update_time_desc：按照群组更新时间降序排序</item>
    /// <item>member_count_desc：按照群组成员数量降序排序</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("sorter")]
    public string? Sorter { get; set; }
}
