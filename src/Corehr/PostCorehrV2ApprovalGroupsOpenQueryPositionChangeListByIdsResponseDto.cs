// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-11
//
// Last Modified By : yxr
// Last Modified On : 2025-10-11
// ************************************************************************
// <copyright file="PostCorehrV2ApprovalGroupsOpenQueryPositionChangeListByIdsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询岗位调整内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询岗位调整内容 响应体
/// <para>根据岗位调整记录 ID 批量查询岗位调整内容</para>
/// <para>接口ID：7428890785897234433</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/open_query_position_change_list_by_ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fopen_query_position_change_list_by_ids</para>
/// </summary>
public record PostCorehrV2ApprovalGroupsOpenQueryPositionChangeListByIdsResponseDto
{
    /// <summary>
    /// <para>岗位调整记录信息列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("position_changes")]
    public PositionChange[]? PositionChanges { get; set; }

    /// <summary>
    /// <para>岗位调整记录信息列表</para>
    /// </summary>
    public record PositionChange
    {
        /// <summary>
        /// <para>关联的岗位调整记录 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6991776076699549697</para>
        /// </summary>
        [JsonPropertyName("position_change_id")]
        public string? PositionChangeId { get; set; }

        /// <summary>
        /// <para>岗位 ID。对于在本次调整中新建的岗位，在调整未生效时将返回为空</para>
        /// <para>必填：否</para>
        /// <para>示例值：6966236933198579208</para>
        /// </summary>
        [JsonPropertyName("position_id")]
        public string? PositionId { get; set; }

        /// <summary>
        /// <para>调整过程岗位 ID 。对于在本次调整中新建的岗位，在调整未生效前会返回格式为 td_xxx 的过程岗位 ID，生效后将返回正式的岗位 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6966236933198579208</para>
        /// </summary>
        [JsonPropertyName("draft_position_id")]
        public string? DraftPositionId { get; set; }

        /// <summary>
        /// <para>调整类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：Create</para>
        /// <para>可选值：<list type="bullet">
        /// <item>Unknown：未知</item>
        /// <item>Create：新建</item>
        /// <item>Modify：编辑</item>
        /// <item>Inactive：停用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("position_change_type")]
        public string? PositionChangeType { get; set; }

        /// <summary>
        /// <para>调整详细信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("position_adjustment_info")]
        public PositionChangePositionAdjustmentInfo? PositionAdjustmentInfo { get; set; }

        /// <summary>
        /// <para>调整详细信息</para>
        /// </summary>
        public record PositionChangePositionAdjustmentInfo
        {
            /// <summary>
            /// <para>原序列 ID 列表，可通过[【批量查询序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)获取详情</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("original_job_families")]
            public string[]? OriginalJobFamilies { get; set; }

            /// <summary>
            /// <para>调整后序列 ID 列表，可通过[【批量查询序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)获取详情</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("target_job_families")]
            public string[]? TargetJobFamilies { get; set; }

            /// <summary>
            /// <para>原所属部门 ID，可通过[【批量查询部门V2】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get) 或者[【搜索部门信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search) 获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("original_department")]
            public string? OriginalDepartment { get; set; }

            /// <summary>
            /// <para>调整后所属部门 ID，如果是一个已存在的部门， 则会使用其飞书人事部门 ID 作为调整记录 ID，可通过[【批量查询部门V2】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get) 或者[【搜索部门信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search) 获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("target_department")]
            public string? TargetDepartment { get; set; }

            /// <summary>
            /// <para>调整后所属部门临时 ID，为避免一个没有经过审批的组织架构调整影响正在运行的系统，如果是在组织架构调整中新生成的『部门』，会返回一个临时 ID，格式为 "td_xxx"</para>
            /// <para>可通过[【批量查询部门调整内容】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/open_query_department_change_list_by_ids)获取详情，ID 类型需要为 ==people_corehr_department_id==</para>
            /// <para>必填：否</para>
            /// <para>示例值：td_704442734715974602312</para>
            /// </summary>
            [JsonPropertyName("target_draft_department")]
            public string? TargetDraftDepartment { get; set; }

            /// <summary>
            /// <para>原岗位默认成本中心 ID，可以通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("original_cost_center")]
            public string? OriginalCostCenter { get; set; }

            /// <summary>
            /// <para>调整后岗位默认成本中心 ID，可以通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("target_cost_center")]
            public string? TargetCostCenter { get; set; }

            /// <summary>
            /// <para>原工时制度 ID，枚举值及详细信息可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)接口查询获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("original_working_hours_type")]
            public string? OriginalWorkingHoursType { get; set; }

            /// <summary>
            /// <para>调整后工时制度 ID，枚举值及详细信息可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)接口查询获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("target_working_hours_type")]
            public string? TargetWorkingHoursType { get; set; }

            /// <summary>
            /// <para>原职务 ID，可通过[【查询单个职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/get)获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("original_job")]
            public string? OriginalJob { get; set; }

            /// <summary>
            /// <para>调整后职务 ID，可通过[【查询单个职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/get)获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("target_job")]
            public string? TargetJob { get; set; }

            /// <summary>
            /// <para>原是否关键岗位</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("original_is_key_position")]
            public bool? OriginalIsKeyPosition { get; set; }

            /// <summary>
            /// <para>调整后是否关键岗位</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("target_is_key_position")]
            public bool? TargetIsKeyPosition { get; set; }

            /// <summary>
            /// <para>原人员类型 ID 列表，可通过[【查询人员类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)获取详情</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("original_employee_types")]
            public string[]? OriginalEmployeeTypes { get; set; }

            /// <summary>
            /// <para>调整后人员类型 ID 列表，可通过[【查询人员类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)获取详情</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("target_employee_types")]
            public string[]? TargetEmployeeTypes { get; set; }

            /// <summary>
            /// <para>原名称</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("original_names")]
            public I18n[]? OriginalNames { get; set; }

            /// <summary>
            /// <para>原名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言编码（IETF BCP 47）</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>文本内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：中文示例</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>调整后名称</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("target_names")]
            public I18n[]? TargetNames { get; set; }

            /// <summary>
            /// <para>原职等 ID 列表，可通过[【查询职等信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)获取详情</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("original_job_grades")]
            public string[]? OriginalJobGrades { get; set; }

            /// <summary>
            /// <para>调整后职等 ID 列表，可通过[【查询职等信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)获取详情</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("target_job_grades")]
            public string[]? TargetJobGrades { get; set; }

            /// <summary>
            /// <para>原编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：P00000456</para>
            /// </summary>
            [JsonPropertyName("original_code")]
            public string? OriginalCode { get; set; }

            /// <summary>
            /// <para>调整后编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：P00000456</para>
            /// </summary>
            [JsonPropertyName("target_code")]
            public string? TargetCode { get; set; }

            /// <summary>
            /// <para>原职级 ID 列表，可通过[【通过职级 ID 批量获取职级信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get)获取详情</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("original_job_levels")]
            public string[]? OriginalJobLevels { get; set; }

            /// <summary>
            /// <para>调整后职级 ID 列表，可通过[【通过职级 ID 批量获取职级信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get)获取详情</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("target_job_levels")]
            public string[]? TargetJobLevels { get; set; }

            /// <summary>
            /// <para>原状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("original_active")]
            public bool? OriginalActive { get; set; }

            /// <summary>
            /// <para>调整后状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("target_active")]
            public bool? TargetActive { get; set; }

            /// <summary>
            /// <para>原直线上级（岗位） ID，可通过[【查询岗位信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/position/query)获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("original_direct_leader")]
            public string? OriginalDirectLeader { get; set; }

            /// <summary>
            /// <para>调整后直线上级（岗位） ID，如果是一个已存在的岗位，可通过[【查询岗位信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/position/query)获取详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("target_direct_leader")]
            public string? TargetDirectLeader { get; set; }

            /// <summary>
            /// <para>调整后直线上级（岗位） ID，对于在本次调整中新建的岗位，在调整未生效前会返回格式为 td_xxx 的过程岗位 ID，生效后将返回正式的岗位ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("target_draft_direct_leader")]
            public string? TargetDraftDirectLeader { get; set; }

            /// <summary>
            /// <para>原工作地点 ID 列表，可通过[【通过地点 ID 批量获取地点信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/location/batch_get)接口获取详情</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("original_work_locations")]
            public string[]? OriginalWorkLocations { get; set; }

            /// <summary>
            /// <para>调整后工作地点 ID 列表，可通过[【通过地点 ID 批量获取地点信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/location/batch_get)接口获取详情</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("target_work_locations")]
            public string[]? TargetWorkLocations { get; set; }

            /// <summary>
            /// <para>原描述</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("original_descriptions")]
            public I18n[]? OriginalDescriptions { get; set; }

            /// <summary>
            /// <para>调整后描述</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("target_descriptions")]
            public I18n[]? TargetDescriptions { get; set; }

            /// <summary>
            /// <para>原部门全路径，从根部门开始自上而下返回部门 ID 列表, 主要用于 API 场景， 没有审批完成前获取部门路径用于计算</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("original_department_id_paths")]
            public OrgdraftDepartmentId[]? OriginalDepartmentIdPaths { get; set; }

            /// <summary>
            /// <para>原部门全路径，从根部门开始自上而下返回部门 ID 列表, 主要用于 API 场景， 没有审批完成前获取部门路径用于计算</para>
            /// </summary>
            public record OrgdraftDepartmentId
            {
                /// <summary>
                /// <para>部门 ID ，对于在本次调整中新建的部门，在调整未生效时将返回为空。支持根据部门 ID 类型转换</para>
                /// <para>必填：否</para>
                /// <para>示例值：6974659700705068581</para>
                /// </summary>
                [JsonPropertyName("department_id")]
                public string? DepartmentId { get; set; }

                /// <summary>
                /// <para>调整过程部门 ID ，固定返回people_corehr_department_id，不会根据部门 ID 类型进行转换。对于在本次调整中新建的部门，在调整未生效前会返回格式为 td_xxx 的过程部门 ID，生效后将返回正式的people_corehr_department_id</para>
                /// <para>必填：否</para>
                /// <para>示例值：6974659700705068581</para>
                /// </summary>
                [JsonPropertyName("draft_department_id")]
                public string? DraftDepartmentId { get; set; }
            }

            /// <summary>
            /// <para>调整后部门全路径，从根部门开始自上而下返回部门 ID 列表</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("target_department_id_paths")]
            public OrgdraftDepartmentId[]? TargetDepartmentIdPaths { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ChangeFieldPair[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ChangeFieldPair
            {
                /// <summary>
                /// <para>调整前</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("origin_value")]
                public CustomFieldData? OriginValue { get; set; }

                /// <summary>
                /// <para>调整前</para>
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
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
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
                    /// <para>自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同。如：```("\"123\"", "\"123.23\"", "\"true\"", [\"id1\",\"id2\"], \"2006-01-02 15:04:05\")```</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>调整后</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("target_value")]
                public CustomFieldData? TargetValue { get; set; }
            }
        }
    }
}
