namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取职位上的招聘人员信息 响应体
/// <para>根据职位 ID 获取职位上的招聘人员信息，如招聘负责人、用人经理。</para>
/// <para>接口ID：7254447878126878748</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/recruiter</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2frecruiter</para>
/// </summary>
public record GetHireV1JobsByJobIdRecruiterResponseDto
{
    /// <summary>
    /// <para>职位负责人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("info")]
    public JobRecruiter2? Info { get; set; }

    /// <summary>
    /// <para>职位负责人</para>
    /// </summary>
    public record JobRecruiter2
    {
        /// <summary>
        /// <para>职位ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618209327096</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>招聘负责人ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_efk39117c300506837def50545420c6a</para>
        /// </summary>
        [JsonPropertyName("recruiter_id")]
        public string? RecruiterId { get; set; }

        /// <summary>
        /// <para>用人经理ID列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("hiring_manager_id_list")]
        public string[]? HiringManagerIdList { get; set; }

        /// <summary>
        /// <para>协助人ID列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("assistant_id_list")]
        public string[]? AssistantIdList { get; set; }
    }
}
