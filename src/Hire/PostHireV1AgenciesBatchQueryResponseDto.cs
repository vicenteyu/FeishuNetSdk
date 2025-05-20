// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1AgenciesBatchQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索猎头供应商列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 搜索猎头供应商列表 响应体
/// <para>可根据猎头供应商 ID 列表或关键字、筛选项查询供应商信息。</para>
/// <para>接口ID：7413697955198074884</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/agency/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fbatch_query</para>
/// </summary>
public record PostHireV1AgenciesBatchQueryResponseDto : IPageableResponse<PostHireV1AgenciesBatchQueryResponseDto.AgencySupplier>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJvZmZzZXQiOjEsInRpbWVzdGFtcCI6MTY0MDc2NTYzMjA4OCwiaWQiOm51bGx9</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>猎头供应商列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AgencySupplier[]? Items { get; set; }

    /// <summary>
    /// <para>猎头供应商列表</para>
    /// </summary>
    public record AgencySupplier
    {
        /// <summary>
        /// <para>猎头供应商 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7398493486516799788</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>猎头供应商名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：北极无敌猎头</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>猎头标签列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("label_list")]
        public AgencySupplierLabel[]? LabelLists { get; set; }

        /// <summary>
        /// <para>猎头标签列表</para>
        /// </summary>
        public record AgencySupplierLabel
        {
            /// <summary>
            /// <para>标签 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6887469228283299336</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>标签名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>标签名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>标签中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：东方树叶</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>标签英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：oriental Leaves</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>管理员列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("admin_list")]
        public AgencySupplierAdmin[]? AdminLists { get; set; }

        /// <summary>
        /// <para>管理员列表</para>
        /// </summary>
        public record AgencySupplierAdmin
        {
            /// <summary>
            /// <para>管理员 ID，与入参`user_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：7398493486516799788</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>管理员名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>管理员名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>管理员中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>管理员英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：ZhangSan</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>管理员邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：283xxxx2171813@qq.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }
        }

        /// <summary>
        /// <para>猎头简历保护期</para>
        /// <para>- 候选人在「猎头简历保护期」内入职需支付猎头费用，且保护期内无法被其他猎头公司推荐（猎头公司可重复推荐）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agency_protect_time")]
        public AgencySupplierProtectTime? AgencyProtectTime { get; set; }

        /// <summary>
        /// <para>猎头简历保护期</para>
        /// <para>- 候选人在「猎头简历保护期」内入职需支付猎头费用，且保护期内无法被其他猎头公司推荐（猎头公司可重复推荐）</para>
        /// </summary>
        public record AgencySupplierProtectTime
        {
            /// <summary>
            /// <para>保护时长，单位（天）</para>
            /// <para>必填：否</para>
            /// <para>示例值：180</para>
            /// </summary>
            [JsonPropertyName("day")]
            public int? Day { get; set; }

            /// <summary>
            /// <para>是否使用统一设置，当为`false`时代表`保护时长（day）`由用户自定义设置，否则由招聘系统预设</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// <para>可选值：<list type="bullet">
            /// <item>true：统一设置</item>
            /// <item>fasle：非统一设置</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("use_default")]
            public bool? UseDefault { get; set; }
        }

        /// <summary>
        /// <para>合作创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1639992265035</para>
        /// </summary>
        [JsonPropertyName("cooperation_create_time")]
        public string? CooperationCreateTime { get; set; }

        /// <summary>
        /// <para>合作开始时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1639992265035</para>
        /// </summary>
        [JsonPropertyName("cooperation_start_time")]
        public string? CooperationStartTime { get; set; }

        /// <summary>
        /// <para>合作终止时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1639992265035</para>
        /// </summary>
        [JsonPropertyName("cooperation_end_time")]
        public string? CooperationEndTime { get; set; }

        /// <summary>
        /// <para>合作状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：正式合作</item>
        /// <item>2：试单</item>
        /// <item>3：合作终止</item>
        /// <item>4：邀请中</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("cooperation_status")]
        public int? CooperationStatus { get; set; }

        /// <summary>
        /// <para>供应商邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：28933718393.qq.com</para>
        /// </summary>
        [JsonPropertyName("invite_email")]
        public string? InviteEmail { get; set; }

        /// <summary>
        /// <para>猎头地区</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：中国大陆</item>
        /// <item>2：非中国大陆</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("supplier_area")]
        public int? SupplierArea { get; set; }

        /// <summary>
        /// <para>企业自有简历保护期</para>
        /// <para>- 猎头无法推荐在「企业自有简历保护期」内活跃的候选人（「活跃」指在飞书招聘中有「新建人才或投递」、「安排评估、笔试或面试」、「申请 Offer」记录）；猎头无法推荐活跃流程中的候选人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("talent_protect_time")]
        public AgencySupplierTalentProtectTime? TalentProtectTime { get; set; }

        /// <summary>
        /// <para>企业自有简历保护期</para>
        /// <para>- 猎头无法推荐在「企业自有简历保护期」内活跃的候选人（「活跃」指在飞书招聘中有「新建人才或投递」、「安排评估、笔试或面试」、「申请 Offer」记录）；猎头无法推荐活跃流程中的候选人</para>
        /// </summary>
        public record AgencySupplierTalentProtectTime
        {
            /// <summary>
            /// <para>保护时长，单位（天）</para>
            /// <para>必填：否</para>
            /// <para>示例值：180</para>
            /// </summary>
            [JsonPropertyName("day")]
            public int? Day { get; set; }

            /// <summary>
            /// <para>是否使用统一设置，当为`false`时代表`保护时长（day）`由用户自定义设置，否则由招聘系统预设</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// <para>可选值：<list type="bullet">
            /// <item>true：统一设置</item>
            /// <item>fasle：非统一设置</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("use_default")]
            public bool? UseDefault { get; set; }

            /// <summary>
            /// <para>是否永久保护</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// <para>可选值：<list type="bullet">
            /// <item>true：永久保护</item>
            /// <item>fasle：非永久保护</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("forever")]
            public bool? Forever { get; set; }
        }
    }
}
