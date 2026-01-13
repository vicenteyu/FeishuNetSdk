// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-01-13
//
// Last Modified By : yxr
// Last Modified On : 2026-01-13
// ************************************************************************
// <copyright file="PostPerformanceV2UserInfoQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取绩效周期的人员信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取绩效周期的人员信息 响应体
/// <para>获取指定绩效周期下，被评估人在评估时的部门、序列、职级等人员信息。</para>
/// <para>接口ID：7477768482569650178</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/reviewee/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fuser_info%2fquery</para>
/// </summary>
public record PostPerformanceV2UserInfoQueryResponseDto
{
    /// <summary>
    /// <para>评估周期 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6992035450862224940</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string? SemesterId { get; set; }

    /// <summary>
    /// <para>人员的快照信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_infos")]
    public UserInfo[]? UserInfos { get; set; }

    /// <summary>
    /// <para>人员的快照信息列表</para>
    /// </summary>
    public record UserInfo
    {
        /// <summary>
        /// <para>人员的用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public User? UserId { get; set; }

        /// <summary>
        /// <para>人员的用户 ID</para>
        /// </summary>
        public record User
        {
            /// <summary>
            /// <para>用户的 open_id</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-asd2dasdasd</para>
            /// </summary>
            [JsonPropertyName("open_id")]
            public string? OpenId { get; set; }

            /// <summary>
            /// <para>用户的 user_id，取值与user_id_type一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou-ux987dsf6x</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }
        }

        /// <summary>
        /// <para>人员的直属上级的用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("direct_leader_user_id")]
        public User? DirectLeaderUserId { get; set; }

        /// <summary>
        /// <para>人员的部门</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department")]
        public UserInfoDepartment? Department { get; set; }

        /// <summary>
        /// <para>人员的部门</para>
        /// </summary>
        public record UserInfoDepartment
        {
            /// <summary>
            /// <para>部门 ID，与入参中的department_id_type类型一致，详情请查看：[获取单个部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>部门名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>部门名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：部门</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：department</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>人员的序列</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_family")]
        public UserInfoJobFamily? JobFamily { get; set; }

        /// <summary>
        /// <para>人员的序列</para>
        /// </summary>
        public record UserInfoJobFamily
        {
            /// <summary>
            /// <para>序列 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：mga5oa8ayjlp9rb</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>序列名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>序列名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：序列</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Job family</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>人员的职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_level")]
        public UserInfoJobLevel? JobLevel { get; set; }

        /// <summary>
        /// <para>人员的职级</para>
        /// </summary>
        public record UserInfoJobLevel
        {
            /// <summary>
            /// <para>职级 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：mga5oa81212312</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职级名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>职级名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：职级</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Job level</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }
    }
}
