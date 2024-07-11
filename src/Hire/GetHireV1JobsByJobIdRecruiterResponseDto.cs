// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1JobsByJobIdRecruiterResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取职位上的招聘人员信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取职位上的招聘人员信息 响应体
/// <para>根据职位 ID 获取职位上的招聘人员信息，如招聘负责人、用人经理等。</para>
/// <para>接口ID：7254447878126878748</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/recruiter</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2frecruiter</para>
/// </summary>
public record GetHireV1JobsByJobIdRecruiterResponseDto
{
    /// <summary>
    /// <para>职位招聘人员信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("info")]
    public JobRecruiter2? Info { get; set; }

    /// <summary>
    /// <para>职位招聘人员信息</para>
    /// </summary>
    public record JobRecruiter2
    {
        /// <summary>
        /// <para>职位 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618209327096</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>招聘负责人 ID，与入参 `user_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_efk39117c300506837def50545420c6a</para>
        /// </summary>
        [JsonPropertyName("recruiter_id")]
        public string? RecruiterId { get; set; }

        /// <summary>
        /// <para>用人经理 ID 列表，与入参 `user_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("hiring_manager_id_list")]
        public string[]? HiringManagerIdList { get; set; }

        /// <summary>
        /// <para>协助人 ID 列表，与入参 `user_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("assistant_id_list")]
        public string[]? AssistantIdList { get; set; }
    }
}
