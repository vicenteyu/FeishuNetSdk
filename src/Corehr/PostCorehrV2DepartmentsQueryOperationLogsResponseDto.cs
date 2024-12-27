// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-27
//
// Last Modified By : yxr
// Last Modified On : 2024-12-27
// ************************************************************************
// <copyright file="PostCorehrV2DepartmentsQueryOperationLogsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询部门操作日志 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询部门操作日志 响应体
/// <para>批量查询指定时间范围内的部门操作日志</para>
/// <para>接口ID：7439765965024165889</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/query_operation_logs</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fquery_operation_logs</para>
/// </summary>
public record PostCorehrV2DepartmentsQueryOperationLogsResponseDto
{
    /// <summary>
    /// <para>操作日志列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("op_logs")]
    public OrganizationOpLog[]? OpLogs { get; set; }

    /// <summary>
    /// <para>操作日志列表</para>
    /// </summary>
    public record OrganizationOpLog
    {
        /// <summary>
        /// <para>部门ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7094136522860922111</para>
        /// </summary>
        [JsonPropertyName("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// <para>字段变化列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("changes")]
        public OperationLogEntityField[]? Changes { get; set; }

        /// <summary>
        /// <para>字段变化列表</para>
        /// </summary>
        public record OperationLogEntityField
        {
            /// <summary>
            /// <para>变更字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：description</para>
            /// </summary>
            [JsonPropertyName("field")]
            public string? Field { get; set; }

            /// <summary>
            /// <para>旧值</para>
            /// <para>必填：否</para>
            /// <para>示例值：old_description</para>
            /// </summary>
            [JsonPropertyName("before")]
            public string? Before { get; set; }

            /// <summary>
            /// <para>新值</para>
            /// <para>必填：否</para>
            /// <para>示例值：new_description</para>
            /// </summary>
            [JsonPropertyName("after")]
            public string? After { get; set; }
        }

        /// <summary>
        /// <para>操作人工号，更多详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：工号001</para>
        /// </summary>
        [JsonPropertyName("operator")]
        public string? Operator { get; set; }

        /// <summary>
        /// <para>操作类型。现有如下类型：</para>
        /// <para>- `10`：新建部门记录</para>
        /// <para>- `20`：新建/复制部门版本</para>
        /// <para>- `50`：编辑部门版本</para>
        /// <para>- `60`：撤销部门版本</para>
        /// <para>- `70`：停用部门</para>
        /// <para>- `80`：启用部门</para>
        /// <para>- `90`：删除部门记录</para>
        /// <para>- `100`：自定义部门排序</para>
        /// <para>- `110`：更新部门</para>
        /// <para>- `120`：编辑部门关联规则</para>
        /// <para>- `130`：新增授权</para>
        /// <para>- `140`：更正授权</para>
        /// <para>- `150`：撤销授权</para>
        /// <para>- `160`：混合授权</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("operation_type")]
        public int? OperationType { get; set; }

        /// <summary>
        /// <para>操作时间，带时分秒。示例值：2023-11-15 19:25:45</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-11-15 19:25:45</para>
        /// </summary>
        [JsonPropertyName("operation_time")]
        public string? OperationTime { get; set; }

        /// <summary>
        /// <para>操作生效时间，表示被操作的部门版本的生效日期。示例值：2023-10-28</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-10-28</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string? EffectiveTime { get; set; }

        /// <summary>
        /// <para>操作原因说明</para>
        /// <para>必填：否</para>
        /// <para>示例值：因人员调整,变更部门负责人为某某</para>
        /// </summary>
        [JsonPropertyName("operation_reason")]
        public string? OperationReason { get; set; }

        /// <summary>
        /// <para>调整原因列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("change_reasons")]
        public string[]? ChangeReasons { get; set; }
    }

    /// <summary>
    /// <para>下一页token</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// </summary>
    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
