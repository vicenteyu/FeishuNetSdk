// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1ExternalReferralRewardsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>导入外部内推奖励 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 导入外部内推奖励 请求体
/// <para>支持将外部的内推奖励（积分/现金）导入到招聘的「内推账号」中</para>
/// <para>接口ID：7325271522314584065</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/external_referral_reward/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_referral_reward%2fcreate</para>
/// </summary>
public record PostHireV1ExternalReferralRewardsBodyDto
{
    /// <summary>
    /// <para>内推人 ID</para>
    /// <para>内推人的唯一标识，在[获取用户信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/get)中获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：on_94a1ee5551019f18cd73d9f111898cf2</para>
    /// </summary>
    [JsonPropertyName("referral_user_id")]
    public string ReferralUserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>奖励创建人，管理员与内推人可见，若不传，则默认为「外部系统」</para>
    /// <para>必填：否</para>
    /// <para>示例值：on_94a1ee5551019f18cd73d9f111898cf2</para>
    /// </summary>
    [JsonPropertyName("create_user_id")]
    public string? CreateUserId { get; set; }

    /// <summary>
    /// <para>确认人，若导入的「内推奖励状态」为「已确认」可传入，若不传，则默认为「外部系统」</para>
    /// <para>必填：否</para>
    /// <para>示例值：on_94a1ee5551019f18cd73d9f111898cf2</para>
    /// </summary>
    [JsonPropertyName("confirm_user_id")]
    public string? ConfirmUserId { get; set; }

    /// <summary>
    /// <para>发放人，导入的「内推奖励状态」为「已发放」的奖励传入，若不传，则默认为「外部系统」</para>
    /// <para>必填：否</para>
    /// <para>示例值：on_94a1ee5551019f18cd73d9f111898cf2</para>
    /// </summary>
    [JsonPropertyName("pay_user_id")]
    public string? PayUserId { get; set; }

    /// <summary>
    /// <para>外部系统奖励唯一id（仅用于幂等）</para>
    /// <para>必填：是</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("external_id")]
    public string ExternalId { get; set; } = string.Empty;

    /// <summary>
    /// <para>内推的候选人投递 ID，建议传入招聘系统内的投递 ID</para>
    /// <para>若无投递ID，可传入「内推的候选人人才 ID」，传入了「内推的候选人人才 ID」后，该参数可不填</para>
    /// <para>若不传入投递 ID，当前内推奖励将无法关联到投递</para>
    /// <para>系统内无法展示该内推对应的「职位」、「职位负责人」、「offer负责人」，对应字段将展示为「--」</para>
    /// <para>内推人可看到该奖励记录，但职位负责人、offer负责人无法看到该奖励记录</para>
    /// <para>投递 ID 查询方式为</para>
    /// <para>1. [通过手机号或邮箱获取人才 ID](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/batch_get_id)</para>
    /// <para>2. [获取投递列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/list)</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114325</para>
    /// </summary>
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// <para>内推的候选人人才 ID</para>
    /// <para>若未传入「内推的候选人投递 ID」，该参数必填</para>
    /// <para>若传入了「内推的候选人投递 ID」，该参数可不填，将以「内推的候选人投递 ID」为准</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114326</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string? TalentId { get; set; }

    /// <summary>
    /// <para>内推职位 ID</para>
    /// <para>招聘系统内的职位 ID。若不传入，对管理员与内推人将展示为--</para>
    /// <para>若传入了「内推的候选人投递 ID」，该参数可不填，职位ID将自动以「投递ID」关联的「职位ID」为准</para>
    /// <para>若不传入「内推职位 ID」，且未传入「内推的投递 ID」，当前内推奖励将无法关联到职位</para>
    /// <para>「职位的相关权限人」（如社/校招管理员、职位负责人、协助人、用人经理等）无法看到该条内推记录</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114327</para>
    /// </summary>
    [JsonPropertyName("job_id")]
    public string? JobId { get; set; }

    /// <summary>
    /// <para>奖励原因，若不传则为 「--」</para>
    /// <para>将展示在内推奖励明细中，管理员与内推人可见。</para>
    /// <para>如需与飞书招聘判定的内推奖励原因保持一致，方便统计，可参考下方说明传入</para>
    /// <para>- 若「奖励规则类型」为「过程奖励」，建议传入如下原因：</para>
    /// <para>- 推荐奖励</para>
    /// <para>- 进入{阶段名称}阶段</para>
    /// <para>- 候选人到面奖励</para>
    /// <para>- 若「奖励规则类型」为「入职奖励」，建议传入如下原因:</para>
    /// <para>- 入职</para>
    /// <para>- 转正</para>
    /// <para>- 若「奖励规则类型」为「活动奖励」，建议传入如下原因：</para>
    /// <para>- 累计推荐 n 个候选人{过程奖励或入职奖励原因}</para>
    /// <para>- 推荐满 n 个候选人</para>
    /// <para>- 若「奖励规则类型」为「开源奖励」，建议传入如下原因：</para>
    /// <para>- 入职｜开源</para>
    /// <para>- 转正｜开源</para>
    /// <para>必填：否</para>
    /// <para>示例值：入职｜开源</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>
    /// <para>导入的奖励规则类型，将展示在内推奖励明细中，管理员与内推人可见</para>
    /// <para>如需与飞书招聘内的奖励原因保持一致，方便统一统计，可参考下方说明传入</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：入职奖励，候选人入职或转正后产生的奖励</item>
    /// <item>2：过程奖励，入职奖励外，若候选人有阶段性进展，则给予内推人对应的奖励</item>
    /// <item>3：活动奖励，额外奖励，用于支持内推周期性活动</item>
    /// <item>4：开源奖励，若内推候选人首次进入人才库，且在被推荐后一段时间内，入职了规则内的任意职位的奖励</item>
    /// <item>5：其他奖励，以上奖励无法覆盖的奖励</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("rule_type")]
    public int RuleType { get; set; }

    /// <summary>
    /// <para>奖励额度</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("bonus")]
    public BonusAmount Bonus { get; set; } = new();

    /// <summary>
    /// <para>奖励额度</para>
    /// </summary>
    public record BonusAmount
    {
        /// <summary>
        /// <para>奖励发放形式</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：积分</item>
        /// <item>2：现金</item>
        /// </list></para>
        /// <para>默认值：1</para>
        /// </summary>
        [JsonPropertyName("bonus_type")]
        public int BonusType { get; set; }

        /// <summary>
        /// <para>导入积分数量，若奖励发放形式为现金为必填</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("point_bonus")]
        public int? PointBonus { get; set; }

        /// <summary>
        /// <para>现金奖励</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cash")]
        public BonusAmountCash? Cash { get; set; }

        /// <summary>
        /// <para>现金奖励</para>
        /// </summary>
        public record BonusAmountCash
        {
            /// <summary>
            /// <para>导入现金币种，若奖励发放形式为现金为必填，币种参数可在[「枚举常量介绍中查询」](https://open.feishu.cn/document/server-docs/hire-v1/enum)</para>
            /// <para>必填：是</para>
            /// <para>示例值：CNY</para>
            /// </summary>
            [JsonPropertyName("currency_type")]
            public string CurrencyType { get; set; } = string.Empty;

            /// <summary>
            /// <para>导入现金数量，若奖励发放形式为现金为必填，需传入非负数</para>
            /// <para>必填：是</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("amount")]
            public float Amount { get; set; }
        }
    }

    /// <summary>
    /// <para>导入的内推奖励状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：待确认，建议导入需人工审核的奖励明细，导入后，需管理员在「内推奖励管理」-「待确认」中，手动审核确认才会展示给内推人</item>
    /// <item>2：已确认，建议导入已通过人工审核但仍未发放的奖励明细 导入后，将展示给管理员和内推人，奖励状态展示为「已确认」（未发放）</item>
    /// <item>3：已发放，建议导入已发放完成的奖励明细，导入后，将展示给管理员和内推人，奖励状态展示为「已发放」</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("stage")]
    public int Stage { get; set; }

    /// <summary>
    /// <para>奖励产生时间</para>
    /// <para>时间戳，内推奖励触发时间，若未传入，取接口调用时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1704720275000</para>
    /// </summary>
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// <para>确认时间</para>
    /// <para>时间戳，若导入的「内推奖励状态」为「已确认」可传入，若未传入，取接口传入时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1704720275000</para>
    /// </summary>
    [JsonPropertyName("confirm_time")]
    public string? ConfirmTime { get; set; }

    /// <summary>
    /// <para>发放时间</para>
    /// <para>时间戳，若导入的「内推奖励状态」为「已确认」可传入，若未传入，取接口传入时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1704720275001</para>
    /// </summary>
    [JsonPropertyName("pay_time")]
    public string? PayTime { get; set; }

    /// <summary>
    /// <para>入职时间</para>
    /// <para>时间戳，管理员与内推人可见，当「奖励规则类型」为「入职奖励」时，建议传入该参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：1704720275002</para>
    /// </summary>
    [JsonPropertyName("onboard_time")]
    public string? OnboardTime { get; set; }

    /// <summary>
    /// <para>转正时间</para>
    /// <para>时间戳，管理员与内推人可见，当「奖励规则类型」为「入职奖励」时，建议传入该参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：1704720275003</para>
    /// </summary>
    [JsonPropertyName("conversion_time")]
    public string? ConversionTime { get; set; }

    /// <summary>
    /// <para>操作备注</para>
    /// <para>管理员与内推人可见，若为空，将展示为奖励原因</para>
    /// <para>必填：否</para>
    /// <para>示例值：已发放</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}
