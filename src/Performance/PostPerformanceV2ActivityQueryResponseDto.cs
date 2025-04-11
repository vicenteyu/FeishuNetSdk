// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-10-23
// ************************************************************************
// <copyright file="PostPerformanceV2ActivityQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取项目列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取项目列表 响应体
/// <para>批量获取项目的配置信息，如项目名称、项目模式等信息。</para>
/// <para>接口ID：7351374599659765764</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/activity/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2factivity%2fquery</para>
/// </summary>
public record PostPerformanceV2ActivityQueryResponseDto
{
    /// <summary>
    /// <para>项目列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("activities")]
    public Activity[]? Activities { get; set; }

    /// <summary>
    /// <para>项目列表</para>
    /// </summary>
    public record Activity
    {
        /// <summary>
        /// <para>项目 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7343513161666707459</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>项目名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>项目名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>项目中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：项目一</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>项目英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Activity 1</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>项目描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n? Description { get; set; }

        /// <summary>
        /// <para>周期 ID，详情可查看：[获取周期](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)</para>
        /// <para>必填：否</para>
        /// <para>示例值：7343513161666707459</para>
        /// </summary>
        [JsonPropertyName("semester_id")]
        public string? SemesterId { get; set; }

        /// <summary>
        /// <para>项目模式</para>
        /// <para>必填：否</para>
        /// <para>示例值：performance_review</para>
        /// <para>可选值：<list type="bullet">
        /// <item>metric_development：指标制定</item>
        /// <item>performance_review：绩效评估</item>
        /// <item>metric_development_and_performance_review：指标制定及绩效评估</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// <para>项目状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：configurable</para>
        /// <para>可选值：<list type="bullet">
        /// <item>configurable：待完成配置</item>
        /// <item>unable：未启动</item>
        /// <item>initiating：启动中</item>
        /// <item>enabled：已启动</item>
        /// <item>finished：已结束</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("progress")]
        public string? Progress { get; set; }

        /// <summary>
        /// <para>项目创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1691951256000</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>项目更新时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1691951256000</para>
        /// </summary>
        [JsonPropertyName("modify_time")]
        public string? ModifyTime { get; set; }

        /// <summary>
        /// <para>项目创建人 ID，与入参 `user_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：6924187793321444877</para>
        /// </summary>
        [JsonPropertyName("create_user_id")]
        public string? CreateUserId { get; set; }

        /// <summary>
        /// <para>项目更新人 ID，与入参 `user_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：6924187793321444877</para>
        /// </summary>
        [JsonPropertyName("modify_user_id")]
        public string? ModifyUserId { get; set; }
    }
}
