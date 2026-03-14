// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-14
//
// Last Modified By : yxr
// Last Modified On : 2026-03-14
// ************************************************************************
// <copyright file="PostCorehrV2ProbationEditBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>编辑试用期 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 编辑试用期 请求体
/// <para>通过本接口可新增、编辑、删除员工试用期信息</para>
/// <para>接口ID：7476132303751446529</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/edit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fedit</para>
/// </summary>
public record PostCorehrV2ProbationEditBodyDto
{
    /// <summary>
    /// <para>试用期人员的雇佣 ID，类型与查询参数 user_id_type取值一致：</para>
    /// <para>1、当user_id_type取值为open_id时，ID获取方式参考[如何获取自己的Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>2、当user_id_type取值为user_id时，ID获取方式参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
    /// <para>3、当user_id_type取值为union_id时，ID获取方式参考[如何获取自己的 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)。</para>
    /// <para>4、当user_id_type取值为people_corehr_id时，先参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)获取User ID。然后通过[ID 转换](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert)获取雇佣ID。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7140964208476371111</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string EmploymentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>试用期开始日期，格式："YYYY-MM-DD"，填写时满足以下规则</para>
    /// <para>- corehr:probation.probation_start_date:write : 读写试用期开始日期信息</para>
    /// <para>- 「试用期开始日期」和「试用期预计结束日期」需要一同填写。</para>
    /// <para>- 若该员工存在试用期记录，且同时填写「试用期开始日期」和「试用期预计结束日期」为空串，则删除该试用期记录。</para>
    /// <para>- 若该员工不存在试用期记录，且填写「试用期开始日期」和「试用期预计结束日期」，则新增试用期记录。</para>
    /// <para>- 若该员工不存在试用期记录，且未填写「试用期开始日期」和「试用期预计结束日期」，则试用期记录不会创建，其他写入数据不会生效。</para>
    /// <para>- 入职日期 &lt;= 试用期开始日期 &lt;= 试用期预计结束日期。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-01</para>
    /// </summary>
    [JsonPropertyName("probation_start_date")]
    public string? ProbationStartDate { get; set; }

    /// <summary>
    /// <para>试用期预计结束日期，格式："YYYY-MM-DD"，填写时满足以下规则</para>
    /// <para>- corehr:probation.probation_expected_end_date:write : 读写试用期预计结束日期信息</para>
    /// <para>- 「试用期开始日期」和「试用期预计结束日期」需要一同填写。</para>
    /// <para>- 若该员工存在试用期记录，且同时填写「试用期开始日期」和「试用期预计结束日期」为空串，则删除该试用期记录。</para>
    /// <para>- 若该员工不存在试用期记录，且填写「试用期开始日期」和「试用期预计结束日期」，则新增试用期记录。</para>
    /// <para>- 若该员工不存在试用期记录，且未填写「试用期开始日期」和「试用期预计结束日期」，则试用期记录不会创建，其他写入数据不会生效。</para>
    /// <para>- 试用期开始日期 &lt;= 试用期预计结束日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：2025-01-01</para>
    /// </summary>
    [JsonPropertyName("probation_expected_end_date")]
    public string? ProbationExpectedEndDate { get; set; }

    /// <summary>
    /// <para>试用期结果，填写时满足以下规则</para>
    /// <para>- corehr:probation.probation_outcome:write : 写试用期结果字段</para>
    /// <para>- 取值区分大小写。</para>
    /// <para>- 填写「通过」时，必填「试用期实际结束日期」。</para>
    /// <para>- 填写「延长」时，「延长后试用期预计结束日期」和「试用期预计延长时长」至少填写一项。</para>
    /// <para>- 填写「未通过」时，需要置空「试用期实际结束日期」。</para>
    /// <para>必填：否</para>
    /// <para>示例值：passed</para>
    /// <para>可选值：<list type="bullet">
    /// <item>passed：通过</item>
    /// <item>failed：未通过</item>
    /// <item>delayed：延期</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("probation_outcome")]
    public string? ProbationOutcome { get; set; }

    /// <summary>
    /// <para>试用期实际结束日期，格式："YYYY-MM-DD"，填写时满足以下规则</para>
    /// <para>- corehr:probation.actual_probation_end_date:write : 读写试用期实际结束日期信息</para>
    /// <para>- 需同时指定试用期结果为「通过」。</para>
    /// <para>- 试用期开始时间 &lt;= 试用期实际结束日期 &lt;= 试用期预计结束日期。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2025-01-01</para>
    /// </summary>
    [JsonPropertyName("actual_probation_end_date")]
    public string? ActualProbationEndDate { get; set; }

    /// <summary>
    /// <para>延长后试用期预计结束日期，格式："YYYY-MM-DD"，填写时满足以下规则</para>
    /// <para>- corehr:probation.probation_extend_expected_end_date:write : 读写延长后试用期预计结束日期信息</para>
    /// <para>- 需同时指定「试用期结果」为「延期」。</para>
    /// <para>- 若同时填写「试用期预计延长时长」，需保持两者数据一致。</para>
    /// <para>- 延长后试用期预计结束日期 &gt; 试用期预计结束日期。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2025-01-01</para>
    /// </summary>
    [JsonPropertyName("probation_extend_expected_end_date")]
    public string? ProbationExtendExpectedEndDate { get; set; }

    /// <summary>
    /// <para>试用期预计延长时长，填写时满足以下规则</para>
    /// <para>- corehr:probation.extended_probation_period_duration:write : 读写试用期预计延长时长信息</para>
    /// <para>- 需同时指定「试用期结果」为「延期」。</para>
    /// <para>- 填写时需要指定「试用期延长时长单位」。</para>
    /// <para>- 若同时填写「延长后试用期预计结束日期」，需保持两者数据一致。</para>
    /// <para>- 试用期预计延长时长 &gt; 0。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>最大值：500</para>
    /// <para>最小值：1</para>
    /// </summary>
    [JsonPropertyName("extended_probation_period_duration")]
    public int? ExtendedProbationPeriodDuration { get; set; }

    /// <summary>
    /// <para>试用期延长时长单位，填写时满足以下规则</para>
    /// <para>- corehr:probation.extended_probation_period_duration:write : 读写试用期预计延长时长信息</para>
    /// <para>- 取值区分大小写。</para>
    /// <para>- 需要和「试用期预计延长时长」一同填写。</para>
    /// <para>- 需同时指定「试用期结果」为「延期」。</para>
    /// <para>必填：否</para>
    /// <para>示例值：day</para>
    /// <para>可选值：<list type="bullet">
    /// <item>day：天</item>
    /// <item>week：周</item>
    /// <item>month：月</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("extended_probation_period_unit")]
    public string? ExtendedProbationPeriodUnit { get; set; }

    /// <summary>
    /// <para>备注</para>
    /// <para>- corehr:probation.notes:write : 读写试用期备注信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：试用期表现良好。</para>
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// <para>员工自评</para>
    /// <para>- corehr:probation.self_review:write : 读写员工自评信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：试用期表现良好。</para>
    /// </summary>
    [JsonPropertyName("self_review")]
    public string? SelfReview { get; set; }

    /// <summary>
    /// <para>自定义字段（当前不支持附件类型字段写入）</para>
    /// <para>- corehr:probation.custom_field:write : 读写试用期自定义字段信息</para>
    /// <para>- 可填写的字段范围参考[人员档案配置](https://people.feishu.cn/people/hr-settings/profile) &gt; 信息配置 &gt; 试用期 中的自定义字段</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public CustomFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段（当前不支持附件类型字段写入）</para>
    /// <para>- corehr:probation.custom_field:write : 读写试用期自定义字段信息</para>
    /// <para>- 可填写的字段范围参考[人员档案配置](https://people.feishu.cn/people/hr-settings/profile) &gt; 信息配置 &gt; 试用期 中的自定义字段</para>
    /// </summary>
    public record CustomFieldData
    {
        /// <summary>
        /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("custom_api_name")]
        public string CustomApiName { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义字段名称（无需填写）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public CustomName? Name { get; set; }

        /// <summary>
        /// <para>自定义字段名称（无需填写）</para>
        /// </summary>
        public record CustomName
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：自定义姓名</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Custom Name</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>自定义字段类型（无需填写）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同，不同类型字段传值格式如下</para>
        /// <para>- 文本，示例："你好"</para>
        /// <para>- 超链接，示例："https://www.baidu.com/"</para>
        /// <para>- 数字，示例："123"</para>
        /// <para>- 布尔，示例："true"</para>
        /// <para>- 单选，示例："option1"</para>
        /// <para>- 多选，示例："[\"option1\", \"option2\"]"</para>
        /// <para>- 人员（单选），示例："7140964208476371111"</para>
        /// <para>- 人员（多选），示例："[\"7140964208476371111\", \"7140964208476371112\"]"</para>
        /// <para>- 日期，示例："2025-01-01"</para>
        /// <para>必填：是</para>
        /// <para>示例值：231</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
