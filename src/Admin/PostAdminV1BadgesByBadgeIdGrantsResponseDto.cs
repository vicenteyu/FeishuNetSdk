using Newtonsoft.Json;
namespace FeishuNetSdk.Admin;
/// <summary>
/// 创建授予名单 响应体
/// <para>通过该接口可以为特定勋章创建一份授予名单，一枚勋章下最多可创建1000份授予名单。</para>
/// <para>接口ID：7104154222309179395</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/badge/badge-grant/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fbadge-grant%2fcreate</para>
/// </summary>
public record PostAdminV1BadgesByBadgeIdGrantsResponseDto
{
    /// <summary>
    /// <para>授予名单的信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"grant_id":"g_uS4yux","badge_id":"m_DjMzaK","name":"授权给全员用户的周年授予名单","grant_type":1,"timezone":"Asia/Shanghai","is_grant_all":true,"rule_detail":{"anniversary":6,"effective_period":0}}</para>
    /// </summary>
    [JsonProperty("grant")]
    public PostAdminV1BadgesByBadgeIdGrantsResponseDtoGrant? Grant { get; set; }

    /// <summary>
    /// <para>授予名单的信息</para>
    /// </summary>
    public record PostAdminV1BadgesByBadgeIdGrantsResponseDtoGrant
    {
        /// <summary>
        /// <para>租户内授予名单的唯一标识，该值由系统随机生成。</para>
        /// <para>必填：否</para>
        /// <para>示例值：g_49Z7CQ</para>
        /// <para>最大长度：64</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>企业勋章的唯一ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：m_qTR2HM</para>
        /// <para>最大长度：64</para>
        /// </summary>
        [JsonProperty("badge_id")]
        public string? BadgeId { get; set; }

        /// <summary>
        /// <para>勋章下唯一的授予事项，最多100个字符。</para>
        /// <para>必填：是</para>
        /// <para>示例值：激励勋章的授予名单</para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>授予名单类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：手动选择有效期</item>
        /// <item>1：匹配系统入职时间</item>
        /// </list></para>
        /// <para>默认值：0</para>
        /// </summary>
        [JsonProperty("grant_type")]
        public int GrantType { get; set; }

        /// <summary>
        /// <para>授予名单的生效时间对应的时区，用于检查RuleDetail的时间戳的取值是否规范，取值范围为TZ database name</para>
        /// <para>必填：是</para>
        /// <para>示例值：Asia/Shanghai</para>
        /// </summary>
        [JsonProperty("time_zone")]
        public string TimeZone { get; set; } = string.Empty;

        /// <summary>
        /// <para>规则详情</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("rule_detail")]
        public PostAdminV1BadgesByBadgeIdGrantsResponseDtoGrantRuleDetail RuleDetail { get; set; } = new();

        /// <summary>
        /// <para>规则详情</para>
        /// </summary>
        public record PostAdminV1BadgesByBadgeIdGrantsResponseDtoGrantRuleDetail
        {
            /// <summary>
            /// <para>开始生效的时间戳。1.手动设置有效期类型勋章，配置有效期限需要配置该字段；2.时间戳必须是所在时区当天的零点时间戳，如时区为Asia/Shanghai时区时的1649606400</para>
            /// <para>必填：否</para>
            /// <para>示例值：1649606400</para>
            /// </summary>
            [JsonProperty("effective_time")]
            public string? EffectiveTime { get; set; }

            /// <summary>
            /// <para>结束生效的时间戳。1.手动设置有效期类型勋章，配置有效期限需要配置该字段；2.最大值：不得超过effective_time+100 年；3.非永久有效：时间戳必须是所在时区当天的23:59:59时间戳，如时区为Asia/Shanghai时区时的1649692799；4.永久有效：传值为0即可</para>
            /// <para>必填：否</para>
            /// <para>示例值：1649692799</para>
            /// </summary>
            [JsonProperty("expiration_time")]
            public string? ExpirationTime { get; set; }

            /// <summary>
            /// <para>入职周年日。根据入职时间发放类型勋章，需要配置该字段。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>默认值：1</para>
            /// </summary>
            [JsonProperty("anniversary")]
            public int? Anniversary { get; set; }

            /// <summary>
            /// <para>有效期限。根据入职时间发放类型勋章，需要配置该字段。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：有效期为一年</item>
            /// <item>2：永久有效</item>
            /// </list></para>
            /// <para>默认值：1</para>
            /// </summary>
            [JsonProperty("effective_period")]
            public int? EffectivePeriod { get; set; }
        }

        /// <summary>
        /// <para>是否授予给全员。1.为false时，需要关联1~500个用户群体。2.为true时，不可关联用户、用户组、部门。</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonProperty("is_grant_all")]
        public bool IsGrantAll { get; set; }

        /// <summary>
        /// <para>授予的用户ID列表，授予名单列表接口返回结果中不返回该字段，只在详情接口返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：[u273y71]</para>
        /// </summary>
        [JsonProperty("user_ids")]
        public string[]? UserIds { get; set; }

        /// <summary>
        /// <para>授予的部门ID列表，授予名单列表接口返回结果中不返回该字段，只在详情接口返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：[h121921]</para>
        /// </summary>
        [JsonProperty("department_ids")]
        public string[]? DepartmentIds { get; set; }

        /// <summary>
        /// <para>授予的用户组ID列表，授予名单列表接口返回结果中不返回该字段，只在详情接口返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：[g122817]</para>
        /// </summary>
        [JsonProperty("group_ids")]
        public string[]? GroupIds { get; set; }
    }
}
