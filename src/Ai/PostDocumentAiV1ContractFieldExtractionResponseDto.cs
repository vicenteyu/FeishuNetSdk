using Newtonsoft.Json;
namespace FeishuNetSdk.Ai;
/// <summary>
/// 提取文件中的合同字段 响应体
/// <para>支持从doc、docx和pdf文件类型中提取合同字段</para>
/// <para>接口ID：7220312184105664515</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/document_ai-v1/contract/field_extraction</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fcontract%2ffield_extraction</para>
/// </summary>
public record PostDocumentAiV1ContractFieldExtractionResponseDto
{
    /// <summary>
    /// <para>文件的唯一id</para>
    /// <para>必填：否</para>
    /// <para>示例值：121345678</para>
    /// </summary>
    [JsonProperty("file_id")]
    public string? FileId { get; set; }

    /// <summary>
    /// <para>总交易金额</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("price")]
    public ExtractPrice? Price { get; set; }

    /// <summary>
    /// <para>总交易金额</para>
    /// </summary>
    public record ExtractPrice
    {
        /// <summary>
        /// <para>交易金额</para>
        /// <para>必填：否</para>
        /// <para>示例值：200000</para>
        /// </summary>
        [JsonProperty("contract_price")]
        public float? ContractPrice { get; set; }

        /// <summary>
        /// <para>从原文中抽取的交易金额</para>
        /// <para>必填：否</para>
        /// <para>示例值："200000"</para>
        /// </summary>
        [JsonProperty("contract_price_original")]
        public string? ContractPriceOriginal { get; set; }

        /// <summary>
        /// <para>原文中描述交易金额的文字</para>
        /// <para>必填：否</para>
        /// <para>示例值：本合同项下总金额共计￥200000（贰拾万元整）</para>
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }
    }

    /// <summary>
    /// <para>期限相关信息，包括开始日期、结束日期、有效时长</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("time")]
    public ExtractTime? Time { get; set; }

    /// <summary>
    /// <para>期限相关信息，包括开始日期、结束日期、有效时长</para>
    /// </summary>
    public record ExtractTime
    {
        /// <summary>
        /// <para>开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-07-01</para>
        /// </summary>
        [JsonProperty("time_start")]
        public string? TimeStart { get; set; }

        /// <summary>
        /// <para>结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-06-30</para>
        /// </summary>
        [JsonProperty("time_end")]
        public string? TimeEnd { get; set; }

        /// <summary>
        /// <para>原文中抽取出的开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020年07月1日</para>
        /// </summary>
        [JsonProperty("original_time_start")]
        public string? OriginalTimeStart { get; set; }

        /// <summary>
        /// <para>原文中抽取出的结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022年6月30日</para>
        /// </summary>
        [JsonProperty("original_time_end")]
        public string? OriginalTimeEnd { get; set; }

        /// <summary>
        /// <para>原文中关于开始时间的描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：本协议自有效期自【2020】年【07】月【1】日至【2022】年【6】月【30】日，有效期2年。</para>
        /// </summary>
        [JsonProperty("text_start")]
        public string? TextStart { get; set; }

        /// <summary>
        /// <para>原文中关于结束时间的描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：本协议自有效期自【2020】年【07】月【1】日至【2022】年【6】月【30】日，有效期2年。</para>
        /// </summary>
        [JsonProperty("text_end")]
        public string? TextEnd { get; set; }

        /// <summary>
        /// <para>合同持续时长</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("initial_term")]
        public ExtractTerm? InitialTerm { get; set; }

        /// <summary>
        /// <para>合同持续时长</para>
        /// </summary>
        public record ExtractTerm
        {
            /// <summary>
            /// <para>合同持续时长</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// </summary>
            [JsonProperty("initial_time")]
            public string? InitialTime { get; set; }

            /// <summary>
            /// <para>持续时长单位</para>
            /// <para>必填：否</para>
            /// <para>示例值：年</para>
            /// </summary>
            [JsonProperty("initial_unit")]
            public string? InitialUnit { get; set; }
        }

        /// <summary>
        /// <para>原文中关于持续时间的描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：2年</para>
        /// </summary>
        [JsonProperty("text_initial_term")]
        public string? TextInitialTerm { get; set; }
    }

    /// <summary>
    /// <para>盖章份数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("copy")]
    public ExtractCopy? Copy { get; set; }

    /// <summary>
    /// <para>盖章份数</para>
    /// </summary>
    public record ExtractCopy
    {
        /// <summary>
        /// <para>盖章份数</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonProperty("copy_num")]
        public int? CopyNum { get; set; }

        /// <summary>
        /// <para>从原文中抽取的盖章份数</para>
        /// <para>必填：否</para>
        /// <para>示例值：一式贰份</para>
        /// </summary>
        [JsonProperty("original_copy")]
        public string? OriginalCopy { get; set; }

        /// <summary>
        /// <para>盖章文件类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：协议</para>
        /// </summary>
        [JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// <para>原文有关盖章份数的描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：此协议一式贰份，双方各执壹份，具有同等法律效力。</para>
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }
    }

    /// <summary>
    /// <para>币种</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("currency")]
    public ExtractCurrency? Currency { get; set; }

    /// <summary>
    /// <para>币种</para>
    /// </summary>
    public record ExtractCurrency
    {
        /// <summary>
        /// <para>币种名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：CNY</para>
        /// </summary>
        [JsonProperty("currency_name")]
        public string? CurrencyName { get; set; }

        /// <summary>
        /// <para>币种符号</para>
        /// <para>必填：否</para>
        /// <para>示例值：¥</para>
        /// </summary>
        [JsonProperty("currency_text")]
        public string? CurrencyText { get; set; }
    }

    /// <summary>
    /// <para>合同标题</para>
    /// <para>必填：否</para>
    /// <para>示例值：项目活动框架协议</para>
    /// </summary>
    [JsonProperty("header")]
    public string? Header { get; set; }

    /// <summary>
    /// <para>主体信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("body_info")]
    public BodyInfo[]? BodyInfos { get; set; }

    /// <summary>
    /// <para>主体信息</para>
    /// </summary>
    public record BodyInfo
    {
        /// <summary>
        /// <para>主体类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：buy</para>
        /// <para>可选值：<list type="bullet">
        /// <item>buy：甲方主体</item>
        /// <item>sell：乙方主体</item>
        /// <item>third：第三方、其他方主体</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("body_type")]
        public string? BodyType { get; set; }

        /// <summary>
        /// <para>值</para>
        /// <para>必填：否</para>
        /// <para>示例值：value</para>
        /// </summary>
        [JsonProperty("value")]
        public BodyEntity? Value { get; set; }

        /// <summary>
        /// <para>值</para>
        /// </summary>
        public record BodyEntity
        {
            /// <summary>
            /// <para>地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京市A区B园4号楼</para>
            /// </summary>
            [JsonProperty("address")]
            public string? Address { get; set; }

            /// <summary>
            /// <para>联系人</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonProperty("contacts")]
            public string? Contacts { get; set; }

            /// <summary>
            /// <para>邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：zhangsan.1111@bytedance.com</para>
            /// </summary>
            [JsonProperty("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>电话</para>
            /// <para>必填：否</para>
            /// <para>示例值：13600000000</para>
            /// </summary>
            [JsonProperty("phone")]
            public string? Phone { get; set; }

            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：310XXXXXXXXXXXXXXX</para>
            /// </summary>
            [JsonProperty("id_number")]
            public string? IdNumber { get; set; }

            /// <summary>
            /// <para>法人代表</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonProperty("legal_representative")]
            public string? LegalRepresentative { get; set; }

            /// <summary>
            /// <para>当事人</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京字节跳动网络技术有限公司</para>
            /// </summary>
            [JsonProperty("party")]
            public string? Party { get; set; }
        }
    }

    /// <summary>
    /// <para>银行信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("bank_info")]
    public BankInfo[]? BankInfos { get; set; }

    /// <summary>
    /// <para>银行信息</para>
    /// </summary>
    public record BankInfo
    {
        /// <summary>
        /// <para>甲乙方信息类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：buy</para>
        /// <para>可选值：<list type="bullet">
        /// <item>buy_bank：甲方银行</item>
        /// <item>sell_bank：乙方银行</item>
        /// <item>third_bank：第三方银行</item>
        /// <item>unceratin_bank：其他方银行</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("bank_type")]
        public string? BankType { get; set; }

        /// <summary>
        /// <para>值</para>
        /// <para>必填：否</para>
        /// <para>示例值：value</para>
        /// </summary>
        [JsonProperty("value")]
        public BankEntity? Value { get; set; }

        /// <summary>
        /// <para>值</para>
        /// </summary>
        public record BankEntity
        {
            /// <summary>
            /// <para>账户名</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京字节跳动网络技术有限公司</para>
            /// </summary>
            [JsonProperty("account_name")]
            public string? AccountName { get; set; }

            /// <summary>
            /// <para>银行名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：中国A银行B支行</para>
            /// </summary>
            [JsonProperty("bank_name")]
            public string? BankName { get; set; }

            /// <summary>
            /// <para>账户ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：11230xxxxx004701</para>
            /// </summary>
            [JsonProperty("account_number")]
            public string? AccountNumber { get; set; }

            /// <summary>
            /// <para>电话</para>
            /// <para>必填：否</para>
            /// <para>示例值：010-8xxxx688</para>
            /// </summary>
            [JsonProperty("phone")]
            public string? Phone { get; set; }

            /// <summary>
            /// <para>联系人</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonProperty("contacts")]
            public string? Contacts { get; set; }

            /// <summary>
            /// <para>传真号码</para>
            /// <para>必填：否</para>
            /// <para>示例值：911101xxxxx684235</para>
            /// </summary>
            [JsonProperty("tax_number")]
            public string? TaxNumber { get; set; }

            /// <summary>
            /// <para>联系地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：A市B区C园D楼3-8</para>
            /// </summary>
            [JsonProperty("address")]
            public string? Address { get; set; }

            /// <summary>
            /// <para>id号</para>
            /// <para>必填：否</para>
            /// <para>示例值：11230xxxxx004701</para>
            /// </summary>
            [JsonProperty("id_number")]
            public string? IdNumber { get; set; }

            /// <summary>
            /// <para>邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：zhangsan.1111@bytedance.com</para>
            /// </summary>
            [JsonProperty("email")]
            public string? Email { get; set; }
        }
    }
}
