// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="PostPerformanceV2UserGroupUserRelsWriteResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新人员组成员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 更新人员组成员 响应体
/// <para>更新指定人员组成员。</para>
/// <para>接口ID：7381506957100875778</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/user_group_user_rel/write</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fuser_group_user_rel%2fwrite</para>
/// </summary>
public record PostPerformanceV2UserGroupUserRelsWriteResponseDto
{
    /// <summary>
    /// <para>更新结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("data")]
    public WriteUserGroupScopeData? Data { get; set; }

    /// <summary>
    /// <para>更新结果</para>
    /// </summary>
    public record WriteUserGroupScopeData
    {
        /// <summary>
        /// <para>更新成功的员工 ID 列表，与入参 `user_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("success_user_ids")]
        public string[]? SuccessUserIds { get; set; }

        /// <summary>
        /// <para>更新失败的员工信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("fail_user_datas")]
        public WriteUserGroupScopeFailUserData[]? FailUserDatas { get; set; }

        /// <summary>
        /// <para>更新失败的员工信息</para>
        /// </summary>
        public record WriteUserGroupScopeFailUserData
        {
            /// <summary>
            /// <para>员工 ID，与入参 `user_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_ff77dba046431fc53ea21a0095df82f4</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>失败原因枚举</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：10</para>
            /// <para>最小值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：员工未找到</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("fail_code")]
            public int? FailCode { get; set; }
        }
    }
}
