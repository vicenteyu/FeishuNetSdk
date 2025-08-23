// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostHireV1BackgroundCheckOrdersBatchQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询背调信息列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询背调信息列表 响应体
/// <para>可根据背调 ID 列表或投递 ID 等过滤条件查询背调订单信息。</para>
/// <para>接口ID：7413697955198107652</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/background_check_order/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fbackground_check_order%2fbatch_query</para>
/// </summary>
public record PostHireV1BackgroundCheckOrdersBatchQueryResponseDto : IPageableResponse<PostHireV1BackgroundCheckOrdersBatchQueryResponseDto.BackgroundCheckOrder>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJvZmZzZXQiOjEsInRpbWVzdGFtcCI6MTY0MDc2NTYzMjA4OCwiaWQiOm51bGx9</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>背调订单列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public BackgroundCheckOrder[]? Items { get; set; }

    /// <summary>
    /// <para>背调订单列表</para>
    /// </summary>
    public record BackgroundCheckOrder
    {
        /// <summary>
        /// <para>背调订单 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7037986982531778860</para>
        /// </summary>
        [JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// <para>投递 ID，详情可查看：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6985833807195212076</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>背调状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>2：已安排</item>
        /// <item>3：已完成</item>
        /// <item>4：已终止</item>
        /// <item>5：审批中</item>
        /// <item>6：审批已撤回</item>
        /// <item>8：审批通过</item>
        /// <item>9：审批未通过</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("order_status")]
        public int? OrderStatus { get; set; }

        /// <summary>
        /// <para>供应商类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：八方锦程</item>
        /// <item>2：背调</item>
        /// <item>3：轩渡</item>
        /// <item>127：自定义供应商</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("account_third_type")]
        public int? AccountThirdType { get; set; }

        /// <summary>
        /// <para>背调套餐名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：基础版</para>
        /// </summary>
        [JsonPropertyName("package")]
        public string? Package { get; set; }

        /// <summary>
        /// <para>背调名称（仅用户手动录入的背调结果支持返回该字段）</para>
        /// <para>必填：否</para>
        /// <para>示例值：录入的背调</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>背调报告列表，按照报告创建时间降序排列。可通过[更新背调订单进度](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check/update_progress)更新报告</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("feedback_info_list")]
        public BackgroundCheckOrderFeedbackInfo[]? FeedbackInfoLists { get; set; }

        /// <summary>
        /// <para>背调报告列表，按照报告创建时间降序排列。可通过[更新背调订单进度](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check/update_progress)更新报告</para>
        /// </summary>
        public record BackgroundCheckOrderFeedbackInfo
        {
            /// <summary>
            /// <para>背调报告 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6930815272790114324</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>背调信息附件下载链接（大部分供应商均支持该字段；该字段与「report_preview_url」同一供应商只能支持 1 种），有效期1小时</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://feishucdn.com/staource/v1/2de04c10-5cda-4c50~?image_size=np&amp;cutpe=&amp;quity=&amp;mat=g&amp;stmat=.wp</para>
            /// </summary>
            [JsonPropertyName("attachment_url")]
            public string? AttachmentUrl { get; set; }

            /// <summary>
            /// <para>背调预览链接（该字段与「attachment_url」同一供应商只能支持 1 种），有效期由供应商控制</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://feishucdn.com/preview/file/6930815272790114324/</para>
            /// </summary>
            [JsonPropertyName("report_preview_url")]
            public string? ReportPreviewUrl { get; set; }

            /// <summary>
            /// <para>背调结果。招聘系统预置的背调结果有 红灯、黄灯、蓝灯、绿灯，也可以是更新背调进度时推送的状态。</para>
            /// <para>必填：否</para>
            /// <para>示例值：红灯</para>
            /// </summary>
            [JsonPropertyName("result")]
            public string? Result { get; set; }

            /// <summary>
            /// <para>报告类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：阶段性报告</item>
            /// <item>2：终版报告</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("report_type")]
            public int? ReportType { get; set; }

            /// <summary>
            /// <para>创建时间，毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1686645425868</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>报告名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三的背调报告</para>
            /// </summary>
            [JsonPropertyName("report_name")]
            public string? ReportName { get; set; }
        }

        /// <summary>
        /// <para>背调进度列表，按照更新时间降序排列。可通过[更新背调订单进度](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check/update_progress)更新进度</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("process_info_list")]
        public BackgroundCheckOrderProcessInfo[]? ProcessInfoLists { get; set; }

        /// <summary>
        /// <para>背调进度列表，按照更新时间降序排列。可通过[更新背调订单进度](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check/update_progress)更新进度</para>
        /// </summary>
        public record BackgroundCheckOrderProcessInfo
        {
            /// <summary>
            /// <para>中文背调进度</para>
            /// <para>必填：否</para>
            /// <para>示例值：待安排</para>
            /// </summary>
            [JsonPropertyName("process")]
            public string? Process { get; set; }

            /// <summary>
            /// <para>进度更新时间，毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1638359554952</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public string? UpdateTime { get; set; }

            /// <summary>
            /// <para>英文背调进度</para>
            /// <para>必填：否</para>
            /// <para>示例值：arranged</para>
            /// </summary>
            [JsonPropertyName("en_process")]
            public string? EnProcess { get; set; }
        }

        /// <summary>
        /// <para>录入时间毫秒时间戳（仅用户手动录入的背调结果支持返回该字段）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1662476247755</para>
        /// </summary>
        [JsonPropertyName("upload_time")]
        public string? UploadTime { get; set; }

        /// <summary>
        /// <para>候选人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("candidate_info")]
        public UserContactInfo? CandidateInfo { get; set; }

        /// <summary>
        /// <para>候选人信息</para>
        /// </summary>
        public record UserContactInfo
        {
            /// <summary>
            /// <para>候选人姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：王二</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>候选人手机号</para>
            /// <para>必填：否</para>
            /// <para>示例值：176xxxx1234</para>
            /// </summary>
            [JsonPropertyName("mobile")]
            public string? Mobile { get; set; }

            /// <summary>
            /// <para>候选人邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxx@abc.vom</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>候选人名字</para>
            /// <para>必填：否</para>
            /// <para>示例值：Ming</para>
            /// </summary>
            [JsonPropertyName("first_name")]
            public string? FirstName { get; set; }

            /// <summary>
            /// <para>候选人姓氏</para>
            /// <para>必填：否</para>
            /// <para>示例值：Lee</para>
            /// </summary>
            [JsonPropertyName("last_name")]
            public string? LastName { get; set; }
        }

        /// <summary>
        /// <para>背调发起人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("creator_info")]
        public BackgroundCheckOrderCreator? CreatorInfo { get; set; }

        /// <summary>
        /// <para>背调发起人信息</para>
        /// </summary>
        public record BackgroundCheckOrderCreator
        {
            /// <summary>
            /// <para>发起人 ID，与入参 `user_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：6930815272790114324</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }
        }

        /// <summary>
        /// <para>背调联系人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("contactor_info")]
        public UserContactInfo? ContactorInfo { get; set; }

        /// <summary>
        /// <para>背调发起时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686297649024</para>
        /// </summary>
        [JsonPropertyName("begin_time")]
        public string? BeginTime { get; set; }

        /// <summary>
        /// <para>背调结束时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686297649024</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>背调结论，为最后一次背调报告的结果</para>
        /// <para>必填：否</para>
        /// <para>示例值：绿灯</para>
        /// </summary>
        [JsonPropertyName("conclusion")]
        public string? Conclusion { get; set; }

        /// <summary>
        /// <para>供应商信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("provider_info")]
        public ProviderIdNameObject? ProviderInfo { get; set; }

        /// <summary>
        /// <para>供应商信息</para>
        /// </summary>
        public record ProviderIdNameObject
        {
            /// <summary>
            /// <para>供应商 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6930815272790114324</para>
            /// </summary>
            [JsonPropertyName("provider_id")]
            public string? ProviderId { get; set; }

            /// <summary>
            /// <para>供应商名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("provider_name")]
            public I18n? ProviderName { get; set; }

            /// <summary>
            /// <para>供应商名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>供应商中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试供应商</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>供应商英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：test provider</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>自定义字段模板。数据来源于[创建背调自定义字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check_custom_field/create)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_field_list")]
        public EcoBackgroundCheckCustomFieldData[]? CustomFieldLists { get; set; }

        /// <summary>
        /// <para>自定义字段模板。数据来源于[创建背调自定义字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check_custom_field/create)</para>
        /// </summary>
        public record EcoBackgroundCheckCustomFieldData
        {
            /// <summary>
            /// <para>自定义字段类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：number</para>
            /// <para>可选值：<list type="bullet">
            /// <item>text：单行文本，最多100个汉字</item>
            /// <item>textarea：多行文本，最多200个汉字</item>
            /// <item>number：数字</item>
            /// <item>boolean：布尔</item>
            /// <item>select：单选</item>
            /// <item>multiselect：多选</item>
            /// <item>date：日期</item>
            /// <item>file：附件</item>
            /// <item>resume：候选人简历</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string Type { get; set; } = string.Empty;

            /// <summary>
            /// <para>自定义字段的标识，在同一账号内唯一</para>
            /// <para>必填：是</para>
            /// <para>示例值：candidate_resume</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>自定义字段的名称，用户在安排背调表单看到的控件标题</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n Name { get; set; } = new();

            /// <summary>
            /// <para>自定义字段的名称，用户在安排背调表单看到的控件标题</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>自定义字段中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：其他备注</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>自定义字段英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Other remark</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>是否必填</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_required")]
            public bool IsRequired { get; set; }

            /// <summary>
            /// <para>自定义字段的描述，如果是输入控件，为用户在安排背调表单看到的 placeholder 或提示文字</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public I18n? Description { get; set; }

            /// <summary>
            /// <para>`type` 为 `select` 或 `multiselect` 时必填，单选或多选的选项</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("options")]
            public EcoBackgroundCheckCustomFieldDataOption[]? Options { get; set; }

            /// <summary>
            /// <para>`type` 为 `select` 或 `multiselect` 时必填，单选或多选的选项</para>
            /// </summary>
            public record EcoBackgroundCheckCustomFieldDataOption
            {
                /// <summary>
                /// <para>选项的 key</para>
                /// <para>必填：是</para>
                /// <para>示例值：A</para>
                /// </summary>
                [JsonPropertyName("key")]
                public string Key { get; set; } = string.Empty;

                /// <summary>
                /// <para>选项名称</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n Name { get; set; } = new();

                /// <summary>
                /// <para>选项名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>选项中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：选项 A</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>选项英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：option A</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }
        }

        /// <summary>
        /// <para>自定义字段值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_data_list")]
        public BackgroundCheckCustomFieldDataValue[]? CustomDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段值</para>
        /// </summary>
        public record BackgroundCheckCustomFieldDataValue
        {
            /// <summary>
            /// <para>对应前文`custom_field_list`的 key</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string? Key { get; set; }

            /// <summary>
            /// <para>用户填入的值</para>
            /// <para>必填：否</para>
            /// <para>示例值：user input value</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }

        /// <summary>
        /// <para>背调调查附加项列表。数据来源于[创建背调套餐和附加调查项](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check_package/create)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ext_item_info_list")]
        public BackgroundCheckItemInfo[]? ExtItemInfoLists { get; set; }

        /// <summary>
        /// <para>背调调查附加项列表。数据来源于[创建背调套餐和附加调查项](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check_package/create)</para>
        /// </summary>
        public record BackgroundCheckItemInfo
        {
            /// <summary>
            /// <para>附加项的 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6930815272790114324</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>附加项的名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：户籍查询</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>订单更新时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686809576215</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>属地</para>
        /// <para>必填：否</para>
        /// <para>示例值：cn</para>
        /// <para>可选值：<list type="bullet">
        /// <item>cn：中国大陆</item>
        /// <item>sg：新加坡</item>
        /// <item>us：美东</item>
        /// <item>jp：日本</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("geo")]
        public string? Geo { get; set; }

        /// <summary>
        /// <para>预计入职地点的编码，详见[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN_1</para>
        /// </summary>
        [JsonPropertyName("location_code")]
        public string? LocationCode { get; set; }

        /// <summary>
        /// <para>备注</para>
        /// <para>必填：否</para>
        /// <para>示例值：候选人很优秀</para>
        /// </summary>
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }
    }
}
