// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="GetHireV1JobsByJobIdGetDetailResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取职位详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取职位详情 响应体
/// <para>根据职位 ID 获取职位详情，包含职位基本信息、职位负责人、协助人、用人经理、职位地址列表、职位设置、关联招需、门店列表及标签列表等信息。</para>
/// <para>接口ID：7397677441935884289</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/job/get_detail</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fget_detail</para>
/// </summary>
public record GetHireV1JobsByJobIdGetDetailResponseDto
{
    /// <summary>
    /// <para>职位详情数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_detail")]
    public GetHireV1JobsByJobIdGetDetailResponseDtoJobDetail? JobDetail { get; set; }

    /// <summary>
    /// <para>职位详情数据</para>
    /// </summary>
    public record GetHireV1JobsByJobIdGetDetailResponseDtoJobDetail
    {
        /// <summary>
        /// <para>职位基本信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("basic_info")]
        public JobDetailBasicInfo? BasicInfo { get; set; }

        /// <summary>
        /// <para>职位基本信息</para>
        /// </summary>
        public record JobDetailBasicInfo
        {
            /// <summary>
            /// <para>职位 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7395082456917805339</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职位名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试职位</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>职位描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：这是一个测试职位，仅仅用来测试。</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>职位编号</para>
            /// <para>必填：否</para>
            /// <para>示例值：R18</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>职位要求</para>
            /// <para>必填：否</para>
            /// <para>示例值：职位要求文本</para>
            /// </summary>
            [JsonPropertyName("requirement")]
            public string? Requirement { get; set; }

            /// <summary>
            /// <para>职位雇佣类型，详情请查看：[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)中职位性质/雇佣类型（recruitment_type）枚举定义」</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("recruitment_type")]
            public JobDetailRecruitmentType? RecruitmentType { get; set; }

            /// <summary>
            /// <para>职位雇佣类型，详情请查看：[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)中职位性质/雇佣类型（recruitment_type）枚举定义」</para>
            /// </summary>
            public record JobDetailRecruitmentType
            {
                /// <summary>
                /// <para>雇佣类型 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7395082456917805339</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>雇佣类型名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>雇佣类型名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>雇佣类型中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：全职</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>雇佣类型英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Full-time</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>雇佣类型启用状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：启用</item>
                /// <item>2：未启用</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("active_status")]
                public int? ActiveStatus { get; set; }
            }

            /// <summary>
            /// <para>职位部门</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department")]
            public JobDetailDepartment? Department { get; set; }

            /// <summary>
            /// <para>职位部门</para>
            /// </summary>
            public record JobDetailDepartment
            {
                /// <summary>
                /// <para>部门 ID，与入参中的`department_id_type`类型一致，详情请查看：[获取单个部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/get)</para>
                /// <para>必填：否</para>
                /// <para>示例值：7395082456917805339</para>
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
                    /// <para>部门中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：飞书</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>部门英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Lark</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>最低职级</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("min_job_level")]
            public JobDetailLevel? MinJobLevel { get; set; }

            /// <summary>
            /// <para>最低职级</para>
            /// </summary>
            public record JobDetailLevel
            {
                /// <summary>
                /// <para>职级 ID，与入参`job_level_id_type` 类型一致</para>
                /// <para>必填：否</para>
                /// <para>示例值：6890840777044265230</para>
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
                    /// <para>职级中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：级别-2</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>职级英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：level-2</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>职级启用状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：启用</item>
                /// <item>2：未启用</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("active_status")]
                public int? ActiveStatus { get; set; }
            }

            /// <summary>
            /// <para>最高职级</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("max_job_level")]
            public JobDetailLevel? MaxJobLevel { get; set; }

            /// <summary>
            /// <para>职位亮点</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("highlight_list")]
            public JobDetailHighlight[]? HighlightLists { get; set; }

            /// <summary>
            /// <para>职位亮点</para>
            /// </summary>
            public record JobDetailHighlight
            {
                /// <summary>
                /// <para>职位亮点 ID，详情请查看：[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)中「职位亮点枚举定义」</para>
                /// <para>必填：否</para>
                /// <para>示例值：7395082456917805339</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>职位亮点名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>职位亮点名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>职位亮点中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：高薪资</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>职位亮点英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：high salary</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>职位序列</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_category")]
            public JobDetailCategory? JobCategory { get; set; }

            /// <summary>
            /// <para>职位序列</para>
            /// </summary>
            public record JobDetailCategory
            {
                /// <summary>
                /// <para>职位序列 ID，与入参`job_family_id_type` 类型一致</para>
                /// <para>必填：否</para>
                /// <para>示例值：7395082456917805339</para>
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
                    /// <para>职位序列中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：研发序列</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>职位序列英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：RD</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>职位序列启用状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：启用</item>
                /// <item>2：未启用</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("active_status")]
                public int? ActiveStatus { get; set; }
            }

            /// <summary>
            /// <para>职位类别</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_type")]
            public JobDetailType? JobType { get; set; }

            /// <summary>
            /// <para>职位类别</para>
            /// </summary>
            public record JobDetailType
            {
                /// <summary>
                /// <para>职位类别 ID，详情请查看：[获取职位类别列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_type/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：6890840777044265230</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>职位类别名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>职位类别名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>职位类别中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：金融</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>职位类别英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Finance</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>启用状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：启用</item>
            /// <item>2：未启用</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("active_status")]
            public int? ActiveStatus { get; set; }

            /// <summary>
            /// <para>创建人ID，与入参`user_id_type`类型一致，若为空则为系统或其他对接系统创建</para>
            /// <para>必填：否</para>
            /// <para>示例值：7395082456917805339</para>
            /// </summary>
            [JsonPropertyName("creator_id")]
            public string? CreatorId { get; set; }

            /// <summary>
            /// <para>创建时间，毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1617170925462</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>更新时间，毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1617170925462</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public string? UpdateTime { get; set; }

            /// <summary>
            /// <para>职位流程类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：社招流程</item>
            /// <item>2：校招流程</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("process_type")]
            public int? ProcessType { get; set; }

            /// <summary>
            /// <para>职位流程 ID，详情请查看：[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("process_id")]
            public string? ProcessId { get; set; }

            /// <summary>
            /// <para>职位流程名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("process_name")]
            public I18n? ProcessName { get; set; }

            /// <summary>
            /// <para>职位流程名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>职位流程中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：社招流程</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>职位流程英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Social process</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>自定义字段列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("customized_data_list")]
            public JobCustomizedData[]? CustomizedDataLists { get; set; }

            /// <summary>
            /// <para>自定义字段列表</para>
            /// </summary>
            public record JobCustomizedData
            {
                /// <summary>
                /// <para>自定义字段 ID，详情请查看：[获取职位模板](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_schema/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：6949805467799537964</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>字段名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>字段名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>字段中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：集团化</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>字段英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：JiTuanHua</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>字段类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：单行文本</item>
                /// <item>2：多行文本</item>
                /// <item>3：单选</item>
                /// <item>4：多选</item>
                /// <item>5：日期</item>
                /// <item>6：月份选择</item>
                /// <item>7：年份选择</item>
                /// <item>8：时间段</item>
                /// <item>9：数字</item>
                /// <item>10：默认字段</item>
                /// <item>11：模块</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("object_type")]
                public int? ObjectType { get; set; }

                /// <summary>
                /// <para>自定义字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("value")]
                public JobCustomizedValue? Value { get; set; }

                /// <summary>
                /// <para>自定义字段值</para>
                /// </summary>
                public record JobCustomizedValue
                {
                    /// <summary>
                    /// <para>当字段类型为单行文本、多行文本、模块、默认字段时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：集团化使用字段</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string? Content { get; set; }

                    /// <summary>
                    /// <para>当字段类型为单选时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("option")]
                    public JobCustomizedOption? Option { get; set; }

                    /// <summary>
                    /// <para>当字段类型为单选时，从此字段取值</para>
                    /// </summary>
                    public record JobCustomizedOption
                    {
                        /// <summary>
                        /// <para>选项 ID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：AA</para>
                        /// </summary>
                        [JsonPropertyName("key")]
                        public string? Key { get; set; }

                        /// <summary>
                        /// <para>选项名称</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("name")]
                        public I18n? Name { get; set; }

                        /// <summary>
                        /// <para>选项名称</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>选项中文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：选项A</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>选项英文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：选项A</para>
                            /// </summary>
                            [JsonPropertyName("en_us")]
                            public string? EnUs { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>当字段类型为多选时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("option_list")]
                    public JobCustomizedOption[]? OptionLists { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("time_range")]
                    public JobCustomizedTimeRange? TimeRange { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// </summary>
                    public record JobCustomizedTimeRange
                    {
                        /// <summary>
                        /// <para>开始时间，毫秒时间戳</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1721976368000</para>
                        /// </summary>
                        [JsonPropertyName("start_time")]
                        public string? StartTime { get; set; }

                        /// <summary>
                        /// <para>结束时间，毫秒时间戳</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1721976368000</para>
                        /// </summary>
                        [JsonPropertyName("end_time")]
                        public string? EndTime { get; set; }
                    }

                    /// <summary>
                    /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是毫秒时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721000</para>
                    /// </summary>
                    [JsonPropertyName("time")]
                    public string? Time { get; set; }

                    /// <summary>
                    /// <para>当字段类型为数字时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：111</para>
                    /// </summary>
                    [JsonPropertyName("number")]
                    public string? Number { get; set; }
                }
            }

            /// <summary>
            /// <para>职能分类</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_function")]
            public IdNameObject? JobFunction { get; set; }

            /// <summary>
            /// <para>职能分类</para>
            /// </summary>
            public record IdNameObject
            {
                /// <summary>
                /// <para>职能分类 ID，详情请参考：[获取职能分类列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_function/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：7392444731470563625</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>职能分类名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>职能分类名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>职能分类中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：分类1</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>职能分类英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：function 1</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>职位项目</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("subject")]
            public IdNameObject? Subject { get; set; }

            /// <summary>
            /// <para>招聘数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("head_count")]
            public int? HeadCount { get; set; }

            /// <summary>
            /// <para>工作年限</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：不限</item>
            /// <item>2：应届毕业生</item>
            /// <item>3：1年以下</item>
            /// <item>4：1-3年</item>
            /// <item>5：3-5年</item>
            /// <item>6：5-7年</item>
            /// <item>7：7-10年</item>
            /// <item>8：10年以上</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("experience")]
            public int? Experience { get; set; }

            /// <summary>
            /// <para>到期日期，毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1622484739955</para>
            /// </summary>
            [JsonPropertyName("expiry_time")]
            public string? ExpiryTime { get; set; }

            /// <summary>
            /// <para>月薪范围-最低薪资，单位：千</para>
            /// <para>必填：否</para>
            /// <para>示例值：10</para>
            /// </summary>
            [JsonPropertyName("min_salary")]
            public int? MinSalary { get; set; }

            /// <summary>
            /// <para>月薪范围-最高薪资，单位：千</para>
            /// <para>必填：否</para>
            /// <para>示例值：20</para>
            /// </summary>
            [JsonPropertyName("max_salary")]
            public int? MaxSalary { get; set; }

            /// <summary>
            /// <para>学历要求</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：小学及以上</item>
            /// <item>2：初中及以上</item>
            /// <item>3：专职及以上</item>
            /// <item>4：高中及以上</item>
            /// <item>5：大专及以上</item>
            /// <item>6：本科及以上</item>
            /// <item>7：硕士及以上</item>
            /// <item>8：博士及以上</item>
            /// <item>20：不限</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("required_degree")]
            public int? RequiredDegree { get; set; }

            /// <summary>
            /// <para>工作地点列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("city_list")]
            public CodeNameObject[]? CityLists { get; set; }

            /// <summary>
            /// <para>工作地点列表</para>
            /// </summary>
            public record CodeNameObject
            {
                /// <summary>
                /// <para>地点编码，详情请查看：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
                /// <para>必填：否</para>
                /// <para>示例值：CT_112</para>
                /// </summary>
                [JsonPropertyName("code")]
                public string? Code { get; set; }

                /// <summary>
                /// <para>地点名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>地点名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>地点中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：上海市</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>地点英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ShangHai</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>职位属性</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：实体职位</item>
            /// <item>2：虚拟职位</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("job_attribute")]
            public int? JobAttribute { get; set; }

            /// <summary>
            /// <para>目标专业</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("target_major_list")]
            public JobDetailTargetMajorInfo[]? TargetMajorLists { get; set; }

            /// <summary>
            /// <para>目标专业</para>
            /// </summary>
            public record JobDetailTargetMajorInfo
            {
                /// <summary>
                /// <para>目标专业ID，「0」 为不限专业，其他情况可通过[「根据主数据编码批量获取专业」](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/mdm-v3/batch_major/get)获取专业详情</para>
                /// <para>必填：否</para>
                /// <para>示例值：6930815272790114324</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>目标专业名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>目标专业名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>目标专业中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：社会学</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>目标专业英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Social</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>标志是否门店职位</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：普通职位</item>
            /// <item>2：门店职位</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("storefront_mode")]
            public int? StorefrontMode { get; set; }
        }

        /// <summary>
        /// <para>职位负责人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("recruiter")]
        public JobUserInfo? Recruiter { get; set; }

        /// <summary>
        /// <para>职位负责人</para>
        /// </summary>
        public record JobUserInfo
        {
            /// <summary>
            /// <para>人员 ID，与入参`user_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_efk39117c300506837def50545420c6a</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>负责人名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>负责人名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>负责人中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>负责人英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：ZhangSan</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>职位协助人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("assistant_list")]
        public JobUserInfo[]? AssistantLists { get; set; }

        /// <summary>
        /// <para>职位用人经理列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("hiring_manager_list")]
        public JobUserInfo[]? HiringManagerLists { get; set; }

        /// <summary>
        /// <para>招聘需求列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_requirement_list")]
        public JobRequirementSimple[]? JobRequirementLists { get; set; }

        /// <summary>
        /// <para>招聘需求列表</para>
        /// </summary>
        public record JobRequirementSimple
        {
            /// <summary>
            /// <para>招聘需求 ID，详情请查看：[获取招聘需求信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement/list_by_id)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6949805467799537964</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>招聘需求编号</para>
            /// <para>必填：否</para>
            /// <para>示例值：2232</para>
            /// </summary>
            [JsonPropertyName("short_code")]
            public string? ShortCode { get; set; }

            /// <summary>
            /// <para>需求名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：华中大区部门</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>需求部门 ID，与入参中的`department_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：6833685612520950030</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }
        }

        /// <summary>
        /// <para>职位地址列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("address_list")]
        public CommonAddress[]? AddressLists { get; set; }

        /// <summary>
        /// <para>职位地址列表</para>
        /// </summary>
        public record CommonAddress
        {
            /// <summary>
            /// <para>地址 ID，详情请查看：[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6583482347283472832</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>地址名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>地址名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>地址中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京华清大厦3324号</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>地址英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：No. 3324, Huaqing Building, Beijing</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>区域信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("district")]
            public CodeNameObject? District { get; set; }

            /// <summary>
            /// <para>区域信息</para>
            /// </summary>
            public record CodeNameObject
            {
                /// <summary>
                /// <para>区域编码</para>
                /// <para>必填：否</para>
                /// <para>示例值：DS_70</para>
                /// </summary>
                [JsonPropertyName("code")]
                public string? Code { get; set; }

                /// <summary>
                /// <para>区域名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>区域名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>区域中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：铁东区</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>区域英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Tiedong</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>城市信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("city")]
            public CodeNameObject? City { get; set; }

            /// <summary>
            /// <para>省信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("state")]
            public CodeNameObject? State { get; set; }

            /// <summary>
            /// <para>国家信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("country")]
            public CodeNameObject? Country { get; set; }
        }

        /// <summary>
        /// <para>职位设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_config")]
        public JobConfigDetail? JobConfig { get; set; }

        /// <summary>
        /// <para>职位设置</para>
        /// </summary>
        public record JobConfigDetail
        {
            /// <summary>
            /// <para>Offer 申请表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("offer_apply_schema")]
            public IdNameObject? OfferApplySchema { get; set; }

            /// <summary>
            /// <para>Offer 申请表</para>
            /// </summary>
            public record IdNameObject
            {
                /// <summary>
                /// <para>Offer 申请表 ID，详情请查看：[获取 Offer 申请表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer_application_form/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：7392444731470563625</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>Offer 申请表名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>Offer 申请表名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>Offer 申请表中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：申请表1</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>Offer 申请表英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Offer Apply 1</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>Offer 审批流</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("offer_process_conf")]
            public IdNameObject? OfferProcessConf { get; set; }

            /// <summary>
            /// <para>建议评估人列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("recommended_evaluator_list")]
            public IdNameObject[]? RecommendedEvaluatorLists { get; set; }

            /// <summary>
            /// <para>面试评价表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("assessment_template")]
            public IdNameObject? AssessmentTemplate { get; set; }

            /// <summary>
            /// <para>建议面试官列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("interview_round_list")]
            public JobConfigInterviewRound[]? InterviewRoundLists { get; set; }

            /// <summary>
            /// <para>建议面试官列表</para>
            /// </summary>
            public record JobConfigInterviewRound
            {
                /// <summary>
                /// <para>面试官列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("interviewer_list")]
                public IdNameObject[]? InterviewerLists { get; set; }

                /// <summary>
                /// <para>面试官列表</para>
                /// </summary>
                public record IdNameObject
                {
                    /// <summary>
                    /// <para>面试官 ID，与入参`user_id_type`类型一致</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7392444731470563625</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>面试官名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>面试官名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>面试官中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：张三</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>面试官英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：ZhangSan</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }

                /// <summary>
                /// <para>面试轮次</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("round")]
                public int? Round { get; set; }
            }

            /// <summary>
            /// <para>面试登记表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("interview_registration")]
            public RegistrationInfo? InterviewRegistration { get; set; }

            /// <summary>
            /// <para>面试登记表</para>
            /// </summary>
            public record RegistrationInfo
            {
                /// <summary>
                /// <para>面试登记表模版 ID，详情可查看：[获取面试登记表模板列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_registration_schema/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：6930815272790114324</para>
                /// </summary>
                [JsonPropertyName("schema_id")]
                public string? SchemaId { get; set; }

                /// <summary>
                /// <para>面试登记表名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：默认登记表</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }
            }

            /// <summary>
            /// <para>入职登记表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("onboard_registration")]
            public RegistrationInfo? OnboardRegistration { get; set; }

            /// <summary>
            /// <para>面试轮次类型列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("interview_round_type_list")]
            public JobConfigRoundTypeResult[]? InterviewRoundTypeLists { get; set; }

            /// <summary>
            /// <para>面试轮次类型列表</para>
            /// </summary>
            public record JobConfigRoundTypeResult
            {
                /// <summary>
                /// <para>面试轮次类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("assessment_round")]
                public IdNameObject? AssessmentRound { get; set; }

                /// <summary>
                /// <para>面试轮次类型</para>
                /// </summary>
                public record IdNameObject
                {
                    /// <summary>
                    /// <para>面试轮次类型 ID，详情请查看：[获取面试轮次类型列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_round_type/list)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7392444731470563625</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>面试轮次类型名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>面试轮次类型名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>面试轮次类型中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试类型</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>面试轮次类型英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Test type</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }

                /// <summary>
                /// <para>面试评价表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("assessment_template")]
                public IdNameObject? AssessmentTemplate { get; set; }
            }

            /// <summary>
            /// <para>关联职位列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("related_job_list")]
            public IdNameObject[]? RelatedJobLists { get; set; }

            /// <summary>
            /// <para>职位属性，1是实体职位，2是虚拟职位</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("job_attribute")]
            public int? JobAttribute { get; set; }

            /// <summary>
            /// <para>面试官安排面试配置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("interview_appointment_config")]
            public JobConfigDetailInterviewAppointmentConfig? InterviewAppointmentConfig { get; set; }

            /// <summary>
            /// <para>面试官安排面试配置</para>
            /// </summary>
            public record JobConfigDetailInterviewAppointmentConfig
            {
                /// <summary>
                /// <para>是否开启面试官安排面试</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("enable_interview_appointment_by_interviewer")]
                public bool? EnableInterviewAppointmentByInterviewer { get; set; }

                /// <summary>
                /// <para>配置详情</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("config")]
                public InterviewAppointmentConfigContent? Config { get; set; }

                /// <summary>
                /// <para>配置详情</para>
                /// </summary>
                public record InterviewAppointmentConfigContent
                {
                    /// <summary>
                    /// <para>面试类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：现场面试</item>
                    /// <item>2：电话面试</item>
                    /// <item>3：视频面试</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("interview_type")]
                    public int? InterviewType { get; set; }

                    /// <summary>
                    /// <para>时区</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Asia/Shanghai</para>
                    /// </summary>
                    [JsonPropertyName("talent_timezone_code")]
                    public string? TalentTimezoneCode { get; set; }

                    /// <summary>
                    /// <para>联系人 ID，与入参`user_id_type`类型一致</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ou_c99c5f35d542efc7ee492afe11af19ef</para>
                    /// </summary>
                    [JsonPropertyName("contact_user_id")]
                    public string? ContactUserId { get; set; }

                    /// <summary>
                    /// <para>联系人电话</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：177xxxx1773</para>
                    /// </summary>
                    [JsonPropertyName("contact_mobile")]
                    public string? ContactMobile { get; set; }

                    /// <summary>
                    /// <para>联系人邮箱</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：test@open.com</para>
                    /// </summary>
                    [JsonPropertyName("contact_email")]
                    public string? ContactEmail { get; set; }

                    /// <summary>
                    /// <para>联系人地址 ID，详情请查看：[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6960663240925956576</para>
                    /// </summary>
                    [JsonPropertyName("address_id")]
                    public string? AddressId { get; set; }

                    /// <summary>
                    /// <para>视频面试类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：zoom</item>
                    /// <item>2：牛客技术类型</item>
                    /// <item>3：牛客非技术类型</item>
                    /// <item>4：赛码</item>
                    /// <item>5：飞书</item>
                    /// <item>8：Hackerrank</item>
                    /// <item>9：飞书(含代码考核)</item>
                    /// <item>100：不使用系统工具</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("video_type")]
                    public int? VideoType { get; set; }

                    /// <summary>
                    /// <para>抄送人 ID 列表，与入参`user_id_type`类型一致</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("cc")]
                    public string[]? Cc { get; set; }

                    /// <summary>
                    /// <para>面试配置备注</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：这个职位最好选择现场牛客网面试</para>
                    /// </summary>
                    [JsonPropertyName("remark")]
                    public string? Remark { get; set; }

                    /// <summary>
                    /// <para>面试通知模板 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6960663240925956573</para>
                    /// </summary>
                    [JsonPropertyName("interview_notification_template_id")]
                    public string? InterviewNotificationTemplateId { get; set; }

                    /// <summary>
                    /// <para>预约通知模板 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6960663240925956573</para>
                    /// </summary>
                    [JsonPropertyName("appointment_notification_template_id")]
                    public string? AppointmentNotificationTemplateId { get; set; }

                    /// <summary>
                    /// <para>取消面试通知模版 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6960663240925956573</para>
                    /// </summary>
                    [JsonPropertyName("cancel_interview_notification_template_id")]
                    public string? CancelInterviewNotificationTemplateId { get; set; }
                }
            }

            /// <summary>
            /// <para>实习 Offer 申请表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("internship_offer_apply_schema")]
            public IdNameObject? InternshipOfferApplySchema { get; set; }
        }

        /// <summary>
        /// <para>门店列表，仅当 `storefront_mode` 值为`2`的时候会填充</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("storefront_list")]
        public JobStorefront[]? StorefrontLists { get; set; }

        /// <summary>
        /// <para>门店列表，仅当 `storefront_mode` 值为`2`的时候会填充</para>
        /// </summary>
        public record JobStorefront
        {
            /// <summary>
            /// <para>门店 ID，详情请查看：[获取门店信息列表](https://open.larkoffice.com/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/store/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6960663240925956547</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>门店名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>门店名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>门店中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：肯德基门店</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>门店英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：KFC Store</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>启用状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：启用</item>
            /// <item>2：停用</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("active_status")]
            public int? ActiveStatus { get; set; }

            /// <summary>
            /// <para>门店部门</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department")]
            public JobDepartmentSimple? Department { get; set; }

            /// <summary>
            /// <para>门店部门</para>
            /// </summary>
            public record JobDepartmentSimple
            {
                /// <summary>
                /// <para>部门 ID，与入参中的`department_id_type`类型一致</para>
                /// <para>必填：否</para>
                /// <para>示例值：7392444731470563625</para>
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
                    /// <para>部门中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：华北大区部门</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>部门英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Hua Bei Department</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>门店地址</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("address")]
            public CommonAddress? Address { get; set; }

            /// <summary>
            /// <para>门店地址</para>
            /// </summary>
            public record CommonAddress
            {
                /// <summary>
                /// <para>地址 ID，详情请查看：[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：6583482347283472832</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>地址名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>地址名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>地址中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：北京华清大厦2226号</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>地址英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：No. 2226, Huaqing Building, Beijing</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>区域信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("district")]
                public CodeNameObject? District { get; set; }

                /// <summary>
                /// <para>区域信息</para>
                /// </summary>
                public record CodeNameObject
                {
                    /// <summary>
                    /// <para>区域编码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：DS_70</para>
                    /// </summary>
                    [JsonPropertyName("code")]
                    public string? Code { get; set; }

                    /// <summary>
                    /// <para>区域名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>区域名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>区域中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：铁东区</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>区域英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Tiedong</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }

                /// <summary>
                /// <para>城市信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("city")]
                public CodeNameObject? City { get; set; }

                /// <summary>
                /// <para>省信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("state")]
                public CodeNameObject? State { get; set; }

                /// <summary>
                /// <para>国家信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("country")]
                public CodeNameObject? Country { get; set; }
            }

            /// <summary>
            /// <para>门店负责人</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("manager")]
            public JobUserInfo? Manager { get; set; }

            /// <summary>
            /// <para>门店负责人</para>
            /// </summary>
            public record JobUserInfo
            {
                /// <summary>
                /// <para>负责人 ID，与入参`user_id_type`类型一致</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou_efk39117c300506837def50545420c6a</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>负责人名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>负责人名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>负责人中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>负责人英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ZhangSan</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>创建时间，毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1622484739955</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>门店备注</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("remark")]
            public I18n? Remark { get; set; }
        }

        /// <summary>
        /// <para>职位标签列表，根据标签顺序降序排列返回。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tag_list")]
        public JobDetailTag[]? TagLists { get; set; }

        /// <summary>
        /// <para>职位标签列表，根据标签顺序降序排列返回。</para>
        /// </summary>
        public record JobDetailTag
        {
            /// <summary>
            /// <para>标签 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6949805467799537964</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>标签名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>标签名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>标签中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：985、211</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>标签英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：985、211</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>标签顺序</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("order")]
            public int? Order { get; set; }
        }
    }
}
