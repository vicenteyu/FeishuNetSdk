// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="DriveFileBitableRecordChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>多维表格记录变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Events;
/// <summary>
/// 多维表格记录变更 事件体
/// <para>多维表格记录变更事件。被订阅的多维表格记录发生变更时，将会触发此事件。了解事件订阅的配置流程和使用场景，参考[事件概述](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM)。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=drive&amp;version=v1&amp;resource=file&amp;event=bitable_record_changed)</para>
/// <para>接口ID：7374619918313455620</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/events/bitable_record_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fevents%2fbitable_record_changed</para>
/// </summary>
public record DriveFileBitableRecordChangedV1EventBodyDto() : EventBodyDto("drive.file.bitable_record_changed_v1")
{
    /// <summary>
    /// <para>文件类型，即 bitable</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file_type")]
    public string? FileType { get; set; }

    /// <summary>
    /// <para>多维表格 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string? FileToken { get; set; }

    /// <summary>
    /// <para>发生变更的数据表 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("table_id")]
    public string? TableId { get; set; }

    /// <summary>
    /// <para>多维表格数据表的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>操作人 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }

    /// <summary>
    /// <para>行变更操作列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("action_list")]
    public BitableTableRecordAction[]? ActionList { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record BitableTableRecordAction
    {
        /// <summary>
        /// <para>发生变更的记录 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("record_id")]
        public string? RecordId { get; set; }

        /// <summary>
        /// <para>支持的记录变更类型。枚举值有：</para>
        /// <para>- record_added：新增行记录</para>
        /// <para>- record_deleted：删除行记录</para>
        /// <para>- record_edited：修改行记录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// <para>发生变更前的记录值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("before_value")]
        public BitableTableRecordActionField[]? BeforeValue { get; set; }

        /// <summary>
        /// <para>发生变更后的字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("after_value")]
        public BitableTableRecordActionField[]? AfterValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record BitableTableRecordActionField
        {
            /// <summary>
            /// <para>发生变更的字段 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("field_id")]
            public string? FieldId { get; set; }

            /// <summary>
            /// <para>发生变更前的字段值。该字段为 JSON 序列化后的字符串，序列化前的结构请参考 [数据结构](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/development-guide/bitable-structure)。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("field_value")]
            public string? FieldValue { get; set; }

            /// <summary>
            /// <para>人员字段补充信息。有人员、创建人、修改人类型字段变更时返回</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("field_identity_value")]
            public BitableTableRecordActionFieldIdentity? FieldIdentityValue { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public record BitableTableRecordActionFieldIdentity
            {
                /// <summary>
                /// <para>用户列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("users")]
                public BitableTableRecordActionFieldIdentityUser[]? Users { get; set; }

                /// <summary>
                /// 
                /// </summary>
                public record BitableTableRecordActionFieldIdentityUser
                {
                    /// <summary>
                    /// <para>用户的 User ID</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("user_id")]
                    public UserIdSuffix? UserId { get; set; }

                    /// <summary>
                    /// <para>用户名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>用户英文名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("en_name")]
                    public string? EnName { get; set; }

                    /// <summary>
                    /// <para>用户头像 URL</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("avatar_url")]
                    public string? AvatarUrl { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>订阅的用户列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("subscriber_id_list")]
    public UserIdSuffix[]? SubscriberIdList { get; set; }

    /// <summary>
    /// <para>编辑时间（格式：时间戳；单位：秒）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("update_time")]
    public int? UpdateTime { get; set; }
}
