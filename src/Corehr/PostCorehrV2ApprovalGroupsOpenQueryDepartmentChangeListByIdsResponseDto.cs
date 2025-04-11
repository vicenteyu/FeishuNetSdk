// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-22
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostCorehrV2ApprovalGroupsOpenQueryDepartmentChangeListByIdsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询部门调整内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询部门调整内容 响应体
/// <para>根据部门调整记录 ID 批量查询部门调整内容</para>
/// <para>接口ID：7317581509003771908</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/open_query_department_change_list_by_ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fopen_query_department_change_list_by_ids</para>
/// </summary>
public record PostCorehrV2ApprovalGroupsOpenQueryDepartmentChangeListByIdsResponseDto
{
    /// <summary>
    /// <para>部门调整记录信息列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：6893014062142064111</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("department_changes")]
    public DepartmentChange[]? DepartmentChanges { get; set; }

    /// <summary>
    /// <para>部门调整记录信息列表</para>
    /// </summary>
    public record DepartmentChange
    {
        /// <summary>
        /// <para>关联的部门调整记录 ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6991776076699549697</para>
        /// </summary>
        [JsonPropertyName("department_change_id")]
        public string? DepartmentChangeId { get; set; }

        /// <summary>
        /// <para>部门 ID，对于在本次调整中新建的部门，在调整未生效时将返回为空。支持根据部门 ID 类型转换。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6966236933198579208</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>调整过程部门 ID 。固定返回people_corehr_department_id，不会根据部门 ID 类型进行转换。对于在本次调整中新建的部门，在调整未生效前会返回格式为 td_xxx 的过程部门 ID，生效后将返回正式的people_corehr_department_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6966236933198579208</para>
        /// </summary>
        [JsonPropertyName("draft_department_id")]
        public string? DraftDepartmentId { get; set; }

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
        [JsonPropertyName("department_change_type")]
        public string? DepartmentChangeType { get; set; }

        /// <summary>
        /// <para>调整状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：发起审批，流程成功发起，并等待审批人审批。</item>
        /// <item>1：审批通过。</item>
        /// <item>2：审批被拒绝，审批未通过。</item>
        /// <item>3：审批被撤销，用户主动撤销审批，调整会进入已撤销状态。</item>
        /// <item>4：执行成功，调整已经执行成功。</item>
        /// <item>5：执行失败，调整已经执行失败。</item>
        /// <item>6：待执行，调整依赖其他流程完成，等待执行。</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("department_change_status")]
        public int? DepartmentChangeStatus { get; set; }

        /// <summary>
        /// <para>调整详细信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reorganization_info")]
        public DepartmentChangeReorganizationInfo? ReorganizationInfo { get; set; }

        /// <summary>
        /// <para>调整详细信息</para>
        /// </summary>
        public record DepartmentChangeReorganizationInfo
        {
            /// <summary>
            /// <para>原部门名称</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("original_department_names")]
            public I18n[]? OriginalDepartmentNames { get; set; }

            /// <summary>
            /// <para>原部门名称</para>
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
            /// <para>调整后部门名称</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("target_department_names")]
            public I18n[]? TargetDepartmentNames { get; set; }

            /// <summary>
            /// <para>原部门编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：D00000456</para>
            /// </summary>
            [JsonPropertyName("original_department_code")]
            public string? OriginalDepartmentCode { get; set; }

            /// <summary>
            /// <para>调整后部门编码， 在新建部门场景下， 如果租户开通部门自动编码，该编码会为空值。</para>
            /// <para>必填：否</para>
            /// <para>示例值：D00000456</para>
            /// </summary>
            [JsonPropertyName("target_department_code")]
            public string? TargetDepartmentCode { get; set; }

            /// <summary>
            /// <para>原部门类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)部门子类型（department_sub_type）枚举定义部分获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("original_sub_type")]
            public Enum? OriginalSubType { get; set; }

            /// <summary>
            /// <para>原部门类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)部门子类型（department_sub_type）枚举定义部分获得</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>枚举值</para>
                /// <para>必填：是</para>
                /// <para>示例值：department</para>
                /// </summary>
                [JsonPropertyName("enum_name")]
                public string EnumName { get; set; } = string.Empty;

                /// <summary>
                /// <para>枚举多语展示</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("display")]
                public I18n[]? Displies { get; set; }

                /// <summary>
                /// <para>枚举多语展示</para>
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
            }

            /// <summary>
            /// <para>调整后部门类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)部门子类型（department_sub_type）枚举定义部分获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("target_sub_type")]
            public Enum? TargetSubType { get; set; }

            /// <summary>
            /// <para>原部门负责人，详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974648866876573198</para>
            /// </summary>
            [JsonPropertyName("original_department_manager")]
            public string? OriginalDepartmentManager { get; set; }

            /// <summary>
            /// <para>调整后部门负责人， 详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：7013328578351842852</para>
            /// </summary>
            [JsonPropertyName("target_department_manager")]
            public string? TargetDepartmentManager { get; set; }

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
            /// <para>原默认成本中心</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("original_cost_center")]
            public CostCenter? OriginalCostCenter { get; set; }

            /// <summary>
            /// <para>原默认成本中心</para>
            /// </summary>
            public record CostCenter
            {
                /// <summary>
                /// <para>成本中心ID，可以通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口获取对应的成本中心信息</para>
                /// <para>必填：否</para>
                /// <para>示例值：6969828847121885087</para>
                /// </summary>
                [JsonPropertyName("cost_center_id")]
                public string? CostCenterId { get; set; }

                /// <summary>
                /// <para>成本中心名称</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n[] Names { get; set; } = Array.Empty<I18n>();

                /// <summary>
                /// <para>成本中心名称</para>
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
                /// <para>编码， 成本中心编码</para>
                /// <para>必填：否</para>
                /// <para>示例值：MDPD00000023</para>
                /// </summary>
                [JsonPropertyName("code")]
                public string? Code { get; set; }

                /// <summary>
                /// <para>上级成本中心ID，可以通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口获取对应的成本中心信息</para>
                /// <para>必填：否</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("parent_cost_center_id")]
                public string? ParentCostCenterId { get; set; }

                /// <summary>
                /// <para>成本中心负责人ID 列表，详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("managers")]
                public string[]? Managers { get; set; }

                /// <summary>
                /// <para>成本中心描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("description")]
                public I18n[]? Descriptions { get; set; }

                /// <summary>
                /// <para>生效时间</para>
                /// <para>- 日期格式： YYYY-MM-DD</para>
                /// <para>- 最小值： 1900-01-01</para>
                /// <para>- 最大值：9999-12-31</para>
                /// <para>必填：是</para>
                /// <para>示例值：2020-01-01</para>
                /// </summary>
                [JsonPropertyName("effective_time")]
                public string EffectiveTime { get; set; } = string.Empty;

                /// <summary>
                /// <para>过期时间</para>
                /// <para>- 日期格式： YYYY-MM-DD</para>
                /// <para>- 最小值： 1900-01-01</para>
                /// <para>- 最大值：9999-12-31</para>
                /// <para>必填：否</para>
                /// <para>示例值：2020-01-01</para>
                /// </summary>
                [JsonPropertyName("expiration_time")]
                public string? ExpirationTime { get; set; }

                /// <summary>
                /// <para>当前实体是否启用</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("active")]
                public bool? Active { get; set; }

                /// <summary>
                /// <para>操作原因</para>
                /// <para>必填：否</para>
                /// <para>示例值：过期作废</para>
                /// </summary>
                [JsonPropertyName("operation_reason")]
                public string? OperationReason { get; set; }
            }

            /// <summary>
            /// <para>调整后默认成本中心</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("target_cost_center")]
            public CostCenter? TargetCostCenter { get; set; }

            /// <summary>
            /// <para>原是否保密</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("original_is_confidential")]
            public bool? OriginalIsConfidential { get; set; }

            /// <summary>
            /// <para>调整后是否保密</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("target_is_confidential")]
            public bool? TargetIsConfidential { get; set; }

            /// <summary>
            /// <para>原岗职模式</para>
            /// <para>- 可通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。请求参数：object_api_name=department；custom_api_name=staffing_model。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("original_staffing_mode_option")]
            public Enum? OriginalStaffingModeOption { get; set; }

            /// <summary>
            /// <para>调整后岗职模式</para>
            /// <para>- 可通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。请求参数：object_api_name=department；custom_api_name=staffing_model。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("target_staffing_mode_option")]
            public Enum? TargetStaffingModeOption { get; set; }

            /// <summary>
            /// <para>原上级部门 ID，支持根据部门 ID 类型转换</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("original_parent_department_id")]
            public string? OriginalParentDepartmentId { get; set; }

            /// <summary>
            /// <para>调整后上级部门 ID，对于在本次调整中新建的部门，在调整未生效时将返回为空。支持根据部门 ID 类型转换。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("target_parent_department_id")]
            public string? TargetParentDepartmentId { get; set; }

            /// <summary>
            /// <para>调整后上级部门过程 ID 。固定返回people_corehr_department_id，不会根据部门 ID 类型进行转换。对于在本次调整中新建的部门，在调整未生效前会返回格式为 td_xxx 的过程部门 ID，生效后将返回正式的people_corehr_department_id</para>
            /// <para>必填：否</para>
            /// <para>示例值：6966236933198579208</para>
            /// </summary>
            [JsonPropertyName("draft_target_parent_department_id")]
            public string? DraftTargetParentDepartmentId { get; set; }

            /// <summary>
            /// <para>原部门全路径，从根部门开始自上而下返回部门 ID 列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("original_department_id_path")]
            public OrgdraftDepartmentId[]? OriginalDepartmentIdPaths { get; set; }

            /// <summary>
            /// <para>原部门全路径，从根部门开始自上而下返回部门 ID 列表</para>
            /// </summary>
            public record OrgdraftDepartmentId
            {
                /// <summary>
                /// <para>部门 ID ，对于在本次调整中新建的部门，在调整未生效时将返回为空。支持根据部门 ID 类型转换。</para>
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
            /// </summary>
            [JsonPropertyName("target_department_id_path")]
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
                    /// <para>示例值：```"\"231\""```</para>
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
