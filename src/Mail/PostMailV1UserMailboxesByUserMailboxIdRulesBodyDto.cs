// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-11
//
// Last Modified By : yxr
// Last Modified On : 2025-04-11
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdRulesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建收信规则 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建收信规则 请求体
/// <para>创建收信规则</para>
/// <para>接口ID：7275929163676172291</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-rule/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-rule%2fcreate</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdRulesBodyDto
{
    /// <summary>
    /// <para>匹配条件</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("condition")]
    public RuleCondition Condition { get; set; } = new();

    /// <summary>
    /// <para>匹配条件</para>
    /// </summary>
    public record RuleCondition
    {
        /// <summary>
        /// <para>匹配类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>最大值：2</para>
        /// <para>最小值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：满足所有条件</item>
        /// <item>2：满足任意条件</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("match_type")]
        public int MatchType { get; set; }

        /// <summary>
        /// <para>匹配规则列表</para>
        /// <para>必填：是</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("items")]
        public RuleConditionItem[] Items { get; set; } = Array.Empty<RuleConditionItem>();

        /// <summary>
        /// <para>匹配规则列表</para>
        /// </summary>
        public record RuleConditionItem
        {
            /// <summary>
            /// <para>匹配条件左值</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>最大值：16</para>
            /// <para>最小值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：发件人地址</item>
            /// <item>2：收件人地址</item>
            /// <item>3：抄送地址</item>
            /// <item>4：收件人或抄送地址</item>
            /// <item>6：主题</item>
            /// <item>7：正文</item>
            /// <item>8：附件名字</item>
            /// <item>9：附件类型</item>
            /// <item>10：任意地址</item>
            /// <item>12：所有邮件</item>
            /// <item>13：是外部邮件</item>
            /// <item>14：是垃圾邮件</item>
            /// <item>15：不是垃圾邮件</item>
            /// <item>16：有附件</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public int Type { get; set; }

            /// <summary>
            /// <para>匹配条件操作符</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：10</para>
            /// <para>最小值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：包含</item>
            /// <item>2：不包含</item>
            /// <item>3：开头是</item>
            /// <item>4：结尾是</item>
            /// <item>5：是</item>
            /// <item>6：不是</item>
            /// <item>7：包含自己</item>
            /// <item>10：为空</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("operator")]
            public int? Operator { get; set; }

            /// <summary>
            /// <para>匹配条件右值</para>
            /// <para>必填：否</para>
            /// <para>示例值：hello@world.com</para>
            /// </summary>
            [JsonPropertyName("input")]
            public string? Input { get; set; }
        }
    }

    /// <summary>
    /// <para>匹配命中后的操作</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("action")]
    public RuleAction Action { get; set; } = new();

    /// <summary>
    /// <para>匹配命中后的操作</para>
    /// </summary>
    public record RuleAction
    {
        /// <summary>
        /// <para>匹配中规则后的操作列表</para>
        /// <para>必填：是</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("items")]
        public RuleActionItem[] Items { get; set; } = Array.Empty<RuleActionItem>();

        /// <summary>
        /// <para>匹配中规则后的操作列表</para>
        /// </summary>
        public record RuleActionItem
        {
            /// <summary>
            /// <para>操作类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>最大值：13</para>
            /// <para>最小值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：归档</item>
            /// <item>2：删除邮件</item>
            /// <item>3：标记为已读</item>
            /// <item>4：移至垃圾邮件</item>
            /// <item>5：不移至垃圾邮件</item>
            /// <item>8：添加用户标签（暂不支持）</item>
            /// <item>9：添加旗标</item>
            /// <item>10：不弹出通知</item>
            /// <item>11：移至用户文件夹</item>
            /// <item>12：自动转发（暂不支持）</item>
            /// <item>13：分享到会话（暂不支持）</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public int Type { get; set; }

            /// <summary>
            /// <para>当 type 为移动到文件夹时，该字段填文件夹的 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：283412371233</para>
            /// </summary>
            [JsonPropertyName("input")]
            public string? Input { get; set; }
        }
    }

    /// <summary>
    /// <para>是否终点规则</para>
    /// <para>必填：是</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("ignore_the_rest_of_rules")]
    public bool IgnoreTheRestOfRules { get; set; }

    /// <summary>
    /// <para>规则名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：将李三的邮件标记为垃圾邮件</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>是否启用</para>
    /// <para>必填：是</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("is_enable")]
    public bool IsEnable { get; set; }
}
