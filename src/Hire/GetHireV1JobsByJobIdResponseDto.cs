// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1JobsByJobIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取职位信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取职位信息 响应体
/// <para>根据职位 ID 获取职位信息。</para>
/// <para>接口ID：6963910685080289282</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fget</para>
/// </summary>
public record GetHireV1JobsByJobIdResponseDto
{
    /// <summary>
    /// <para>职位数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job")]
    public GetHireV1JobsByJobIdResponseDtoJob? Job { get; set; }

    /// <summary>
    /// <para>职位数据</para>
    /// </summary>
    public record GetHireV1JobsByJobIdResponseDtoJob
    {
        /// <summary>
        /// <para>职位 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6001</para>
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
        /// <para>示例值：职位描述文本</para>
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
        /// <para>雇佣类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("recruitment_type")]
        public JobRecruitmentType? RecruitmentType { get; set; }

        /// <summary>
        /// <para>雇佣类型</para>
        /// </summary>
        public record JobRecruitmentType
        {
            /// <summary>
            /// <para>雇佣类型 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6001</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>雇佣类型中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：全职</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>雇佣类型英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：FullTime</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

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
        /// <para>部门</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department")]
        public JobDepartment? Department { get; set; }

        /// <summary>
        /// <para>部门</para>
        /// </summary>
        public record JobDepartment
        {
            /// <summary>
            /// <para>部门 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-xxxx</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>部门中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：字节跳动</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>部门英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Bytedance</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }
        }

        /// <summary>
        /// <para>工作地点</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("city")]
        public JobCity? City { get; set; }

        /// <summary>
        /// <para>工作地点</para>
        /// </summary>
        public record JobCity
        {
            /// <summary>
            /// <para>工作地点城市代码</para>
            /// <para>必填：否</para>
            /// <para>示例值：C20</para>
            /// </summary>
            [JsonPropertyName("city_code")]
            public string? CityCode { get; set; }

            /// <summary>
            /// <para>工作地点中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：成都</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>工作地点英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Chengdu</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }
        }

        /// <summary>
        /// <para>最低职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("min_job_level")]
        public JobLevel? MinJobLevel { get; set; }

        /// <summary>
        /// <para>最低职级</para>
        /// </summary>
        public record JobLevel
        {
            /// <summary>
            /// <para>职级 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6301</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职级中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：级别-2</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>职级英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：level-2</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

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
        public JobLevel? MaxJobLevel { get; set; }

        /// <summary>
        /// <para>职位亮点</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("highlight_list")]
        public JobHighlight[]? HighlightLists { get; set; }

        /// <summary>
        /// <para>职位亮点</para>
        /// </summary>
        public record JobHighlight
        {
            /// <summary>
            /// <para>职位亮点 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6301</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职位亮点中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：团队氛围好</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>职位亮点英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Positiveteamatmosphere</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }
        }

        /// <summary>
        /// <para>职位序列</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_category")]
        public GetHireV1JobsByJobIdResponseDtoJobJobCategory? JobCategory { get; set; }

        /// <summary>
        /// <para>职位序列</para>
        /// </summary>
        public record GetHireV1JobsByJobIdResponseDtoJobJobCategory
        {
            /// <summary>
            /// <para>职位序列 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6301</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职位序列中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：序列-A</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>职位序列英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：category-A</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

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
        public GetHireV1JobsByJobIdResponseDtoJobJobType? JobType { get; set; }

        /// <summary>
        /// <para>职位类别</para>
        /// </summary>
        public record GetHireV1JobsByJobIdResponseDtoJobJobType
        {
            /// <summary>
            /// <para>职位类别 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6890840777044265230</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职位类别中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：金融</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>职位类别英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Finance</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }
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
        /// <para>创建人ID，若为空则为系统或其他对接系统创建</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou-xxx</para>
        /// </summary>
        [JsonPropertyName("create_user_id")]
        public string? CreateUserId { get; set; }

        /// <summary>
        /// <para>创建时间 请使用create_timestamp</para>
        /// <para>必填：否</para>
        /// <para>示例值：1617170925462</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间 请使用update_timestamp</para>
        /// <para>必填：否</para>
        /// <para>示例值：1617170925462</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// <para>招聘流程类型</para>
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
        /// <para>招聘流程 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("process_id")]
        public string? ProcessId { get; set; }

        /// <summary>
        /// <para>招聘流程中文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：流程中文名</para>
        /// </summary>
        [JsonPropertyName("process_name")]
        public string? ProcessName { get; set; }

        /// <summary>
        /// <para>招聘流程英文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：流程英文名</para>
        /// </summary>
        [JsonPropertyName("process_en_name")]
        public string? ProcessEnName { get; set; }

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
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
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
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
                /// <para>示例值：text</para>
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
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
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
                    /// <para>开始时间</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
                    /// </summary>
                    [JsonPropertyName("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
                    /// </summary>
                    [JsonPropertyName("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是毫秒级时间戳</para>
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
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1213213123123</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
        /// <para>到期日期 请使用expiry_timestamp</para>
        /// <para>必填：否</para>
        /// <para>示例值：1622484739955</para>
        /// </summary>
        [JsonPropertyName("expiry_time")]
        public int? ExpiryTime { get; set; }

        /// <summary>
        /// <para>最低薪资，单位:k</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("min_salary")]
        public int? MinSalary { get; set; }

        /// <summary>
        /// <para>最高薪资，单位:k</para>
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
        /// <item>1：JuniorMiddleSchoolEducation</item>
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
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：1111</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>职位属性，1是实体职位，2是虚拟职位</para>
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
        /// <para>创建时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1617170925462</para>
        /// </summary>
        [JsonPropertyName("create_timestamp")]
        public string? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>更新时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1617170925462</para>
        /// </summary>
        [JsonPropertyName("update_timestamp")]
        public string? UpdateTimestamp { get; set; }

        /// <summary>
        /// <para>到期时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1622484739955</para>
        /// </summary>
        [JsonPropertyName("expiry_timestamp")]
        public string? ExpiryTimestamp { get; set; }

        /// <summary>
        /// <para>目标专业ID，「0」 为不限专业，其他情况可通过[「根据主数据编码批量获取专业」](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/mdm-v3/batch_major/get)获取专业详情</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("target_major_list")]
        public TargetMajorInfo[]? TargetMajorLists { get; set; }

        /// <summary>
        /// <para>目标专业ID，「0」 为不限专业，其他情况可通过[「根据主数据编码批量获取专业」](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/mdm-v3/batch_major/get)获取专业详情</para>
        /// </summary>
        public record TargetMajorInfo
        {
            /// <summary>
            /// <para>目标专业ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6930815272790114324</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>目标专业中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：考古</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>目标专业英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：archeology</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }
        }
    }
}
